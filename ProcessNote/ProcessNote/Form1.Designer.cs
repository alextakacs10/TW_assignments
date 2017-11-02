namespace ProcessNote
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.StartedAtBox = new System.Windows.Forms.TextBox();
            this.RunningTimeBox = new System.Windows.Forms.TextBox();
            this.MemoryBox = new System.Windows.Forms.TextBox();
            this.StartedAtLabel = new System.Windows.Forms.Label();
            this.RunningTimeLabel = new System.Windows.Forms.Label();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.CPULabel = new System.Windows.Forms.Label();
            this.CPUBox = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.IDCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.alwaysOnTop = new System.Windows.Forms.CheckBox();
            this.ThreadButton = new System.Windows.Forms.Button();
            this.commentBox = new System.Windows.Forms.TextBox();
            this.submitComment = new System.Windows.Forms.Button();
            this.feedBack = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.listView1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 50);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.86813F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.13187F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(504, 364);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 184F));
            this.tableLayoutPanel2.Controls.Add(this.StartedAtBox, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.RunningTimeBox, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.MemoryBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.StartedAtLabel, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.RunningTimeLabel, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.MemoryLabel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.CPULabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.CPUBox, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 301);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(498, 40);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // StartedAtBox
            // 
            this.StartedAtBox.Location = new System.Drawing.Point(317, 18);
            this.StartedAtBox.Name = "StartedAtBox";
            this.StartedAtBox.ReadOnly = true;
            this.StartedAtBox.Size = new System.Drawing.Size(178, 20);
            this.StartedAtBox.TabIndex = 7;
            // 
            // RunningTimeBox
            // 
            this.RunningTimeBox.Location = new System.Drawing.Point(181, 18);
            this.RunningTimeBox.Name = "RunningTimeBox";
            this.RunningTimeBox.ReadOnly = true;
            this.RunningTimeBox.Size = new System.Drawing.Size(130, 20);
            this.RunningTimeBox.TabIndex = 6;
            // 
            // MemoryBox
            // 
            this.MemoryBox.Location = new System.Drawing.Point(95, 18);
            this.MemoryBox.Name = "MemoryBox";
            this.MemoryBox.ReadOnly = true;
            this.MemoryBox.Size = new System.Drawing.Size(80, 20);
            this.MemoryBox.TabIndex = 5;
            // 
            // StartedAtLabel
            // 
            this.StartedAtLabel.AutoSize = true;
            this.StartedAtLabel.Location = new System.Drawing.Point(317, 0);
            this.StartedAtLabel.Name = "StartedAtLabel";
            this.StartedAtLabel.Size = new System.Drawing.Size(53, 13);
            this.StartedAtLabel.TabIndex = 3;
            this.StartedAtLabel.Text = "Started at";
            // 
            // RunningTimeLabel
            // 
            this.RunningTimeLabel.AutoSize = true;
            this.RunningTimeLabel.Location = new System.Drawing.Point(181, 0);
            this.RunningTimeLabel.Name = "RunningTimeLabel";
            this.RunningTimeLabel.Size = new System.Drawing.Size(69, 13);
            this.RunningTimeLabel.TabIndex = 2;
            this.RunningTimeLabel.Text = "Running time";
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.AutoSize = true;
            this.MemoryLabel.Location = new System.Drawing.Point(95, 0);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(44, 13);
            this.MemoryLabel.TabIndex = 1;
            this.MemoryLabel.Text = "Memory";
            // 
            // CPULabel
            // 
            this.CPULabel.AutoSize = true;
            this.CPULabel.Location = new System.Drawing.Point(3, 0);
            this.CPULabel.Name = "CPULabel";
            this.CPULabel.Size = new System.Drawing.Size(29, 13);
            this.CPULabel.TabIndex = 0;
            this.CPULabel.Text = "CPU";
            // 
            // CPUBox
            // 
            this.CPUBox.Location = new System.Drawing.Point(3, 18);
            this.CPUBox.Name = "CPUBox";
            this.CPUBox.ReadOnly = true;
            this.CPUBox.Size = new System.Drawing.Size(86, 20);
            this.CPUBox.TabIndex = 4;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDCol,
            this.NameCol});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(498, 292);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // IDCol
            // 
            this.IDCol.Text = "ID";
            this.IDCol.Width = 79;
            // 
            // NameCol
            // 
            this.NameCol.Text = "Process Name";
            this.NameCol.Width = 400;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load Processes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(365, 474);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // alwaysOnTop
            // 
            this.alwaysOnTop.AutoSize = true;
            this.alwaysOnTop.Location = new System.Drawing.Point(424, 17);
            this.alwaysOnTop.Name = "alwaysOnTop";
            this.alwaysOnTop.Size = new System.Drawing.Size(92, 17);
            this.alwaysOnTop.TabIndex = 3;
            this.alwaysOnTop.Text = "Always on top";
            this.alwaysOnTop.UseVisualStyleBackColor = true;
            this.alwaysOnTop.CheckStateChanged += new System.EventHandler(this.alwaysOnTop_CheckStateChanged);
            // 
            // ThreadButton
            // 
            this.ThreadButton.Location = new System.Drawing.Point(148, 13);
            this.ThreadButton.Name = "ThreadButton";
            this.ThreadButton.Size = new System.Drawing.Size(237, 23);
            this.ThreadButton.TabIndex = 4;
            this.ThreadButton.Text = "Show Threads";
            this.ThreadButton.UseVisualStyleBackColor = true;
            // 
            // commentBox
            // 
            this.commentBox.Enabled = false;
            this.commentBox.Location = new System.Drawing.Point(18, 445);
            this.commentBox.Multiline = true;
            this.commentBox.Name = "commentBox";
            this.commentBox.Size = new System.Drawing.Size(247, 52);
            this.commentBox.TabIndex = 5;
            this.commentBox.TextChanged += new System.EventHandler(this.commentBox_TextChanged);
            // 
            // submitComment
            // 
            this.submitComment.Enabled = false;
            this.submitComment.Location = new System.Drawing.Point(271, 445);
            this.submitComment.Name = "submitComment";
            this.submitComment.Size = new System.Drawing.Size(75, 52);
            this.submitComment.TabIndex = 6;
            this.submitComment.Text = "Submit";
            this.submitComment.UseVisualStyleBackColor = true;
            this.submitComment.Click += new System.EventHandler(this.submitComment_Click);
            // 
            // feedBack
            // 
            this.feedBack.AutoSize = true;
            this.feedBack.Location = new System.Drawing.Point(18, 426);
            this.feedBack.Name = "feedBack";
            this.feedBack.Size = new System.Drawing.Size(0, 13);
            this.feedBack.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 509);
            this.Controls.Add(this.feedBack);
            this.Controls.Add(this.submitComment);
            this.Controls.Add(this.commentBox);
            this.Controls.Add(this.ThreadButton);
            this.Controls.Add(this.alwaysOnTop);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.Label CPULabel;
        private System.Windows.Forms.Label StartedAtLabel;
        private System.Windows.Forms.Label RunningTimeLabel;
        private System.Windows.Forms.TextBox CPUBox;
        private System.Windows.Forms.TextBox StartedAtBox;
        private System.Windows.Forms.TextBox RunningTimeBox;
        private System.Windows.Forms.TextBox MemoryBox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader IDCol;
        private System.Windows.Forms.ColumnHeader NameCol;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox alwaysOnTop;
        private System.Windows.Forms.Button ThreadButton;
        private System.Windows.Forms.TextBox commentBox;
        private System.Windows.Forms.Button submitComment;
        private System.Windows.Forms.Label feedBack;
    }
}

