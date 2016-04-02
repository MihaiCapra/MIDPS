//---------------------------------------------------------------------------

#include <vcl.h>
#pragma hdrstop

#include "Unit1.h"
//---------------------------------------------------------------------------
#pragma package(smart_init)
#pragma resource "*.dfm"
TForm1 *Form1;
double Timer = 0;
//---------------------------------------------------------------------------
__fastcall TForm1::TForm1(TComponent* Owner)
        : TForm(Owner)
{
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button1Click(TObject *Sender)
{
        float x,y,result;
        x = StrToFloat(Edit1->Text);
        y = StrToFloat(Edit2->Text);
        result = x + y;
        Edit3->Text = result;        
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button2Click(TObject *Sender)
{
        float x,y,result;
        x = StrToFloat(Edit1->Text);
        y = StrToFloat(Edit2->Text);
        result = x-y;
        Edit3->Text = result;        
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Button3Click(TObject *Sender)
{
        float x,result;
        x = StrToFloat(Edit1->Text);
        result = x*x;
        Edit3->Text = result;
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Button4Click(TObject *Sender)
{
        float y,result;
        y = StrToFloat(Edit2->Text);
        result = y*y;
        Edit3->Text = result;        
}
//---------------------------------------------------------------------------
void __fastcall TForm1::RadioButton1Click(TObject *Sender)
{
        Label1->Font->Name = "Calibri";
}
//---------------------------------------------------------------------------
void __fastcall TForm1::RadioButton2Click(TObject *Sender)
{
        Label1->Font->Name = "Arial";
}
//---------------------------------------------------------------------------
void __fastcall TForm1::RadioButton3Click(TObject *Sender)
{
        Label1->Font->Name = "Comic Sans MS";
}
//---------------------------------------------------------------------------
void __fastcall TForm1::RadioButton4Click(TObject *Sender)
{
        Label1->Font->Color = clRed;
}
//---------------------------------------------------------------------------
void __fastcall TForm1::RadioButton5Click(TObject *Sender)
{
        Label1->Font->Color = clPurple;        
}
//---------------------------------------------------------------------------
void __fastcall TForm1::RadioButton6Click(TObject *Sender)
{
        Label1->Font->Color = clLime;        
}
//---------------------------------------------------------------------------
void __fastcall TForm1::RadioButton7Click(TObject *Sender)
{
        Label1->Font->Style = Font->Style<<fsBold;      
}
//---------------------------------------------------------------------------
void __fastcall TForm1::RadioButton8Click(TObject *Sender)
{
        Label1->Font->Style = Font->Style<<fsItalic;        
}
//---------------------------------------------------------------------------
void __fastcall TForm1::RadioButton9Click(TObject *Sender)
{
        Label1->Font->Style = Font->Style<<fsUnderline;
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Timer1Timer(TObject *Sender)
{
     Timer += 1;
     Label2->Caption = Timer;
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Button5Click(TObject *Sender)
{
     if(Timer1->Enabled == true){
        Timer1->Enabled = false;
     }
     else{
        Timer1->Enabled = true;
     }
}
//---------------------------------------------------------------------------
void __fastcall TForm1::Button6Click(TObject *Sender)
{
        Timer1->Enabled = false;
        Label2->Caption = "Counter";
        Timer = 0;
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Button7Click(TObject *Sender)
{
        PaintBox1 -> Canvas -> MoveTo(0,105);
        PaintBox1 -> Canvas -> LineTo(0,50);
        PaintBox1 -> Canvas -> LineTo(20,50);
        PaintBox1 -> Canvas -> LineTo(20,105);
        PaintBox1 -> Canvas -> LineTo(20,30);
        PaintBox1 -> Canvas -> LineTo(40,30);
        PaintBox1 -> Canvas -> LineTo(40,105);
        PaintBox1 -> Canvas -> LineTo(40,40);
        PaintBox1 -> Canvas -> LineTo(60,40);
        PaintBox1 -> Canvas -> LineTo(60,105);
        PaintBox1 -> Canvas -> LineTo(60,70);
        PaintBox1 -> Canvas -> LineTo(80,70);
        PaintBox1 -> Canvas -> LineTo(80,105);
        PaintBox1 -> Canvas -> LineTo(80,0);
        PaintBox1 -> Canvas -> LineTo(100,0);
        PaintBox1 -> Canvas -> LineTo(100,105);
        PaintBox1 -> Canvas -> LineTo(100,55);
        PaintBox1 -> Canvas -> LineTo(200,55);
        PaintBox1 -> Canvas -> LineTo(200,105);
        PaintBox1 -> Canvas -> LineTo(200,25);
        PaintBox1 -> Canvas -> LineTo(380,25);
        PaintBox1 -> Canvas -> LineTo(380,105);

}
//---------------------------------------------------------------------------
void __fastcall TForm1::Button8Click(TObject *Sender)
{
        PaintBox2->Canvas->Ellipse(100,0,150,50);
        PaintBox2->Canvas->Ellipse(50,100,100,150);
        PaintBox2->Canvas->Ellipse(150,100,200,150);
        PaintBox2->Canvas->MoveTo(125,50);
        PaintBox2->Canvas->LineTo(75,100);
        PaintBox2->Canvas->MoveTo(125,50);
        PaintBox2->Canvas->LineTo(175,100);
}
//---------------------------------------------------------------------------

void __fastcall TForm1::Timer3Timer(TObject *Sender)
{
        Label3->Caption = Time();
        Label4->Caption = Date();
}
//---------------------------------------------------------------------------

