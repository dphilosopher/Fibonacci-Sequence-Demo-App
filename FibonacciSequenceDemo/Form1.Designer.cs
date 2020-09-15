namespace FibonacciSequenceDemo
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
            this.maxNoTextField = new System.Windows.Forms.TextBox();
            this.randomTextField = new System.Windows.Forms.TextBox();
            this.addRandomBtn = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maxResultLbl = new System.Windows.Forms.Label();
            this.validSequenceLbl = new System.Windows.Forms.Label();
            this.invalidSequenceLbl = new System.Windows.Forms.Label();
            this.maxNumRsltLbl = new System.Windows.Forms.Label();
            this.validSeqRsltLbl = new System.Windows.Forms.Label();
            this.invalidSeqRsltLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // maxNoTextField
            // 
            this.maxNoTextField.Location = new System.Drawing.Point(118, 43);
            this.maxNoTextField.Name = "maxNoTextField";
            this.maxNoTextField.Size = new System.Drawing.Size(257, 22);
            this.maxNoTextField.TabIndex = 0;
            // 
            // randomTextField
            // 
            this.randomTextField.Location = new System.Drawing.Point(395, 43);
            this.randomTextField.Name = "randomTextField";
            this.randomTextField.Size = new System.Drawing.Size(253, 22);
            this.randomTextField.TabIndex = 1;
            // 
            // addRandomBtn
            // 
            this.addRandomBtn.Location = new System.Drawing.Point(117, 102);
            this.addRandomBtn.Name = "addRandomBtn";
            this.addRandomBtn.Size = new System.Drawing.Size(530, 41);
            this.addRandomBtn.TabIndex = 2;
            this.addRandomBtn.Text = "Add Random";
            this.addRandomBtn.UseVisualStyleBackColor = true;
            this.addRandomBtn.Click += new System.EventHandler(this.addRandomBtn_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(115, 180);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(533, 40);
            this.submitBtn.TabIndex = 3;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Max Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter Random Sequence";
            // 
            // maxResultLbl
            // 
            this.maxResultLbl.AutoSize = true;
            this.maxResultLbl.Location = new System.Drawing.Point(122, 293);
            this.maxResultLbl.Name = "maxResultLbl";
            this.maxResultLbl.Size = new System.Drawing.Size(95, 17);
            this.maxResultLbl.TabIndex = 6;
            this.maxResultLbl.Text = "Max Number: ";
            // 
            // validSequenceLbl
            // 
            this.validSequenceLbl.AutoSize = true;
            this.validSequenceLbl.Location = new System.Drawing.Point(121, 340);
            this.validSequenceLbl.Name = "validSequenceLbl";
            this.validSequenceLbl.Size = new System.Drawing.Size(176, 17);
            this.validSequenceLbl.TabIndex = 7;
            this.validSequenceLbl.Text = "Valid Sequences Entered: ";
            // 
            // invalidSequenceLbl
            // 
            this.invalidSequenceLbl.AutoSize = true;
            this.invalidSequenceLbl.Location = new System.Drawing.Point(121, 393);
            this.invalidSequenceLbl.Name = "invalidSequenceLbl";
            this.invalidSequenceLbl.Size = new System.Drawing.Size(185, 17);
            this.invalidSequenceLbl.TabIndex = 8;
            this.invalidSequenceLbl.Text = "Invalid Sequences Entered: ";
            // 
            // maxNumRsltLbl
            // 
            this.maxNumRsltLbl.AutoSize = true;
            this.maxNumRsltLbl.Location = new System.Drawing.Point(415, 300);
            this.maxNumRsltLbl.Name = "maxNumRsltLbl";
            this.maxNumRsltLbl.Size = new System.Drawing.Size(0, 17);
            this.maxNumRsltLbl.TabIndex = 9;
            // 
            // validSeqRsltLbl
            // 
            this.validSeqRsltLbl.AutoSize = true;
            this.validSeqRsltLbl.Location = new System.Drawing.Point(415, 340);
            this.validSeqRsltLbl.Name = "validSeqRsltLbl";
            this.validSeqRsltLbl.Size = new System.Drawing.Size(0, 17);
            this.validSeqRsltLbl.TabIndex = 10;
            // 
            // invalidSeqRsltLbl
            // 
            this.invalidSeqRsltLbl.AutoSize = true;
            this.invalidSeqRsltLbl.Location = new System.Drawing.Point(415, 393);
            this.invalidSeqRsltLbl.Name = "invalidSeqRsltLbl";
            this.invalidSeqRsltLbl.Size = new System.Drawing.Size(0, 17);
            this.invalidSeqRsltLbl.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.invalidSeqRsltLbl);
            this.Controls.Add(this.validSeqRsltLbl);
            this.Controls.Add(this.maxNumRsltLbl);
            this.Controls.Add(this.invalidSequenceLbl);
            this.Controls.Add(this.validSequenceLbl);
            this.Controls.Add(this.maxResultLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.addRandomBtn);
            this.Controls.Add(this.randomTextField);
            this.Controls.Add(this.maxNoTextField);
            this.Name = "Form1";
            this.Text = "Fibonacci Sequence Validator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox maxNoTextField;
        private System.Windows.Forms.TextBox randomTextField;
        private System.Windows.Forms.Button addRandomBtn;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label maxResultLbl;
        private System.Windows.Forms.Label validSequenceLbl;
        private System.Windows.Forms.Label invalidSequenceLbl;
        private System.Windows.Forms.Label maxNumRsltLbl;
        private System.Windows.Forms.Label validSeqRsltLbl;
        private System.Windows.Forms.Label invalidSeqRsltLbl;
    }
}

