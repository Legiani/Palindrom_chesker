using System;
using Xamarin.Forms;

namespace Palindromchesker
{
	public partial class PalindromcheskerPage : ContentPage
	{
		public PalindromcheskerPage()
		{
			InitializeComponent();


		}
		public void odeslat(object sender, EventArgs e) {
			vys.Text = jePalindrom(text.Text);
		}

		public static string jePalindrom(string retezec)
		{
			retezec = retezec.ToLower()
			                 .Replace(" ", "")
			                 .Replace(".", "")
			                 .Replace("!", "")
			                 .Replace("?", "")
			                 .Replace("ě", "e")
			                 .Replace("š", "s")
			                 .Replace("č", "c")
			                 .Replace("ř", "r")
			                 .Replace("ž", "z")
			                 .Replace("ý", "y")
			                 .Replace("á", "a")
			                 .Replace("í", "i")
			                 .Replace("é", "e");
			char[] array = retezec.ToCharArray();
			Array.Reverse(array);
			string backwards = new string(array);

			if (retezec == backwards)
			{
				return "je";
			}
			else {
				return "není";
			}
		}
	}
}
