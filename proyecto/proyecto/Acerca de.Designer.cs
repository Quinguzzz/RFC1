/*
 * Created by SharpDevelop.
 * User: CC1_PC01
 * Date: 24/10/2024
 * Time: 11:02 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace proyecto
{
	partial class Acerca_de
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(10, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "CBTIS 217";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(10, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(146, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "METODOLOGIAS AGILES";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(10, 59);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "PROYECTO";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(10, 85);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "VERSION 4";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(10, 110);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(116, 23);
			this.label5.TabIndex = 4;
			this.label5.Text = "22/OCTUBRE/2024";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(10, 136);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(162, 23);
			this.label6.TabIndex = 5;
			this.label6.Text = "ARANA QUINTINO GUZMAN";
			// 
			// Acerca_de
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 158);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Acerca_de";
			this.Text = "Acerca_de";
			this.Load += new System.EventHandler(this.Acerca_deLoad);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
