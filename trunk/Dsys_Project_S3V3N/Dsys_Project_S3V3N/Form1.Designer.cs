namespace Dsys_Project_S3V3N
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
            this.hostButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ipSelectList_HOST = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.newRadioButton = new System.Windows.Forms.RadioButton();
            this.openRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ipAddress_CONNECT = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hostButton);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.ipSelectList_HOST);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 201);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Host";
            // 
            // hostButton
            // 
            this.hostButton.Location = new System.Drawing.Point(98, 158);
            this.hostButton.Name = "hostButton";
            this.hostButton.Size = new System.Drawing.Size(75, 23);
            this.hostButton.TabIndex = 4;
            this.hostButton.Text = "HOST";
            this.hostButton.UseVisualStyleBackColor = true;
            this.hostButton.Click += new System.EventHandler(this.hostButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(34, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(73, 15);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "IP Address";
            // 
            // ipSelectList_HOST
            // 
            this.ipSelectList_HOST.FormattingEnabled = true;
            this.ipSelectList_HOST.Location = new System.Drawing.Point(113, 114);
            this.ipSelectList_HOST.Name = "ipSelectList_HOST";
            this.ipSelectList_HOST.Size = new System.Drawing.Size(154, 24);
            this.ipSelectList_HOST.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.newRadioButton);
            this.panel1.Controls.Add(this.openRadioButton);
            this.panel1.Location = new System.Drawing.Point(34, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 74);
            this.panel1.TabIndex = 1;
            // 
            // newRadioButton
            // 
            this.newRadioButton.AutoSize = true;
            this.newRadioButton.Location = new System.Drawing.Point(54, 14);
            this.newRadioButton.Name = "newRadioButton";
            this.newRadioButton.Size = new System.Drawing.Size(124, 21);
            this.newRadioButton.TabIndex = 0;
            this.newRadioButton.TabStop = true;
            this.newRadioButton.Text = "New Document";
            this.newRadioButton.UseVisualStyleBackColor = true;
            // 
            // openRadioButton
            // 
            this.openRadioButton.AutoSize = true;
            this.openRadioButton.Location = new System.Drawing.Point(54, 41);
            this.openRadioButton.Name = "openRadioButton";
            this.openRadioButton.Size = new System.Drawing.Size(116, 21);
            this.openRadioButton.TabIndex = 1;
            this.openRadioButton.TabStop = true;
            this.openRadioButton.Text = "Open Existing";
            this.openRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ipAddress_CONNECT);
            this.groupBox2.Controls.Add(this.connectButton);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Location = new System.Drawing.Point(349, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(322, 201);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Connect";
            // 
            // ipAddress_CONNECT
            // 
            this.ipAddress_CONNECT.Location = new System.Drawing.Point(130, 59);
            this.ipAddress_CONNECT.Name = "ipAddress_CONNECT";
            this.ipAddress_CONNECT.Size = new System.Drawing.Size(161, 22);
            this.ipAddress_CONNECT.TabIndex = 5;
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(105, 115);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(100, 23);
            this.connectButton.TabIndex = 4;
            this.connectButton.Text = "CONNECT";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(22, 62);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(102, 15);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Host IP Address";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 236);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton newRadioButton;
        private System.Windows.Forms.RadioButton openRadioButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox ipSelectList_HOST;
        private System.Windows.Forms.Button hostButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ipAddress_CONNECT;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;

    }
}

