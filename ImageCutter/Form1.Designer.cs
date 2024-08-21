using System.Drawing;
using System.Windows.Forms;

namespace ImageCutter
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            fileLabel = new Label();
            label1 = new Label();
            label2 = new Label();
            intervalInput = new NumericUpDown();
            label3 = new Label();
            button2 = new Button();
            error = new Label();
            linkToFiles = new Button();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)intervalInput).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(34, 34);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(430, 36);
            button1.TabIndex = 0;
            button1.Text = "Select Video";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // fileLabel
            // 
            fileLabel.AutoSize = true;
            fileLabel.Location = new Point(34, 104);
            fileLabel.Margin = new Padding(4, 30, 4, 0);
            fileLabel.Name = "fileLabel";
            fileLabel.Size = new Size(129, 25);
            fileLabel.TabIndex = 1;
            fileLabel.Text = "Selected Video";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(489, 318);
            label1.Margin = new Padding(4, 30, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 159);
            label2.Margin = new Padding(4, 30, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(146, 25);
            label2.TabIndex = 3;
            label2.Text = "Screenshot every";
            // 
            // intervalInput
            // 
            intervalInput.Location = new Point(191, 156);
            intervalInput.Margin = new Padding(4);
            intervalInput.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            intervalInput.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            intervalInput.Name = "intervalInput";
            intervalInput.Size = new Size(188, 31);
            intervalInput.TabIndex = 4;
            intervalInput.Value = new decimal(new int[] { 1, 0, 0, 0 });
            intervalInput.ValueChanged += intervalInput_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(386, 159);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 5;
            label3.Text = "seconds";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.Location = new Point(34, 335);
            button2.Margin = new Padding(4, 4, 4, 24);
            button2.Name = "button2";
            button2.Size = new Size(430, 36);
            button2.TabIndex = 6;
            button2.Text = "Start Snipping";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // error
            // 
            error.AutoSize = true;
            error.ForeColor = Color.Red;
            error.Location = new Point(34, 214);
            error.Margin = new Padding(4, 30, 4, 0);
            error.Name = "error";
            error.Size = new Size(0, 25);
            error.TabIndex = 7;
            // 
            // linkToFiles
            // 
            linkToFiles.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            linkToFiles.Enabled = false;
            linkToFiles.Location = new Point(33, 271);
            linkToFiles.Margin = new Padding(4, 4, 4, 24);
            linkToFiles.Name = "linkToFiles";
            linkToFiles.Size = new Size(430, 36);
            linkToFiles.TabIndex = 8;
            linkToFiles.Text = "View Images";
            linkToFiles.UseVisualStyleBackColor = true;
            linkToFiles.Click += linkToFiles_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Bottom;
            label4.Font = new Font("Segoe UI", 7F);
            label4.Location = new Point(30, 395);
            label4.Name = "label4";
            label4.Size = new Size(98, 19);
            label4.TabIndex = 9;
            label4.Text = "By Skye Renda";
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 7F);
            linkLabel1.Location = new Point(412, 395);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(53, 19);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "GitHub";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 444);
            Controls.Add(linkLabel1);
            Controls.Add(label4);
            Controls.Add(linkToFiles);
            Controls.Add(error);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(intervalInput);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(fileLabel);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximumSize = new Size(520, 500);
            MinimumSize = new Size(520, 500);
            Name = "Form1";
            Padding = new Padding(30);
            Text = "Image Cutter";
            ((System.ComponentModel.ISupportInitialize)intervalInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label fileLabel;
        private Label label1;
        private Label label2;
        private NumericUpDown intervalInput;
        private Label label3;
        private Button button2;
        private Label error;
        private Button linkToFiles;
        private Label label4;
        private LinkLabel linkLabel1;
    }
}
