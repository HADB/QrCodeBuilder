namespace QrCodeBuilder.WinForm
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.qrCodeGraphicControl = new Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeGraphicControl();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SelectDarkColorButton = new System.Windows.Forms.Button();
            this.SelectLightColorButton = new System.Windows.Forms.Button();
            this.ErrorCorrectLevelComboBox = new System.Windows.Forms.ComboBox();
            this.BackgroundTransparentCheckBox = new System.Windows.Forms.CheckBox();
            this.QuietZoneComboBox = new System.Windows.Forms.ComboBox();
            this.SizeTextBox = new System.Windows.Forms.TextBox();
            this.ExportButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // qrCodeGraphicControl
            // 
            this.qrCodeGraphicControl.ErrorCorrectLevel = Gma.QrCodeNet.Encoding.ErrorCorrectionLevel.M;
            this.qrCodeGraphicControl.Location = new System.Drawing.Point(13, 145);
            this.qrCodeGraphicControl.Margin = new System.Windows.Forms.Padding(4);
            this.qrCodeGraphicControl.Name = "qrCodeGraphicControl";
            this.qrCodeGraphicControl.QuietZoneModule = Gma.QrCodeNet.Encoding.Windows.Render.QuietZoneModules.Two;
            this.qrCodeGraphicControl.Size = new System.Drawing.Size(248, 248);
            this.qrCodeGraphicControl.TabIndex = 1;
            this.qrCodeGraphicControl.Text = "Hello, World! by Bean.";
            // 
            // InputTextBox
            // 
            this.InputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputTextBox.Location = new System.Drawing.Point(16, 18);
            this.InputTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.InputTextBox.Multiline = true;
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(592, 96);
            this.InputTextBox.TabIndex = 0;
            this.InputTextBox.TextChanged += new System.EventHandler(this.InputTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(360, 162);
            this.label1.Margin = new System.Windows.Forms.Padding(10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "前景色：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 201);
            this.label2.Margin = new System.Windows.Forms.Padding(10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "背景色：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 240);
            this.label3.Margin = new System.Windows.Forms.Padding(10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "纠错级别：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 279);
            this.label4.Margin = new System.Windows.Forms.Padding(10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = " 边缘空白：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(347, 318);
            this.label5.Margin = new System.Windows.Forms.Padding(10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "导出边长：";
            // 
            // SelectDarkColorButton
            // 
            this.SelectDarkColorButton.AutoSize = true;
            this.SelectDarkColorButton.Location = new System.Drawing.Point(434, 157);
            this.SelectDarkColorButton.Name = "SelectDarkColorButton";
            this.SelectDarkColorButton.Size = new System.Drawing.Size(121, 29);
            this.SelectDarkColorButton.TabIndex = 1;
            this.SelectDarkColorButton.Text = "选取";
            this.SelectDarkColorButton.UseVisualStyleBackColor = true;
            this.SelectDarkColorButton.Click += new System.EventHandler(this.SelectDarkColorButton_Click);
            // 
            // SelectLightColorButton
            // 
            this.SelectLightColorButton.AutoSize = true;
            this.SelectLightColorButton.Location = new System.Drawing.Point(434, 196);
            this.SelectLightColorButton.Name = "SelectLightColorButton";
            this.SelectLightColorButton.Size = new System.Drawing.Size(121, 29);
            this.SelectLightColorButton.TabIndex = 2;
            this.SelectLightColorButton.Text = "选取";
            this.SelectLightColorButton.UseVisualStyleBackColor = true;
            this.SelectLightColorButton.Click += new System.EventHandler(this.SelectLightColorButton_Click);
            // 
            // ErrorCorrectLevelComboBox
            // 
            this.ErrorCorrectLevelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ErrorCorrectLevelComboBox.FormattingEnabled = true;
            this.ErrorCorrectLevelComboBox.Items.AddRange(new object[] {
            "L",
            "M",
            "Q",
            "H"});
            this.ErrorCorrectLevelComboBox.Location = new System.Drawing.Point(434, 237);
            this.ErrorCorrectLevelComboBox.Name = "ErrorCorrectLevelComboBox";
            this.ErrorCorrectLevelComboBox.Size = new System.Drawing.Size(121, 27);
            this.ErrorCorrectLevelComboBox.TabIndex = 4;
            this.ErrorCorrectLevelComboBox.SelectedIndexChanged += new System.EventHandler(this.ErrorCorrectLevelComboBox_SelectedIndexChanged);
            // 
            // BackgroundTransparentCheckBox
            // 
            this.BackgroundTransparentCheckBox.AutoSize = true;
            this.BackgroundTransparentCheckBox.Location = new System.Drawing.Point(561, 200);
            this.BackgroundTransparentCheckBox.Name = "BackgroundTransparentCheckBox";
            this.BackgroundTransparentCheckBox.Size = new System.Drawing.Size(54, 23);
            this.BackgroundTransparentCheckBox.TabIndex = 3;
            this.BackgroundTransparentCheckBox.Text = "透明";
            this.BackgroundTransparentCheckBox.UseVisualStyleBackColor = true;
            this.BackgroundTransparentCheckBox.CheckedChanged += new System.EventHandler(this.BackgroundTransparentCheckBox_CheckedChanged);
            // 
            // QuietZoneComboBox
            // 
            this.QuietZoneComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.QuietZoneComboBox.FormattingEnabled = true;
            this.QuietZoneComboBox.Items.AddRange(new object[] {
            "无",
            "默认",
            "多"});
            this.QuietZoneComboBox.Location = new System.Drawing.Point(434, 276);
            this.QuietZoneComboBox.Name = "QuietZoneComboBox";
            this.QuietZoneComboBox.Size = new System.Drawing.Size(121, 27);
            this.QuietZoneComboBox.TabIndex = 5;
            this.QuietZoneComboBox.SelectedIndexChanged += new System.EventHandler(this.QuietZoneComboBox_SelectedIndexChanged);
            // 
            // SizeTextBox
            // 
            this.SizeTextBox.Location = new System.Drawing.Point(434, 315);
            this.SizeTextBox.Name = "SizeTextBox";
            this.SizeTextBox.Size = new System.Drawing.Size(91, 25);
            this.SizeTextBox.TabIndex = 6;
            this.SizeTextBox.Text = "100";
            // 
            // ExportButton
            // 
            this.ExportButton.AutoSize = true;
            this.ExportButton.Location = new System.Drawing.Point(434, 355);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(121, 29);
            this.ExportButton.TabIndex = 11;
            this.ExportButton.Text = "导出";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(531, 318);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "px";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 406);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SizeTextBox);
            this.Controls.Add(this.BackgroundTransparentCheckBox);
            this.Controls.Add(this.QuietZoneComboBox);
            this.Controls.Add(this.ErrorCorrectLevelComboBox);
            this.Controls.Add(this.SelectLightColorButton);
            this.Controls.Add(this.SelectDarkColorButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.qrCodeGraphicControl);
            this.Controls.Add(this.InputTextBox);
            this.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "二维码生成器";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Gma.QrCodeNet.Encoding.Windows.Forms.QrCodeGraphicControl qrCodeGraphicControl;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button SelectDarkColorButton;
        private System.Windows.Forms.Button SelectLightColorButton;
        private System.Windows.Forms.ComboBox ErrorCorrectLevelComboBox;
        private System.Windows.Forms.CheckBox BackgroundTransparentCheckBox;
        private System.Windows.Forms.ComboBox QuietZoneComboBox;
        private System.Windows.Forms.TextBox SizeTextBox;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.Label label6;
    }
}

