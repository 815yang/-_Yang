
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;
using Microsoft.VisualBasic;
using System.Xml;
using IWshRuntimeLibrary;
using System.Diagnostics;
using System.Threading;
namespace 桌面倒计时
{

    public partial class Form1 : Form
    {

        //声明对象
        private settime stime = new settime();
        private outdate outd = new outdate();
        private help hp = new help();
        //获取桌面,程序路径,程序目录
        string deskTop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\";
        string execPath = System.Windows.Forms.Application.ExecutablePath;
        string execPath_1 = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
        //移动窗口的参数
        int temp = 1;//一秒 首页日期输出刷新时间
        bool mov = false;//初始化移动窗口
        int xpos = 0;//初始化移动窗口时的x坐标
        int ypos = 0;//初始化移动窗口时的y坐标
        // 快捷方式名称-任意自定义
        private const string QuickName = "桌面倒计时";
        /// /// 自动获取系统自动启动目录  
        private string systemStartPath { get { return Environment.GetFolderPath(Environment.SpecialFolder.Startup); } }

        // 自动获取程序完整路径   

        // 自动获取桌面目录         
       // private string desktopPath { get { return Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory); } }              
        
        public Form1()
        {

            InitializeComponent();
            /***********创建快捷方式*************/

                if (System.IO.File.Exists(deskTop + "桌面倒计时_Yang" + ".lnk"))  //
                {
                    System.IO.File.Delete(deskTop + "桌面倒计时_Yang" + ".lnk");//删除原来的桌面快捷键方式
                    CreateDesktopShortcut("桌面倒计时", execPath);
                }
                if (!System.IO.File.Exists(deskTop + "桌面倒计时_Yang" + ".lnk"))
                {
                    if (!System.IO.File.Exists(deskTop + "桌面倒计时" + ".lnk"))
                    {
                        CreateDesktopShortcut("桌面倒计时", execPath);
                    }
                }

            /**********判断程序是否已经设置开机自启*********/
            List<string> shortcutPaths = GetQuickFromFolder(systemStartPath, execPath);
            if (shortcutPaths.Count > 0)
            {
                开机自启ToolStripMenuItem.Checked = true;
            }
            else
            {
                开机自启ToolStripMenuItem.Checked = false;
            }
        
        }
              
        private void Form1_Load(object sender, EventArgs e)
        {
            /***********获取注册表记录窗体上一次关闭的坐标**********/
             RegistryKey myReg1, myReg2;  
            //声明注册表对象          
            myReg1 = Registry.CurrentUser;  
            //获取当前用户注册表项        
            try
            {
                myReg2 = myReg1.CreateSubKey("Software\\Mysoft");
                if (myReg2.GetValue("Running").ToString() == "true")
                {
                    Process.GetCurrentProcess().Kill();
                }
                else
                {
                    myReg2.SetValue("Running", "true");
                }
            }
            catch
            {
                myReg2 = myReg1.CreateSubKey("Software\\Mysoft");
                myReg2.SetValue("Running", "true");
            }

            try          
            {           
                myReg2 = myReg1.CreateSubKey("Software\\MySoft"); 
                //在注册表项中创建子项         
                this.Location = new Point(Convert.ToInt16(myReg2.GetValue("1")), Convert.ToInt16(myReg2.GetValue("2")));        
            }           
            catch     
            {
                //设置窗体的显示位置
                this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width / 2 - Form.ActiveForm.Width / 2,0);
            }


            /*****winodw_st 显示首页********/
            window_st.Controls.Clear();
            window_st.Controls.Add(outd);
            outd.Show();
            Thread.Sleep(2000);
            /*********窗口状态初始化**********/
            checkBox1.Checked = false;//置顶选项否
            this.TopMost = false;
            首页ToolStripMenuItem.Checked = true;//首页选项true
            checkBox_右上角.Checked = false;//窗口center选项false
            
        }


        /*************窗口居中跟middle显示的单击事件*****************/
        private void checkBox_右上角_Click(object sender, EventArgs e)
        {
            if (checkBox_右上角.Checked == true)
                this.CenterToScreen();
            else
            {
                this.Left = Screen.PrimaryScreen.WorkingArea.Width / 2 - Form.ActiveForm.Width / 2;
                this.Top = 0;
            }

        }
        /********窗口是否置顶单击事件***********/
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                this.TopMost = true;

            }
            else
            {
                this.TopMost = false;
            }
        }
    
     
     
        /********首页单击事件***********/
        private void 首页ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            window_st.Controls.Clear();
            window_st.Controls.Add(outd);
            outd.Show();
    
            if (首页ToolStripMenuItem.Checked == false)
            {
                首页ToolStripMenuItem.Checked = true;
                时间设置ToolStripMenuItem.Checked = false;
                帮助ToolStripMenuItem.Checked = false;
            }
        }
       
        /**************时间设置单击事件***************/
        private void 时间设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            window_st.Controls.Clear();
            window_st.Controls.Add(stime);
            stime.Show();
            if (时间设置ToolStripMenuItem.Checked == false)
            {
                首页ToolStripMenuItem.Checked = false;
                帮助ToolStripMenuItem.Checked = false;
                时间设置ToolStripMenuItem.Checked = true;
            }

        }
        /**************开机自启单击事件*************/
        private void 开机自启ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (开机自启ToolStripMenuItem.Checked == false)
            {
                SetMeAutoStart(true);
                开机自启ToolStripMenuItem.Checked = true;
            }
            else
            {
                SetMeAutoStart(false);
                开机自启ToolStripMenuItem.Checked = false;
            }
        }
        /*************程序开机自启改变事件*********/
        private void 开机自启ToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (开机自启ToolStripMenuItem.Checked == true)
            {
                SetMeAutoStart();
            }
        }
        /*********程序重新启动单击事件**********/
        private void 重新启动ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }



        private void 重新启动ToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {

        }
        /************帮助按钮单击事件*************/
        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            window_st.Controls.Clear();
            window_st.Controls.Add(hp);
            hp.Show();
            if (帮助ToolStripMenuItem.Checked == false)
            {
                时间设置ToolStripMenuItem.Checked = false;
                首页ToolStripMenuItem.Checked = false;
                帮助ToolStripMenuItem.Checked = true;
            }
        }
        /********窗口最小化***********/
        private void 最小化ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        /*********关闭窗口****************/
        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /***********第一行目标事件+距离日期+剩余时间的输出*******************/
        int timers = 0;
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timers++;
            if (timers == temp)
            {
                timers = 0;
                

                if (stime.checkBox_save.Checked == true)
                {

                    outd.textBox_longdate.Text = "距离"+stime.comboBox_thing.Text+"："+stime.ComboBox_year.Text+"年"+stime.comboBox_month.Text+"月"+stime.comboBox_day.Text+"日仅有:"+stime.result()+"天";
                    outd.textBox_put.Text = stime.result() + "天";
                }
                else
                {
                    outd.textBox_longdate.Text = "请点开菜单栏,点击'时间设置',设置目标日期";
                    outd.textBox_put.Text = "珍惜时间";
                }
            }
        }

        /*************窗口移动**************/
        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = true;
            xpos = MousePosition.X;//鼠标的x坐标为当前窗体左上角x坐标
            ypos = MousePosition.Y;//鼠标的y坐标为当前窗体左上角y坐标
        }

        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov)
            {
                this.Left += MousePosition.X - xpos;//根据鼠标x坐标确定窗体的左边坐标x
                this.Top += MousePosition.Y - ypos;//根据鼠标的y坐标窗体的顶部，即Y坐标
                xpos = MousePosition.X;
                ypos = MousePosition.Y;
            }
        }

        private void menuStrip1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = false;//停止移动
        }

        private void menuStrip1_MouseLeave(object sender, EventArgs e)
        {
            xpos = 0; //设置初始状态
            ypos = 0;
            mov = false;
        }
        /********************创建桌面快捷方式***************/
        public bool CreateDesktopShortcut(string FileName, string exePath)
        {
            try
            {

                if (System.IO.File.Exists(deskTop + FileName + ".lnk"))  //
                {
                    System.IO.File.Delete(deskTop + FileName + ".lnk");//删除原来的桌面快捷键方式
                }
                WshShell shell = new WshShell();

                //快捷键方式创建的位置、名称
                IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(deskTop + FileName + ".lnk");
                shortcut.TargetPath = exePath; //目标文件
                //该属性指定应用程序的工作目录，当用户没有指定一个具体的目录时，快捷方式的目标应用程序将使用该属性所指定的目录来装载或保存文件。
                shortcut.WorkingDirectory = System.Environment.CurrentDirectory;
                //shortcut.IconLocation = exePath_1 + "logo.ico";  //快捷方式图标
                shortcut.WindowStyle = 1; //目标应用程序的窗口状态分为普通、最大化、最小化【1,3,7】
                shortcut.Description = FileName; //描述
                shortcut.Arguments = "";
                //shortcut.Hotkey = "CTRL+ALT+F11"; // 快捷键
                shortcut.Save(); //必须调用保存快捷才成创建成功
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }



       



        private void window_st_Paint(object sender, PaintEventArgs e)
        {

        }


      /********************设置开启自启*********************************/
       public void SetMeAutoStart(bool onOff = true)    
       {      
           if (onOff)//开机启动   
           {               
               //获取启动路径应用程序快捷方式的路径集合     
               List<string> shortcutPaths = GetQuickFromFolder(systemStartPath, execPath);   
               //存在2个以快捷方式则保留一个快捷方式-避免重复多于        
               if (shortcutPaths.Count >= 2)             
               {                   
                   for (int i = 1; i < shortcutPaths.Count; i++)     
                   {                   
                       DeleteFile(shortcutPaths[i]);  
                   }              
               }              
               else if (shortcutPaths.Count < 1)//不存在则创建快捷方式    
               {
                   CreateShortcut(systemStartPath, QuickName, execPath, "桌面倒计时");
                   MessageBox.Show("设置成功！");
               }         
           }        
           else//开机不启动   
           {        

               //获取启动路径应用程序快捷方式的路径集合   
               List<string> shortcutPaths = GetQuickFromFolder(systemStartPath, execPath);  
               //存在快捷方式则遍历全部删除            
               if (shortcutPaths.Count > 0)          
               {              
                   for (int i = 0; i < shortcutPaths.Count; i++)    
                   {                  
                       DeleteFile(shortcutPaths[i]);      
                   }            
               }
               MessageBox.Show("取消成功！");
           }         
           //创建桌面快捷方式-如果需要可以取消注释 
           //CreateDesktopQuick(desktopPath, QuickName, appAllPath);   
       }       
        //  向目标路径创建指定文件的快捷方式   
        /// </summary>     
        /// /// <param name="directory">目标目录</param>   
        /// /// <param name="shortcutName">快捷方式名字</param>      
        /// /// <param name="targetPath">文件完全路径</param>     
        /// /// <param name="description">描述</param>      
        /// /// <param name="iconLocation">图标地址</param>      
        /// /// <returns>成功或失败</returns>      
       private bool CreateShortcut(string directory, string shortcutName, string targetPath, string description = null)     
       {      
           try   
           {          
               if (!Directory.Exists(directory)) Directory.CreateDirectory(directory);          
           //目录不存在则创建      
           //添加引用 Com 中搜索 Windows Script Host Object Model    
           string shortcutPath = Path.Combine(directory, string.Format("{0}.lnk", shortcutName));    
           //合成路径             
           WshShell shell = new IWshRuntimeLibrary.WshShell();     
           IWshShortcut shortcut = (IWshRuntimeLibrary.IWshShortcut)shell.CreateShortcut(shortcutPath);    //创建快捷方式对象  
           shortcut.TargetPath = targetPath;                      //指定目标路径        
           shortcut.WorkingDirectory = Path.GetDirectoryName(targetPath);                                  //设置起始位置  
           shortcut.WindowStyle = 1;                                                                       //设置运行方式，默认为常规窗口   
           shortcut.Description = description;                                                             //设置备注  
           //shortcut.IconLocation = exePath_1 + "logo.ico";    //设置图标路径        
           shortcut.Save();                                                                                //保存快捷方式     
           return true;        
       }         
       catch(Exception ex)  
       {             
           string temp = ex.Message;    
           temp = "";        
       }         
           return false;   
       }       
        /// 获取指定文件夹下指定应用程序的快捷方式路径集合   目标应用程序路径   /// <returns>目标应用程序的快捷方式</returns>    
        private List<string> GetQuickFromFolder(string directory, string targetPath)      
         {            List<string> tempStrs = new List<string>();       
             tempStrs.Clear();  
             string tempStr = null;   
             string[] files = Directory.GetFiles(directory, "*.lnk");     
             if (files == null || files.Length < 1)    
             {             
                 return tempStrs;    
             }          
             for (int i = 0; i < files.Length; i++) 
             {               
                 //files[i] = string.Format("{0}\\{1}", directory, files[i]);  
                 tempStr = GetAppPathFromQuick(files[i]);     
                 if (tempStr == targetPath)           
                 {                  
                     tempStrs.Add(files[i]);    
                 }           
             }      
             return tempStrs; 
         }      
        /// 获取快捷方式的目标文件路径-用于判断是否已经开启了自动启动          
        private string GetAppPathFromQuick(string shortcutPath)      
        {         
            //快捷方式文件的路径 = @"d:\Test.lnk";     
            if (System.IO.File.Exists(shortcutPath))    
            {              
                WshShell shell = new WshShell();    
                IWshShortcut shortct = (IWshShortcut)shell.CreateShortcut(shortcutPath);  
                //快捷方式文件指向的路径.Text = 当前快捷方式文件IWshShortcut类.TargetPath;    
                //快捷方式文件指向的目标目录.Text = 当前快捷方式文件IWshShortcut类.WorkingDirectory;    
                return shortct.TargetPath;       
            }          
            else       
            {         
                return "";     
            }    
        }       
        /// <summary>        /// 根据路径删除文件-用于取消自启时从计算机自启目录删除程序的快捷方式        /// </summary>        /// <param name="path">路径</param>      
        private void DeleteFile(string path)       
        {           
            FileAttributes attr = System.IO. File.GetAttributes(path);   
            if (attr == FileAttributes.Directory)         
            {              
                Directory.Delete(path, true);   
            }          
            else        
            {            
                System.IO.File.Delete(path);     
            }        
        }

        /************窗体关闭后,将最后的窗体坐标写入注册表:当前用户||Software\\Mysoft*************/
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            RegistryKey myReg1, myReg2;        
            //声明注册表对象         
            myReg1 = Registry.CurrentUser;   
            //获取当前用户注册表项         
            myReg2 = myReg1.CreateSubKey("Software\\MySoft"); 
            //在注册表项中创建子项          
            try      
            {         
                myReg2.SetValue("1", this.Location.X.ToString()); 
                myReg2.SetValue("2", this.Location.Y.ToString());
                myReg2.SetValue("Running", "false");
            }          
            catch       
            {       
            }
        }
      
    }
}

