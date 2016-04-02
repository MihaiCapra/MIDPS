void __fastcall TForm1::Button1Click(TObject *Sender)
{
float x,y,result;
x = StrToFloat(Edit1->Text);
y = StrToFloat(Edit2->Text);
result = x + y;
Edit3->Text = result;
}