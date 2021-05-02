using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tut_Events
{
	static class Program
	{

		static Button but1 = new Button { Text = "Button 1" };
		static Random rand = new Random();

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{

			but1.Click += (s, e) => theButtonWasClicked(s, e);
			but1.MouseMove += (s, e) => mouseMoved(s, e);

			var form = new Form();

			form.Controls.Add(but1);
			
			form.Show();

			Application.Run();

		}

		/// <summary>
		/// Handles a button click
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		static void theButtonWasClicked(object sender, EventArgs e)
		{
			Button b = (Button)sender;
			MessageBox.Show($"You clicked: { b.Text }.");
		}

		static void mouseMoved(object sender, MouseEventArgs e)
		{
			Button b = (Button)sender;

			b.Top = rand.Next() % 200;
			b.Left = rand.Next() % 200;

			//MessageBox.Show($"You moved the mouse over { b.Text } at { e.Location }!");

		}

	}
}
