object Form1: TForm1
  Left = 358
  Top = 201
  Width = 662
  Height = 404
  Caption = 'MIDPS'
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  PixelsPerInch = 96
  TextHeight = 13
  object Label1: TLabel
    Left = 16
    Top = 72
    Width = 79
    Height = 13
    Caption = 'HELLO WORLD'
  end
  object Label2: TLabel
    Left = 520
    Top = 24
    Width = 114
    Height = 37
    Caption = 'Counter'
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -32
    Font.Name = 'MS Sans Serif'
    Font.Style = []
    ParentFont = False
  end
  object PaintBox1: TPaintBox
    Left = 8
    Top = 208
    Width = 393
    Height = 105
  end
  object PaintBox2: TPaintBox
    Left = 416
    Top = 120
    Width = 217
    Height = 193
  end
  object Label3: TLabel
    Left = 440
    Top = 72
    Width = 5
    Height = 24
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -19
    Font.Name = 'MS Sans Serif'
    Font.Style = []
    ParentFont = False
  end
  object Label4: TLabel
    Left = 552
    Top = 72
    Width = 5
    Height = 24
    Font.Charset = DEFAULT_CHARSET
    Font.Color = clWindowText
    Font.Height = -19
    Font.Name = 'MS Sans Serif'
    Font.Style = []
    ParentFont = False
  end
  object Panel1: TPanel
    Left = 8
    Top = 8
    Width = 393
    Height = 41
    Caption = 'Panel1'
    TabOrder = 20
  end
  object GroupBox3: TGroupBox
    Left = 272
    Top = 112
    Width = 129
    Height = 73
    Caption = 'Style'
    TabOrder = 15
    object RadioButton7: TRadioButton
      Left = 8
      Top = 16
      Width = 113
      Height = 17
      Caption = 'BOLD'
      TabOrder = 0
      OnClick = RadioButton7Click
    end
    object RadioButton8: TRadioButton
      Left = 8
      Top = 32
      Width = 113
      Height = 17
      Caption = 'Italic'
      TabOrder = 1
      OnClick = RadioButton8Click
    end
    object RadioButton9: TRadioButton
      Left = 8
      Top = 48
      Width = 113
      Height = 17
      Caption = 'Underlined'
      TabOrder = 2
      OnClick = RadioButton9Click
    end
  end
  object GroupBox2: TGroupBox
    Left = 8
    Top = 112
    Width = 129
    Height = 73
    Caption = 'Font'
    TabOrder = 14
  end
  object GroupBox1: TGroupBox
    Left = 136
    Top = 112
    Width = 137
    Height = 73
    Caption = 'Colors'
    TabOrder = 13
  end
  object Edit1: TEdit
    Left = 16
    Top = 16
    Width = 121
    Height = 21
    TabOrder = 0
  end
  object Edit2: TEdit
    Left = 144
    Top = 16
    Width = 121
    Height = 21
    TabOrder = 1
  end
  object Edit3: TEdit
    Left = 272
    Top = 16
    Width = 121
    Height = 21
    TabOrder = 2
  end
  object Button1: TButton
    Left = 16
    Top = 40
    Width = 75
    Height = 25
    Caption = 'x+y'
    TabOrder = 3
    OnClick = Button1Click
  end
  object Button2: TButton
    Left = 96
    Top = 40
    Width = 75
    Height = 25
    Caption = 'x-y'
    TabOrder = 4
    OnClick = Button2Click
  end
  object Button3: TButton
    Left = 176
    Top = 40
    Width = 75
    Height = 25
    Caption = 'pow(x,2)'
    TabOrder = 5
    OnClick = Button3Click
  end
  object Button4: TButton
    Left = 256
    Top = 40
    Width = 75
    Height = 25
    Caption = 'pow(y,2)'
    TabOrder = 6
    OnClick = Button4Click
  end
  object RadioButton1: TRadioButton
    Left = 16
    Top = 128
    Width = 113
    Height = 17
    Caption = 'Calibri'
    TabOrder = 7
    OnClick = RadioButton1Click
  end
  object RadioButton2: TRadioButton
    Left = 16
    Top = 144
    Width = 113
    Height = 17
    Caption = 'Arial'
    TabOrder = 8
    OnClick = RadioButton2Click
  end
  object RadioButton3: TRadioButton
    Left = 16
    Top = 160
    Width = 113
    Height = 17
    Caption = 'Comic'
    TabOrder = 9
    OnClick = RadioButton3Click
  end
  object RadioButton4: TRadioButton
    Left = 152
    Top = 128
    Width = 113
    Height = 17
    Caption = 'Red'
    TabOrder = 10
    OnClick = RadioButton4Click
  end
  object RadioButton5: TRadioButton
    Left = 152
    Top = 144
    Width = 113
    Height = 17
    Caption = 'Purple'
    TabOrder = 11
    OnClick = RadioButton5Click
  end
  object RadioButton6: TRadioButton
    Left = 152
    Top = 160
    Width = 113
    Height = 17
    Caption = 'Lime'
    TabOrder = 12
    OnClick = RadioButton6Click
  end
  object Button5: TButton
    Left = 440
    Top = 16
    Width = 75
    Height = 25
    Caption = 'Start'
    TabOrder = 16
    OnClick = Button5Click
  end
  object Button6: TButton
    Left = 440
    Top = 40
    Width = 75
    Height = 25
    Caption = 'Reset'
    TabOrder = 17
    OnClick = Button6Click
  end
  object Button7: TButton
    Left = 8
    Top = 320
    Width = 75
    Height = 25
    Caption = 'Bargraf'
    TabOrder = 18
    OnClick = Button7Click
  end
  object Button8: TButton
    Left = 416
    Top = 320
    Width = 75
    Height = 25
    Caption = 'Diagrama'
    TabOrder = 19
    OnClick = Button8Click
  end
  object Timer1: TTimer
    Enabled = False
    OnTimer = Timer1Timer
    Left = 408
    Top = 16
  end
  object Timer3: TTimer
    OnTimer = Timer3Timer
    Left = 408
    Top = 48
  end
end
