namespace 桌面倒计时
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.首页ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.时间设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开机自启ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重新启动ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.最小化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainwindow = new System.Windows.Forms.Panel();
            this.window_st = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.checkBox_右上角 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.mainwindow.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.菜单ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(400, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            this.menuStrip1.MouseLeave += new System.EventHandler(this.menuStrip1_MouseLeave);
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseMove);
            this.menuStrip1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseUp);
            // 
            // 菜单ToolStripMenuItem
            // 
            this.菜单ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.首页ToolStripMenuItem,
            this.时间设置ToolStripMenuItem,
            this.开机自启ToolStripMenuItem,
            this.重新启动ToolStripMenuItem,
            this.帮助ToolStripMenuItem,
            this.最小化ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.菜单ToolStripMenuItem.Name = "菜单ToolStripMenuItem";
            this.菜单ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.菜单ToolStripMenuItem.Text = "菜单";
            // 
            // 首页ToolStripMenuItem
            // 
            this.首页ToolStripMenuItem.Name = "首页ToolStripMenuItem";
            this.首页ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.首页ToolStripMenuItem.Text = "首页";
            this.首页ToolStripMenuItem.Click += new System.EventHandler(this.首页ToolStripMenuItem_Click);
            // 
            // 时间设置ToolStripMenuItem
            // 
            this.时间设置ToolStripMenuItem.Name = "时间设置ToolStripMenuItem";
            this.时间设置ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.时间设置ToolStripMenuItem.Text = "时间设置";
            this.时间设置ToolStripMenuItem.Click += new System.EventHandler(this.时间设置ToolStripMenuItem_Click);
            // 
            // 开机自启ToolStripMenuItem
            // 
            this.开机自启ToolStripMenuItem.Name = "开机自启ToolStripMenuItem";
            this.开机自启ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.开机自启ToolStripMenuItem.Text = "开机自启";
            this.开机自启ToolStripMenuItem.CheckedChanged += new System.EventHandler(this.开机自启ToolStripMenuItem_CheckedChanged);
            this.开机自启ToolStripMenuItem.Click += new System.EventHandler(this.开机自启ToolStripMenuItem_Click);
            // 
            // 重新启动ToolStripMenuItem
            // 
            this.重新启动ToolStripMenuItem.Name = "重新启动ToolStripMenuItem";
            this.重新启动ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.重新启动ToolStripMenuItem.Text = "重新启动";
            this.重新启动ToolStripMenuItem.DropDownOpening += new System.EventHandler(this.重新启动ToolStripMenuItem_DropDownOpening);
            this.重新启动ToolStripMenuItem.Click += new System.EventHandler(this.重新启动ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.帮助ToolStripMenuItem.Text = "帮助";
            this.帮助ToolStripMenuItem.Click += new System.EventHandler(this.帮助ToolStripMenuItem_Click);
            // 
            // 最小化ToolStripMenuItem
            // 
            this.最小化ToolStripMenuItem.Name = "最小化ToolStripMenuItem";
            this.最小化ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.最小化ToolStripMenuItem.Text = "最小化";
            this.最小化ToolStripMenuItem.Click += new System.EventHandler(this.最小化ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // mainwindow
            // 
            this.mainwindow.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.mainwindow.Controls.Add(this.window_st);
            this.mainwindow.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.mainwindow.Location = new System.Drawing.Point(0, 28);
            this.mainwindow.Name = "mainwindow";
            this.mainwindow.Size = new System.Drawing.Size(400, 105);
            this.mainwindow.TabIndex = 2;
            // 
            // window_st
            // 
            this.window_st.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.window_st.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.window_st.ForeColor = System.Drawing.SystemColors.WindowText;
            this.window_st.Location = new System.Drawing.Point(3, 3);
            this.window_st.Name = "window_st";
            this.window_st.Size = new System.Drawing.Size(394, 99);
            this.window_st.TabIndex = 1;
            this.window_st.Paint += new System.Windows.Forms.PaintEventHandler(this.window_st_Paint);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.Location = new System.Drawing.Point(349, 5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 16);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "置顶";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // checkBox_右上角
            // 
            this.checkBox_右上角.AutoSize = true;
            this.checkBox_右上角.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.checkBox_右上角.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_右上角.Location = new System.Drawing.Point(283, 5);
            this.checkBox_右上角.Name = "checkBox_右上角";
            this.checkBox_右上角.Size = new System.Drawing.Size(60, 16);
            this.checkBox_右上角.TabIndex = 4;
            this.checkBox_右上角.Text = "Center";
            this.checkBox_右上角.UseVisualStyleBackColor = false;
            this.checkBox_右上角.Click += new System.EventHandler(this.checkBox_右上角_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("隶书", 15F);
            this.label1.Location = new System.Drawing.Point(103, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(139, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "仲恺中学";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(400, 135);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox_右上角);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.mainwindow);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 265);
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "桌面倒计时_Yang";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainwindow.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 菜单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 首页ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 时间设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.Panel mainwindow;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel window_st;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.CheckBox checkBox_右上角;
        private System.Windows.Forms.ToolStripMenuItem 最小化ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem 开机自启ToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem 重新启动ToolStripMenuItem;
    }
}

