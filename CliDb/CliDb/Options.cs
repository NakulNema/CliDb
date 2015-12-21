/*
 * Created by SharpDevelop.
 * User: Nakul
 * Date: 21-Dec-15
 * Time: 2:58 PM
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CliDb
{
	
	public partial class Options : Form
	{
		public Options()
		{
			InitializeComponent();
		}
		
		void RestoreClick(object sender, EventArgs e)
		{
			OpenFileDialog theDialog = new OpenFileDialog();
			theDialog.Title = "Open Text File";
			theDialog.Filter = "bk files|*.bk";
			theDialog.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath);
			if (theDialog.ShowDialog() == DialogResult.Cancel)
				return;	
			
			if(MessageBox.Show("This bakup was created on " + DateTime.FromFileTime(long.Parse(theDialog.SafeFileName.Substring(0,18))).ToString() + "\n\nContinue?","Data Restore",MessageBoxButtons.YesNo) == DialogResult.No)
				return;
			
			DialogResult Result = MessageBox.Show("Create bakup of current data file?","Data Restore",MessageBoxButtons.YesNoCancel);
			if(Result == DialogResult.Cancel)
				return;
			else if(Result == DialogResult.Yes)
				File.Move("DB.csv",DateTime.Now.ToFileTime().ToString() + ".bk");
			
			File.Move(theDialog.FileName,"DB.csv");
			
		}
		
		void AboutButtonClick(object sender, EventArgs e)
		{
			MessageBox.Show("CliDB\n\nCliDB is an application for ceating and maintaining a clinical patient database. Data is saved in a simple \"CSV\" format, readable in any texteditor and editable in any spreadsheet software. Please submit any bugs and crash report at nakulnema91@gmail.com.\n\n Created by Nakul Nema (nakulnema91@gmail.com)\nusing SharpDevelop \n\n\nVer. 0.1 Alpha ");
		}
	}
}
