namespace ShutdownTimer
{
    partial class ShutdownTimer
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShutdownTimer));
            this.buttonShutdown = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.checkBoxReboot = new System.Windows.Forms.CheckBox();
            this.textBoxTHour = new System.Windows.Forms.TextBox();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.labelTHour = new System.Windows.Forms.Label();
            this.labelTMIN = new System.Windows.Forms.Label();
            this.textBoxTMin = new System.Windows.Forms.TextBox();
            this.textBoxTSec = new System.Windows.Forms.TextBox();
            this.labelTSec = new System.Windows.Forms.Label();
            this.textBoxDYear = new System.Windows.Forms.TextBox();
            this.labelDAD = new System.Windows.Forms.Label();
            this.labelDYear = new System.Windows.Forms.Label();
            this.textBoxDMonth = new System.Windows.Forms.TextBox();
            this.labelDMonth = new System.Windows.Forms.Label();
            this.labelDDate = new System.Windows.Forms.Label();
            this.textBoxDDate = new System.Windows.Forms.TextBox();
            this.labelDHour = new System.Windows.Forms.Label();
            this.textBoxDHour = new System.Windows.Forms.TextBox();
            this.labelDMin = new System.Windows.Forms.Label();
            this.textBoxDMin = new System.Windows.Forms.TextBox();
            this.groupBoxShutdown = new System.Windows.Forms.GroupBox();
            this.radioButtonSoon = new System.Windows.Forms.RadioButton();
            this.radioButtonDate = new System.Windows.Forms.RadioButton();
            this.radioButtonTimer = new System.Windows.Forms.RadioButton();
            this.groupBoxSetting = new System.Windows.Forms.GroupBox();
            this.groupBoxShutdown.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonShutdown
            // 
            this.buttonShutdown.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonShutdown.Location = new System.Drawing.Point(99, 429);
            this.buttonShutdown.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonShutdown.Name = "buttonShutdown";
            this.buttonShutdown.Size = new System.Drawing.Size(271, 95);
            this.buttonShutdown.TabIndex = 0;
            this.buttonShutdown.Text = "シャットダウン予約";
            this.buttonShutdown.UseVisualStyleBackColor = true;
            this.buttonShutdown.Click += new System.EventHandler(this.buttonShutdown_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonCancel.Location = new System.Drawing.Point(552, 429);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(271, 95);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "シャットダウン予約の取り消し";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // checkBoxReboot
            // 
            this.checkBoxReboot.AutoSize = true;
            this.checkBoxReboot.Font = new System.Drawing.Font("游ゴシック", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBoxReboot.Location = new System.Drawing.Point(99, 357);
            this.checkBoxReboot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxReboot.Name = "checkBoxReboot";
            this.checkBoxReboot.Size = new System.Drawing.Size(283, 24);
            this.checkBoxReboot.TabIndex = 2;
            this.checkBoxReboot.Text = "シャットダウンの代わりに再起動する";
            this.checkBoxReboot.UseVisualStyleBackColor = true;
            // 
            // textBoxTHour
            // 
            this.textBoxTHour.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxTHour.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBoxTHour.Location = new System.Drawing.Point(99, 92);
            this.textBoxTHour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTHour.MaxLength = 2;
            this.textBoxTHour.Name = "textBoxTHour";
            this.textBoxTHour.Size = new System.Drawing.Size(51, 27);
            this.textBoxTHour.TabIndex = 3;
            this.textBoxTHour.Text = "1";
            this.textBoxTHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // labelTHour
            // 
            this.labelTHour.AutoSize = true;
            this.labelTHour.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTHour.Location = new System.Drawing.Point(157, 96);
            this.labelTHour.Name = "labelTHour";
            this.labelTHour.Size = new System.Drawing.Size(39, 20);
            this.labelTHour.TabIndex = 5;
            this.labelTHour.Text = "時間";
            // 
            // labelTMIN
            // 
            this.labelTMIN.AutoSize = true;
            this.labelTMIN.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTMIN.Location = new System.Drawing.Point(266, 96);
            this.labelTMIN.Name = "labelTMIN";
            this.labelTMIN.Size = new System.Drawing.Size(24, 20);
            this.labelTMIN.TabIndex = 7;
            this.labelTMIN.Text = "分";
            // 
            // textBoxTMin
            // 
            this.textBoxTMin.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxTMin.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBoxTMin.Location = new System.Drawing.Point(210, 92);
            this.textBoxTMin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTMin.MaxLength = 2;
            this.textBoxTMin.Name = "textBoxTMin";
            this.textBoxTMin.Size = new System.Drawing.Size(51, 27);
            this.textBoxTMin.TabIndex = 6;
            this.textBoxTMin.Text = "0";
            this.textBoxTMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxTSec
            // 
            this.textBoxTSec.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxTSec.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBoxTSec.Location = new System.Drawing.Point(301, 92);
            this.textBoxTSec.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTSec.MaxLength = 2;
            this.textBoxTSec.Name = "textBoxTSec";
            this.textBoxTSec.Size = new System.Drawing.Size(51, 27);
            this.textBoxTSec.TabIndex = 8;
            this.textBoxTSec.Text = "0";
            this.textBoxTSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelTSec
            // 
            this.labelTSec.AutoSize = true;
            this.labelTSec.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelTSec.Location = new System.Drawing.Point(359, 96);
            this.labelTSec.Name = "labelTSec";
            this.labelTSec.Size = new System.Drawing.Size(127, 20);
            this.labelTSec.TabIndex = 9;
            this.labelTSec.Text = "秒後にシャットダウン";
            // 
            // textBoxDYear
            // 
            this.textBoxDYear.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxDYear.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBoxDYear.Location = new System.Drawing.Point(152, 198);
            this.textBoxDYear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDYear.MaxLength = 4;
            this.textBoxDYear.Name = "textBoxDYear";
            this.textBoxDYear.Size = new System.Drawing.Size(67, 27);
            this.textBoxDYear.TabIndex = 13;
            this.textBoxDYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelDAD
            // 
            this.labelDAD.AutoSize = true;
            this.labelDAD.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelDAD.Location = new System.Drawing.Point(99, 202);
            this.labelDAD.Name = "labelDAD";
            this.labelDAD.Size = new System.Drawing.Size(39, 20);
            this.labelDAD.TabIndex = 14;
            this.labelDAD.Text = "西暦";
            // 
            // labelDYear
            // 
            this.labelDYear.AutoSize = true;
            this.labelDYear.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelDYear.Location = new System.Drawing.Point(226, 202);
            this.labelDYear.Name = "labelDYear";
            this.labelDYear.Size = new System.Drawing.Size(24, 20);
            this.labelDYear.TabIndex = 15;
            this.labelDYear.Text = "年";
            // 
            // textBoxDMonth
            // 
            this.textBoxDMonth.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxDMonth.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBoxDMonth.Location = new System.Drawing.Point(261, 198);
            this.textBoxDMonth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDMonth.MaxLength = 2;
            this.textBoxDMonth.Name = "textBoxDMonth";
            this.textBoxDMonth.Size = new System.Drawing.Size(47, 27);
            this.textBoxDMonth.TabIndex = 16;
            this.textBoxDMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelDMonth
            // 
            this.labelDMonth.AutoSize = true;
            this.labelDMonth.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelDMonth.Location = new System.Drawing.Point(316, 202);
            this.labelDMonth.Name = "labelDMonth";
            this.labelDMonth.Size = new System.Drawing.Size(24, 20);
            this.labelDMonth.TabIndex = 17;
            this.labelDMonth.Text = "月";
            // 
            // labelDDate
            // 
            this.labelDDate.AutoSize = true;
            this.labelDDate.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelDDate.Location = new System.Drawing.Point(400, 202);
            this.labelDDate.Name = "labelDDate";
            this.labelDDate.Size = new System.Drawing.Size(24, 20);
            this.labelDDate.TabIndex = 19;
            this.labelDDate.Text = "日";
            // 
            // textBoxDDate
            // 
            this.textBoxDDate.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxDDate.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBoxDDate.Location = new System.Drawing.Point(346, 198);
            this.textBoxDDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDDate.MaxLength = 2;
            this.textBoxDDate.Name = "textBoxDDate";
            this.textBoxDDate.Size = new System.Drawing.Size(46, 27);
            this.textBoxDDate.TabIndex = 18;
            this.textBoxDDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelDHour
            // 
            this.labelDHour.AutoSize = true;
            this.labelDHour.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelDHour.Location = new System.Drawing.Point(485, 202);
            this.labelDHour.Name = "labelDHour";
            this.labelDHour.Size = new System.Drawing.Size(24, 20);
            this.labelDHour.TabIndex = 21;
            this.labelDHour.Text = "時";
            // 
            // textBoxDHour
            // 
            this.textBoxDHour.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxDHour.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBoxDHour.Location = new System.Drawing.Point(435, 198);
            this.textBoxDHour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDHour.MaxLength = 2;
            this.textBoxDHour.Name = "textBoxDHour";
            this.textBoxDHour.Size = new System.Drawing.Size(46, 27);
            this.textBoxDHour.TabIndex = 20;
            this.textBoxDHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelDMin
            // 
            this.labelDMin.AutoSize = true;
            this.labelDMin.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelDMin.Location = new System.Drawing.Point(570, 202);
            this.labelDMin.Name = "labelDMin";
            this.labelDMin.Size = new System.Drawing.Size(112, 20);
            this.labelDMin.TabIndex = 23;
            this.labelDMin.Text = "分にシャットダウン";
            // 
            // textBoxDMin
            // 
            this.textBoxDMin.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxDMin.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBoxDMin.Location = new System.Drawing.Point(520, 198);
            this.textBoxDMin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDMin.MaxLength = 2;
            this.textBoxDMin.Name = "textBoxDMin";
            this.textBoxDMin.Size = new System.Drawing.Size(46, 27);
            this.textBoxDMin.TabIndex = 22;
            this.textBoxDMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBoxShutdown
            // 
            this.groupBoxShutdown.Controls.Add(this.radioButtonSoon);
            this.groupBoxShutdown.Controls.Add(this.radioButtonDate);
            this.groupBoxShutdown.Controls.Add(this.radioButtonTimer);
            this.groupBoxShutdown.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBoxShutdown.Location = new System.Drawing.Point(54, 11);
            this.groupBoxShutdown.Name = "groupBoxShutdown";
            this.groupBoxShutdown.Size = new System.Drawing.Size(815, 292);
            this.groupBoxShutdown.TabIndex = 25;
            this.groupBoxShutdown.TabStop = false;
            this.groupBoxShutdown.Text = "シャットダウン時間設定";
            // 
            // radioButtonSoon
            // 
            this.radioButtonSoon.AutoSize = true;
            this.radioButtonSoon.Location = new System.Drawing.Point(42, 244);
            this.radioButtonSoon.Name = "radioButtonSoon";
            this.radioButtonSoon.Size = new System.Drawing.Size(140, 24);
            this.radioButtonSoon.TabIndex = 3;
            this.radioButtonSoon.TabStop = true;
            this.radioButtonSoon.Text = "今すぐシャットダウン";
            this.radioButtonSoon.UseVisualStyleBackColor = true;
            // 
            // radioButtonDate
            // 
            this.radioButtonDate.AutoSize = true;
            this.radioButtonDate.Location = new System.Drawing.Point(42, 156);
            this.radioButtonDate.Name = "radioButtonDate";
            this.radioButtonDate.Size = new System.Drawing.Size(110, 24);
            this.radioButtonDate.TabIndex = 2;
            this.radioButtonDate.TabStop = true;
            this.radioButtonDate.Text = "時間指定する";
            this.radioButtonDate.UseVisualStyleBackColor = true;
            // 
            // radioButtonTimer
            // 
            this.radioButtonTimer.AutoSize = true;
            this.radioButtonTimer.Location = new System.Drawing.Point(42, 50);
            this.radioButtonTimer.Name = "radioButtonTimer";
            this.radioButtonTimer.Size = new System.Drawing.Size(123, 24);
            this.radioButtonTimer.TabIndex = 1;
            this.radioButtonTimer.TabStop = true;
            this.radioButtonTimer.Text = "タイマー指定する";
            this.radioButtonTimer.UseVisualStyleBackColor = true;
            // 
            // groupBoxSetting
            // 
            this.groupBoxSetting.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBoxSetting.Location = new System.Drawing.Point(54, 310);
            this.groupBoxSetting.Name = "groupBoxSetting";
            this.groupBoxSetting.Size = new System.Drawing.Size(815, 100);
            this.groupBoxSetting.TabIndex = 26;
            this.groupBoxSetting.TabStop = false;
            this.groupBoxSetting.Text = "詳細設定";
            // 
            // ShutdownTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 562);
            this.Controls.Add(this.labelDMin);
            this.Controls.Add(this.textBoxDMin);
            this.Controls.Add(this.labelDHour);
            this.Controls.Add(this.textBoxDHour);
            this.Controls.Add(this.labelDDate);
            this.Controls.Add(this.textBoxDDate);
            this.Controls.Add(this.labelDMonth);
            this.Controls.Add(this.textBoxDMonth);
            this.Controls.Add(this.labelDYear);
            this.Controls.Add(this.labelDAD);
            this.Controls.Add(this.textBoxDYear);
            this.Controls.Add(this.labelTSec);
            this.Controls.Add(this.textBoxTSec);
            this.Controls.Add(this.labelTMIN);
            this.Controls.Add(this.textBoxTMin);
            this.Controls.Add(this.labelTHour);
            this.Controls.Add(this.textBoxTHour);
            this.Controls.Add(this.checkBoxReboot);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonShutdown);
            this.Controls.Add(this.groupBoxShutdown);
            this.Controls.Add(this.groupBoxSetting);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ShutdownTimer";
            this.Text = "シャットダウンタイマー";
            this.groupBoxShutdown.ResumeLayout(false);
            this.groupBoxShutdown.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonShutdown;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.CheckBox checkBoxReboot;
        private System.Windows.Forms.TextBox textBoxTHour;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Label labelTHour;
        private System.Windows.Forms.Label labelTMIN;
        private System.Windows.Forms.TextBox textBoxTMin;
        private System.Windows.Forms.TextBox textBoxTSec;
        private System.Windows.Forms.Label labelTSec;
        private System.Windows.Forms.TextBox textBoxDYear;
        private System.Windows.Forms.Label labelDAD;
        private System.Windows.Forms.Label labelDYear;
        private System.Windows.Forms.TextBox textBoxDMonth;
        private System.Windows.Forms.Label labelDMonth;
        private System.Windows.Forms.Label labelDDate;
        private System.Windows.Forms.TextBox textBoxDDate;
        private System.Windows.Forms.Label labelDHour;
        private System.Windows.Forms.TextBox textBoxDHour;
        private System.Windows.Forms.Label labelDMin;
        private System.Windows.Forms.TextBox textBoxDMin;
        private System.Windows.Forms.GroupBox groupBoxShutdown;
        private System.Windows.Forms.RadioButton radioButtonSoon;
        private System.Windows.Forms.RadioButton radioButtonDate;
        private System.Windows.Forms.RadioButton radioButtonTimer;
        private System.Windows.Forms.GroupBox groupBoxSetting;
    }
}

