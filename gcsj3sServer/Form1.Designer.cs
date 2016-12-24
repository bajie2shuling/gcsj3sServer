namespace gcsj3sServer
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.RightPanel = new System.Windows.Forms.Panel();
            this.labTempTime = new System.Windows.Forms.Label();
            this.tbxTempTime = new System.Windows.Forms.TextBox();
            this.tbxConInfo = new System.Windows.Forms.TextBox();
            this.tbxGasTime = new System.Windows.Forms.TextBox();
            this.tbxGas = new System.Windows.Forms.TextBox();
            this.tbxTemp = new System.Windows.Forms.TextBox();
            this.labGasTime = new System.Windows.Forms.Label();
            this.labGas = new System.Windows.Forms.Label();
            this.labTemp = new System.Windows.Forms.Label();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.btnClearBuf = new System.Windows.Forms.Button();
            this.btnEsc = new System.Windows.Forms.Button();
            this.btnStopRecv = new System.Windows.Forms.Button();
            this.btnStratRecv = new System.Windows.Forms.Button();
            this.btnStartServer = new System.Windows.Forms.Button();
            this.RightPanel.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // RightPanel
            // 
            this.RightPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.RightPanel.Controls.Add(this.labTempTime);
            this.RightPanel.Controls.Add(this.tbxTempTime);
            this.RightPanel.Controls.Add(this.tbxConInfo);
            this.RightPanel.Controls.Add(this.tbxGasTime);
            this.RightPanel.Controls.Add(this.tbxGas);
            this.RightPanel.Controls.Add(this.tbxTemp);
            this.RightPanel.Controls.Add(this.labGasTime);
            this.RightPanel.Controls.Add(this.labGas);
            this.RightPanel.Controls.Add(this.labTemp);
            this.RightPanel.Location = new System.Drawing.Point(204, 2);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(731, 557);
            this.RightPanel.TabIndex = 2;
            // 
            // labTempTime
            // 
            this.labTempTime.AutoSize = true;
            this.labTempTime.BackColor = System.Drawing.Color.RosyBrown;
            this.labTempTime.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTempTime.Location = new System.Drawing.Point(233, 23);
            this.labTempTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labTempTime.Name = "labTempTime";
            this.labTempTime.Size = new System.Drawing.Size(39, 19);
            this.labTempTime.TabIndex = 20;
            this.labTempTime.Text = "时间";
            // 
            // tbxTempTime
            // 
            this.tbxTempTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbxTempTime.Location = new System.Drawing.Point(165, 57);
            this.tbxTempTime.Margin = new System.Windows.Forms.Padding(2);
            this.tbxTempTime.Multiline = true;
            this.tbxTempTime.Name = "tbxTempTime";
            this.tbxTempTime.Size = new System.Drawing.Size(171, 418);
            this.tbxTempTime.TabIndex = 19;
            this.tbxTempTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxConInfo
            // 
            this.tbxConInfo.BackColor = System.Drawing.Color.White;
            this.tbxConInfo.Location = new System.Drawing.Point(14, 479);
            this.tbxConInfo.Margin = new System.Windows.Forms.Padding(2);
            this.tbxConInfo.Multiline = true;
            this.tbxConInfo.Name = "tbxConInfo";
            this.tbxConInfo.Size = new System.Drawing.Size(707, 69);
            this.tbxConInfo.TabIndex = 18;
            this.tbxConInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxGasTime
            // 
            this.tbxGasTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tbxGasTime.Location = new System.Drawing.Point(550, 57);
            this.tbxGasTime.Margin = new System.Windows.Forms.Padding(2);
            this.tbxGasTime.Multiline = true;
            this.tbxGasTime.Name = "tbxGasTime";
            this.tbxGasTime.Size = new System.Drawing.Size(171, 418);
            this.tbxGasTime.TabIndex = 17;
            this.tbxGasTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxGas
            // 
            this.tbxGas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbxGas.Location = new System.Drawing.Point(400, 57);
            this.tbxGas.Margin = new System.Windows.Forms.Padding(2);
            this.tbxGas.Multiline = true;
            this.tbxGas.Name = "tbxGas";
            this.tbxGas.Size = new System.Drawing.Size(137, 418);
            this.tbxGas.TabIndex = 16;
            this.tbxGas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxTemp
            // 
            this.tbxTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbxTemp.Location = new System.Drawing.Point(14, 57);
            this.tbxTemp.Margin = new System.Windows.Forms.Padding(2);
            this.tbxTemp.Multiline = true;
            this.tbxTemp.Name = "tbxTemp";
            this.tbxTemp.Size = new System.Drawing.Size(137, 418);
            this.tbxTemp.TabIndex = 15;
            this.tbxTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labGasTime
            // 
            this.labGasTime.AutoSize = true;
            this.labGasTime.BackColor = System.Drawing.Color.RosyBrown;
            this.labGasTime.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labGasTime.Location = new System.Drawing.Point(617, 23);
            this.labGasTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labGasTime.Name = "labGasTime";
            this.labGasTime.Size = new System.Drawing.Size(39, 19);
            this.labGasTime.TabIndex = 14;
            this.labGasTime.Text = "时间";
            // 
            // labGas
            // 
            this.labGas.AutoSize = true;
            this.labGas.BackColor = System.Drawing.Color.RosyBrown;
            this.labGas.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labGas.Location = new System.Drawing.Point(451, 23);
            this.labGas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labGas.Name = "labGas";
            this.labGas.Size = new System.Drawing.Size(39, 19);
            this.labGas.TabIndex = 13;
            this.labGas.Text = "气体";
            // 
            // labTemp
            // 
            this.labTemp.AutoSize = true;
            this.labTemp.BackColor = System.Drawing.Color.RosyBrown;
            this.labTemp.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labTemp.Location = new System.Drawing.Point(66, 23);
            this.labTemp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labTemp.Name = "labTemp";
            this.labTemp.Size = new System.Drawing.Size(39, 19);
            this.labTemp.TabIndex = 12;
            this.labTemp.Text = "温度";
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.RosyBrown;
            this.LeftPanel.Controls.Add(this.btnClearBuf);
            this.LeftPanel.Controls.Add(this.btnEsc);
            this.LeftPanel.Controls.Add(this.btnStopRecv);
            this.LeftPanel.Controls.Add(this.btnStratRecv);
            this.LeftPanel.Controls.Add(this.btnStartServer);
            this.LeftPanel.Location = new System.Drawing.Point(2, 2);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(202, 557);
            this.LeftPanel.TabIndex = 3;
            // 
            // btnClearBuf
            // 
            this.btnClearBuf.Location = new System.Drawing.Point(53, 331);
            this.btnClearBuf.Name = "btnClearBuf";
            this.btnClearBuf.Size = new System.Drawing.Size(88, 33);
            this.btnClearBuf.TabIndex = 14;
            this.btnClearBuf.Text = "清除缓存";
            this.btnClearBuf.UseVisualStyleBackColor = true;
            this.btnClearBuf.Click += new System.EventHandler(this.btnClearBuf_Click);
            // 
            // btnEsc
            // 
            this.btnEsc.Location = new System.Drawing.Point(53, 416);
            this.btnEsc.Name = "btnEsc";
            this.btnEsc.Size = new System.Drawing.Size(88, 33);
            this.btnEsc.TabIndex = 11;
            this.btnEsc.Text = "退出";
            this.btnEsc.UseVisualStyleBackColor = true;
            this.btnEsc.Click += new System.EventHandler(this.btnEsc_Click);
            // 
            // btnStopRecv
            // 
            this.btnStopRecv.Location = new System.Drawing.Point(53, 246);
            this.btnStopRecv.Name = "btnStopRecv";
            this.btnStopRecv.Size = new System.Drawing.Size(88, 33);
            this.btnStopRecv.TabIndex = 10;
            this.btnStopRecv.Text = "暂停接收";
            this.btnStopRecv.UseVisualStyleBackColor = true;
            this.btnStopRecv.Click += new System.EventHandler(this.btnStopRecv_Click);
            // 
            // btnStratRecv
            // 
            this.btnStratRecv.Location = new System.Drawing.Point(53, 161);
            this.btnStratRecv.Name = "btnStratRecv";
            this.btnStratRecv.Size = new System.Drawing.Size(88, 33);
            this.btnStratRecv.TabIndex = 9;
            this.btnStratRecv.Text = "开始接收";
            this.btnStratRecv.UseVisualStyleBackColor = true;
            this.btnStratRecv.Click += new System.EventHandler(this.btnStratRecv_Click);
            // 
            // btnStartServer
            // 
            this.btnStartServer.Location = new System.Drawing.Point(53, 76);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(88, 33);
            this.btnStartServer.TabIndex = 8;
            this.btnStartServer.Text = "开启服务器";
            this.btnStartServer.UseVisualStyleBackColor = true;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 563);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.RightPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.RightPanel.ResumeLayout(false);
            this.RightPanel.PerformLayout();
            this.LeftPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.Label labTempTime;
        private System.Windows.Forms.TextBox tbxTempTime;
        private System.Windows.Forms.TextBox tbxConInfo;
        private System.Windows.Forms.TextBox tbxGasTime;
        private System.Windows.Forms.TextBox tbxGas;
        private System.Windows.Forms.TextBox tbxTemp;
        private System.Windows.Forms.Label labGasTime;
        private System.Windows.Forms.Label labGas;
        private System.Windows.Forms.Label labTemp;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Button btnClearBuf;
        private System.Windows.Forms.Button btnEsc;
        private System.Windows.Forms.Button btnStopRecv;
        private System.Windows.Forms.Button btnStratRecv;
        private System.Windows.Forms.Button btnStartServer;
    }
}

