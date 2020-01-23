namespace Lab3___Kids_Calculator
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DivisionButton = new System.Windows.Forms.RadioButton();
            this.MultiplicationButton = new System.Windows.Forms.RadioButton();
            this.SubtractionButton = new System.Windows.Forms.RadioButton();
            this.AdditionButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.eualLabel = new System.Windows.Forms.Label();
            this.operatorLabel = new System.Windows.Forms.Label();
            this.ValueBox3 = new System.Windows.Forms.TextBox();
            this.ValueBox2 = new System.Windows.Forms.TextBox();
            this.ValueBox1 = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.CheckButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.DivisionButton);
            this.groupBox1.Controls.Add(this.MultiplicationButton);
            this.groupBox1.Controls.Add(this.SubtractionButton);
            this.groupBox1.Controls.Add(this.AdditionButton);
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(776, 83);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operator Box";
            // 
            // DivisionButton
            // 
            this.DivisionButton.AutoSize = true;
            this.DivisionButton.Location = new System.Drawing.Point(612, 37);
            this.DivisionButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DivisionButton.Name = "DivisionButton";
            this.DivisionButton.Size = new System.Drawing.Size(55, 17);
            this.DivisionButton.TabIndex = 3;
            this.DivisionButton.TabStop = true;
            this.DivisionButton.Text = "Divide";
            this.DivisionButton.UseVisualStyleBackColor = true;
            this.DivisionButton.CheckedChanged += new System.EventHandler(this.DivisionButton_CheckedChanged);
            // 
            // MultiplicationButton
            // 
            this.MultiplicationButton.AutoSize = true;
            this.MultiplicationButton.Location = new System.Drawing.Point(444, 37);
            this.MultiplicationButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MultiplicationButton.Name = "MultiplicationButton";
            this.MultiplicationButton.Size = new System.Drawing.Size(60, 17);
            this.MultiplicationButton.TabIndex = 2;
            this.MultiplicationButton.TabStop = true;
            this.MultiplicationButton.Text = "Multiply";
            this.MultiplicationButton.UseVisualStyleBackColor = true;
            this.MultiplicationButton.CheckedChanged += new System.EventHandler(this.MultiplicationButton_CheckedChanged);
            // 
            // SubtractionButton
            // 
            this.SubtractionButton.AutoSize = true;
            this.SubtractionButton.Location = new System.Drawing.Point(278, 37);
            this.SubtractionButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SubtractionButton.Name = "SubtractionButton";
            this.SubtractionButton.Size = new System.Drawing.Size(65, 17);
            this.SubtractionButton.TabIndex = 1;
            this.SubtractionButton.TabStop = true;
            this.SubtractionButton.Text = "Subtract";
            this.SubtractionButton.UseVisualStyleBackColor = true;
            this.SubtractionButton.CheckedChanged += new System.EventHandler(this.SubtractionButton_CheckedChanged);
            // 
            // AdditionButton
            // 
            this.AdditionButton.AutoSize = true;
            this.AdditionButton.Location = new System.Drawing.Point(116, 37);
            this.AdditionButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AdditionButton.Name = "AdditionButton";
            this.AdditionButton.Size = new System.Drawing.Size(44, 17);
            this.AdditionButton.TabIndex = 0;
            this.AdditionButton.TabStop = true;
            this.AdditionButton.Text = "Add";
            this.AdditionButton.UseVisualStyleBackColor = true;
            this.AdditionButton.CheckedChanged += new System.EventHandler(this.AdditionButton_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.eualLabel);
            this.groupBox2.Controls.Add(this.operatorLabel);
            this.groupBox2.Controls.Add(this.ValueBox3);
            this.groupBox2.Controls.Add(this.ValueBox2);
            this.groupBox2.Controls.Add(this.ValueBox1);
            this.groupBox2.Location = new System.Drawing.Point(10, 121);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(776, 83);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input Box";
            // 
            // eualLabel
            // 
            this.eualLabel.AutoSize = true;
            this.eualLabel.Location = new System.Drawing.Point(485, 44);
            this.eualLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.eualLabel.Name = "eualLabel";
            this.eualLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.eualLabel.Size = new System.Drawing.Size(13, 13);
            this.eualLabel.TabIndex = 4;
            this.eualLabel.Text = "=";
            // 
            // operatorLabel
            // 
            this.operatorLabel.AutoSize = true;
            this.operatorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operatorLabel.Location = new System.Drawing.Point(304, 44);
            this.operatorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.operatorLabel.Name = "operatorLabel";
            this.operatorLabel.Size = new System.Drawing.Size(15, 15);
            this.operatorLabel.TabIndex = 3;
            this.operatorLabel.Text = "+";
            this.operatorLabel.Click += new System.EventHandler(this.operatorLabel_Click);
            // 
            // ValueBox3
            // 
            this.ValueBox3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ValueBox3.Location = new System.Drawing.Point(528, 41);
            this.ValueBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ValueBox3.Name = "ValueBox3";
            this.ValueBox3.Size = new System.Drawing.Size(104, 20);
            this.ValueBox3.TabIndex = 2;
            this.ValueBox3.TextChanged += new System.EventHandler(this.ValueBox3_TextChanged);
            // 
            // ValueBox2
            // 
            this.ValueBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ValueBox2.Location = new System.Drawing.Point(349, 41);
            this.ValueBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ValueBox2.Name = "ValueBox2";
            this.ValueBox2.Size = new System.Drawing.Size(104, 20);
            this.ValueBox2.TabIndex = 1;
            this.ValueBox2.TextChanged += new System.EventHandler(this.ValueBox2_TextChanged);
            // 
            // ValueBox1
            // 
            this.ValueBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ValueBox1.Location = new System.Drawing.Point(168, 41);
            this.ValueBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ValueBox1.Name = "ValueBox1";
            this.ValueBox1.Size = new System.Drawing.Size(104, 20);
            this.ValueBox1.TabIndex = 0;
            this.ValueBox1.TextChanged += new System.EventHandler(this.ValueBox1_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Controls.Add(this.ResultLabel);
            this.groupBox4.Location = new System.Drawing.Point(10, 340);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(776, 83);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Result";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.Location = new System.Drawing.Point(351, 37);
            this.ResultLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(25, 24);
            this.ResultLabel.TabIndex = 0;
            this.ResultLabel.Text = "...";
            this.ResultLabel.Click += new System.EventHandler(this.ResultLabel_Click);
            // 
            // NextButton
            // 
            this.NextButton.BackColor = System.Drawing.Color.HotPink;
            this.NextButton.Location = new System.Drawing.Point(168, 35);
            this.NextButton.Margin = new System.Windows.Forms.Padding(2);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(92, 22);
            this.NextButton.TabIndex = 0;
            this.NextButton.Text = "Next Question";
            this.NextButton.UseVisualStyleBackColor = false;
            this.NextButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CheckButton
            // 
            this.CheckButton.BackColor = System.Drawing.Color.Fuchsia;
            this.CheckButton.Location = new System.Drawing.Point(366, 35);
            this.CheckButton.Margin = new System.Windows.Forms.Padding(2);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(73, 24);
            this.CheckButton.TabIndex = 1;
            this.CheckButton.Text = "Am I Right?";
            this.CheckButton.UseVisualStyleBackColor = false;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.CloseButton.Location = new System.Drawing.Point(543, 35);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(2);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(68, 22);
            this.CloseButton.TabIndex = 2;
            this.CloseButton.Text = "Quit";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.CloseButton);
            this.groupBox3.Controls.Add(this.CheckButton);
            this.groupBox3.Controls.Add(this.NextButton);
            this.groupBox3.Location = new System.Drawing.Point(10, 228);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(776, 83);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Button Box";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(811, 442);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton DivisionButton;
        private System.Windows.Forms.RadioButton MultiplicationButton;
        private System.Windows.Forms.RadioButton SubtractionButton;
        private System.Windows.Forms.RadioButton AdditionButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ValueBox3;
        private System.Windows.Forms.TextBox ValueBox2;
        private System.Windows.Forms.TextBox ValueBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label eualLabel;
        private System.Windows.Forms.Label operatorLabel;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button CheckButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

