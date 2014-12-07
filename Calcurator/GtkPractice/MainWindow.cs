using System;
using Gtk;
using System.Collections.Generic;

public partial class MainWindow: Gtk.Window
{
    /// <summary> 小数点 </summary>
	private const string dot = ".";

	/// <summary> テキストフィールドに表示する0 </summary>
	private const string zero = "0";

	/// <summary> 小数点の入力確認フラグ </summary>
	public bool isInputDot = false;

	/// <summary> 入力値を格納するリスト </summary>
	public List<string> valueList = new List<string> ();

	/// <summary> 演算子の種類 </summary>
	private string typeOfOperatorSymbol = string.Empty;

	/// <summary> 小数点に続けて０が入力された場合の表示 </summary>
	private const string dotZero = ".0";

	/// <summary> 0で除算した場合のメッセージ </summary>
	private const string errorMessageOfZeroDivision = "0で割らないでください。";

	/// <summary> overflowExceptionキャッチ時のエラーメッセージ</summary>
	private const string overFlowMessage = "オーバーフローしました。";

	/// <summary> 合計値算出時のメッセージ</summary>
	private const string answerMessage = "答えです!!";

	/// <sumamry> 入力値がオーバーフローした際のメッセージ</summary>
	private const string overNumber = "これ以上入力できません！";

	/// <summary> 演算子の種類</summary>
	enum operatorSymbol
	{
		Addition,
		Subtraction,
		multiplication,
		Division
	}

	public MainWindow () : base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	/// <summary>
	/// 合計値を算出
	/// </summary>
	/// <param name="sender">Sender.</param>
	/// <param name="e">E.</param>
	protected void OnButtonCalculateClicked (object sender, EventArgs e)
	{
		// 1.演算子直後に"="押下で処理終了
		// 2.演算子未入力で処理終了
		if (string.IsNullOrEmpty (mainDisplay.Text) ||
			typeOfOperatorSymbol == string.Empty)
		{
			return;
		}

		// 画面の入力値を保持
		valueList.Add (mainDisplay.Text);

		// 合計値を格納する変数
		double calculatedValue = 0;

		// 演算子前のオペランド
		double firstOfOperand = double.Parse (valueList[0]);

		// 演算子後のオペランド
		double secondOfOperand = double.Parse (valueList[1]);

		valueList.Clear ();

		try{
			//合計値の計算
			switch (typeOfOperatorSymbol)
			{
				case "Addition":  
					calculatedValue = firstOfOperand + secondOfOperand;
					break;
					
				case "Subtraction":
					calculatedValue = firstOfOperand - secondOfOperand;
					break;
					
				case "multiplication":
					calculatedValue = firstOfOperand * secondOfOperand;
					break;

				case "Division":
				    // 0除算時のエラー
					if(secondOfOperand == 0)
					{
						mainDisplay.Text = zero; 
						subDisplay.Text = errorMessageOfZeroDivision;
						typeOfOperatorSymbol = string.Empty;
						valueList.Clear();
						return;
					}
					calculatedValue = firstOfOperand / secondOfOperand;
					break;
			};
		}
		catch(OverflowException)//計算結果がオーバーフローした場合の処理
		{
			mainDisplay.Text = zero; 
			subDisplay.Text = overFlowMessage;
			typeOfOperatorSymbol = string.Empty;
			return;
		}

		// 画面に計算結果を表示
		mainDisplay.Text = calculatedValue.ToString();
		subDisplay.Text = answerMessage;

		// 演算子情報を空にする
		typeOfOperatorSymbol = string.Empty;
	}

	/// <summary>
	/// 小数点の重複判定
	/// </summary>
	/// <param name="sender">Sender.</param>
	/// <param name="e">E.</param>
	private void OnButtonDotClicked (object sender, EventArgs e)
	{
		// 小数点が入力されました
		isInputDot = true;

		// 小数点未入力の場合
		if (mainDisplay.Text.IndexOf (dot) == -1)
		{
			// 小数点を追加して画面に表示
			mainDisplay.Text = mainDisplay.Text + ((Button)sender).Label;
		} 
		else
		{
			// 処理なしでそのまま返却
			return;
		}
	}

	/// <summary>
	/// 演算子の種類を保持する
	/// </summary>
	/// <param name="sender">Sender.</param>
	/// <param name="e">E.</param>
	protected void OnButtonOperatorSymbolClicked (object sender, EventArgs e)
	{
		// 演算子の種類を保持
		string compare = ((Button)sender).Label.ToString();

		// 演算子の種類を設定
		switch (compare)
		{
			case "+":
				typeOfOperatorSymbol = operatorSymbol.Addition.ToString();
				break;

			case "-":
				typeOfOperatorSymbol = operatorSymbol.Subtraction.ToString();
				break;

			case "×":
				typeOfOperatorSymbol = operatorSymbol.multiplication.ToString();
				break;

			case "÷":
				typeOfOperatorSymbol = operatorSymbol.Division.ToString();
				break;
		};
			
		// "="押下時に計算する入力値の保持
		valueList.Add (mainDisplay.Text);

		// テキストフィールドを未入力状態で表示
		mainDisplay.Text = zero;

		// 演算子の種類を画面に表示
		subDisplay.Text = compare;
	}
		
	/// <summary>
	/// 入力された値の画面表示
	/// </summary>
	/// <param name="sender">Sender.</param>
	/// <param name="e">E.</param>
	protected void OnButtonNumber (object sender, EventArgs e)
	{
		// 画面に表示された文字列を取得
		string textOfValue = mainDisplay.Text + ((Button)sender).Label;

		//画面上の入力値を数値で保持する変数
		double textToDouble;

		try
		{
		    // 先頭の0を取り除く(01,02...みたいな表示はおかしいから)
		    textToDouble = Convert.ToDouble (textOfValue);
		}
		catch (OverflowException)
		{
			subDisplay.Text = overNumber;
			return;
		}

		// 画面表示用の変数
		string displayText = textToDouble.ToString ();

		// 行末から一つ前の入力値
		string oneBeforeValueOfEndLine = textOfValue.Substring (mainDisplay.Text.Length - 1, 1);




		//TODO:小数点以降の最後の入力に対して０が入力された場合を可能とする。


		// 小数点の次に０が入力されている場合の処理
		if (mainDisplay.Text.Length != 0   && 
			((Button)sender).Label == zero &&
			oneBeforeValueOfEndLine == dot)
		{
			displayText += dotZero;
		} 

		// 画面に表示
		mainDisplay.Text = displayText;
	}
		
	/// <summary>
	/// 保持した情報を消去する(Clearボタン押下時の処理)
	/// </summary>
	/// <param name="sender">Sender.</param>
	/// <param name="e">E.</param>
	protected void OnButtonclearClicked (object sender, EventArgs e)
	{
		mainDisplay.Text = zero;
		subDisplay.Text = string.Empty;
		typeOfOperatorSymbol = string.Empty;
		valueList.Clear ();
	}
}