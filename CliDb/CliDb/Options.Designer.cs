/*
 * Created by SharpDevelop.
 * User: Nakul
 * Date: 21-Dec-15
 * Time: 2:58 PM
 */
namespace CliDb
{
	partial class Options
	{
		
		private System.ComponentModel.IContainer components = null;
		
		
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		
		private void InitializeComponent()
		{
			this.Restore = new System.Windows.Forms.Button();
			this.AboutButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Restore
			// 
			this.Restore.Location = new System.Drawing.Point(12, 12);
			this.Restore.Name = "Restore";
			this.Restore.Size = new System.Drawing.Size(176, 33);
			this.Restore.TabIndex = 0;
			this.Restore.Text = "Restore Data File";
			this.Restore.UseVisualStyleBackColor = true;
			this.Restore.Click += new System.EventHandler(this.RestoreClick);
			// 
			// AboutButton
			// 
			this.AboutButton.Location = new System.Drawing.Point(12, 51);
			this.AboutButton.Name = "AboutButton";
			this.AboutButton.Size = new System.Drawing.Size(176, 30);
			this.AboutButton.TabIndex = 1;
			this.AboutButton.Text = "About";
			this.AboutButton.UseVisualStyleBackColor = true;
			this.AboutButton.Click += new System.EventHandler(this.AboutButtonClick);
			// 
			// Options
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(197, 90);
			this.Controls.Add(this.AboutButton);
			this.Controls.Add(this.Restore);
			this.Name = "Options";
			this.Text = "Options";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button AboutButton;
		private System.Windows.Forms.Button Restore;
	}
}
