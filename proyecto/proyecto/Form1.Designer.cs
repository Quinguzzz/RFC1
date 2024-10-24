/*
 * Created by SharpDevelop.
 * User: CC2-PC20
 * Date: 24/10/2024
 * Time: 08:08 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace proyecto
{
	partial class Form1
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
			this.lblNombre = new System.Windows.Forms.Label();
			this.lblRFC2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblNombre
			// 
			this.lblNombre.Location = new System.Drawing.Point(25, 20);
			this.lblNombre.Name = "lblNombre";
			this.lblNombre.Size = new System.Drawing.Size(186, 23);
			this.lblNombre.TabIndex = 0;
			this.lblNombre.Text = "label1";
			// 
			// lblRFC2
			// 
			this.lblRFC2.Location = new System.Drawing.Point(25, 63);
			this.lblRFC2.Name = "lblRFC2";
			this.lblRFC2.Size = new System.Drawing.Size(186, 23);
			this.lblRFC2.TabIndex = 1;
			this.lblRFC2.Text = "label2";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.lblRFC2);
			this.Controls.Add(this.lblNombre);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label lblRFC2;
		private System.Windows.Forms.Label lblNombre;
	}
}
