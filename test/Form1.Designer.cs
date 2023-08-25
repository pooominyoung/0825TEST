namespace test
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.message = new System.Windows.Forms.TextBox();
            this.PortNumber = new System.Windows.Forms.ComboBox();
            this.conn = new System.Windows.Forms.Button();
            this.led_01_on = new System.Windows.Forms.Button();
            this.led_01_off = new System.Windows.Forms.Button();
            this.led_02_on = new System.Windows.Forms.Button();
            this.led_02_off = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // message
            // 
            this.message.Enabled = false;
            this.message.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.message.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.message.Location = new System.Drawing.Point(12, 267);
            this.message.Name = "message";
            this.message.ReadOnly = true;
            this.message.Size = new System.Drawing.Size(294, 25);
            this.message.TabIndex = 0;
            this.message.Tag = "";
            this.message.ReadOnlyChanged += new System.EventHandler(this.Form1_Load);
            // 
            // PortNumber
            // 
            this.PortNumber.FormattingEnabled = true;
            this.PortNumber.ItemHeight = 15;
            this.PortNumber.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8"});
            this.PortNumber.Location = new System.Drawing.Point(12, 22);
            this.PortNumber.Name = "PortNumber";
            this.PortNumber.Size = new System.Drawing.Size(136, 23);
            this.PortNumber.TabIndex = 1;
            this.PortNumber.UseWaitCursor = true;
            // 
            // conn
            // 
            this.conn.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.conn.Location = new System.Drawing.Point(170, 22);
            this.conn.Name = "conn";
            this.conn.Size = new System.Drawing.Size(136, 31);
            this.conn.TabIndex = 2;
            this.conn.Text = "연결";
            this.conn.UseVisualStyleBackColor = true;
            this.conn.Click += new System.EventHandler(this.conn_Click);
            // 
            // led_01_on
            // 
            this.led_01_on.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.led_01_on.Location = new System.Drawing.Point(12, 77);
            this.led_01_on.Name = "led_01_on";
            this.led_01_on.Size = new System.Drawing.Size(136, 62);
            this.led_01_on.TabIndex = 3;
            this.led_01_on.Text = "LED_01 ON";
            this.led_01_on.UseVisualStyleBackColor = true;
            this.led_01_on.Click += new System.EventHandler(this.led_01_on_Click);
            // 
            // led_01_off
            // 
            this.led_01_off.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.led_01_off.Location = new System.Drawing.Point(170, 77);
            this.led_01_off.Name = "led_01_off";
            this.led_01_off.Size = new System.Drawing.Size(136, 62);
            this.led_01_off.TabIndex = 4;
            this.led_01_off.Text = "LED_01 OFF";
            this.led_01_off.UseVisualStyleBackColor = true;
            this.led_01_off.Click += new System.EventHandler(this.led_01_off_Click);
            // 
            // led_02_on
            // 
            this.led_02_on.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.led_02_on.Location = new System.Drawing.Point(12, 161);
            this.led_02_on.Name = "led_02_on";
            this.led_02_on.Size = new System.Drawing.Size(136, 59);
            this.led_02_on.TabIndex = 5;
            this.led_02_on.Text = "LED_02 ON";
            this.led_02_on.UseVisualStyleBackColor = true;
            this.led_02_on.Click += new System.EventHandler(this.led_02_on_Click);
            // 
            // led_02_off
            // 
            this.led_02_off.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.led_02_off.Location = new System.Drawing.Point(170, 161);
            this.led_02_off.Name = "led_02_off";
            this.led_02_off.Size = new System.Drawing.Size(136, 59);
            this.led_02_off.TabIndex = 6;
            this.led_02_off.Text = "LED_02 OFF";
            this.led_02_off.UseVisualStyleBackColor = true;
            this.led_02_off.Click += new System.EventHandler(this.led_02_off_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Message :\r\n ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 311);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.led_02_off);
            this.Controls.Add(this.led_02_on);
            this.Controls.Add(this.led_01_off);
            this.Controls.Add(this.led_01_on);
            this.Controls.Add(this.conn);
            this.Controls.Add(this.PortNumber);
            this.Controls.Add(this.message);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.ComboBox PortNumber;
        private System.Windows.Forms.Button conn;
        private System.Windows.Forms.Button led_01_on;
        private System.Windows.Forms.Button led_01_off;
        private System.Windows.Forms.Button led_02_on;
        private System.Windows.Forms.Button led_02_off;
        private System.Windows.Forms.Label label1;
    }
}

