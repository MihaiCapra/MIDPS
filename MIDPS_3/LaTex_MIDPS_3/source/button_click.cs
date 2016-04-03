private void button_Click(object sender, EventArgs e)
{
	if ((result.Text == "0")||(op_btn_action))
		result.Clear();
		op_btn_action = false;
		Button btn = (Button)sender;
	if(btn.Text == ".")
	{
		if (!result.Text.Contains("."))
		result.Text = result.Text + btn.Text;
	}
	else
		result.Text = result.Text + btn.Text;
}
