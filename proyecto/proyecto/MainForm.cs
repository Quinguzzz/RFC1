/*
 * Created by SharpDevelop.
 * User: CC2-PC20
 * Date: 24/10/2024
 * Time: 07:42 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace proyecto
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnLimpiarClick(object sender, EventArgs e)
		{
			txtNombre.Clear();
			txtA1.Clear();
			txtA2.Clear();
			txtTelefono.Clear();
			txtDireccion.Clear();
			cbSemestre.Text="";	
			dateTimePicker1.Format = DateTimePickerFormat.Custom;
			dateTimePicker1.CustomFormat = " ";			
		}
		
		void BtnListoClick(object sender, EventArgs e)
		{
			string nombre = txtNombre.Text.Trim().ToUpper();			
			if (nombre == null || nombre.Trim() == "") 
			{
				MessageBox.Show("Debes llenar el campo de Nombre");
			}
			else
			{
			string apellido1 = txtA1.Text.Trim().ToUpper();
			if (apellido1 == null || apellido1.Trim() == "") 
			{
				MessageBox.Show("Debes llenar el campo de Primer apellido");
			}
			else
			{
			string apellido2 = txtA2.Text.Trim().ToUpper();
			if (apellido2 == null || apellido2.Trim() == "") 
			{
				MessageBox.Show("Debes llenar el campo de Segundo apellido");
			}
			
            
            string telefono=txtTelefono.Text;
            string direccion=txtDireccion.Text;
            string semestre=cbSemestre.SelectedItem.ToString();
            DateTime fechaNacimiento=dateTimePicker1.Value;
            
          
            
            Random random = new Random();
            string h =random.Next(100000, 999999).ToString("D6");
 			
            string rfc = apellido1.Substring(0, 2) + apellido2.Substring(0, 1) + nombre.Substring(0, 1) +
            fechaNacimiento.ToString("yyMMdd")+h.Substring(0,3);
            lblRFC.Text = "RFC: " + rfc;
            
            string textToPass = txtNombre.Text + " " + txtA1.Text + " " + txtA2.Text;
    		string textToPass2 = lblRFC.Text;
    		Form1 form1 = new Form1(textToPass, textToPass2);
   			form1.Show();
			}
			}			
					
		}
	}
}
