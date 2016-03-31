using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
	public partial class Form1 : Form
	{
		Double value = 0;
		String op = "";
		bool op_btn_action = false;
		bool symbol = true;

		public Form1()
		{
			InitializeComponent();
		}

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

		private void button16_Click(object sender, EventArgs e)
		{
			result.Text = "0";
			equation.Text = "";
		}

		private void operator_click(object sender, EventArgs e)
		{
			Button btn = (Button)sender;

			if (value != 0)
			{
				if (btn.Text == "√")
					result.Text = Math.Sqrt(Double.Parse(result.Text)).ToString();
				if (btn.Text == "^2")
					result.Text = Math.Pow(Double.Parse(result.Text),2).ToString();

				equal.PerformClick();
				op_btn_action = true;
				op = btn.Text;
				equation.Text = value + " " + op;
			}
			else if(btn.Text == "√")
			{
				result.Text = Math.Sqrt(Double.Parse(result.Text)).ToString();
				value = Math.Sqrt(Double.Parse(result.Text));
			}
			else if(btn.Text == "^2")
			{
				result.Text = Math.Pow(Double.Parse(result.Text),2).ToString();
				value = Math.Pow(Double.Parse(result.Text),2);
			}
			else {
				op = btn.Text;
				value = Double.Parse(result.Text);
				op_btn_action = true;
				equation.Text = value + " " + op;
			}

		}

		private void button18_Click(object sender, EventArgs e)
		{
			
			equation.Text = "";
			switch (op)
			{
				case "+":
					result.Text = (value + Double.Parse(result.Text)).ToString();
					break;
				case "-":
					result.Text = (value - Double.Parse(result.Text)).ToString();
					break;
				case "*":
					result.Text = (value * Double.Parse(result.Text)).ToString();
					break;
				case "/":
					result.Text = (value / Double.Parse(result.Text)).ToString();
					break;
				default: break;
			}
			value = Int32.Parse(result.Text);
			op = "";
			
		}

		private void button17_Click(object sender, EventArgs e)
		{
			result.Text = "0";
			equation.Text = "";
			value = 0;
			
		}

		private void Form1_KeyPress(object sender, KeyPressEventArgs e)
		{
			switch (e.KeyChar.ToString())
			{
				case "0":
					zero.PerformClick();
					break;
				case "1":
					one.PerformClick();
					break;
				case "2":
					two.PerformClick();
					break;
				case "3":
					three.PerformClick();
					break;
				case "4":
					four.PerformClick();
					break;
				case "5":
					five.PerformClick();
					break;
				case "6":
					six.PerformClick();
					break;
				case "7":
					seven.PerformClick();
					break;
				case "8":
					eight.PerformClick();
					break;
				case "9":
					nine.PerformClick();
					break;
				case "+":
					add.PerformClick();
					break;
				case "-":
					sub.PerformClick();
					break;
				case "*":
					multiply.PerformClick();
					break;
				case "/":
					divide.PerformClick();
					break;
				case "=":
					equal.PerformClick();
					break;
				case "q":
					sqrt.PerformClick();
					break;
				case "p":
					pow.PerformClick();
					break;

				default:break;
			}
		}

		private void plus_minus_Click(object sender, EventArgs e)
		{
			if(symbol == true)
			{
				result.Text = "-" + result.Text;
				symbol = false;
			}
			else
			{
				result.Text = result.Text.Replace("-", "");
				symbol = true;
			}
		}
	}
}
