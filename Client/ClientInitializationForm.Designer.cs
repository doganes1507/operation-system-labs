namespace Client
{
    partial class ClientInitializationForm
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
            CreateClientButton = new Button();
            WelcomeLabel = new Label();
            PortNumberTextBox = new TextBox();
            PortNumberLabel = new Label();
            SuspendLayout();
            // 
            // CreateClientButton
            // 
            CreateClientButton.Location = new Point(12, 362);
            CreateClientButton.Name = "CreateClientButton";
            CreateClientButton.Size = new Size(308, 29);
            CreateClientButton.TabIndex = 1;
            CreateClientButton.Text = "Create client";
            CreateClientButton.UseVisualStyleBackColor = true;
            CreateClientButton.Click += CreateClientButton_Click;
            // 
            // WelcomeLabel
            // 
            WelcomeLabel.AutoSize = true;
            WelcomeLabel.Location = new Point(28, 9);
            WelcomeLabel.Name = "WelcomeLabel";
            WelcomeLabel.Size = new Size(272, 80);
            WelcomeLabel.TabIndex = 2;
            WelcomeLabel.Text = "Welcome to Client Initialization Wizard!\r\n\r\nPlease choose configuration\r\nparameters to create a client";
            WelcomeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PortNumberTextBox
            // 
            PortNumberTextBox.Location = new Point(195, 147);
            PortNumberTextBox.Name = "PortNumberTextBox";
            PortNumberTextBox.Size = new Size(125, 27);
            PortNumberTextBox.TabIndex = 0;
            // 
            // PortNumberLabel
            // 
            PortNumberLabel.AutoSize = true;
            PortNumberLabel.Location = new Point(12, 150);
            PortNumberLabel.Name = "PortNumberLabel";
            PortNumberLabel.Size = new Size(93, 20);
            PortNumberLabel.TabIndex = 4;
            PortNumberLabel.Text = "Port number:";
            // 
            // ClientInitializationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 403);
            Controls.Add(PortNumberLabel);
            Controls.Add(PortNumberTextBox);
            Controls.Add(WelcomeLabel);
            Controls.Add(CreateClientButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ClientInitializationForm";
            Text = "Client Initialization Wizard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CreateClientButton;
        private Label WelcomeLabel;
        private TextBox PortNumberTextBox;
        private Label PortNumberLabel;
    }
}