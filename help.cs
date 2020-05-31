using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 桌面倒计时
{
    public partial class help : UserControl
    {
        public help()
        {
            InitializeComponent();
            string text = "事件设置框不得输入特殊、标点、数学符号,如需扩展联系作者\r\n\r\n" +"程序初始坐标是上一次关闭时的坐标\r\n\r\n"+ "作者:Mr_Yang\r\n\r\n" + "版权归作者:Mr_Yang所有\r\n\r\n" +"请尊重作者知识产权,未经作者同意不得传播此程序\r\n\r\n"+ "最后修改时间:2020/5/30";
            textBox1.Text = text;
            /* textBox1.AppendText("作者:Mr_Yang\r\n");
            textBox1.AppendText("联系方式:yf468772061@outlook.com\r\n");
            textBox1.AppendText("请尊重作者知识产权,未经作者同意不得传播此程序\r\n");
            textBox1.AppendText("版权归作者:Mr_Yang所有\r\n");
            textBox1.AppendText("为了保证程序能正常运行事件设置框只能输入汉字和Back键，如需扩展联系作者\r\n");
            textBox1.AppendText("An inch of time is worth an inch of gold\r\n");
            textBox1.AppendText("一寸光阴一寸金\r\n");
            textBox1.AppendText("请善待时间~~\r\n");*/
        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
