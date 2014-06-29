using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace TestMonoDroid
{

	public class Calc : ICalc {

		public EditText firstValueContainer { get; private set; }

		public EditText lastValueContainer {get; private set; }

		public EditText operationType { get; private set; }

		public TextView resultMessageWriter { get; private set; }

		public Calc(EditText fValue, EditText lValue, EditText operation, TextView resultView) {
			firstValueContainer = fValue;
			lastValueContainer = lValue;
			operationType = operation;
			resultMessageWriter = resultView;
		}

		#region ICalc implementation

		public void Calculate ()
		{
			try {
				decimal lValue = Convert.ToDecimal(firstValueContainer.Text);
				decimal rValue = Convert.ToDecimal(lastValueContainer.Text);
				OperationType operation = operationType.Text.GetOperationType();
				decimal result = operation.ApplyOperation(lValue, rValue);
				resultMessageWriter.Text = Convert.ToString(result);
			}
			catch (Exception ex) {
				resultMessageWriter.Text = ex.Message;				
			}
		}

		#endregion
	}

}
