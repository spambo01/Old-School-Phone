namespace OldSchoolPhone
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSentence = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblNumberedText = new System.Windows.Forms.Label();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please insert a sentence in English:";
            // 
            // txtSentence
            // 
            this.txtSentence.Location = new System.Drawing.Point(12, 67);
            this.txtSentence.Name = "txtSentence";
            this.txtSentence.Size = new System.Drawing.Size(388, 35);
            this.txtSentence.TabIndex = 1;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(257, 128);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(143, 61);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 261);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(681, 29);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Your sentence converted in an old phone number sequence is:";
            // 
            // lblNumberedText
            // 
            this.lblNumberedText.AutoSize = true;
            this.lblNumberedText.Location = new System.Drawing.Point(12, 310);
            this.lblNumberedText.Name = "lblNumberedText";
            this.lblNumberedText.Size = new System.Drawing.Size(0, 29);
            this.lblNumberedText.TabIndex = 4;
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.AutoSize = true;
            this.lblErrorMsg.Location = new System.Drawing.Point(17, 187);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(0, 29);
            this.lblErrorMsg.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(495, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Minimum time to enter the above sentence is:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(17, 420);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 29);
            this.lblTime.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 599);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblErrorMsg);
            this.Controls.Add(this.lblNumberedText);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtSentence);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Nokia 3310";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSentence;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblNumberedText;
        private System.Windows.Forms.Label lblErrorMsg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTime;
    }
}

