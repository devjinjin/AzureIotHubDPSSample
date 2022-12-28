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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SymmetricKeyTextBox = new System.Windows.Forms.TextBox();
            this.scopeIdButton = new System.Windows.Forms.Button();
            this.DeviceRegistRequestButton = new System.Windows.Forms.Button();
            this.RegistrationIdTextBox = new System.Windows.Forms.TextBox();
            this.scopeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.messageSendButton = new System.Windows.Forms.Button();
            this.iotHubUrlTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SymmetricKeyResultTextBox = new System.Windows.Forms.TextBox();
            this.VcuIdTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SymmetricKeyGeneratedButton = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.SymmetricKeyTextBox);
            this.groupBox3.Controls.Add(this.scopeIdButton);
            this.groupBox3.Controls.Add(this.DeviceRegistRequestButton);
            this.groupBox3.Controls.Add(this.RegistrationIdTextBox);
            this.groupBox3.Controls.Add(this.scopeTextBox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(23, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(546, 307);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "디바이스 관리";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "대칭키";
            // 
            // SymmetricKeyTextBox
            // 
            this.SymmetricKeyTextBox.Location = new System.Drawing.Point(6, 192);
            this.SymmetricKeyTextBox.Name = "SymmetricKeyTextBox";
            this.SymmetricKeyTextBox.Size = new System.Drawing.Size(534, 27);
            this.SymmetricKeyTextBox.TabIndex = 19;
            this.SymmetricKeyTextBox.TextChanged += new System.EventHandler(this.SymmetricKeyTextBox_TextChanged);
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
            // DeviceRegistRequestButton
            // 
            this.DeviceRegistRequestButton.Location = new System.Drawing.Point(6, 240);
            this.DeviceRegistRequestButton.Name = "DeviceRegistRequestButton";
            this.DeviceRegistRequestButton.Size = new System.Drawing.Size(534, 49);
            this.DeviceRegistRequestButton.TabIndex = 17;
            this.DeviceRegistRequestButton.Text = "디바이스 등록하기";
            this.DeviceRegistRequestButton.UseVisualStyleBackColor = true;
            this.DeviceRegistRequestButton.Click += new System.EventHandler(this.DeviceRegistRequestButton_Click);
            // 
            // RegistrationIdTextBox
            // 
            this.RegistrationIdTextBox.Location = new System.Drawing.Point(6, 119);
            this.RegistrationIdTextBox.Name = "RegistrationIdTextBox";
            this.RegistrationIdTextBox.Size = new System.Drawing.Size(534, 27);
            this.RegistrationIdTextBox.TabIndex = 15;
            this.RegistrationIdTextBox.TextChanged += new System.EventHandler(this.RegistrationIdTextBox_TextChanged);
            // 
            // scopeTextBox
            // 
            this.scopeTextBox.Location = new System.Drawing.Point(6, 56);
            this.scopeTextBox.Name = "scopeTextBox";
            this.scopeTextBox.Size = new System.Drawing.Size(465, 27);
            this.scopeTextBox.TabIndex = 14;
            this.scopeTextBox.TextChanged += new System.EventHandler(this.scopeTextBox_TextChanged);
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
            this.messageSendButton.Click += new System.EventHandler(this.messageSendButton_ClickAsync);
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
            this.groupBox1.Location = new System.Drawing.Point(21, 348);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 135);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "메세지 전송";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox3);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Location = new System.Drawing.Point(623, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(586, 489);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "VCU 동작부";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.groupBox6);
            this.groupBox5.Location = new System.Drawing.Point(12, 17);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(593, 489);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "VCU 등록 전 처리";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.SymmetricKeyResultTextBox);
            this.groupBox6.Controls.Add(this.VcuIdTextBox);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Controls.Add(this.SymmetricKeyGeneratedButton);
            this.groupBox6.Location = new System.Drawing.Point(20, 35);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(551, 170);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "대칭키변환";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "생성 대칭키 결과";
            // 
            // SymmetricKeyResultTextBox
            // 
            this.SymmetricKeyResultTextBox.Location = new System.Drawing.Point(9, 129);
            this.SymmetricKeyResultTextBox.Name = "SymmetricKeyResultTextBox";
            this.SymmetricKeyResultTextBox.Size = new System.Drawing.Size(534, 27);
            this.SymmetricKeyResultTextBox.TabIndex = 3;
            // 
            // VcuIdTextBox
            // 
            this.VcuIdTextBox.Location = new System.Drawing.Point(105, 30);
            this.VcuIdTextBox.Name = "VcuIdTextBox";
            this.VcuIdTextBox.PlaceholderText = "대칭키를 위한 VCU 아이디를 입력하세요";
            this.VcuIdTextBox.Size = new System.Drawing.Size(438, 27);
            this.VcuIdTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "VCU 아이디";
            // 
            // SymmetricKeyGeneratedButton
            // 
            this.SymmetricKeyGeneratedButton.Location = new System.Drawing.Point(9, 63);
            this.SymmetricKeyGeneratedButton.Name = "SymmetricKeyGeneratedButton";
            this.SymmetricKeyGeneratedButton.Size = new System.Drawing.Size(534, 29);
            this.SymmetricKeyGeneratedButton.TabIndex = 0;
            this.SymmetricKeyGeneratedButton.Text = "SHA256으로 변환 하기";
            this.SymmetricKeyGeneratedButton.UseVisualStyleBackColor = true;
            this.SymmetricKeyGeneratedButton.Click += new System.EventHandler(this.SymmetricKeyGeneratedButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 518);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Name = "Form1";
            this.Text = "Azure Iot Hub 관리 테스트";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private GroupBox groupBox3;
        private Button DeviceRegistRequestButton;
        private TextBox RegistrationIdTextBox;
        private TextBox scopeTextBox;
        private Label label4;
        private Label label1;
        private Button messageSendButton;
        private TextBox iotHubUrlTextBox;
        private Label label3;
        private GroupBox groupBox1;
        private Button scopeIdButton;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private Label label7;
        private TextBox SymmetricKeyResultTextBox;
        private TextBox VcuIdTextBox;
        private Label label2;
        private Button SymmetricKeyGeneratedButton;
        private Label label5;
        private TextBox SymmetricKeyTextBox;
    }
}