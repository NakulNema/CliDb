/*
 * Created by SharpDevelop.
 * User: Nakul
 * Date: 17-Dec-15
 * Time: 11:12 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace CliDb
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
			this.label1 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.mainListView = new System.Windows.Forms.ListView();
			this.columnHeader13 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
			this.New_Patient = new System.Windows.Forms.GroupBox();
			this.Print_Rx = new System.Windows.Forms.Button();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.Settings_Button = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.Modify_Worklist = new System.Windows.Forms.Button();
			this.Add_Work = new System.Windows.Forms.Button();
			this.workListView = new System.Windows.Forms.ListView();
			this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader11 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader12 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader14 = new System.Windows.Forms.ColumnHeader();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.Delete_Button = new System.Windows.Forms.Button();
			this.Modify_Button = new System.Windows.Forms.Button();
			this.Add_Record_Button = new System.Windows.Forms.Button();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.New_Patient.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(6, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 30);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name";
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
									"Mr.",
									"Mrs.",
									"Ms.",
									"Dr."});
			this.comboBox1.Location = new System.Drawing.Point(45, 19);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(50, 21);
			this.comboBox1.TabIndex = 0;
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(101, 19);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(142, 20);
			this.textBox1.TabIndex = 1;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
			this.dateTimePicker1.Location = new System.Drawing.Point(45, 48);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(198, 20);
			this.dateTimePicker1.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(6, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 26);
			this.label2.TabIndex = 6;
			this.label2.Text = "Date";
			// 
			// mainListView
			// 
			this.mainListView.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
			this.mainListView.AllowColumnReorder = true;
			this.mainListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.mainListView.BackColor = System.Drawing.SystemColors.Window;
			this.mainListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader13,
									this.columnHeader1,
									this.columnHeader2,
									this.columnHeader3,
									this.columnHeader9,
									this.columnHeader7,
									this.columnHeader4,
									this.columnHeader5,
									this.columnHeader6,
									this.columnHeader8});
			this.mainListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mainListView.ForeColor = System.Drawing.SystemColors.WindowText;
			this.mainListView.FullRowSelect = true;
			this.mainListView.GridLines = true;
			this.mainListView.Location = new System.Drawing.Point(4, 212);
			this.mainListView.Name = "mainListView";
			this.mainListView.Size = new System.Drawing.Size(927, 228);
			this.mainListView.TabIndex = 7;
			this.mainListView.UseCompatibleStateImageBehavior = false;
			this.mainListView.View = System.Windows.Forms.View.Details;
			this.mainListView.DoubleClick += new System.EventHandler(this.MainListViewDoubleClick);
			// 
			// columnHeader13
			// 
			this.columnHeader13.Text = "ID";
			this.columnHeader13.Width = 40;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Date";
			this.columnHeader1.Width = 50;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Name";
			this.columnHeader2.Width = 150;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Phone";
			this.columnHeader3.Width = 100;
			// 
			// columnHeader9
			// 
			this.columnHeader9.Text = "DOB";
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Fee Due";
			this.columnHeader7.Width = 100;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Problems";
			this.columnHeader4.Width = 202;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Work Done";
			this.columnHeader5.Width = 327;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Fee(s)";
			this.columnHeader6.Width = 100;
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "All Procedure Completed";
			this.columnHeader8.Width = 118;
			// 
			// New_Patient
			// 
			this.New_Patient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.New_Patient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.New_Patient.Controls.Add(this.Print_Rx);
			this.New_Patient.Controls.Add(this.numericUpDown1);
			this.New_Patient.Controls.Add(this.Settings_Button);
			this.New_Patient.Controls.Add(this.label9);
			this.New_Patient.Controls.Add(this.groupBox1);
			this.New_Patient.Controls.Add(this.Delete_Button);
			this.New_Patient.Controls.Add(this.Modify_Button);
			this.New_Patient.Controls.Add(this.Add_Record_Button);
			this.New_Patient.Controls.Add(this.dateTimePicker2);
			this.New_Patient.Controls.Add(this.label4);
			this.New_Patient.Controls.Add(this.textBox2);
			this.New_Patient.Controls.Add(this.label3);
			this.New_Patient.Controls.Add(this.label2);
			this.New_Patient.Controls.Add(this.dateTimePicker1);
			this.New_Patient.Controls.Add(this.textBox1);
			this.New_Patient.Controls.Add(this.comboBox1);
			this.New_Patient.Controls.Add(this.label1);
			this.New_Patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.New_Patient.Location = new System.Drawing.Point(0, 0);
			this.New_Patient.MaximumSize = new System.Drawing.Size(1150, 200);
			this.New_Patient.Name = "New_Patient";
			this.New_Patient.Size = new System.Drawing.Size(928, 200);
			this.New_Patient.TabIndex = 1;
			this.New_Patient.TabStop = false;
			this.New_Patient.Text = "New Patient";
			// 
			// Print_Rx
			// 
			this.Print_Rx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Print_Rx.Location = new System.Drawing.Point(843, 162);
			this.Print_Rx.Name = "Print_Rx";
			this.Print_Rx.Size = new System.Drawing.Size(79, 27);
			this.Print_Rx.TabIndex = 26;
			this.Print_Rx.Text = "Print Rx";
			this.Print_Rx.UseVisualStyleBackColor = true;
			this.Print_Rx.Click += new System.EventHandler(this.Print_RxClick);
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(62, 129);
			this.numericUpDown1.Maximum = new decimal(new int[] {
									10000,
									0,
									0,
									0});
			this.numericUpDown1.Minimum = new decimal(new int[] {
									10000,
									0,
									0,
									-2147483648});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(181, 20);
			this.numericUpDown1.TabIndex = 5;
			// 
			// Settings_Button
			// 
			this.Settings_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Settings_Button.Location = new System.Drawing.Point(843, 129);
			this.Settings_Button.Name = "Settings_Button";
			this.Settings_Button.Size = new System.Drawing.Size(79, 27);
			this.Settings_Button.TabIndex = 24;
			this.Settings_Button.Text = "Options";
			this.Settings_Button.UseVisualStyleBackColor = true;
			this.Settings_Button.Click += new System.EventHandler(this.Settings_ButtonClick);
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(6, 131);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(68, 22);
			this.label9.TabIndex = 24;
			this.label9.Text = "Fee Paid";
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Controls.Add(this.Modify_Worklist);
			this.groupBox1.Controls.Add(this.Add_Work);
			this.groupBox1.Controls.Add(this.workListView);
			this.groupBox1.Controls.Add(this.textBox5);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.textBox4);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.textBox3);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Location = new System.Drawing.Point(249, 19);
			this.groupBox1.MaximumSize = new System.Drawing.Size(760, 166);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(585, 166);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Procedures";
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(7, 110);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(171, 21);
			this.checkBox1.TabIndex = 3;
			this.checkBox1.Text = "Procedure Competed";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// Modify_Worklist
			// 
			this.Modify_Worklist.Location = new System.Drawing.Point(6, 137);
			this.Modify_Worklist.Name = "Modify_Worklist";
			this.Modify_Worklist.Size = new System.Drawing.Size(54, 22);
			this.Modify_Worklist.TabIndex = 23;
			this.Modify_Worklist.Text = "Modify";
			this.Modify_Worklist.UseVisualStyleBackColor = true;
			this.Modify_Worklist.Click += new System.EventHandler(this.Modify_WorklistClick);
			// 
			// Add_Work
			// 
			this.Add_Work.Location = new System.Drawing.Point(66, 137);
			this.Add_Work.Name = "Add_Work";
			this.Add_Work.Size = new System.Drawing.Size(34, 22);
			this.Add_Work.TabIndex = 4;
			this.Add_Work.Text = "Add";
			this.Add_Work.UseVisualStyleBackColor = true;
			this.Add_Work.Click += new System.EventHandler(this.Add_Work_Click);
			// 
			// workListView
			// 
			this.workListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.workListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader10,
									this.columnHeader11,
									this.columnHeader12,
									this.columnHeader14});
			this.workListView.FullRowSelect = true;
			this.workListView.GridLines = true;
			this.workListView.Location = new System.Drawing.Point(220, 21);
			this.workListView.MaximumSize = new System.Drawing.Size(550, 138);
			this.workListView.MultiSelect = false;
			this.workListView.Name = "workListView";
			this.workListView.Size = new System.Drawing.Size(359, 138);
			this.workListView.TabIndex = 21;
			this.workListView.UseCompatibleStateImageBehavior = false;
			this.workListView.View = System.Windows.Forms.View.Details;
			this.workListView.Click += new System.EventHandler(this.WorkListViewClick);
			this.workListView.DoubleClick += new System.EventHandler(this.WorkListViewDoubleClick);
			// 
			// columnHeader10
			// 
			this.columnHeader10.Text = "Problem";
			this.columnHeader10.Width = 88;
			// 
			// columnHeader11
			// 
			this.columnHeader11.Text = "Work Done";
			this.columnHeader11.Width = 84;
			// 
			// columnHeader12
			// 
			this.columnHeader12.Text = "Fee(s)";
			this.columnHeader12.Width = 71;
			// 
			// columnHeader14
			// 
			this.columnHeader14.Text = "Procedure Status";
			this.columnHeader14.Width = 118;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(66, 84);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(100, 20);
			this.textBox5.TabIndex = 2;
			this.textBox5.Text = "0";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(7, 84);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(93, 26);
			this.label8.TabIndex = 19;
			this.label8.Text = "Fee";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(345, 93);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(8, 8);
			this.label7.TabIndex = 18;
			this.label7.Text = "Fee";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(66, 58);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(148, 20);
			this.textBox4.TabIndex = 1;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(6, 61);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 26);
			this.label6.TabIndex = 16;
			this.label6.Text = "Work Done";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(66, 29);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(148, 20);
			this.textBox3.TabIndex = 0;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(7, 35);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(80, 21);
			this.label5.TabIndex = 11;
			this.label5.Text = "Problem";
			// 
			// Delete_Button
			// 
			this.Delete_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Delete_Button.Location = new System.Drawing.Point(843, 97);
			this.Delete_Button.Name = "Delete_Button";
			this.Delete_Button.Size = new System.Drawing.Size(82, 28);
			this.Delete_Button.TabIndex = 15;
			this.Delete_Button.Text = "Delete";
			this.Delete_Button.UseVisualStyleBackColor = true;
			this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
			// 
			// Modify_Button
			// 
			this.Modify_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Modify_Button.Location = new System.Drawing.Point(842, 60);
			this.Modify_Button.Name = "Modify_Button";
			this.Modify_Button.Size = new System.Drawing.Size(82, 30);
			this.Modify_Button.TabIndex = 14;
			this.Modify_Button.Text = "Modify";
			this.Modify_Button.UseVisualStyleBackColor = true;
			this.Modify_Button.Click += new System.EventHandler(this.Modify_Button_Click);
			// 
			// Add_Record_Button
			// 
			this.Add_Record_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Add_Record_Button.AutoSize = true;
			this.Add_Record_Button.Location = new System.Drawing.Point(845, 24);
			this.Add_Record_Button.MaximumSize = new System.Drawing.Size(100, 30);
			this.Add_Record_Button.Name = "Add_Record_Button";
			this.Add_Record_Button.Size = new System.Drawing.Size(82, 30);
			this.Add_Record_Button.TabIndex = 7;
			this.Add_Record_Button.Text = "Add Record";
			this.Add_Record_Button.UseVisualStyleBackColor = true;
			this.Add_Record_Button.Click += new System.EventHandler(this.Add_Record_Button_Click);
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.CustomFormat = "dd-MM-yyyy";
			this.dateTimePicker2.Location = new System.Drawing.Point(45, 103);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(198, 20);
			this.dateTimePicker2.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(6, 103);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(37, 22);
			this.label4.TabIndex = 9;
			this.label4.Text = "DOB";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(45, 77);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(198, 20);
			this.textBox2.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(6, 80);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 25);
			this.label3.TabIndex = 7;
			this.label3.Text = "Phone";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			this.ClientSize = new System.Drawing.Size(939, 444);
			this.Controls.Add(this.New_Patient);
			this.Controls.Add(this.mainListView);
			this.MinimumSize = new System.Drawing.Size(955, 480);
			this.Name = "MainForm";
			this.Text = "CliDb";
			this.New_Patient.ResumeLayout(false);
			this.New_Patient.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button Print_Rx;
		private System.Windows.Forms.ColumnHeader columnHeader13;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
		private System.Windows.Forms.ColumnHeader columnHeader14;
		private System.Windows.Forms.ColumnHeader columnHeader12;
		private System.Windows.Forms.ColumnHeader columnHeader11;
		private System.Windows.Forms.ColumnHeader columnHeader10;
		private System.Windows.Forms.ColumnHeader columnHeader9;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.Button Settings_Button;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button Modify_Worklist;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.ListView workListView;
		private System.Windows.Forms.Button Add_Work;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button Add_Record_Button;
		private System.Windows.Forms.Button Modify_Button;
		private System.Windows.Forms.Button Delete_Button;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.GroupBox New_Patient;
		private System.Windows.Forms.ListView mainListView;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label1;
		
		
		
		
		
		
		
		
		
		
	}
}
