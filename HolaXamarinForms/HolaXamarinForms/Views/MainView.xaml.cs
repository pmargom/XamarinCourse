using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HolaXamarinForms
{
	public partial class MainView : ContentPage
	{

		int count = 1;

		public MainView()
		{
			InitializeComponent();

			MyButton.Clicked += (sender, args) =>
			   {
				   MyButton.Text = string.Format("{0} clicks!", count++);
			   };
		}
	}
}
