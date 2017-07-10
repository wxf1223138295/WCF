namespace XF.CForm
{
    partial class DoWithFile
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.FileStreamName = new System.Windows.Forms.Button();
            this.PathClass = new System.Windows.Forms.Button();
            this.FileClass = new System.Windows.Forms.Button();
            this.StreamReadWrite = new System.Windows.Forms.Button();
            this.filestrread = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.test = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(556, 149);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // FileStreamName
            // 
            this.FileStreamName.Location = new System.Drawing.Point(0, 201);
            this.FileStreamName.Name = "FileStreamName";
            this.FileStreamName.Size = new System.Drawing.Size(113, 23);
            this.FileStreamName.TabIndex = 1;
            this.FileStreamName.Text = "FileStreamWrite";
            this.FileStreamName.UseVisualStyleBackColor = true;
            this.FileStreamName.Click += new System.EventHandler(this.FileStreamName_Click);
            // 
            // PathClass
            // 
            this.PathClass.Location = new System.Drawing.Point(119, 200);
            this.PathClass.Name = "PathClass";
            this.PathClass.Size = new System.Drawing.Size(75, 23);
            this.PathClass.TabIndex = 2;
            this.PathClass.Text = "Path类";
            this.PathClass.UseVisualStyleBackColor = true;
            this.PathClass.Click += new System.EventHandler(this.PathClass_Click);
            // 
            // FileClass
            // 
            this.FileClass.Location = new System.Drawing.Point(249, 200);
            this.FileClass.Name = "FileClass";
            this.FileClass.Size = new System.Drawing.Size(75, 23);
            this.FileClass.TabIndex = 3;
            this.FileClass.Text = "Flie";
            this.FileClass.UseVisualStyleBackColor = true;
            this.FileClass.Click += new System.EventHandler(this.FileClass_Click);
            // 
            // StreamReadWrite
            // 
            this.StreamReadWrite.Location = new System.Drawing.Point(362, 200);
            this.StreamReadWrite.Name = "StreamReadWrite";
            this.StreamReadWrite.Size = new System.Drawing.Size(118, 23);
            this.StreamReadWrite.TabIndex = 4;
            this.StreamReadWrite.Text = "StreamRead";
            this.StreamReadWrite.UseVisualStyleBackColor = true;
            this.StreamReadWrite.Click += new System.EventHandler(this.StreamReadWrite_Click);
            // 
            // filestrread
            // 
            this.filestrread.Location = new System.Drawing.Point(0, 230);
            this.filestrread.Name = "filestrread";
            this.filestrread.Size = new System.Drawing.Size(113, 23);
            this.filestrread.TabIndex = 5;
            this.filestrread.Text = "FileStreamRead";
            this.filestrread.UseVisualStyleBackColor = true;
            this.filestrread.Click += new System.EventHandler(this.filestrread_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 156);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(544, 21);
            this.textBox1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(362, 229);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Streamwrite";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(249, 230);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(75, 23);
            this.test.TabIndex = 8;
            this.test.Text = "test";
            this.test.UseVisualStyleBackColor = true;
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(119, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "xml";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DoWithFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.test);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.filestrread);
            this.Controls.Add(this.StreamReadWrite);
            this.Controls.Add(this.FileClass);
            this.Controls.Add(this.PathClass);
            this.Controls.Add(this.FileStreamName);
            this.Controls.Add(this.richTextBox1);
            this.Name = "DoWithFile";
            this.Text = "DoWithFile";
            this.Load += new System.EventHandler(this.DoWithFile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button FileStreamName;
        private System.Windows.Forms.Button PathClass;
        private System.Windows.Forms.Button FileClass;
        private System.Windows.Forms.Button StreamReadWrite;
        private System.Windows.Forms.Button filestrread;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button test;
        private System.Windows.Forms.Button button2;
    }
}