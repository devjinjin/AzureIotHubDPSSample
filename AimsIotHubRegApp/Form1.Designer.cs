namespace AimsIotHubRegApp
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.firstRegistrationTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.firstPrimaryKeyTextBot = new System.Windows.Forms.TextBox();
            this.GenerateDeviceKeyButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.privateKeyTextBox = new System.Windows.Forms.TextBox();
            this.registrationIdTextBox = new System.Windows.Forms.TextBox();
            this.scopeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.messageSendButton = new System.Windows.Forms.Button();
            this.iotHubUrlTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.primaryKeySaveButton = new System.Windows.Forms.Button();
            this.scopeIdButton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.primaryKeySaveButton);
            this.groupBox2.Controls.Add(this.firstRegistrationTextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.firstPrimaryKeyTextBot);
            this.groupBox2.Controls.Add(this.GenerateDeviceKeyButton);
            this.groupBox2.Location = new System.Drawing.Point(14, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(551, 146);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "디바이스키 관리";
            // 
            // firstRegistrationTextBox
            // 
            this.firstRegistrationTextBox.Location = new System.Drawing.Point(109, 59);
            this.firstRegistrationTextBox.Name = "firstRegistrationTextBox";
            this.firstRegistrationTextBox.Size = new System.Drawing.Size(434, 27);
            this.firstRegistrationTextBox.TabIndex = 4;
            this.firstRegistrationTextBox.TextChanged += new System.EventHandler(this.firstRegistrationTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "등록 아이디";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "기본 키";
            // 
            // firstPrimaryKeyTextBot
            // 
            this.firstPrimaryKeyTextBot.Location = new System.Drawing.Point(109, 26);
            this.firstPrimaryKeyTextBot.Name = "firstPrimaryKeyTextBot";
            this.firstPrimaryKeyTextBot.Size = new System.Drawing.Size(365, 27);
            this.firstPrimaryKeyTextBot.TabIndex = 1;
            // 
            // GenerateDeviceKeyButton
            // 
            this.GenerateDeviceKeyButton.Location = new System.Drawing.Point(9, 99);
            this.GenerateDeviceKeyButton.Name = "GenerateDeviceKeyButton";
            this.GenerateDeviceKeyButton.Size = new System.Drawing.Size(534, 29);
            this.GenerateDeviceKeyButton.TabIndex = 0;
            this.GenerateDeviceKeyButton.Text = "디바이스 키 생성";
            this.GenerateDeviceKeyButton.UseVisualStyleBackColor = true;
            this.GenerateDeviceKeyButton.Click += new System.EventHandler(this.GenerateDeviceKeyButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.scopeIdButton);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.privateKeyTextBox);
            this.groupBox3.Controls.Add(this.registrationIdTextBox);
            this.groupBox3.Controls.Add(this.scopeTextBox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(17, 185);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(546, 279);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "디바이스 관리";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(534, 49);
            this.button1.TabIndex = 17;
            this.button1.Text = "디바이스 등록하기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // privateKeyTextBox
            // 
            this.privateKeyTextBox.Location = new System.Drawing.Point(6, 181);
            this.privateKeyTextBox.Name = "privateKeyTextBox";
            this.privateKeyTextBox.Size = new System.Drawing.Size(534, 27);
            this.privateKeyTextBox.TabIndex = 16;
            // 
            // registrationIdTextBox
            // 
            this.registrationIdTextBox.Location = new System.Drawing.Point(6, 119);
            this.registrationIdTextBox.Name = "registrationIdTextBox";
            this.registrationIdTextBox.Size = new System.Drawing.Size(534, 27);
            this.registrationIdTextBox.TabIndex = 15;
            // 
            // scopeTextBox
            // 
            this.scopeTextBox.Location = new System.Drawing.Point(6, 56);
            this.scopeTextBox.Name = "scopeTextBox";
            this.scopeTextBox.Size = new System.Drawing.Size(465, 27);
            this.scopeTextBox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "ID 범위";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "디바이스 키";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "등록 아이디";
            // 
            // messageSendButton
            // 
            this.messageSendButton.Location = new System.Drawing.Point(6, 79);
            this.messageSendButton.Name = "messageSendButton";
            this.messageSendButton.Size = new System.Drawing.Size(534, 49);
            this.messageSendButton.TabIndex = 13;
            this.messageSendButton.Text = "메세지 전송";
            this.messageSendButton.UseVisualStyleBackColor = true;
            this.messageSendButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // iotHubUrlTextBox
            // 
            this.iotHubUrlTextBox.Location = new System.Drawing.Point(6, 46);
            this.iotHubUrlTextBox.Name = "iotHubUrlTextBox";
            this.iotHubUrlTextBox.Size = new System.Drawing.Size(534, 27);
            this.iotHubUrlTextBox.TabIndex = 14;
            this.iotHubUrlTextBox.TextChanged += new System.EventHandler(this.iotHubUrlTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "호스트 이름(Iot Hub Url)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.messageSendButton);
            this.groupBox1.Controls.Add(this.iotHubUrlTextBox);
            this.groupBox1.Location = new System.Drawing.Point(17, 470);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 135);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "메세지 전송";
            // 
            // primaryKeySaveButton
            // 
            this.primaryKeySaveButton.Location = new System.Drawing.Point(480, 25);
            this.primaryKeySaveButton.Name = "primaryKeySaveButton";
            this.primaryKeySaveButton.Size = new System.Drawing.Size(63, 29);
            this.primaryKeySaveButton.TabIndex = 5;
            this.primaryKeySaveButton.Text = "저장";
            this.primaryKeySaveButton.UseVisualStyleBackColor = true;
            this.primaryKeySaveButton.Click += new System.EventHandler(this.primaryKeySaveButton_Click);
            // 
            // scopeIdButton
            // 
            this.scopeIdButton.Location = new System.Drawing.Point(477, 56);
            this.scopeIdButton.Name = "scopeIdButton";
            this.scopeIdButton.Size = new System.Drawing.Size(63, 29);
            this.scopeIdButton.TabIndex = 18;
            this.scopeIdButton.Text = "저장";
            this.scopeIdButton.UseVisualStyleBackColor = true;
            this.scopeIdButton.Click += new System.EventHandler(this.scopeIdButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 611);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Azure Iot Hub 관리 테스트";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox2;
        private TextBox firstRegistrationTextBox;
        private Label label6;
        private Label label5;
        private TextBox firstPrimaryKeyTextBot;
        private Button GenerateDeviceKeyButton;
        private GroupBox groupBox3;
        private Button button1;
        private TextBox privateKeyTextBox;
        private TextBox registrationIdTextBox;
        private TextBox scopeTextBox;
        private Label label4;
        private Label label2;
        private Label label1;
        private Button messageSendButton;
        private TextBox iotHubUrlTextBox;
        private Label label3;
        private GroupBox groupBox1;
        private Button primaryKeySaveButton;
        private Button scopeIdButton;
    }
}