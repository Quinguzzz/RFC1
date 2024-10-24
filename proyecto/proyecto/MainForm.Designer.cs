/*
 * Created by SharpDevelop.
 * User: CC2-PC20
 * Date: 24/10/2024
 * Time: 07:42 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace proyecto
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.lblRFC = new System.Windows.Forms.Label();
			this.btnListo = new System.Windows.Forms.Button();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.cbSemestre = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtDireccion = new System.Windows.Forms.TextBox();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.txtA2 = new System.Windows.Forms.TextBox();
			this.txtA1 = new System.Windows.Forms.TextBox();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(303, 53);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker1.TabIndex = 50;
			// 
			// lblRFC
			// 
			this.lblRFC.Location = new System.Drawing.Point(303, 133);
			this.lblRFC.Name = "lblRFC";
			this.lblRFC.Size = new System.Drawing.Size(200, 23);
			this.lblRFC.TabIndex = 49;
			this.lblRFC.Text = "RFC: ";
			// 
			// btnListo
			// 
			this.btnListo.Location = new System.Drawing.Point(428, 91);
			this.btnListo.Name = "btnListo";
			this.btnListo.Size = new System.Drawing.Size(75, 23);
			this.btnListo.TabIndex = 48;
			this.btnListo.Text = "LISTO";
			this.btnListo.UseVisualStyleBackColor = true;
			this.btnListo.Click += new System.EventHandler(this.BtnListoClick);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(303, 91);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
			this.btnLimpiar.TabIndex = 47;
			this.btnLimpiar.Text = "LIMPIAR";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiarClick);
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(303, 14);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(162, 23);
			this.label7.TabIndex = 46;
			this.label7.Text = "FECHA DE NACIMIENTO";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(14, 221);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(101, 23);
			this.label6.TabIndex = 45;
			this.label6.Text = "SEMESTRE";
			// 
			// cbSemestre
			// 
			this.cbSemestre.FormattingEnabled = true;
			this.cbSemestre.Items.AddRange(new object[] {
									"1er Semestre",
									"2do Semestre",
									"3er Semestre",
									"4to Semestre",
									"5to Semestre",
									"6to Semestre"});
			this.cbSemestre.Location = new System.Drawing.Point(136, 218);
			this.cbSemestre.Name = "cbSemestre";
			this.cbSemestre.Size = new System.Drawing.Size(132, 21);
			this.cbSemestre.TabIndex = 44;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(13, 179);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 43;
			this.label5.Text = "DIRECCIÓN";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(12, 139);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 42;
			this.label4.Text = "TELEFONO";
			// 
			// txtDireccion
			// 
			this.txtDireccion.Location = new System.Drawing.Point(136, 176);
			this.txtDireccion.Name = "txtDireccion";
			this.txtDireccion.Size = new System.Drawing.Size(132, 20);
			this.txtDireccion.TabIndex = 41;
			// 
			// txtTelefono
			// 
			this.txtTelefono.Location = new System.Drawing.Point(136, 136);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(131, 20);
			this.txtTelefono.TabIndex = 40;
			// 
			// txtA2
			// 
			this.txtA2.Location = new System.Drawing.Point(136, 94);
			this.txtA2.Name = "txtA2";
			this.txtA2.Size = new System.Drawing.Size(131, 20);
			this.txtA2.TabIndex = 39;
			// 
			// txtA1
			// 
			this.txtA1.Location = new System.Drawing.Point(136, 53);
			this.txtA1.Name = "txtA1";
			this.txtA1.Size = new System.Drawing.Size(131, 20);
			this.txtA1.TabIndex = 38;
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(136, 12);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(132, 20);
			this.txtNombre.TabIndex = 37;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(12, 99);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(118, 23);
			this.label3.TabIndex = 36;
			this.label3.Text = "SEGUNDO APELLIDO";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(12, 57);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(111, 23);
			this.label2.TabIndex = 35;
			this.label2.Text = "PRIMER APELLIDO";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 34;
			this.label1.Text = "NOMBRE";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(525, 246);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.lblRFC);
			this.Controls.Add(this.btnListo);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.cbSemestre);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtDireccion);
			this.Controls.Add(this.txtTelefono);
			this.Controls.Add(this.txtA2);
			this.Controls.Add(this.txtA1);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "FORMULARIO";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtA1;
		private System.Windows.Forms.TextBox txtA2;
		private System.Windows.Forms.TextBox txtTelefono;
		private System.Windows.Forms.TextBox txtDireccion;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cbSemestre;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.Button btnListo;
		private System.Windows.Forms.Label lblRFC;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
	}
}
