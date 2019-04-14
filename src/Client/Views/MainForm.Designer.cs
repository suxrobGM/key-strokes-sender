namespace Client.Views
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sendInput = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.ipAddressInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timeIntervalInput = new System.Windows.Forms.TextBox();
            this.sendStatusLabel = new System.Windows.Forms.Label();
            this.intervalTimer = new System.Windows.Forms.Timer(this.components);
            this.timeIntervalChB = new System.Windows.Forms.CheckBox();
            this.asynchronouslySendChB = new System.Windows.Forms.CheckBox();
            this.echoTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // sendInput
            // 
            this.sendInput.Location = new System.Drawing.Point(12, 133);
            this.sendInput.Name = "sendInput";
            this.sendInput.Size = new System.Drawing.Size(289, 22);
            this.sendInput.TabIndex = 0;
            this.sendInput.TextChanged += new System.EventHandler(this.sendInput_TextChanged);
            this.sendInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sendInput_KeyDown);
            // 
            // sendBtn
            // 
            this.sendBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendBtn.Location = new System.Drawing.Point(12, 220);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(100, 35);
            this.sendBtn.TabIndex = 1;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = true;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // ipAddressInput
            // 
            this.ipAddressInput.Location = new System.Drawing.Point(12, 34);
            this.ipAddressInput.Name = "ipAddressInput";
            this.ipAddressInput.Size = new System.Drawing.Size(217, 22);
            this.ipAddressInput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Server ip address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter digit between 0 and 57 or string";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(235, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "port: 2000";
            // 
            // timeIntervalInput
            // 
            this.timeIntervalInput.Enabled = false;
            this.timeIntervalInput.Location = new System.Drawing.Point(12, 192);
            this.timeIntervalInput.Name = "timeIntervalInput";
            this.timeIntervalInput.Size = new System.Drawing.Size(289, 22);
            this.timeIntervalInput.TabIndex = 6;
            // 
            // sendStatusLabel
            // 
            this.sendStatusLabel.AutoSize = true;
            this.sendStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendStatusLabel.Location = new System.Drawing.Point(118, 230);
            this.sendStatusLabel.Name = "sendStatusLabel";
            this.sendStatusLabel.Size = new System.Drawing.Size(46, 17);
            this.sendStatusLabel.TabIndex = 8;
            this.sendStatusLabel.Text = "label5";
            // 
            // timeIntervalChB
            // 
            this.timeIntervalChB.AutoSize = true;
            this.timeIntervalChB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeIntervalChB.Location = new System.Drawing.Point(12, 164);
            this.timeIntervalChB.Name = "timeIntervalChB";
            this.timeIntervalChB.Size = new System.Drawing.Size(201, 22);
            this.timeIntervalChB.TabIndex = 9;
            this.timeIntervalChB.Text = "Use time interval: (ms)";
            this.timeIntervalChB.UseVisualStyleBackColor = true;
            this.timeIntervalChB.CheckedChanged += new System.EventHandler(this.timeIntervalChB_CheckedChanged);
            // 
            // asynchronouslySendChB
            // 
            this.asynchronouslySendChB.AutoSize = true;
            this.asynchronouslySendChB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.asynchronouslySendChB.Location = new System.Drawing.Point(12, 71);
            this.asynchronouslySendChB.Name = "asynchronouslySendChB";
            this.asynchronouslySendChB.Size = new System.Drawing.Size(190, 22);
            this.asynchronouslySendChB.TabIndex = 10;
            this.asynchronouslySendChB.Text = "Asynchronously send";
            this.asynchronouslySendChB.UseVisualStyleBackColor = true;
            this.asynchronouslySendChB.CheckedChanged += new System.EventHandler(this.asynchronouslySendChB_CheckedChanged);
            // 
            // echoTimer
            // 
            this.echoTimer.Interval = 1000;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 267);
            this.Controls.Add(this.asynchronouslySendChB);
            this.Controls.Add(this.timeIntervalChB);
            this.Controls.Add(this.sendStatusLabel);
            this.Controls.Add(this.timeIntervalInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ipAddressInput);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.sendInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sendInput;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.TextBox ipAddressInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox timeIntervalInput;
        private System.Windows.Forms.Label sendStatusLabel;
        private System.Windows.Forms.Timer intervalTimer;
        private System.Windows.Forms.CheckBox timeIntervalChB;
        private System.Windows.Forms.CheckBox asynchronouslySendChB;
        private System.Windows.Forms.Timer echoTimer;
    }
}

