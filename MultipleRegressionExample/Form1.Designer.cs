namespace Bobskie_Regression
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.inputx1 = new System.Windows.Forms.TextBox();
            this.inputx2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.regressionEquationOutput = new System.Windows.Forms.Label();
            this.regressionOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show Equation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(554, 115);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 93);
            this.textBox1.TabIndex = 2;
            // 
            // inputx1
            // 
            this.inputx1.Location = new System.Drawing.Point(257, 257);
            this.inputx1.Name = "inputx1";
            this.inputx1.Size = new System.Drawing.Size(100, 22);
            this.inputx1.TabIndex = 3;
            // 
            // inputx2
            // 
            this.inputx2.Location = new System.Drawing.Point(382, 257);
            this.inputx2.Name = "inputx2";
            this.inputx2.Size = new System.Drawing.Size(100, 22);
            this.inputx2.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(19, 326);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Calculate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Input vales for x1 and x2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "x1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "x2";
            // 
            // regressionEquationOutput
            // 
            this.regressionEquationOutput.AutoSize = true;
            this.regressionEquationOutput.Location = new System.Drawing.Point(254, 156);
            this.regressionEquationOutput.Name = "regressionEquationOutput";
            this.regressionEquationOutput.Size = new System.Drawing.Size(44, 16);
            this.regressionEquationOutput.TabIndex = 10;
            this.regressionEquationOutput.Text = "label4";
            // 
            // regressionOutput
            // 
            this.regressionOutput.AutoSize = true;
            this.regressionOutput.Location = new System.Drawing.Point(257, 332);
            this.regressionOutput.Name = "regressionOutput";
            this.regressionOutput.Size = new System.Drawing.Size(44, 16);
            this.regressionOutput.TabIndex = 11;
            this.regressionOutput.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.regressionOutput);
            this.Controls.Add(this.regressionEquationOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.inputx2);
            this.Controls.Add(this.inputx1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox inputx1;
        private System.Windows.Forms.TextBox inputx2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label regressionEquationOutput;
        private System.Windows.Forms.Label regressionOutput;
    }
}

