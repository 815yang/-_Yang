namespace 桌面倒计时
{
    partial class outdate
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_longdate = new System.Windows.Forms.Label();
            this.textBox_put = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBox_longdate);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 29);
            this.panel2.TabIndex = 3;
            // 
            // textBox_longdate
            // 
            this.textBox_longdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_longdate.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.textBox_longdate.ForeColor = System.Drawing.Color.Black;
            this.textBox_longdate.Location = new System.Drawing.Point(3, 0);
            this.textBox_longdate.Name = "textBox_longdate";
            this.textBox_longdate.Size = new System.Drawing.Size(388, 29);
            this.textBox_longdate.TabIndex = 0;
            this.textBox_longdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox_put
            // 
            this.textBox_put.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_put.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_put.Font = new System.Drawing.Font("楷体", 49F);
            this.textBox_put.ForeColor = System.Drawing.Color.Red;
            this.textBox_put.Location = new System.Drawing.Point(3, 32);
            this.textBox_put.Name = "textBox_put";
            this.textBox_put.Size = new System.Drawing.Size(388, 65);
            this.textBox_put.TabIndex = 4;
            this.textBox_put.Text = "珍惜时间";
            this.textBox_put.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox_put);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "outdate";
            this.Size = new System.Drawing.Size(394, 99);
            this.Load += new System.EventHandler(this.outdate_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Label textBox_longdate;
        public System.Windows.Forms.Label textBox_put;
    }
}
