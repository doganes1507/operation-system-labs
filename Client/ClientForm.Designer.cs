namespace Client
{
    partial class ClientForm
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
            Server1GroupBox = new GroupBox();
            Server1PortTextBox = new TextBox();
            Server1PortLabel = new Label();
            GetPrimaryScreenResolutionButton = new Button();
            GetWindowCoordinatesButton = new Button();
            Server2GroupBox = new GroupBox();
            Server2PortTextBox = new TextBox();
            Server2PortLabel = new Label();
            GetNumberOfThreadsButton = new Button();
            GetNumberOfModulesButton = new Button();
            Server1GroupBox.SuspendLayout();
            Server2GroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // Server1GroupBox
            // 
            Server1GroupBox.Controls.Add(Server1PortTextBox);
            Server1GroupBox.Controls.Add(Server1PortLabel);
            Server1GroupBox.Controls.Add(GetPrimaryScreenResolutionButton);
            Server1GroupBox.Controls.Add(GetWindowCoordinatesButton);
            Server1GroupBox.Location = new Point(12, 12);
            Server1GroupBox.Name = "Server1GroupBox";
            Server1GroupBox.Size = new Size(312, 379);
            Server1GroupBox.TabIndex = 6;
            Server1GroupBox.TabStop = false;
            Server1GroupBox.Text = "Server 1";
            // 
            // Server1PortTextBox
            // 
            Server1PortTextBox.Location = new Point(181, 26);
            Server1PortTextBox.Name = "Server1PortTextBox";
            Server1PortTextBox.Size = new Size(125, 27);
            Server1PortTextBox.TabIndex = 0;
            // 
            // Server1PortLabel
            // 
            Server1PortLabel.AutoSize = true;
            Server1PortLabel.Location = new Point(6, 29);
            Server1PortLabel.Name = "Server1PortLabel";
            Server1PortLabel.Size = new Size(140, 20);
            Server1PortLabel.TabIndex = 7;
            Server1PortLabel.Text = "Server port number:";
            // 
            // GetPrimaryScreenResolutionButton
            // 
            GetPrimaryScreenResolutionButton.Location = new Point(6, 344);
            GetPrimaryScreenResolutionButton.Name = "GetPrimaryScreenResolutionButton";
            GetPrimaryScreenResolutionButton.Size = new Size(300, 29);
            GetPrimaryScreenResolutionButton.TabIndex = 2;
            GetPrimaryScreenResolutionButton.Text = "Get server primary screen resolution\r\n";
            GetPrimaryScreenResolutionButton.UseVisualStyleBackColor = true;
            GetPrimaryScreenResolutionButton.Click += GetPrimaryScreenResolutionButton_Click;
            // 
            // GetWindowCoordinatesButton
            // 
            GetWindowCoordinatesButton.Location = new Point(6, 309);
            GetWindowCoordinatesButton.Name = "GetWindowCoordinatesButton";
            GetWindowCoordinatesButton.Size = new Size(300, 29);
            GetWindowCoordinatesButton.TabIndex = 1;
            GetWindowCoordinatesButton.Text = "Get server window coordinates";
            GetWindowCoordinatesButton.UseVisualStyleBackColor = true;
            GetWindowCoordinatesButton.Click += GetWindowCoordinatesButton_Click;
            // 
            // Server2GroupBox
            // 
            Server2GroupBox.Controls.Add(Server2PortTextBox);
            Server2GroupBox.Controls.Add(Server2PortLabel);
            Server2GroupBox.Controls.Add(GetNumberOfThreadsButton);
            Server2GroupBox.Controls.Add(GetNumberOfModulesButton);
            Server2GroupBox.Location = new Point(330, 12);
            Server2GroupBox.Name = "Server2GroupBox";
            Server2GroupBox.Size = new Size(312, 379);
            Server2GroupBox.TabIndex = 8;
            Server2GroupBox.TabStop = false;
            Server2GroupBox.Text = "Server 2";
            // 
            // Server2PortTextBox
            // 
            Server2PortTextBox.Location = new Point(181, 26);
            Server2PortTextBox.Name = "Server2PortTextBox";
            Server2PortTextBox.Size = new Size(125, 27);
            Server2PortTextBox.TabIndex = 3;
            // 
            // Server2PortLabel
            // 
            Server2PortLabel.AutoSize = true;
            Server2PortLabel.Location = new Point(6, 29);
            Server2PortLabel.Name = "Server2PortLabel";
            Server2PortLabel.Size = new Size(140, 20);
            Server2PortLabel.TabIndex = 9;
            Server2PortLabel.Text = "Server port number:";
            // 
            // GetNumberOfThreadsButton
            // 
            GetNumberOfThreadsButton.Location = new Point(6, 344);
            GetNumberOfThreadsButton.Name = "GetNumberOfThreadsButton";
            GetNumberOfThreadsButton.Size = new Size(300, 29);
            GetNumberOfThreadsButton.TabIndex = 5;
            GetNumberOfThreadsButton.Text = "Get number of server threads";
            GetNumberOfThreadsButton.UseVisualStyleBackColor = true;
            GetNumberOfThreadsButton.Click += GetNumberOfThreadsButton_Click;
            // 
            // GetNumberOfModulesButton
            // 
            GetNumberOfModulesButton.Location = new Point(6, 309);
            GetNumberOfModulesButton.Name = "GetNumberOfModulesButton";
            GetNumberOfModulesButton.Size = new Size(300, 29);
            GetNumberOfModulesButton.TabIndex = 4;
            GetNumberOfModulesButton.Text = "Get number of server modules";
            GetNumberOfModulesButton.UseVisualStyleBackColor = true;
            GetNumberOfModulesButton.Click += GetNumberOfModulesButton_Click;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 403);
            Controls.Add(Server2GroupBox);
            Controls.Add(Server1GroupBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ClientForm";
            Text = "Client";
            Server1GroupBox.ResumeLayout(false);
            Server1GroupBox.PerformLayout();
            Server2GroupBox.ResumeLayout(false);
            Server2GroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox Server1GroupBox;
        private Button GetPrimaryScreenResolutionButton;
        private Button GetWindowCoordinatesButton;
        private GroupBox Server2GroupBox;
        private Button GetNumberOfThreadsButton;
        private Button GetNumberOfModulesButton;
        private TextBox Server1PortTextBox;
        private Label Server1PortLabel;
        private TextBox Server2PortTextBox;
        private Label Server2PortLabel;
    }
}