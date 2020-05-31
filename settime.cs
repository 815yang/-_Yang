using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Text.RegularExpressions;
using System.Threading;
using System.Runtime.InteropServices;
using System.IO.MemoryMappedFiles;
using System.Diagnostics;
using Microsoft.Win32;
namespace 桌面倒计时
{

    public partial class settime : UserControl
    {
        //string str = "";
        //public XML xml = new XML();
        //string Datecode = "1";
        public settime()
        {
            /*str = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "MyXML.xml";
            if (!System.IO.File.Exists(str))
            {
                MessageBox.Show("缺少配置文件!");
                Process.GetCurrentProcess().Kill();
            }*/
            InitializeComponent();
           /** XmlDocument myDoc = new XmlDocument();
            myDoc.Load(str);**/
            comboBox_thing.Items.Add("事件");
            comboBox_thing.Items.Add("中考");
            comboBox_thing.Items.Add("高考");
            comboBox_thing.Items.Add("会考");
            comboBox_thing.Items.Add("期中考");
            comboBox_thing.Items.Add("期末考");
            comboBox_thing.Items.Add("第一次月考");
            comboBox_thing.Items.Add("第二次月考");
            string[] year_1 = year();
            string[] month_1 = month();
            for (int i = 0; i < 12; i++)
            {
                ComboBox_year.Items.Add(year_1[i]);
                comboBox_month.Items.Add(month_1[i]);
            }
            RegistryKey myReg1, myReg2;
            //声明注册表对象          
            myReg1 = Registry.CurrentUser;

            //获取当前用户注册表项        
            try
            {
                myReg2 = myReg1.CreateSubKey("Software\\MySoft");
                //在注册表项中创建子项         
                ComboBox_year.Text = myReg2.GetValue("DateYear").ToString();
                comboBox_month.Text = myReg2.GetValue("DateMonth").ToString();
                comboBox_thing.Text = myReg2.GetValue("DateThing").ToString();
                string[] day_1 = day(int.Parse(ComboBox_year.Text), int.Parse(comboBox_month.Text));
                int n = day_num(int.Parse(ComboBox_year.Text), int.Parse(comboBox_month.Text));
                comboBox_day.Items.Clear();
                foreach (string i in day_1)
                {
                    if (i == null || i == "")
                    {
                        comboBox_day.Items.Remove(n + 1);
                        break;
                    }
                    else
                    {
                        comboBox_day.Items.Add(i);
                    }
                }
                comboBox_day.Text = myReg2.GetValue("DateDay").ToString();
            }
            catch
            {
                    myReg2 = myReg1.CreateSubKey("Software\\MySoft");
                    myReg2.SetValue("DateYear",DateTime.Now.Year);
                    myReg2.SetValue("DateMonth",DateTime.Now.Month);
                    myReg2.SetValue("DateDay", DateTime.Now.Day);
                    myReg2.SetValue("DateThing", "");
                    ComboBox_year.Text = DateTime.Now.Year.ToString();
                    comboBox_month.Text = DateTime.Now.Month.ToString();
                    string[] day_1 = day(int.Parse(ComboBox_year.Text), int.Parse(comboBox_month.Text));
                    int n = day_num(int.Parse(ComboBox_year.Text), int.Parse(comboBox_month.Text));
                    comboBox_day.Items.Clear();
                    foreach (string i in day_1)
                    {
                        if (i == null || i == "")
                        {
                            comboBox_day.Items.Remove(n + 1);
                            break;
                        }
                        else
                        {
                            comboBox_day.Items.Add(i);
                        }
                    }
                    comboBox_day.Text = DateTime.Now.Day.ToString();

            }


            


               /* System.Xml.XmlNodeList nodes = myDoc.SelectNodes("//Date");
                foreach (System.Xml.XmlNode xn in nodes)
                {
                    if (xn.SelectSingleNode("Datecode").InnerText == Datecode)
                    {
                        ComboBox_year.Text = xn.SelectSingleNode("DateYear").InnerText;
                        comboBox_month.Text = xn.SelectSingleNode("DateMonth").InnerText;
                        string[] day_1 = day(int.Parse(ComboBox_year.Text), int.Parse(comboBox_month.Text));
                        int n = day_num(int.Parse(ComboBox_year.Text), int.Parse(comboBox_month.Text));
                        comboBox_day.Items.Clear();
                        foreach (string i in day_1)
                        {
                            if (i == null || i == "")
                            {
                                comboBox_day.Items.Remove(n + 1);
                                break;
                            }
                            else
                            {
                                comboBox_day.Items.Add(i);
                            }
                        }
                        comboBox_day.Text = xn.SelectSingleNode("DateDay").InnerText;
                        comboBox_thing.Text = xn.SelectSingleNode("Datething").InnerText;
                    }
                    else
                    {
                        xml.WriteXML(str, DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString(), DateTime.Now.Day.ToString(), Datecode,"");
                        ComboBox_year.Text = xn.SelectSingleNode("DateYear").InnerText;
                        comboBox_month.Text = xn.SelectSingleNode("DateMonth").InnerText;
                        comboBox_thing.Text = xn.SelectSingleNode("Datething").InnerText;
                        string[] day_1 = day(int.Parse(ComboBox_year.Text), int.Parse(comboBox_month.Text));
                        int n = day_num(int.Parse(ComboBox_year.Text), int.Parse(comboBox_month.Text));
                        foreach (string i in day_1)
                        {
                            if (i == null || i == "")
                            {
                                comboBox_day.Items.Remove(n + 1);
                                break;
                            }
                            else
                            {
                                comboBox_day.Items.Add(i);
                            }
                        }
                        comboBox_day.Text = xn.SelectSingleNode("DateDay").InnerText;
                    }
                }   */
           
            checkBox_save.Checked = true;
            ComboBox_year.Enabled = false;
            comboBox_month.Enabled = false;
            comboBox_day.Enabled = false;

           

        }

        private void settime_Load(object sender, EventArgs e)
        {


        }

        private string[] year()
        {
            int now_year = DateTime.Now.Year;
            string[] array = new String[12];
            for (int i = 0; i < 12; i++)
            {
                array[i] = Convert.ToString(now_year + i);
            }
            return array;
        }
        private string[] month()
        {
            string[] array = new String[12];
            for (int i = 0; i < 12; i++)
            {
                array[i] = Convert.ToString(i + 1);
            }
            return array;
        }

        public string[] day(int year, int month)
        {
            int number = 0;
            string[] array = new string[day_num(year, month)];
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    {
                        //大月
                        number = 31;
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    {
                        //小月
                        number = 30;
                    }
                    break;
                case 2:
                    {
                        //是闰年的情况
                        if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                        {
                            number = 29;
                        }
                        else //不是闰年的情况
                        {
                            number = 28;

                        }
                    }
                    break;
            }
            for (int i = 0; i < number; i++)
            {
                array[i] = Convert.ToString(i + 1);
            }
            return array;
        }
        public int day_num(int year, int month)
        {
            int number = 0;
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    {
                        //大月
                        number = 31;
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    {
                        //小月
                        number = 30;
                    }
                    break;
                case 2:
                    {
                        //是闰年的情况
                        if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                        {
                            number = 29;
                        }
                        else //不是闰年的情况
                        {
                            number = 28;

                        }
                    }
                    break;
            }

            return number;
        }



        public bool save = true;
        private void checkBox_save_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_save.Checked == true)
            {
                /*if (xml.ifXML(str, Datecode) == false)
                {
                    xml.WriteXML(str, ComboBox_year.Text, comboBox_month.Text, comboBox_day.Text, Datecode, comboBox_thing.Text);
                }
                else
                {
                    xml.UpdateXML(str, ComboBox_year.Text, comboBox_month.Text, comboBox_day.Text, Datecode);
                    /**if(xml.ifdate(str,Datecode)==true)
                    {
                        xml.UpdateXML(str, ComboBox_year.Text, comboBox_month.Text, comboBox_day.Text, Datecode);
                    }
                    else
                    {
                        xml.UpdateXML(str, DateTime.Now.Year.ToString(), DateTime.Now.Month.ToString(), DateTime.Now.Day.ToString(), Datecode);
                    }**/                     
                RegistryKey myReg1, myReg2;        
            //声明注册表对象                     
                myReg1 = Registry.CurrentUser;   
            //获取当前用户注册表项                    
                myReg2 = myReg1.CreateSubKey("Software\\MySoft"); 
            //在注册表项中创建子项                      
                try                  
                {                                        
                    myReg2.SetValue("DateYear", ComboBox_year.Text);                 
                    myReg2.SetValue("DateMonth",comboBox_month.Text);                
                    myReg2.SetValue("DateDay",comboBox_day.Text);          
                }          
                catch                  
                {       
                }        
            }  
        }

        


        private void checkBox_save_Click(object sender, EventArgs e)
        {
            if (ComboBox_year.Text != "" && comboBox_month.Text != "" && comboBox_day.Text != "" && checkBox_save.Checked == false)
            {
                ComboBox_year.Enabled = true;
                comboBox_month.Enabled = true;
                comboBox_day.Enabled = true;
                save = true;
                return;
            }
            else
            {
                ComboBox_year.Enabled = false;
                comboBox_month.Enabled = false;
                comboBox_day.Enabled = false;
                save = false;
            }
            if ((ComboBox_year.Text == "" || comboBox_month.Text == "" || comboBox_day.Text == "") && save == false)
            {
                MessageBox.Show("日期不能为空！");
                checkBox_save.Checked = false;
                ComboBox_year.Enabled = true;
                comboBox_month.Enabled = true;
                comboBox_day.Enabled = true;
                save = true;
                return;
            }
            if (comboBox_day.Text == "")
            {
                MessageBox.Show("日期不能为空！");
                ComboBox_year.Enabled = true;
                comboBox_month.Enabled = true;
                comboBox_day.Enabled = true;
            }


            if (checkBox_save.Checked == true)
            {

                if (isdate() == false)
                {


                    MessageBox.Show("你所设置的日期已成为历史");
                    comboBox_day.Text = "";
                    checkBox_save.Checked = true;
                    ComboBox_year.Enabled = false;
                    comboBox_month.Enabled = false;
                    comboBox_day.Enabled = false;
                    return;
                }
            }



        }



        private int days_Count(int year, int month)
        {
            int day = 0;
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    {
                        //大月
                        day = 31;
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    {
                        //小月
                        day = 30;
                    }
                    break;
                case 2:
                    {
                        //是闰年的情况
                        if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                        {
                            day = 29;
                        }
                        else //不是闰年的情况
                        {
                            day = 28;

                        }
                    }
                    break;
            }

            return day;
        }

        private int nowday_count()
        {
            int nowday = DateTime.Now.Day;
            int nowmonth = DateTime.Now.Month;
            int nowyear = DateTime.Now.Month;
            int day_num = 0;
            int[] day = new int[nowmonth];
            for (int i = 1; i < nowmonth; i++)
            {
                day[i - 1] = days_Count(nowyear, i);
                day_num += day[i - 1];
            }
            day_num += nowday;
            return day_num;
        }
        private int longday_count()
        {
            int day_num = 0;
            if (ComboBox_year.Text != "" && comboBox_month.Text != "" && comboBox_day.Text != "")
            {

                int year = int.Parse(ComboBox_year.Text);
                int month = int.Parse(comboBox_month.Text);
                int day_1 = int.Parse(comboBox_day.Text);
                for (int i = 1; i < month; i++)
                {
                    day_num += days_Count(year, i);
                }
                day_num += day_1;
            }
            return day_num;
        }
        private int long_nowday(int nowyear, int longyear)
        {
            int days_count = 0;
            int yearrunnian_count = 0;
            int yearpingnian_count = 0;
            int i = longyear - nowyear;
            if (i > 0)
            {
                int[] year = new int[i];
                for (int q = 0; q < i; q++)
                {
                    year[q] = nowyear + q;
                }
                foreach (int a in year)
                {
                    if (a % 4 == 0 && a % 100 != 0 || a % 400 == 0)
                        yearrunnian_count++;
                    else
                        yearpingnian_count++;
                }

            }
            days_count = yearrunnian_count * 366 + yearpingnian_count * 365;
            return days_count;
        }
        public int result()
        {
            int nowyear = 0;
            int longyear = 0;
            int day = 0;
            if (checkBox_save.Checked == true)
            {
                nowyear = DateTime.Now.Year;
                longyear =Convert.ToInt32(ComboBox_year.Text);
                day = long_nowday(nowyear, longyear) + longday_count() - nowday_count() - 1;

            }
            return day;
        }
        public bool isdate()
        {
            int isyear = int.Parse(ComboBox_year.Text) - DateTime.Now.Year;
            int ismonth = int.Parse(comboBox_month.Text) - DateTime.Now.Month;
            int isday = int.Parse(comboBox_day.Text) - DateTime.Now.Day;
            if (isyear == 0)
            {
                if (ismonth == 0)
                {
                    if (isday < 0)
                    {
                        return false;
                    }
                }
                if (ismonth < 0)
                {
                    return false;
                }
            }
            if (isyear < 0)
            {
                return false;
            }
            return true;

        }


        private void comboBox_day_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox_thing_TextChanged(object sender, EventArgs e)
        {
            RegistryKey myReg1, myReg2;
            //声明注册表对象         
            myReg1 = Registry.CurrentUser;
            //获取当前用户注册表项         
            myReg2 = myReg1.CreateSubKey("Software\\MySoft");
            //在注册表项中创建子项          
                myReg2.SetValue("DateThing", comboBox_thing.Text);
        }

        private void comboBox_thing_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex rg = new Regex("^[\u4e00-\u9fa5]$");  //正则表达式   

            if (e.KeyChar != 8 && e.KeyChar != 32)
            {
                if (!(e.KeyChar <= '9' && e.KeyChar >= '0'))
                {
                    if (!(e.KeyChar <= 'z' && e.KeyChar >= 'a'))
                    {
                        if (!(e.KeyChar <= 'Z' && e.KeyChar >= 'A'))
                        {
                            if (!rg.IsMatch(e.KeyChar.ToString()))
                            {
                                e.Handled = true;
                            }
                        }
                    }
                }


            }
        }

        private void comboBox_thing_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_day_MouseClick(object sender, MouseEventArgs e)
        {
            if (comboBox_month.Text != "" && ComboBox_year.Text != "")
            {
                comboBox_day.Items.Clear();
                int i = days_Count(int.Parse(ComboBox_year.Text), int.Parse(comboBox_month.Text));
                for (int a = 1; a <= i; a++)
                    comboBox_day.Items.Add(a);
                comboBox_day.Text = "1";
            }
        }

       

    }

}

