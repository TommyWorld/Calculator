
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.Fixed fixed1;
	
	private global::Gtk.Button button3;
	
	private global::Gtk.Button button2;
	
	private global::Gtk.Button button1;
	
	private global::Gtk.Button button4;
	
	private global::Gtk.Button button5;
	
	private global::Gtk.Button button6;
	
	private global::Gtk.Button button9;
	
	private global::Gtk.Button button8;
	
	private global::Gtk.Button button7;
	
	private global::Gtk.Button buttonDot;
	
	private global::Gtk.Button buttonCalculate;
	
	private global::Gtk.Button buttonZero;
	
	private global::Gtk.Button buttonmultiplication;
	
	private global::Gtk.Button buttonSubtraction;
	
	private global::Gtk.Button buttonAddition;
	
	private global::Gtk.Button buttonDivision;
	
	private global::Gtk.Entry mainDisplay;
	
	private global::Gtk.Entry subDisplay;
	
	private global::Gtk.Button buttonclear;

	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget MainWindow
		this.WidthRequest = 100;
		this.HeightRequest = 300;
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("MainWindow");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.fixed1 = new global::Gtk.Fixed ();
		this.fixed1.Name = "fixed1";
		this.fixed1.HasWindow = false;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.button3 = new global::Gtk.Button ();
		this.button3.WidthRequest = 90;
		this.button3.HeightRequest = 50;
		this.button3.CanFocus = true;
		this.button3.Name = "button3";
		this.button3.UseUnderline = true;
		this.button3.Label = global::Mono.Unix.Catalog.GetString ("3");
		this.fixed1.Add (this.button3);
		global::Gtk.Fixed.FixedChild w1 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.button3]));
		w1.X = 200;
		w1.Y = 100;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.button2 = new global::Gtk.Button ();
		this.button2.WidthRequest = 90;
		this.button2.HeightRequest = 50;
		this.button2.CanFocus = true;
		this.button2.Name = "button2";
		this.button2.UseUnderline = true;
		this.button2.Label = global::Mono.Unix.Catalog.GetString ("2");
		this.fixed1.Add (this.button2);
		global::Gtk.Fixed.FixedChild w2 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.button2]));
		w2.X = 100;
		w2.Y = 100;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.button1 = new global::Gtk.Button ();
		this.button1.WidthRequest = 90;
		this.button1.HeightRequest = 50;
		this.button1.CanFocus = true;
		this.button1.Name = "button1";
		this.button1.UseUnderline = true;
		this.button1.Label = global::Mono.Unix.Catalog.GetString ("1");
		this.fixed1.Add (this.button1);
		global::Gtk.Fixed.FixedChild w3 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.button1]));
		w3.Y = 100;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.button4 = new global::Gtk.Button ();
		this.button4.WidthRequest = 90;
		this.button4.HeightRequest = 50;
		this.button4.CanFocus = true;
		this.button4.Name = "button4";
		this.button4.UseUnderline = true;
		this.button4.Label = global::Mono.Unix.Catalog.GetString ("4");
		this.fixed1.Add (this.button4);
		global::Gtk.Fixed.FixedChild w4 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.button4]));
		w4.Y = 50;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.button5 = new global::Gtk.Button ();
		this.button5.WidthRequest = 90;
		this.button5.HeightRequest = 50;
		this.button5.CanFocus = true;
		this.button5.Name = "button5";
		this.button5.UseUnderline = true;
		this.button5.Label = global::Mono.Unix.Catalog.GetString ("5");
		this.fixed1.Add (this.button5);
		global::Gtk.Fixed.FixedChild w5 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.button5]));
		w5.X = 100;
		w5.Y = 50;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.button6 = new global::Gtk.Button ();
		this.button6.WidthRequest = 90;
		this.button6.HeightRequest = 50;
		this.button6.CanFocus = true;
		this.button6.Name = "button6";
		this.button6.UseUnderline = true;
		this.button6.Label = global::Mono.Unix.Catalog.GetString ("6");
		this.fixed1.Add (this.button6);
		global::Gtk.Fixed.FixedChild w6 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.button6]));
		w6.X = 200;
		w6.Y = 50;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.button9 = new global::Gtk.Button ();
		this.button9.WidthRequest = 90;
		this.button9.HeightRequest = 50;
		this.button9.CanFocus = true;
		this.button9.Name = "button9";
		this.button9.UseUnderline = true;
		this.button9.Label = global::Mono.Unix.Catalog.GetString ("9");
		this.fixed1.Add (this.button9);
		global::Gtk.Fixed.FixedChild w7 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.button9]));
		w7.X = 200;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.button8 = new global::Gtk.Button ();
		this.button8.WidthRequest = 90;
		this.button8.HeightRequest = 50;
		this.button8.CanFocus = true;
		this.button8.Name = "button8";
		this.button8.UseUnderline = true;
		this.button8.Label = global::Mono.Unix.Catalog.GetString ("8");
		this.fixed1.Add (this.button8);
		global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.button8]));
		w8.X = 100;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.button7 = new global::Gtk.Button ();
		this.button7.WidthRequest = 90;
		this.button7.HeightRequest = 50;
		this.button7.CanFocus = true;
		this.button7.Name = "button7";
		this.button7.UseUnderline = true;
		this.button7.Label = global::Mono.Unix.Catalog.GetString ("7");
		this.fixed1.Add (this.button7);
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.buttonDot = new global::Gtk.Button ();
		this.buttonDot.WidthRequest = 90;
		this.buttonDot.HeightRequest = 50;
		this.buttonDot.CanFocus = true;
		this.buttonDot.Name = "buttonDot";
		this.buttonDot.UseUnderline = true;
		this.buttonDot.Label = global::Mono.Unix.Catalog.GetString (".");
		this.fixed1.Add (this.buttonDot);
		global::Gtk.Fixed.FixedChild w10 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.buttonDot]));
		w10.Y = 150;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.buttonCalculate = new global::Gtk.Button ();
		this.buttonCalculate.WidthRequest = 90;
		this.buttonCalculate.HeightRequest = 50;
		this.buttonCalculate.CanFocus = true;
		this.buttonCalculate.Name = "buttonCalculate";
		this.buttonCalculate.UseUnderline = true;
		this.buttonCalculate.Label = global::Mono.Unix.Catalog.GetString ("=");
		this.fixed1.Add (this.buttonCalculate);
		global::Gtk.Fixed.FixedChild w11 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.buttonCalculate]));
		w11.X = 200;
		w11.Y = 150;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.buttonZero = new global::Gtk.Button ();
		this.buttonZero.WidthRequest = 90;
		this.buttonZero.HeightRequest = 50;
		this.buttonZero.CanFocus = true;
		this.buttonZero.Name = "buttonZero";
		this.buttonZero.UseUnderline = true;
		this.buttonZero.Label = global::Mono.Unix.Catalog.GetString ("0");
		this.fixed1.Add (this.buttonZero);
		global::Gtk.Fixed.FixedChild w12 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.buttonZero]));
		w12.X = 100;
		w12.Y = 150;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.buttonmultiplication = new global::Gtk.Button ();
		this.buttonmultiplication.WidthRequest = 50;
		this.buttonmultiplication.HeightRequest = 50;
		this.buttonmultiplication.CanFocus = true;
		this.buttonmultiplication.Name = "buttonmultiplication";
		this.buttonmultiplication.UseUnderline = true;
		this.buttonmultiplication.Label = global::Mono.Unix.Catalog.GetString ("×");
		this.fixed1.Add (this.buttonmultiplication);
		global::Gtk.Fixed.FixedChild w13 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.buttonmultiplication]));
		w13.X = 300;
		w13.Y = 50;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.buttonSubtraction = new global::Gtk.Button ();
		this.buttonSubtraction.WidthRequest = 50;
		this.buttonSubtraction.HeightRequest = 50;
		this.buttonSubtraction.CanFocus = true;
		this.buttonSubtraction.Name = "buttonSubtraction";
		this.buttonSubtraction.UseUnderline = true;
		this.buttonSubtraction.Label = global::Mono.Unix.Catalog.GetString ("-");
		this.fixed1.Add (this.buttonSubtraction);
		global::Gtk.Fixed.FixedChild w14 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.buttonSubtraction]));
		w14.X = 300;
		w14.Y = 100;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.buttonAddition = new global::Gtk.Button ();
		this.buttonAddition.WidthRequest = 50;
		this.buttonAddition.HeightRequest = 50;
		this.buttonAddition.CanFocus = true;
		this.buttonAddition.Name = "buttonAddition";
		this.buttonAddition.UseUnderline = true;
		this.buttonAddition.Label = global::Mono.Unix.Catalog.GetString ("+");
		this.fixed1.Add (this.buttonAddition);
		global::Gtk.Fixed.FixedChild w15 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.buttonAddition]));
		w15.X = 300;
		w15.Y = 150;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.buttonDivision = new global::Gtk.Button ();
		this.buttonDivision.WidthRequest = 50;
		this.buttonDivision.HeightRequest = 50;
		this.buttonDivision.CanFocus = true;
		this.buttonDivision.Name = "buttonDivision";
		this.buttonDivision.UseUnderline = true;
		this.buttonDivision.Label = global::Mono.Unix.Catalog.GetString ("÷");
		this.fixed1.Add (this.buttonDivision);
		global::Gtk.Fixed.FixedChild w16 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.buttonDivision]));
		w16.X = 300;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.mainDisplay = new global::Gtk.Entry ();
		this.mainDisplay.WidthRequest = 350;
		this.mainDisplay.CanFocus = true;
		this.mainDisplay.Name = "mainDisplay";
		this.mainDisplay.Text = global::Mono.Unix.Catalog.GetString ("0");
		this.mainDisplay.IsEditable = true;
		this.mainDisplay.InvisibleChar = '●';
		this.fixed1.Add (this.mainDisplay);
		global::Gtk.Fixed.FixedChild w17 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.mainDisplay]));
		w17.Y = 200;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.subDisplay = new global::Gtk.Entry ();
		this.subDisplay.WidthRequest = 250;
		this.subDisplay.CanFocus = true;
		this.subDisplay.Name = "subDisplay";
		this.subDisplay.IsEditable = true;
		this.subDisplay.InvisibleChar = '●';
		this.fixed1.Add (this.subDisplay);
		global::Gtk.Fixed.FixedChild w18 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.subDisplay]));
		w18.Y = 230;
		// Container child fixed1.Gtk.Fixed+FixedChild
		this.buttonclear = new global::Gtk.Button ();
		this.buttonclear.WidthRequest = 86;
		this.buttonclear.CanFocus = true;
		this.buttonclear.Name = "buttonclear";
		this.buttonclear.UseUnderline = true;
		this.buttonclear.Label = global::Mono.Unix.Catalog.GetString ("Clear");
		this.fixed1.Add (this.buttonclear);
		global::Gtk.Fixed.FixedChild w19 = ((global::Gtk.Fixed.FixedChild)(this.fixed1 [this.buttonclear]));
		w19.X = 260;
		w19.Y = 227;
		this.Add (this.fixed1);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 387;
		this.DefaultHeight = 300;
		this.Show ();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
		this.button3.Clicked += new global::System.EventHandler (this.OnButtonNumber);
		this.button2.Clicked += new global::System.EventHandler (this.OnButtonNumber);
		this.button1.Clicked += new global::System.EventHandler (this.OnButtonNumber);
		this.button4.Clicked += new global::System.EventHandler (this.OnButtonNumber);
		this.button5.Clicked += new global::System.EventHandler (this.OnButtonNumber);
		this.button6.Clicked += new global::System.EventHandler (this.OnButtonNumber);
		this.button9.Clicked += new global::System.EventHandler (this.OnButtonNumber);
		this.button8.Clicked += new global::System.EventHandler (this.OnButtonNumber);
		this.button7.Clicked += new global::System.EventHandler (this.OnButtonNumber);
		this.buttonDot.Clicked += new global::System.EventHandler (this.OnButtonDotClicked);
		this.buttonCalculate.Clicked += new global::System.EventHandler (this.OnButtonCalculateClicked);
		this.buttonZero.Clicked += new global::System.EventHandler (this.OnButtonNumber);
		this.buttonmultiplication.Clicked += new global::System.EventHandler (this.OnButtonOperatorSymbolClicked);
		this.buttonSubtraction.Clicked += new global::System.EventHandler (this.OnButtonOperatorSymbolClicked);
		this.buttonAddition.Clicked += new global::System.EventHandler (this.OnButtonOperatorSymbolClicked);
		this.buttonDivision.Clicked += new global::System.EventHandler (this.OnButtonOperatorSymbolClicked);
		this.buttonclear.Clicked += new global::System.EventHandler (this.OnButtonclearClicked);
	}
}