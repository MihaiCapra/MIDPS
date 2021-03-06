﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TheStack : MonoBehaviour {
	public Text scoreText;
	public Color32[] gameColors = new Color32[4];
	public Material stackMat;
	public GameObject EndPanel;

	private const float BOUNDS_SIZE = 3.5f;
	private const float STACK_MOVING_SPEED = 5.0f;
	private const float ERROR_MARGIN = 0.1f;
	private const float STACK_BOUNDS_GAIN = 0.25f;
	private const int COMBO_START_GAIN = 3;

	private GameObject[] theStack;
	private int scoreCount = 0;
	private int stackIndex;
	private float tileTransition = 0.0f;
	private float tileSpeed = 2.5f;
	private bool isMovingOnX = true;
	private float secondaryPosition;
	private Vector3 dPosition;
	private Vector3 lastTilePsition;
	private int combo = 0;
	private Vector2 stacksBounds = new Vector2(BOUNDS_SIZE,BOUNDS_SIZE);
	private bool gameOver = false;

	// Use this for initialization
	private void Start () {
		theStack = new GameObject[transform.childCount];
		for (int i = 0; i < transform.childCount; i++) {
			theStack[i] = transform.GetChild(i).gameObject;
			ColorMesh (theStack [i].GetComponent<MeshFilter> ().mesh);
		}
			
		stackIndex = transform.childCount - 1;
	}

	private void CreateRubble(Vector3 pos,Vector3 scale){
		GameObject go = GameObject.CreatePrimitive (PrimitiveType.Cube);
		go.transform.localPosition = pos;
		go.transform.localScale = scale;
		go.AddComponent<Rigidbody> ();
		go.GetComponent<MeshRenderer> ().material = stackMat;
		ColorMesh (go.GetComponent<MeshFilter> ().mesh);
	}
	
	// Update is called once per frame
	private void Update () {
		if (Input.GetMouseButtonDown (0)) {
			if (PlaceTile ()) {
				SpawnTile ();
				scoreCount++;
				scoreText.text = scoreCount.ToString ();
			} else {
				EndGame ();
			}

		}
		MoveTile ();
		//Move the stack
		transform.position = Vector3.Lerp(transform.position,dPosition,STACK_MOVING_SPEED*Time.deltaTime);

	}

	private void MoveTile(){
		if (gameOver)
			return;
		tileTransition += Time.deltaTime * tileSpeed;
		if(isMovingOnX)
			theStack [stackIndex].transform.localPosition = new Vector3(Mathf.Sin(tileTransition)*BOUNDS_SIZE,scoreCount,secondaryPosition);
		else
			theStack [stackIndex].transform.localPosition = new Vector3(secondaryPosition,scoreCount,Mathf.Sin(tileTransition)*BOUNDS_SIZE);
		
	}

	private void SpawnTile(){
		
		lastTilePsition = theStack [stackIndex].transform.localPosition;
		stackIndex--;
		if (stackIndex < 0)
			stackIndex = transform.childCount - 1;

		dPosition = (Vector3.down) * scoreCount;
		theStack [stackIndex].transform.localPosition = new Vector3 (0, scoreCount, 0);
		theStack [stackIndex].transform.localScale = new Vector3 (stacksBounds.x, 1, stacksBounds.y);

		ColorMesh (theStack [stackIndex].GetComponent<MeshFilter> ().mesh);

	}

	private bool PlaceTile(){
		Transform t = theStack [stackIndex].transform;

		if (isMovingOnX) {
			float deltaX = lastTilePsition.x - t.position.x;
			if (Mathf.Abs (deltaX) > ERROR_MARGIN) {
				//Cut the tile
				combo = 0;
				stacksBounds.x -= Mathf.Abs (deltaX);
				if (stacksBounds.x <= 0)
					return false;

				float middle = lastTilePsition.x + t.localPosition.x / 2;
				t.localScale = new Vector3 (stacksBounds.x, 1, stacksBounds.y);

				CreateRubble (new Vector3((t.position.x>0)
					?t.position.x+(t.localScale.x/2)
					:t.position.x-(t.localScale.x/2),
					t.position.y,
					t.position.z),
					new Vector3(Mathf.Abs(deltaX),1,t.localScale.z)
				);
				
				t.localPosition = new Vector3 (middle - (lastTilePsition.x / 2), scoreCount, lastTilePsition.z);
			} else {
				if (combo > COMBO_START_GAIN) {
					if (stacksBounds.x > BOUNDS_SIZE)
						stacksBounds.x = BOUNDS_SIZE;
					stacksBounds.x += STACK_BOUNDS_GAIN;
					float middle = lastTilePsition.x + t.localPosition.x / 2;
					t.localScale = new Vector3 (stacksBounds.x, 1, stacksBounds.y);
					t.localPosition = new Vector3 (middle - (lastTilePsition.x / 2), scoreCount, lastTilePsition.z);
				}
				combo++;
				t.localPosition = new Vector3 (lastTilePsition.x, scoreCount, lastTilePsition.z);
			}
		}

		else {
				float deltaZ = lastTilePsition.z - t.position.z;
			if (Mathf.Abs (deltaZ) > ERROR_MARGIN) {
				//Cut the tile
				combo = 0;
				stacksBounds.y -= Mathf.Abs (deltaZ);
				if (stacksBounds.y <= 0)
					return false;

				float middle = lastTilePsition.z + t.localPosition.z / 2;
				t.localScale = new Vector3 (stacksBounds.x, 1, stacksBounds.y);

				CreateRubble (new Vector3(t.position.x,
						t.position.y,
						(t.position.z>0)
						?t.position.z+(t.localScale.z/2)
						:t.position.z-(t.localScale.z/2)),
					new Vector3(t.localScale.x,1,Mathf.Abs(deltaZ))
				);
				t.localPosition = new Vector3 (lastTilePsition.x, scoreCount, middle - (lastTilePsition.z / 2));
			} else {
				if (combo > COMBO_START_GAIN) {
					if (stacksBounds.y > BOUNDS_SIZE)
						stacksBounds.y = BOUNDS_SIZE;
					stacksBounds.y += STACK_BOUNDS_GAIN;
					float middle = lastTilePsition.z + t.localPosition.z / 2;
					t.localScale = new Vector3 (stacksBounds.x, 1, stacksBounds.y);
					t.localPosition = new Vector3 (lastTilePsition.x, scoreCount, middle - (lastTilePsition.z / 2));
				}
				combo++;
				t.localPosition = new Vector3 (lastTilePsition.x, scoreCount, lastTilePsition.z);
			}
		}
		secondaryPosition = (isMovingOnX)?t.localPosition.x:t.localPosition.z;
		isMovingOnX = !isMovingOnX;
		return true;
	}

	private Color32 Lerp4(Color32 a,Color32 b,Color32 c,Color32 d,float t){
		if (t < 0.33f)
			return Color.Lerp (a, b, t / 0.33f);
		else if (t < 0.66f)
			return Color.Lerp (b, c, (t - 0.33f) / 0.33f);
		else
			return Color.Lerp (c, d, (t - 0.66f) / 0.66f);
	}

	private void ColorMesh(Mesh mesh){
		Vector3[] vertices = mesh.vertices;
		Color32[] colors = new Color32[vertices.Length];
		float f = Mathf.Sin (scoreCount * 0.25f);

		for (int i = 0; i < vertices.Length; i++)
			colors [i] = Lerp4 (gameColors [0], gameColors [1], gameColors [2], gameColors [3], f);

		mesh.colors32 = colors;
	}

	private void EndGame(){
		Debug.Log ("YOu Died");
		gameOver = true;
		EndPanel.SetActive (true);
		theStack [stackIndex].AddComponent<Rigidbody> ();
	}

	public void OnButtonClick(string sceneName){
		SceneManager.LoadScene (sceneName);
	}
}
