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
}}
