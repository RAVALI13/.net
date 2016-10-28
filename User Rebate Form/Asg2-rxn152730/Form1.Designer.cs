namespace Asg2_rxn152730
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.FirstNameBox = new System.Windows.Forms.TextBox();
            this.LastNameBox = new System.Windows.Forms.TextBox();
            this.MiddleInitialBox = new System.Windows.Forms.TextBox();
            this.AddressLine1Box = new System.Windows.Forms.TextBox();
            this.AddressLine2Box = new System.Windows.Forms.TextBox();
            this.CityBox = new System.Windows.Forms.TextBox();
            this.StateBox = new System.Windows.Forms.TextBox();
            this.ZipCodeBox = new System.Windows.Forms.TextBox();
            this.EmailIdBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.PhoneNumberBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(44, 15);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(492, 548);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listView1_KeyPress);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 150;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "LastName";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 40);
            this.label3.TabIndex = 4;
            this.label3.Text = "Middle Initial";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 40);
            this.label4.TabIndex = 5;
            this.label4.Text = "Address Line1";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 40);
            this.label5.TabIndex = 6;
            this.label5.Text = "Address Line 2";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 40);
            this.label6.TabIndex = 7;
            this.label6.Text = "City";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 40);
            this.label7.TabIndex = 8;
            this.label7.Text = "State";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 40);
            this.label8.TabIndex = 9;
            this.label8.Text = "ZipCode";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(191, 40);
            this.label9.TabIndex = 10;
            this.label9.Text = "phone number";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 360);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(191, 40);
            this.label10.TabIndex = 11;
            this.label10.Text = "Email Address";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 400);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(191, 40);
            this.label11.TabIndex = 12;
            this.label11.Text = "Proof of Purchase";
            // 
            // FirstNameBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.FirstNameBox, 2);
            this.FirstNameBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.FirstNameBox.Location = new System.Drawing.Point(200, 3);
            this.FirstNameBox.MaxLength = 20;
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(261, 31);
            this.FirstNameBox.TabIndex = 0;
            this.FirstNameBox.TextChanged += new System.EventHandler(this.FirstNameBox_TextChanged);
            // 
            // LastNameBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.LastNameBox, 2);
            this.LastNameBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.LastNameBox.Location = new System.Drawing.Point(200, 43);
            this.LastNameBox.MaxLength = 20;
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(261, 31);
            this.LastNameBox.TabIndex = 1;
            this.LastNameBox.TextChanged += new System.EventHandler(this.LastNameBox_TextChanged);
            // 
            // MiddleInitialBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.MiddleInitialBox, 2);
            this.MiddleInitialBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.MiddleInitialBox.Location = new System.Drawing.Point(200, 83);
            this.MiddleInitialBox.MaxLength = 1;
            this.MiddleInitialBox.Name = "MiddleInitialBox";
            this.MiddleInitialBox.Size = new System.Drawing.Size(261, 31);
            this.MiddleInitialBox.TabIndex = 2;
            this.MiddleInitialBox.TextChanged += new System.EventHandler(this.MiddleInitialBox_TextChanged);
            // 
            // AddressLine1Box
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.AddressLine1Box, 2);
            this.AddressLine1Box.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddressLine1Box.Location = new System.Drawing.Point(200, 123);
            this.AddressLine1Box.MaxLength = 35;
            this.AddressLine1Box.Name = "AddressLine1Box";
            this.AddressLine1Box.Size = new System.Drawing.Size(261, 31);
            this.AddressLine1Box.TabIndex = 3;
            this.AddressLine1Box.TextChanged += new System.EventHandler(this.AddressLine1Box_TextChanged);
            // 
            // AddressLine2Box
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.AddressLine2Box, 2);
            this.AddressLine2Box.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddressLine2Box.Location = new System.Drawing.Point(200, 163);
            this.AddressLine2Box.MaxLength = 35;
            this.AddressLine2Box.Name = "AddressLine2Box";
            this.AddressLine2Box.Size = new System.Drawing.Size(261, 31);
            this.AddressLine2Box.TabIndex = 4;
            this.AddressLine2Box.TextChanged += new System.EventHandler(this.AddressLine2Box_TextChanged);
            // 
            // CityBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.CityBox, 2);
            this.CityBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.CityBox.Location = new System.Drawing.Point(200, 203);
            this.CityBox.MaxLength = 25;
            this.CityBox.Name = "CityBox";
            this.CityBox.Size = new System.Drawing.Size(261, 31);
            this.CityBox.TabIndex = 5;
            this.CityBox.TextChanged += new System.EventHandler(this.CityBox_TextChanged);
            this.CityBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CityBox_KeyPress);
            // 
            // StateBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.StateBox, 2);
            this.StateBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.StateBox.Location = new System.Drawing.Point(200, 243);
            this.StateBox.MaxLength = 2;
            this.StateBox.Name = "StateBox";
            this.StateBox.Size = new System.Drawing.Size(261, 31);
            this.StateBox.TabIndex = 6;
            this.StateBox.TextChanged += new System.EventHandler(this.StateBox_TextChanged);
            this.StateBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StateBox_KeyPress);
            this.StateBox.Leave += new System.EventHandler(this.StateBox_Leave);
            // 
            // ZipCodeBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.ZipCodeBox, 2);
            this.ZipCodeBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.ZipCodeBox.Location = new System.Drawing.Point(200, 283);
            this.ZipCodeBox.MaxLength = 9;
            this.ZipCodeBox.Name = "ZipCodeBox";
            this.ZipCodeBox.Size = new System.Drawing.Size(261, 31);
            this.ZipCodeBox.TabIndex = 7;
            this.ZipCodeBox.TextChanged += new System.EventHandler(this.ZipCodeBox_TextChanged);
            this.ZipCodeBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ZipCodeBox_KeyPress);
            this.ZipCodeBox.Leave += new System.EventHandler(this.ZipCodeBox_Leave);
            // 
            // EmailIdBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.EmailIdBox, 2);
            this.EmailIdBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.EmailIdBox.Location = new System.Drawing.Point(200, 363);
            this.EmailIdBox.MaxLength = 60;
            this.EmailIdBox.Name = "EmailIdBox";
            this.EmailIdBox.Size = new System.Drawing.Size(261, 31);
            this.EmailIdBox.TabIndex = 9;
            this.EmailIdBox.TextChanged += new System.EventHandler(this.EmailIdBox_TextChanged);
            this.EmailIdBox.Leave += new System.EventHandler(this.EmailIdBox_Leave);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(37, 484);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 61);
            this.button1.TabIndex = 13;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(200, 484);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 61);
            this.button2.TabIndex = 14;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(342, 483);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 62);
            this.button3.TabIndex = 15;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 440);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(191, 40);
            this.label12.TabIndex = 13;
            this.label12.Text = "Date Received";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(342, 403);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(66, 30);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "No";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.dateTimePicker1, 2);
            this.dateTimePicker1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(200, 443);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(261, 31);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(200, 403);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(74, 30);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Yes";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 230;
            this.errorProvider1.ContainerControl = this;
            // 
            // PhoneNumberBox
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.PhoneNumberBox, 2);
            this.PhoneNumberBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.PhoneNumberBox.Location = new System.Drawing.Point(200, 323);
            this.PhoneNumberBox.MaxLength = 21;
            this.PhoneNumberBox.Name = "PhoneNumberBox";
            this.PhoneNumberBox.Size = new System.Drawing.Size(261, 31);
            this.PhoneNumberBox.TabIndex = 8;
            this.PhoneNumberBox.TextChanged += new System.EventHandler(this.PhoneNumberBox_TextChanged);
            this.PhoneNumberBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneNumberBox_KeyPress);
            this.PhoneNumberBox.Leave += new System.EventHandler(this.PhoneNumberBox_Leave);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 197F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.55805F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.44195F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateTimePicker1, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 12);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.radioButton1, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.EmailIdBox, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.PhoneNumberBox, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.ZipCodeBox, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.StateBox, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.CityBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.FirstNameBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.AddressLine2Box, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.LastNameBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.AddressLine1Box, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.MiddleInitialBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.radioButton2, 2, 10);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(571, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.tableLayoutPanel1.RowCount = 13;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.374658F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.374657F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.374657F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.374657F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.374657F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.374657F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.374657F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.374657F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.374657F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.374657F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.374657F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.374657F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.50411F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(494, 548);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 622);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1464, 31);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.142858F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(109, 26);
            this.toolStripStatusLabel1.Text = "New Data";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Phone Number";
            this.columnHeader2.Width = 241;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1464, 653);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox FirstNameBox;
        private System.Windows.Forms.TextBox LastNameBox;
        private System.Windows.Forms.TextBox MiddleInitialBox;
        private System.Windows.Forms.TextBox AddressLine1Box;
        private System.Windows.Forms.TextBox AddressLine2Box;
        private System.Windows.Forms.TextBox CityBox;
        private System.Windows.Forms.TextBox StateBox;
        private System.Windows.Forms.TextBox ZipCodeBox;
        private System.Windows.Forms.TextBox EmailIdBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox PhoneNumberBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

