namespace Exercise_5
{
    partial class PlayfairCipher
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
            this.keywordTxtBox = new System.Windows.Forms.TextBox();
            this.inputTxtBox = new System.Windows.Forms.RichTextBox();
            this.outputTxtBox = new System.Windows.Forms.RichTextBox();
            this.buttonsBox = new System.Windows.Forms.GroupBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.translateButton = new System.Windows.Forms.Button();
            this.keywordLabel = new System.Windows.Forms.Label();
            this.inputLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.buttonsBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // keywordTxtBox
            // 
            this.keywordTxtBox.Location = new System.Drawing.Point(127, 39);
            this.keywordTxtBox.Name = "keywordTxtBox";
            this.keywordTxtBox.Size = new System.Drawing.Size(153, 20);
            this.keywordTxtBox.TabIndex = 0;
            this.keywordTxtBox.TextChanged += new System.EventHandler(this.keywordTxtBox_TextChanged);
            // 
            // inputTxtBox
            // 
            this.inputTxtBox.Location = new System.Drawing.Point(127, 89);
            this.inputTxtBox.Name = "inputTxtBox";
            this.inputTxtBox.Size = new System.Drawing.Size(532, 96);
            this.inputTxtBox.TabIndex = 1;
            this.inputTxtBox.Text = "";
            // 
            // outputTxtBox
            // 
            this.outputTxtBox.Location = new System.Drawing.Point(127, 216);
            this.outputTxtBox.Name = "outputTxtBox";
            this.outputTxtBox.ReadOnly = true;
            this.outputTxtBox.Size = new System.Drawing.Size(532, 99);
            this.outputTxtBox.TabIndex = 2;
            this.outputTxtBox.Text = "";
            // 
            // buttonsBox
            // 
            this.buttonsBox.Controls.Add(this.closeButton);
            this.buttonsBox.Controls.Add(this.clearButton);
            this.buttonsBox.Controls.Add(this.translateButton);
            this.buttonsBox.Location = new System.Drawing.Point(119, 402);
            this.buttonsBox.Name = "buttonsBox";
            this.buttonsBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonsBox.Size = new System.Drawing.Size(540, 36);
            this.buttonsBox.TabIndex = 3;
            this.buttonsBox.TabStop = false;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(459, 9);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(119, 9);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // translateButton
            // 
            this.translateButton.Location = new System.Drawing.Point(6, 9);
            this.translateButton.Name = "translateButton";
            this.translateButton.Size = new System.Drawing.Size(107, 23);
            this.translateButton.TabIndex = 0;
            this.translateButton.Text = "Translate Text";
            this.translateButton.UseVisualStyleBackColor = true;
            this.translateButton.Click += new System.EventHandler(this.translateButton_Click);
            // 
            // keywordLabel
            // 
            this.keywordLabel.AutoSize = true;
            this.keywordLabel.Location = new System.Drawing.Point(49, 42);
            this.keywordLabel.Name = "keywordLabel";
            this.keywordLabel.Size = new System.Drawing.Size(51, 13);
            this.keywordLabel.TabIndex = 4;
            this.keywordLabel.Text = "Keyword:";
            this.keywordLabel.Click += new System.EventHandler(this.keywordLabel_Click);
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(49, 89);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(58, 13);
            this.inputLabel.TabIndex = 5;
            this.inputLabel.Text = "Input Text:";
            this.inputLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(49, 216);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(66, 13);
            this.outputLabel.TabIndex = 6;
            this.outputLabel.Text = "Output Text:";
            // 
            // PlayfairCipher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.inputLabel);
            this.Controls.Add(this.keywordLabel);
            this.Controls.Add(this.buttonsBox);
            this.Controls.Add(this.outputTxtBox);
            this.Controls.Add(this.inputTxtBox);
            this.Controls.Add(this.keywordTxtBox);
            this.Name = "PlayfairCipher";
            this.Text = "PlayfairCipher";
            this.buttonsBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox keywordTxtBox;
        private System.Windows.Forms.RichTextBox inputTxtBox;
        private System.Windows.Forms.RichTextBox outputTxtBox;
        private System.Windows.Forms.GroupBox buttonsBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button translateButton;
        private System.Windows.Forms.Label keywordLabel;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Label outputLabel;
    }
}

