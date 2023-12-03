
using System.Drawing;
using System.Windows.Forms;

namespace kal
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
            tableLayoutPanel1 = new TableLayoutPanel();
            displayTextBox = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(displayTextBox, 0, 0);
            tableLayoutPanel1.Controls.Add(button1, 0, 1);
            tableLayoutPanel1.Controls.Add(button2, 1, 1);
            tableLayoutPanel1.Controls.Add(button3, 2, 1);
            tableLayoutPanel1.Controls.Add(button4, 1, 2);
            tableLayoutPanel1.Controls.Add(button5, 0, 2);
            tableLayoutPanel1.Controls.Add(button6, 2, 2);
            tableLayoutPanel1.Controls.Add(button7, 2, 3);
            tableLayoutPanel1.Controls.Add(button8, 1, 3);
            tableLayoutPanel1.Controls.Add(button9, 0, 3);
            tableLayoutPanel1.Controls.Add(button10, 1, 4);
            tableLayoutPanel1.Controls.Add(button11, 3, 1);
            tableLayoutPanel1.Controls.Add(button12, 2, 4);
            tableLayoutPanel1.Controls.Add(button13, 0, 4);
            tableLayoutPanel1.Controls.Add(button14, 3, 2);
            tableLayoutPanel1.Controls.Add(button15, 3, 3);
            tableLayoutPanel1.Controls.Add(button16, 3, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(972, 621);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // displayTextBox
            // 
            tableLayoutPanel1.SetColumnSpan(displayTextBox, 4);
            displayTextBox.Dock = DockStyle.Fill;
            displayTextBox.Font = new Font("Consolas", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            displayTextBox.Location = new Point(3, 3);
            displayTextBox.Name = "displayTextBox";
            displayTextBox.Size = new Size(966, 118);
            displayTextBox.TabIndex = 0;
            displayTextBox.Text = "";
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(3, 127);
            button1.Name = "button1";
            button1.Size = new Size(237, 118);
            button1.TabIndex = 1;
            button1.Text = "7";
            button1.UseVisualStyleBackColor = true;
            button1.Click += DigitPressed;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(246, 127);
            button2.Name = "button2";
            button2.Size = new Size(237, 118);
            button2.TabIndex = 2;
            button2.Text = "8";
            button2.UseVisualStyleBackColor = true;
            button2.Click += DigitPressed;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Fill;
            button3.Location = new Point(489, 127);
            button3.Name = "button3";
            button3.Size = new Size(237, 118);
            button3.TabIndex = 3;
            button3.Text = "9";
            button3.UseVisualStyleBackColor = true;
            button3.Click += DigitPressed;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Fill;
            button4.Location = new Point(246, 251);
            button4.Name = "button4";
            button4.Size = new Size(237, 118);
            button4.TabIndex = 4;
            button4.Text = "5";
            button4.UseVisualStyleBackColor = true;
            button4.Click += DigitPressed;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Fill;
            button5.Location = new Point(3, 251);
            button5.Name = "button5";
            button5.Size = new Size(237, 118);
            button5.TabIndex = 5;
            button5.Text = "4";
            button5.UseVisualStyleBackColor = true;
            button5.Click += DigitPressed;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Fill;
            button6.Location = new Point(489, 251);
            button6.Name = "button6";
            button6.Size = new Size(237, 118);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += DigitPressed;
            // 
            // button7
            // 
            button7.Dock = DockStyle.Fill;
            button7.Location = new Point(489, 375);
            button7.Name = "button7";
            button7.Size = new Size(237, 118);
            button7.TabIndex = 7;
            button7.Text = "3";
            button7.UseVisualStyleBackColor = true;
            button7.Click += DigitPressed;
            // 
            // button8
            // 
            button8.Dock = DockStyle.Fill;
            button8.Location = new Point(246, 375);
            button8.Name = "button8";
            button8.Size = new Size(237, 118);
            button8.TabIndex = 8;
            button8.Text = "2";
            button8.UseVisualStyleBackColor = true;
            button8.Click += DigitPressed;
            // 
            // button9
            // 
            button9.Dock = DockStyle.Fill;
            button9.Location = new Point(3, 375);
            button9.Name = "button9";
            button9.Size = new Size(237, 118);
            button9.TabIndex = 9;
            button9.Text = "1";
            button9.UseVisualStyleBackColor = true;
            button9.Click += DigitPressed;
            // 
            // button10
            // 
            button10.Dock = DockStyle.Fill;
            button10.Location = new Point(246, 499);
            button10.Name = "button10";
            button10.Size = new Size(237, 119);
            button10.TabIndex = 10;
            button10.Text = "0";
            button10.UseVisualStyleBackColor = true;
            button10.Click += DigitPressed;
            // 
            // button11
            // 
            button11.Dock = DockStyle.Fill;
            button11.Location = new Point(732, 127);
            button11.Name = "button11";
            button11.Size = new Size(237, 118);
            button11.TabIndex = 11;
            button11.Text = "+";
            button11.UseVisualStyleBackColor = true;
            button11.Click += OperationPressed;
            // 
            // button12
            // 
            button12.Dock = DockStyle.Fill;
            button12.Location = new Point(489, 499);
            button12.Name = "button12";
            button12.Size = new Size(237, 119);
            button12.TabIndex = 12;
            button12.Text = "=";
            button12.UseVisualStyleBackColor = true;
            button12.Click += OperationPressed;
            // 
            // button13
            // 
            button13.Dock = DockStyle.Fill;
            button13.Location = new Point(3, 499);
            button13.Name = "button13";
            button13.Size = new Size(237, 119);
            button13.TabIndex = 13;
            button13.Text = "C";
            button13.UseVisualStyleBackColor = true;
            button13.Click += ClearPressed;
            // 
            // button14
            // 
            button14.Dock = DockStyle.Fill;
            button14.Location = new Point(732, 251);
            button14.Name = "button14";
            button14.Size = new Size(237, 118);
            button14.TabIndex = 14;
            button14.Text = "-";
            button14.UseVisualStyleBackColor = true;
            button14.Click += OperationPressed;
            // 
            // button15
            // 
            button15.Dock = DockStyle.Fill;
            button15.Location = new Point(732, 375);
            button15.Name = "button15";
            button15.Size = new Size(237, 118);
            button15.TabIndex = 15;
            button15.Text = "*";
            button15.UseVisualStyleBackColor = true;
            button15.Click += OperationPressed;
            // 
            // button16
            // 
            button16.Dock = DockStyle.Fill;
            button16.Location = new Point(732, 499);
            button16.Name = "button16";
            button16.Size = new Size(237, 119);
            button16.TabIndex = 16;
            button16.Text = "/";
            button16.UseVisualStyleBackColor = true;
            button16.Click += OperationPressed;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 621);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private RichTextBox displayTextBox;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
    }
}