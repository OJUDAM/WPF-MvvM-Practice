namespace WinFormMultiComboChange
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
            this.cbxDiv = new System.Windows.Forms.ComboBox();
            this.cbxComCd = new System.Windows.Forms.ComboBox();
            this.lblSelected = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxDiv
            // 
            this.cbxDiv.FormattingEnabled = true;
            this.cbxDiv.Location = new System.Drawing.Point(87, 45);
            this.cbxDiv.Name = "cbxDiv";
            this.cbxDiv.Size = new System.Drawing.Size(185, 23);
            this.cbxDiv.TabIndex = 0;
            this.cbxDiv.SelectedValueChanged += new System.EventHandler(this.cbxDiv_SelectedValueChanged);
            // 
            // cbxComCd
            // 
            this.cbxComCd.FormattingEnabled = true;
            this.cbxComCd.Location = new System.Drawing.Point(333, 45);
            this.cbxComCd.Name = "cbxComCd";
            this.cbxComCd.Size = new System.Drawing.Size(185, 23);
            this.cbxComCd.TabIndex = 1;
            this.cbxComCd.SelectedValueChanged += new System.EventHandler(this.cbxComCd_SelectedValueChanged);
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.Location = new System.Drawing.Point(603, 48);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(45, 15);
            this.lblSelected.TabIndex = 2;
            this.lblSelected.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 140);
            this.Controls.Add(this.lblSelected);
            this.Controls.Add(this.cbxComCd);
            this.Controls.Add(this.cbxDiv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxDiv;
        private System.Windows.Forms.ComboBox cbxComCd;
        private System.Windows.Forms.Label lblSelected;
    }
}

