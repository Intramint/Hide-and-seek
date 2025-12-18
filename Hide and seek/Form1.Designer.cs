namespace Hide_and_seek
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
            descriptionTextBox = new TextBox();
            goHereButton = new Button();
            goThroughDoorButton = new Button();
            exitsComboBox = new ComboBox();
            SuspendLayout();
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(12, 12);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(360, 186);
            descriptionTextBox.TabIndex = 0;
            // 
            // goHereButton
            // 
            goHereButton.Location = new Point(12, 207);
            goHereButton.Name = "goHereButton";
            goHereButton.Size = new Size(101, 23);
            goHereButton.TabIndex = 1;
            goHereButton.Text = "Idź tutaj:";
            goHereButton.UseVisualStyleBackColor = true;
            goHereButton.Click += goHereButton_Click;
            // 
            // goThroughDoorButton
            // 
            goThroughDoorButton.Location = new Point(12, 236);
            goThroughDoorButton.Name = "goThroughDoorButton";
            goThroughDoorButton.Size = new Size(360, 23);
            goThroughDoorButton.TabIndex = 2;
            goThroughDoorButton.Text = "Przejdź przez drzwi";
            goThroughDoorButton.UseVisualStyleBackColor = true;
            goThroughDoorButton.Click += goThroughDoorButton_Click;
            // 
            // exitsComboBox
            // 
            exitsComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            exitsComboBox.FormattingEnabled = true;
            exitsComboBox.Location = new Point(119, 207);
            exitsComboBox.Name = "exitsComboBox";
            exitsComboBox.Size = new Size(253, 23);
            exitsComboBox.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 270);
            Controls.Add(exitsComboBox);
            Controls.Add(goThroughDoorButton);
            Controls.Add(goHereButton);
            Controls.Add(descriptionTextBox);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox descriptionTextBox;
        private Button goHereButton;
        private Button goThroughDoorButton;
        private ComboBox exitsComboBox;
    }
}
