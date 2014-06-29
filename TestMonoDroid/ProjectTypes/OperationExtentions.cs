using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace TestMonoDroid
{

	public static class OperationExtentions{

		public static OperationType GetOperationType(this string operationString) {
			if (string.IsNullOrEmpty(operationString))
				throw new ArgumentNullException ("operationString");
			switch (operationString) {
			case "/":
				return OperationType.Div;
			case "*":
				return OperationType.Mul;
			case "+":
				return OperationType.Add;
			case "-":
				return OperationType.Sub;
			default:
				throw new ArgumentOutOfRangeException ("operationString");
			}
		}
	
		public static decimal ApplyOperation(this OperationType type, decimal lValue, decimal rValue){
			switch (type) {
			case OperationType.Div:
				return lValue / rValue;
			case OperationType.Mul:
				return lValue * rValue;
			case OperationType.Add:
				return lValue + rValue;
			case OperationType.Sub:
				return lValue - rValue;
			default:
				throw new ArgumentOutOfRangeException ("type");
			}
		}
	}
}
