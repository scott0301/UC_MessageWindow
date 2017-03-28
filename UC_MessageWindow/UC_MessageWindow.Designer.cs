namespace UC_MessageWindow
{
    partial class UC_BACKPANEL
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.RICH_MESSAGE_WINDOW = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // RICH_MESSAGE_WINDOW
            // 
            this.RICH_MESSAGE_WINDOW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.RICH_MESSAGE_WINDOW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RICH_MESSAGE_WINDOW.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.RICH_MESSAGE_WINDOW.ForeColor = System.Drawing.Color.Lime;
            this.RICH_MESSAGE_WINDOW.Location = new System.Drawing.Point(0, 0);
            this.RICH_MESSAGE_WINDOW.Name = "RICH_MESSAGE_WINDOW";
            this.RICH_MESSAGE_WINDOW.Size = new System.Drawing.Size(500, 250);
            this.RICH_MESSAGE_WINDOW.TabIndex = 0;
            this.RICH_MESSAGE_WINDOW.Text = "";
            // 
            // UC_BACKPANEL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RICH_MESSAGE_WINDOW);
            this.Font = new System.Drawing.Font("Verdana", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))));
            this.Name = "UC_BACKPANEL";
            this.Size = new System.Drawing.Size(500, 250);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox RICH_MESSAGE_WINDOW;
    }
}
