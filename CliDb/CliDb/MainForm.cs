/*
 * Created by SharpDevelop.
 * User: Nakul
 * Date: 17-Dec-15
 * Time: 11:12 PM
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text;


namespace CliDb
{
	public partial class MainForm : Form
	{
		public int last_id;
		public int current_id;
		public char last_action;
		public MainForm()
		{
			InitializeComponent();
			
			if(!File.Exists("DB.csv"))
			{
			   	if(MessageBox.Show("Data file does not exits Create? \r (You can try to restore bakups in settings)", 
			   	                   "File not found", MessageBoxButtons.YesNo) == DialogResult.No)
			   		return;
			   	else
			   	{
			   		FileStream fs = File.Create("DB.csv");
			   		fs.Close();
			   	}
			}
					
			
			displaydata();
			
			
			
		}
		public void displaydata()
		{
			mainListView.Items.Clear();
			
			StreamReader sr = new StreamReader(@"DB.csv");
			
			string strline = "";
			List<String> list = new List<String>();
			string word1 = "";
			int i=0,flag=0;
			ListViewItem itm ;
			list.Add("0");
			
			
			while (!sr.EndOfStream)
			{
				list.Clear();
					
				//Read a line
   				strline = sr.ReadLine();			
    			
    			//loop to seperate values in 'strline' and insert them in 'list'
    			for (i = 0; i < strline.Length; i++)
    			{
    				//seperate ',' seperated values and '"' grouped values 
    				switch(strline[i])
    				{
    						
    					case ',':
    						if(flag==0)
    						{
    							list.Add(word1);
    							word1 = "";
    						}
    						else
    							word1=word1+strline[i];
    						break;
      					case '"':
							if(flag==0)
								flag=1;
							else flag=0;
							break;
						default:
      						word1=word1+strline[i];
      						break;
    				}
    				
    			}
    			list.Add(word1);
    			word1 = "";
    			
    			String[] stringArray = list.ToArray();
    			itm = new ListViewItem(stringArray);
    			mainListView.Items.Add(itm);
    		}
			
			if(!Int32.TryParse(list[0], out last_id))
			{
				MessageBox.Show("Data file is Corrupt/Invalid! Please select the latest backup to be restored in settings");
			}
			
			sr.Close();
		}
		
		
		
		void Add_Record_Button_Click(object sender, EventArgs e)
		{
			if(!File.Exists("DB.csv"))
			{
			   	MessageBox.Show("Data file has not been assigned, try restarting the application or restore bakup from settings.");
			   	return;
			}
			if(current_id!=0)
				if(MessageBox.Show("This will add a new record.\nAre you sure?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
					return;
			
			List<String> list = new List<String>();
			int i=0;
			decimal x=0;
			string[] arr = new string[4] {"\"","\"","\"","\""};
			if(textBox1.Text=="")
			{
				MessageBox.Show("Field \"Name\" Cannot be empty!");
				return;
			}
			
			i=workListView.Items.Count;
			if(i==0)
			{
				arr[0] = "\"\"";
				arr[1] = "\"\"";
				arr[2] = "\"\"";
				arr[3] = "\"\"";
			}
					
			foreach (ListViewItem itemRow in this.workListView.Items)
			{
				for( int counter = 0; counter < itemRow.SubItems.Count; counter++ )
				{
					if(i>1)
						arr[counter]=arr[counter]+itemRow.SubItems[counter].Text + ",";
					else
						arr[counter]=arr[counter]+itemRow.SubItems[counter].Text + "\"";
				}
				i--;
				x=x+Int32.Parse(itemRow.SubItems[2].Text);
    						
			}
			x=x-numericUpDown1.Value;
			string totfestring = x.ToString();
			string id = (++last_id).ToString();
			
			File.AppendAllText("DB.csv",id + "," + dateTimePicker1.Value.ToString("dd-MM-yyyy") + "," + comboBox1.Text + " " +  textBox1.Text + ","
			                   + textBox2.Text + "," + dateTimePicker1.Value.ToString("dd-MM-yyyy") + "," + totfestring + "," + arr[0] 
			                   + "," + arr[1] + "," + arr[2] + "," + arr[3] + "\r");
    		
    		textBox1.Text = "";
    		textBox2.Text = "";
    		comboBox1.Text = "";
    		numericUpDown1.Value = 0;
    		comboBox1.Focus();
    		displaydata();
    		workListView.Items.Clear();
    		current_id=0;
    		last_action='A';
    		
		}
		
		void Delete_Button_Click(object sender, EventArgs e)
		{
			if(mainListView.SelectedItems.Count<1)
			{
				MessageBox.Show("Please Select a Record.");
				return;
			}
			String text = mainListView.SelectedItems[0].SubItems[2].Text;
			
			
			if(MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
				return;
			int id = Int32.Parse(mainListView.SelectedItems[0].SubItems[0].Text),line_number=0,line_to_delete=1;
			StreamReader sr1 = new StreamReader(@"DB.csv");
			char[] index = new char[5] ;
			StringBuilder line = new StringBuilder();
			
			while(true)
			{
				while((char)sr1.Peek()!=',')
					line.Append((char)sr1.Read());
				
				if(Int32.Parse(line.ToString())==id)
					break;
				line.Clear();
				sr1.ReadLine();
				line_to_delete++;		
			}
			sr1.Close();
			
			string bkupFileName = DateTime.Now.ToFileTime().ToString() + ".bk";
			File.Move("DB.csv",bkupFileName);
			
			string linef = null;
			
			using (StreamReader reader = new StreamReader(bkupFileName))
			{
    			while ((linef = reader.ReadLine()) != null)
        		{
            		line_number++;
            		if (line_number == line_to_delete)
            			continue;
            		File.AppendAllText("DB.csv",linef + "\r");
    			}
			}
			last_action = 'D';
			displaydata();
		}
		
		void Modify_Button_Click(object sender, EventArgs e)
		{
			if(current_id==0)
			{	
				MessageBox.Show("1. Double click a record. \n2. Modify the appropriate field.\n3. Click this button conform modifications.","Incorrect Operation");
				return;
			}			
			if(MessageBox.Show("Modify " + comboBox1.Text + textBox1.Text + "'s record?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
				return;
			
			List<String> list = new List<String>();
			int i=0;
			decimal x=0;
			string[] arr = new string[4] {"\"","\"","\"","\""};
			if(textBox1.Text=="")
			{
				MessageBox.Show("Field \"Name\" Cannot be empty!");
				return;
			}
			
			
						
			i=workListView.Items.Count;
			
			if(i==0)
			{
				arr[0] = "\"\"";
				arr[1] = "\"\"";
				arr[2] = "\"\"";
				arr[3] = "\"\"";
			}
			
			foreach (ListViewItem itemRow in this.workListView.Items)
			{
				for( int counter = 0; counter < itemRow.SubItems.Count; counter++ )
				{
					if(i>1)
						arr[counter]=arr[counter]+itemRow.SubItems[counter].Text + ",";
					else
						arr[counter]=arr[counter]+itemRow.SubItems[counter].Text + "\"";
				}
				i--;
				x=x + Int32.Parse(itemRow.SubItems[2].Text);
    						
			}
			x=x-numericUpDown1.Value;
			string totfestring = x.ToString();
			StreamReader sr1 = new StreamReader(@"DB.csv");
			char[] index = new char[5] ;
			int line_to_modify = 1, line_number = 0;
			StringBuilder line = new StringBuilder();
			
			while(true)
			{
				while((char)sr1.Peek()!=',')
					line.Append((char)sr1.Read());
				
				if(Int32.Parse(line.ToString())==current_id)
					break;
				line.Clear();
				sr1.ReadLine();
				line_to_modify++;		
			}
			sr1.Close();
			
			string bkupFileName = DateTime.Now.ToFileTime().ToString() + ".bk";
			File.Move("DB.csv",bkupFileName);
			string linef = null;
			
			using (StreamReader reader = new StreamReader(bkupFileName))
			{
    			while ((linef = reader.ReadLine()) != null)
    			{
            		line_number++;
            		if (line_number == line_to_modify)
            		{
			            File.AppendAllText("DB.csv",current_id.ToString() + "," + dateTimePicker1.Value.ToString("dd-MM-yyyy") + "," + comboBox1.Text + textBox1.Text + ","
			                   + textBox2.Text + "," + dateTimePicker1.Value.ToString("dd-MM-yyyy") + "," + totfestring + "," + arr[0] 
			                   + "," + arr[1] + "," + arr[2] + "," + arr[3]+ "\r");
            			continue;
            		}
            		File.AppendAllText("DB.csv",linef+"\r");
    			}
    			
			}
			
			
			textBox1.Text = "";
    		textBox2.Text = "";
    		comboBox1.Text = "";
    		numericUpDown1.Value = 0;
    		comboBox1.Focus();
    		displaydata();
    		workListView.Items.Clear();
    		current_id = 0;
			last_action = 'M';
			
			
		}
		
		void MainListViewDoubleClick(object sender, EventArgs e)
		{
			workListView.Items.Clear();
			current_id = int.Parse(mainListView.SelectedItems[0].SubItems[0].Text);
			string str = mainListView.SelectedItems[0].SubItems[1].Text;
			string[] date = str.Split('-');
			dateTimePicker1.Value = new DateTime(int.Parse(date[2]),int.Parse(date[1]),int.Parse(date[0]));
			str = mainListView.SelectedItems[0].SubItems[2].Text;
			string[] name = str.Split('.');
			comboBox1.Text = name[0] + '.';
			textBox1.Text = name[1];
			textBox2.Text = mainListView.SelectedItems[0].SubItems[3].Text;
			str = mainListView.SelectedItems[0].SubItems[4].Text;
			date = str.Split('-');
			dateTimePicker2.Value = new DateTime(int.Parse(date[2]),int.Parse(date[1]),int.Parse(date[0]));
			int feepaid = int.Parse(mainListView.SelectedItems[0].SubItems[5].Text);
			numericUpDown1.Value = feepaid;
			
			
			int rows = mainListView.SelectedItems[0].SubItems[6].Text.Split(',').Length;
			ListViewItem itm ;
						
			List<String> list1 = new List<String>();
			List<String> list2 = new List<String>();
			List<String> list3 = new List<String>();
			List<String> list4 = new List<String>();
			//string[] row_data = new string[4];
			
			list1.AddRange(mainListView.SelectedItems[0].SubItems[6].Text.Split(','));
			list2.AddRange(mainListView.SelectedItems[0].SubItems[7].Text.Split(','));
			list3.AddRange(mainListView.SelectedItems[0].SubItems[8].Text.Split(','));
			list4.AddRange(mainListView.SelectedItems[0].SubItems[9].Text.Split(','));
			
			if(string.Compare(list1[0].ToString(),"")==1)
			{
				for (int i = 0; i < rows;i++)
				{
					string[] row_data = {list1[i],list2[i],list3[i],list4[i]};
					itm = new ListViewItem(row_data);
   					workListView.Items.Add(itm);
				}
			}			
    	}
			
		void Settings_ButtonClick(object sender, System.EventArgs e)
		{
			using(Options frm = new Options())
			{
				frm.ShowDialog(this);
			}
			displaydata();
		}
		

		void Add_Work_Click(object sender, EventArgs e)
		{
			try{int.Parse(textBox5.Text);}
			catch{MessageBox.Show("Fee must be a number");return;}
			if(textBox3.Text=="")
			{
				MessageBox.Show("Field \"Problem\" Cannot be empty!");
				return;
			}
			ListViewItem itm ;
			string[] arr = new string[4]; 
			arr[0]=textBox3.Text;
			arr[1]=textBox4.Text;
			arr[2]=textBox5.Text;
			arr[3]="N";
			if(checkBox1.Checked)
				arr[3]="Y";
			itm = new ListViewItem(arr);
    		workListView.Items.Add(itm);
    		textBox3.Text = "";
    		textBox4.Text = "";
    		textBox5.Text = "0";
    		textBox3.Focus();
		}
		
		void Modify_WorklistClick(object sender, System.EventArgs e)
		{
			if(workListView.SelectedItems.Count==0)
			{
				MessageBox.Show("Please select a row before modifing.");
				return;
			}
			workListView.SelectedItems[0].SubItems[0].Text = textBox3.Text;
			workListView.SelectedItems[0].SubItems[1].Text = textBox4.Text;
			workListView.SelectedItems[0].SubItems[2].Text = textBox5.Text;
			workListView.SelectedItems[0].SubItems[3].Text = "N";
			if(checkBox1.Checked)
				workListView.SelectedItems[0].SubItems[3].Text = "Y";
			textBox3.Text = "";
    		textBox4.Text = "";
    		textBox5.Text = "0";
    		checkBox1.Checked=false;
			 textBox3.Focus();
		}
		
		void WorkListViewDoubleClick(object sender, System.EventArgs e)
		{
			
		}		
		
		
		
		
		void WorkListViewClick(object sender, EventArgs e)
		{
			textBox3.Text = workListView.SelectedItems[0].SubItems[0].Text;
			textBox4.Text = workListView.SelectedItems[0].SubItems[1].Text;
			textBox5.Text = workListView.SelectedItems[0].SubItems[2].Text;
			checkBox1.Checked=true;
			if(string.Compare(workListView.SelectedItems[0].SubItems[3].Text,"N")!=1)
			   checkBox1.Checked=false;
		}
		
		void Print_RxClick(object sender, EventArgs e)
		{
			//PrintPres frm = new PrintPres(this.richTextBox1.Text,1);
			//frm.Show();
			//Form1 frm = new Form1();
			//frm.Show();
			
		}
	}
	
}

