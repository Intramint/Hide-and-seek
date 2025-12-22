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
            components = new System.ComponentModel.Container();
            descriptionTextBox = new TextBox();
            goHereButton = new Button();
            goThroughDoorButton = new Button();
            exitsComboBox = new ComboBox();
            searchRoomButton = new Button();
            startGameButton = new Button();
            toggleControlsTimer = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            countdownTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.BorderStyle = BorderStyle.FixedSingle;
            descriptionTextBox.Enabled = false;
            descriptionTextBox.Location = new Point(12, 12);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.ReadOnly = true;
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
            goHereButton.Visible = false;
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
            goThroughDoorButton.Visible = false;
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
            exitsComboBox.Visible = false;
            // 
            // searchRoomButton
            // 
            searchRoomButton.Location = new Point(12, 265);
            searchRoomButton.Name = "searchRoomButton";
            searchRoomButton.Size = new Size(360, 23);
            searchRoomButton.TabIndex = 4;
            searchRoomButton.Text = "searchRoomButton";
            searchRoomButton.UseVisualStyleBackColor = true;
            searchRoomButton.Visible = false;
            searchRoomButton.Click += searchRoomButton_Click;
            // 
            // startGameButton
            // 
            startGameButton.Location = new Point(12, 294);
            startGameButton.Name = "startGameButton";
            startGameButton.Size = new Size(360, 23);
            startGameButton.TabIndex = 5;
            startGameButton.Text = "Start";
            startGameButton.UseVisualStyleBackColor = true;
            startGameButton.Click += startGameButton_Click;
            // 
            // toggleControlsTimer
            // 
            toggleControlsTimer.Interval = 1000;
            toggleControlsTimer.Tick += toggleControlsTimer_Tick;
            // 
            // countdownTimer
            // 
            countdownTimer.Interval = 300;
            countdownTimer.Tick += countdownTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 324);
            Controls.Add(startGameButton);
            Controls.Add(searchRoomButton);
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
        private Button searchRoomButton;
        private Button startGameButton;
        private System.Windows.Forms.Timer toggleControlsTimer;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer countdownTimer;
    }
}
