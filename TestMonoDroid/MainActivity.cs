using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace TestMonoDroid
{
	[Activity (Label = "TestMonoDroid", MainLauncher = true)]
	public class MainActivity : Activity
	{
		ICalc calc;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);


			calc = new Calc (
				FindViewById<EditText> (Resource.Id.firstNumber),
				FindViewById<EditText> (Resource.Id.lastNumber),
				FindViewById<EditText> (Resource.Id.operationType),
				FindViewById<TextView> (Resource.Id.resultView)
			);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.processButton);
			
			button.Click += delegate {
				calc.Calculate();
			};
		}
	}
}


