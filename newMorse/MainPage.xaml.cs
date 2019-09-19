using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace newMorse
{
	 //Xamarin.Forms previewer
	 // by visiting https://aka.ms/xamarinforms-previewer
	 [DesignTimeVisible(false)]

	public partial class MainPage : ContentPage
	{

        public MainPage()
        {
            InitializeComponent();
        }

        private static string[] codes = new string[] { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--..", "" };

		private static char[] letters = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', ' ' };

		public string dotDashText = "";

        public static char MorseCoder(string code)
        {
            char result = '?';
            for (int i = 0; i < codes.Length; i++)
            {
                if (codes[i].Equals(code))
                {
                    result = letters[i];
                    break;
                }
            }
            return result;
        }


            

            void dotClicked(object sender, System.EventArgs e)
            {
                dotDash.Text += dot.Text;
            }

            void dashClicked(object sender, System.EventArgs e)
            {
                dotDash.Text += dash.Text;
            }

            void spaceClicked(object sender, System.EventArgs e)
            {
                output.Text += MorseCoder(dotDash.Text);
            }

            void delete(object sender, System.EventArgs e)
            {
                output.Text = "";
                dotDash.Text = "";
            }
        }
    }