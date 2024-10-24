/*
 * Created by SharpDevelop.
 * User: CC2-PC20
 * Date: 24/10/2024
 * Time: 08:08 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyecto
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1(string text, string text2)
		{
			InitializeComponent();
			lblNombre.Text=text;
			lblRFC2.Text=text2;
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
	}
}
