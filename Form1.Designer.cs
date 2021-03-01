namespace kQuickTrivia
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
            this.questionLbl = new System.Windows.Forms.Label();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.createdListBox = new System.Windows.Forms.ListBox();
            this.createBtn = new System.Windows.Forms.Button();
            this.firstAnsListBox = new System.Windows.Forms.TextBox();
            this.firstAnsLbl = new System.Windows.Forms.Label();
            this.secondAnsLbl = new System.Windows.Forms.Label();
            this.secondAnsListBox = new System.Windows.Forms.TextBox();
            this.thirdAnsLbl = new System.Windows.Forms.Label();
            this.thirdAnsListBox = new System.Windows.Forms.TextBox();
            this.fouthAnsLbl = new System.Windows.Forms.Label();
            this.fourthAnsListBox = new System.Windows.Forms.TextBox();
            this.trollLbl = new System.Windows.Forms.Label();
            this.createEntryBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // questionLbl
            // 
            this.questionLbl.AutoSize = true;
            this.questionLbl.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLbl.Location = new System.Drawing.Point(21, 24);
            this.questionLbl.Name = "questionLbl";
            this.questionLbl.Size = new System.Drawing.Size(85, 21);
            this.questionLbl.TabIndex = 0;
            this.questionLbl.Text = "Question:";
            // 
            // questionTextBox
            // 
            this.questionTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.questionTextBox.Location = new System.Drawing.Point(25, 57);
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.Size = new System.Drawing.Size(365, 20);
            this.questionTextBox.TabIndex = 1;
            // 
            // createdListBox
            // 
            this.createdListBox.FormattingEnabled = true;
            this.createdListBox.Location = new System.Drawing.Point(25, 206);
            this.createdListBox.Name = "createdListBox";
            this.createdListBox.Size = new System.Drawing.Size(365, 95);
            this.createdListBox.TabIndex = 2;
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(149, 322);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(122, 57);
            this.createBtn.TabIndex = 3;
            this.createBtn.Text = "Write to File";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // firstAnsListBox
            // 
            this.firstAnsListBox.Location = new System.Drawing.Point(25, 126);
            this.firstAnsListBox.Name = "firstAnsListBox";
            this.firstAnsListBox.Size = new System.Drawing.Size(81, 20);
            this.firstAnsListBox.TabIndex = 4;
            // 
            // firstAnsLbl
            // 
            this.firstAnsLbl.AutoSize = true;
            this.firstAnsLbl.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstAnsLbl.Location = new System.Drawing.Point(21, 102);
            this.firstAnsLbl.Name = "firstAnsLbl";
            this.firstAnsLbl.Size = new System.Drawing.Size(87, 21);
            this.firstAnsLbl.TabIndex = 5;
            this.firstAnsLbl.Text = "Answer 1:";
            // 
            // secondAnsLbl
            // 
            this.secondAnsLbl.AutoSize = true;
            this.secondAnsLbl.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondAnsLbl.Location = new System.Drawing.Point(114, 102);
            this.secondAnsLbl.Name = "secondAnsLbl";
            this.secondAnsLbl.Size = new System.Drawing.Size(87, 21);
            this.secondAnsLbl.TabIndex = 7;
            this.secondAnsLbl.Text = "Answer 2:";
            // 
            // secondAnsListBox
            // 
            this.secondAnsListBox.Location = new System.Drawing.Point(118, 126);
            this.secondAnsListBox.Name = "secondAnsListBox";
            this.secondAnsListBox.Size = new System.Drawing.Size(81, 20);
            this.secondAnsListBox.TabIndex = 6;
            // 
            // thirdAnsLbl
            // 
            this.thirdAnsLbl.AutoSize = true;
            this.thirdAnsLbl.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdAnsLbl.Location = new System.Drawing.Point(207, 102);
            this.thirdAnsLbl.Name = "thirdAnsLbl";
            this.thirdAnsLbl.Size = new System.Drawing.Size(87, 21);
            this.thirdAnsLbl.TabIndex = 9;
            this.thirdAnsLbl.Text = "Answer 3:";
            // 
            // thirdAnsListBox
            // 
            this.thirdAnsListBox.Location = new System.Drawing.Point(211, 126);
            this.thirdAnsListBox.Name = "thirdAnsListBox";
            this.thirdAnsListBox.Size = new System.Drawing.Size(81, 20);
            this.thirdAnsListBox.TabIndex = 8;
            // 
            // fouthAnsLbl
            // 
            this.fouthAnsLbl.AutoSize = true;
            this.fouthAnsLbl.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fouthAnsLbl.Location = new System.Drawing.Point(300, 102);
            this.fouthAnsLbl.Name = "fouthAnsLbl";
            this.fouthAnsLbl.Size = new System.Drawing.Size(87, 21);
            this.fouthAnsLbl.TabIndex = 11;
            this.fouthAnsLbl.Text = "Answer 4:";
            // 
            // fourthAnsListBox
            // 
            this.fourthAnsListBox.Location = new System.Drawing.Point(304, 126);
            this.fourthAnsListBox.Name = "fourthAnsListBox";
            this.fourthAnsListBox.Size = new System.Drawing.Size(81, 20);
            this.fourthAnsListBox.TabIndex = 10;
            // 
            // trollLbl
            // 
            this.trollLbl.AutoSize = true;
            this.trollLbl.Location = new System.Drawing.Point(321, 9);
            this.trollLbl.Name = "trollLbl";
            this.trollLbl.Size = new System.Drawing.Size(96, 13);
            this.trollLbl.TabIndex = 12;
            this.trollLbl.Text = "VB2010 design ftw";
            // 
            // createEntryBtn
            // 
            this.createEntryBtn.Location = new System.Drawing.Point(149, 152);
            this.createEntryBtn.Name = "createEntryBtn";
            this.createEntryBtn.Size = new System.Drawing.Size(122, 32);
            this.createEntryBtn.TabIndex = 13;
            this.createEntryBtn.Text = "Add Entry";
            this.createEntryBtn.UseVisualStyleBackColor = true;
            this.createEntryBtn.Click += new System.EventHandler(this.createEntryBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(420, 391);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createEntryBtn);
            this.Controls.Add(this.trollLbl);
            this.Controls.Add(this.fouthAnsLbl);
            this.Controls.Add(this.fourthAnsListBox);
            this.Controls.Add(this.thirdAnsLbl);
            this.Controls.Add(this.thirdAnsListBox);
            this.Controls.Add(this.secondAnsLbl);
            this.Controls.Add(this.secondAnsListBox);
            this.Controls.Add(this.firstAnsLbl);
            this.Controls.Add(this.firstAnsListBox);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.createdListBox);
            this.Controls.Add(this.questionTextBox);
            this.Controls.Add(this.questionLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "kQuickTrivia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionLbl;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.ListBox createdListBox;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.TextBox firstAnsListBox;
        private System.Windows.Forms.Label firstAnsLbl;
        private System.Windows.Forms.Label secondAnsLbl;
        private System.Windows.Forms.TextBox secondAnsListBox;
        private System.Windows.Forms.Label thirdAnsLbl;
        private System.Windows.Forms.TextBox thirdAnsListBox;
        private System.Windows.Forms.Label fouthAnsLbl;
        private System.Windows.Forms.TextBox fourthAnsListBox;
        private System.Windows.Forms.Label trollLbl;
        private System.Windows.Forms.Button createEntryBtn;
        private System.Windows.Forms.Label label1;
    }
}

