namespace Form_task
{
    partial class FormsName
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormsName));
            studentID = new Label();
            studentName = new Label();
            textBoxID = new TextBox();
            textBoxName = new TextBox();
            button1 = new Button();
            button2 = new Button();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // studentID
            // 
            studentID.AutoSize = true;
            studentID.Location = new Point(839, 126);
            studentID.Name = "studentID";
            studentID.Size = new Size(208, 53);
            studentID.TabIndex = 1;
            studentID.Text = "Student ID";
            // 
            // studentName
            // 
            studentName.AutoSize = true;
            studentName.Location = new Point(839, 270);
            studentName.Name = "studentName";
            studentName.Size = new Size(275, 53);
            studentName.TabIndex = 2;
            studentName.Text = "Student Name";
            // 
            // textBoxID
            // 
            textBoxID.Font = new Font("Calibri", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxID.Location = new Point(839, 182);
            textBoxID.Name = "textBoxID";
            textBoxID.PlaceholderText = "Enter Student ID";
            textBoxID.Size = new Size(377, 53);
            textBoxID.TabIndex = 3;
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Calibri", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxName.Location = new Point(839, 326);
            textBoxName.Name = "textBoxName";
            textBoxName.PlaceholderText = "Enter Student Name";
            textBoxName.Size = new Size(377, 53);
            textBoxName.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(839, 450);
            button1.Name = "button1";
            button1.Size = new Size(150, 64);
            button1.TabIndex = 5;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1066, 450);
            button2.Name = "button2";
            button2.Size = new Size(150, 64);
            button2.TabIndex = 6;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.Location = new Point(858, 581);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(307, 39);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Contact Administrator";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(91, 96);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(635, 555);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // FormsName
            // 
            AutoScaleDimensions = new SizeF(22F, 53F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1287, 745);
            Controls.Add(pictureBox1);
            Controls.Add(linkLabel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBoxName);
            Controls.Add(textBoxID);
            Controls.Add(studentName);
            Controls.Add(studentID);
            Font = new Font("Calibri", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "FormsName";
            Text = "asdasd";
            Load += FormsName_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label studentID;
        private Label studentName;
        private TextBox textBoxID;
        private TextBox textBoxName;
        private Button button1;
        private Button button2;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
    }
}
