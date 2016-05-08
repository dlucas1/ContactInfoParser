namespace BusinessCardParser
{
    partial class BusinessCardParserForm
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
            this.inputFileFolderText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inputFileExtensionText = new System.Windows.Forms.TextBox();
            this.parsedResultsTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputFileFolderText
            // 
            this.inputFileFolderText.Location = new System.Drawing.Point(151, 11);
            this.inputFileFolderText.Name = "inputFileFolderText";
            this.inputFileFolderText.ReadOnly = true;
            this.inputFileFolderText.Size = new System.Drawing.Size(503, 22);
            this.inputFileFolderText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input File Folder:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Input File Extension:";
            // 
            // inputFileExtensionText
            // 
            this.inputFileExtensionText.Location = new System.Drawing.Point(151, 39);
            this.inputFileExtensionText.Name = "inputFileExtensionText";
            this.inputFileExtensionText.ReadOnly = true;
            this.inputFileExtensionText.Size = new System.Drawing.Size(503, 22);
            this.inputFileExtensionText.TabIndex = 8;
            // 
            // parsedResultsTextBox
            // 
            this.parsedResultsTextBox.Location = new System.Drawing.Point(15, 93);
            this.parsedResultsTextBox.Multiline = true;
            this.parsedResultsTextBox.Name = "parsedResultsTextBox";
            this.parsedResultsTextBox.ReadOnly = true;
            this.parsedResultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.parsedResultsTextBox.Size = new System.Drawing.Size(638, 635);
            this.parsedResultsTextBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Parsed Results:";
            // 
            // businessCardParserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 740);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.parsedResultsTextBox);
            this.Controls.Add(this.inputFileExtensionText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputFileFolderText);
            this.Name = "BusinessCardParserForm";
            this.Text = "Business Card Parser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputFileFolderText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputFileExtensionText;
        private System.Windows.Forms.TextBox parsedResultsTextBox;
        private System.Windows.Forms.Label label3;
    }
}

