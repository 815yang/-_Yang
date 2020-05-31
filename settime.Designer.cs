namespace 桌面倒计时
{
    partial class settime
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_thing = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_day = new System.Windows.Forms.ComboBox();
            this.comboBox_month = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_save = new System.Windows.Forms.CheckBox();
            this.ComboBox_year = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "请选择目标日期";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "输入目标事件";
            // 
            // comboBox_thing
            // 
            this.comboBox_thing.FormattingEnabled = true;
            this.comboBox_thing.Location = new System.Drawing.Point(89, 9);
            this.comboBox_thing.MaxLength = 6;
            this.comboBox_thing.Name = "comboBox_thing";
            this.comboBox_thing.Size = new System.Drawing.Size(121, 20);
            this.comboBox_thing.TabIndex = 13;
            this.comboBox_thing.SelectedIndexChanged += new System.EventHandler(this.comboBox_thing_SelectedIndexChanged);
            this.comboBox_thing.TextChanged += new System.EventHandler(this.comboBox_thing_TextChanged);
            this.comboBox_thing.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_thing_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "月";
            // 
            // comboBox_day
            // 
            this.comboBox_day.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_day.FormattingEnabled = true;
            this.comboBox_day.Location = new System.Drawing.Point(182, 5);
            this.comboBox_day.Name = "comboBox_day";
            this.comboBox_day.Size = new System.Drawing.Size(42, 20);
            this.comboBox_day.TabIndex = 3;
            this.comboBox_day.SelectedIndexChanged += new System.EventHandler(this.comboBox_day_SelectedIndexChanged_1);
            this.comboBox_day.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox_day_MouseClick);
            // 
            // comboBox_month
            // 
            this.comboBox_month.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_month.FormattingEnabled = true;
            this.comboBox_month.Location = new System.Drawing.Point(107, 5);
            this.comboBox_month.Name = "comboBox_month";
            this.comboBox_month.Size = new System.Drawing.Size(46, 20);
            this.comboBox_month.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "日";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "年";
            // 
            // checkBox_save
            // 
            this.checkBox_save.AutoSize = true;
            this.checkBox_save.Location = new System.Drawing.Point(253, 10);
            this.checkBox_save.Name = "checkBox_save";
            this.checkBox_save.Size = new System.Drawing.Size(48, 16);
            this.checkBox_save.TabIndex = 9;
            this.checkBox_save.Text = "确定";
            this.checkBox_save.UseVisualStyleBackColor = true;
            this.checkBox_save.CheckedChanged += new System.EventHandler(this.checkBox_save_CheckedChanged);
            this.checkBox_save.Click += new System.EventHandler(this.checkBox_save_Click);
            // 
            // ComboBox_year
            // 
            this.ComboBox_year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_year.FormattingEnabled = true;
            this.ComboBox_year.Location = new System.Drawing.Point(24, 5);
            this.ComboBox_year.Name = "ComboBox_year";
            this.ComboBox_year.Size = new System.Drawing.Size(54, 20);
            this.ComboBox_year.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ComboBox_year);
            this.panel1.Controls.Add(this.checkBox_save);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBox_month);
            this.panel1.Controls.Add(this.comboBox_day);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 33);
            this.panel1.TabIndex = 11;
            // 
            // settime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.comboBox_thing);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Name = "settime";
            this.Size = new System.Drawing.Size(394, 96);
            this.Load += new System.EventHandler(this.settime_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox comboBox_day;
        public System.Windows.Forms.ComboBox comboBox_month;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.CheckBox checkBox_save;
        public System.Windows.Forms.ComboBox ComboBox_year;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ComboBox comboBox_thing;
    }
}
