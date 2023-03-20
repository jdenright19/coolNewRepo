namespace Form
{
    partial class AddDrop
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Drop_btn = new System.Windows.Forms.Button();
            this.Back_Btn = new System.Windows.Forms.Button();
            this.lbl_submit = new System.Windows.Forms.Button();
            this.lbl_currentSchedule = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CourseNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Instructor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumSeats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numTimeBlocks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Days = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(48, 64);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(570, 444);
            this.checkedListBox1.TabIndex = 0;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Available Courses";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Drop_btn
            // 
            this.Drop_btn.Location = new System.Drawing.Point(354, 581);
            this.Drop_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Drop_btn.Name = "Drop_btn";
            this.Drop_btn.Size = new System.Drawing.Size(86, 31);
            this.Drop_btn.TabIndex = 5;
            this.Drop_btn.Text = "Drop";
            this.Drop_btn.UseVisualStyleBackColor = true;
            this.Drop_btn.Click += new System.EventHandler(this.Drop_btn_Click);
            // 
            // Back_Btn
            // 
            this.Back_Btn.Location = new System.Drawing.Point(74, 576);
            this.Back_Btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Back_Btn.Name = "Back_Btn";
            this.Back_Btn.Size = new System.Drawing.Size(86, 31);
            this.Back_Btn.TabIndex = 6;
            this.Back_Btn.Text = "Back";
            this.Back_Btn.UseVisualStyleBackColor = true;
            // 
            // lbl_submit
            // 
            this.lbl_submit.Location = new System.Drawing.Point(446, 583);
            this.lbl_submit.Name = "lbl_submit";
            this.lbl_submit.Size = new System.Drawing.Size(114, 27);
            this.lbl_submit.TabIndex = 11;
            this.lbl_submit.Text = "Submit";
            this.lbl_submit.UseVisualStyleBackColor = true;
            this.lbl_submit.Click += new System.EventHandler(this.lbl_submit_Click);
            // 
            // lbl_currentSchedule
            // 
            this.lbl_currentSchedule.AutoSize = true;
            this.lbl_currentSchedule.Location = new System.Drawing.Point(649, 41);
            this.lbl_currentSchedule.Name = "lbl_currentSchedule";
            this.lbl_currentSchedule.Size = new System.Drawing.Size(121, 20);
            this.lbl_currentSchedule.TabIndex = 10;
            this.lbl_currentSchedule.Text = "Current Schedule";
            this.lbl_currentSchedule.Click += new System.EventHandler(this.lbl_currentSchedule_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.MistyRose;
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.78199F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.21801F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 184F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Course Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-148, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Course Name";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.MistyRose;
            this.tableLayoutPanel2.ColumnCount = 9;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.78199F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.21801F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 184F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Course Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(-148, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1, 15);
            this.label9.TabIndex = 1;
            this.label9.Text = "Course Name";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1906, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(609, 583);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 13;
            this.button1.Text = "Course History";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseNum,
            this.CourseName,
            this.Instructor,
            this.Credit,
            this.NumSeats,
            this.numTimeBlocks,
            this.Days,
            this.timeStart,
            this.TimeEnd,
            this.Select});
            this.dataGridView1.Location = new System.Drawing.Point(665, 65);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1191, 460);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CourseNum
            // 
            this.CourseNum.HeaderText = "Course Number";
            this.CourseNum.MinimumWidth = 6;
            this.CourseNum.Name = "CourseNum";
            this.CourseNum.Width = 125;
            // 
            // CourseName
            // 
            this.CourseName.HeaderText = "Course Name";
            this.CourseName.MinimumWidth = 6;
            this.CourseName.Name = "CourseName";
            this.CourseName.Width = 125;
            // 
            // Instructor
            // 
            this.Instructor.HeaderText = "Instructor";
            this.Instructor.MinimumWidth = 6;
            this.Instructor.Name = "Instructor";
            this.Instructor.Width = 125;
            // 
            // Credit
            // 
            this.Credit.HeaderText = "Credit";
            this.Credit.MinimumWidth = 6;
            this.Credit.Name = "Credit";
            this.Credit.Width = 125;
            // 
            // NumSeats
            // 
            this.NumSeats.HeaderText = "Number of Seats";
            this.NumSeats.MinimumWidth = 6;
            this.NumSeats.Name = "NumSeats";
            this.NumSeats.Width = 125;
            // 
            // numTimeBlocks
            // 
            this.numTimeBlocks.HeaderText = "Number of Time Blocks";
            this.numTimeBlocks.MinimumWidth = 6;
            this.numTimeBlocks.Name = "numTimeBlocks";
            this.numTimeBlocks.Width = 125;
            // 
            // Days
            // 
            this.Days.HeaderText = "Days";
            this.Days.MinimumWidth = 6;
            this.Days.Name = "Days";
            this.Days.Width = 125;
            // 
            // timeStart
            // 
            this.timeStart.HeaderText = "Time Start";
            this.timeStart.MinimumWidth = 6;
            this.timeStart.Name = "timeStart";
            this.timeStart.Width = 125;
            // 
            // TimeEnd
            // 
            this.TimeEnd.HeaderText = "Time End";
            this.TimeEnd.MinimumWidth = 6;
            this.TimeEnd.Name = "TimeEnd";
            this.TimeEnd.Width = 125;
            // 
            // Select
            // 
            this.Select.HeaderText = "Select";
            this.Select.MinimumWidth = 6;
            this.Select.Name = "Select";
            this.Select.Width = 125;
            // 
            // AddDrop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1906, 1055);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_submit);
            this.Controls.Add(this.lbl_currentSchedule);
            this.Controls.Add(this.Back_Btn);
            this.Controls.Add(this.Drop_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddDrop";
            this.Text = "AddDrop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckedListBox checkedListBox1;
        private Label label1;
        private Button Drop_btn;
        private Button Back_Btn;
        private Button lbl_submit;
        private Label lbl_currentSchedule;
        private Label lbl_time;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label6;
        private Label label7;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label8;
        private Label label9;
        private MenuStrip menuStrip1;
        private EventHandler label10_Click;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn CourseNum;
        private DataGridViewTextBoxColumn CourseName;
        private DataGridViewTextBoxColumn Instructor;
        private DataGridViewTextBoxColumn Credit;
        private DataGridViewTextBoxColumn NumSeats;
        private DataGridViewTextBoxColumn numTimeBlocks;
        private DataGridViewTextBoxColumn Days;
        private DataGridViewTextBoxColumn timeStart;
        private DataGridViewTextBoxColumn TimeEnd;
        private DataGridViewCheckBoxColumn Select;
    }
}