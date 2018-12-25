using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;



namespace Pc_monitor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();




        }


        private int timer_count_10s = 0;
        //全局变量，存储当前二维码的
        private string Temp_pcNum = null;
        private string staffEnum = null;
        DataTable dt2 = null;

        private void timer1_Tick(object sender, EventArgs e)
        {
            //1秒跑一次的程序
            if (richTextBox1.Text.Contains("\n"))
            {
                try
                {
                    string jsonText = richTextBox1.Text;
                    JavaScriptObject jsonObj = JavaScriptConvert.DeserializeObject<JavaScriptObject>(jsonText);
                    Temp_pcNum = jsonObj["Num"].ToString();
                    staffEnum = jsonObj["staffEnum"].ToString();
                    richTextBox1.Text = "";
                    label2.Text = "扫码成功！";
                }
                catch (Exception)
                {
                    richTextBox1.Text = "";
                    label2.Text = "请出示正确的二维码";

                }


                //写入文本，写入记录

            }

            //10秒跑一次程序
            if (timer_count_10s >= 10)
            {

                //分割线·············分割线//
                int catlocation = Properties.Settings.Default.catlocation;
                DateTime currentTime = new DateTime();
                currentTime = DateTime.Now;
                string st1 = Properties.Settings.Default.b1; //早餐前

                string st2 = Properties.Settings.Default.b2; //早餐后

                string st3 = Properties.Settings.Default.l1; //午餐前

                string st4 = Properties.Settings.Default.l2; //午餐后

                DateTime b1DateTime = Convert.ToDateTime(st1);

                DateTime b2DateTime = Convert.ToDateTime(st2);

                DateTime l1DateTime = Convert.ToDateTime(st3);

                DateTime l2DateTime = Convert.ToDateTime(st4);


                string currentCat = "";
                string showString = "";
                if (DateTime.Compare(currentTime, b1DateTime) > 0 && DateTime.Compare(currentTime, b2DateTime) < 0)
                {
                    currentCat = "Breakfast";
                    showString = "早餐";
                }
                else if (DateTime.Compare(currentTime, l1DateTime) > 0 && DateTime.Compare(currentTime, l2DateTime) < 0)
                {
                    currentCat = "Lunch";
                    showString = "午餐";
                }
                else
                {
                    currentCat = "Dinner";
                    showString = "晚餐";
                }
                if (dt2 != null)
                {
                    dt2.Clear();
                }
                try
                {
                   
                  dt2 =
                SqlHelper.ExecuteDataTable("select * from  Cater.CookbookSetInDate where CafeteriaId=" + catlocation +
                               " and CookbookEnum='" + currentCat + "' and ChooseDate='2018-12-24'");
                }
                catch (Exception)
                {
                    timer1.Stop();
                    MessageBox.Show("数据库连接错误");
                    return;
                }

                int rowCounts = dt2.Rows.Count;
                var dtRows = dt2.Rows;
                groupBox1.Controls.Clear();
                for (int i = 0; i < rowCounts; i++)
                {
                    //实例化GroupBox控件
                    Button button = new Button();
                    button.BackgroundImage = Properties.Resources.login_bg2;
                    button.ForeColor = Color.White;
                    button.Font = new Font("宋体粗体", 14);
                    button.TextAlign = ContentAlignment.MiddleCenter;
                    button.Name = "row*" + dtRows[i][0];
                    button.Text = showString + "--" + dtRows[i][4];

                    //通过坐标设置位置
                    button.Size = new Size(200, 40);
                    if (i < 5)
                    {
                        button.Location = new Point(20 + 260*i, 20);
                    }
                    else if (i >= 5 && i <= 9)
                    {
                        button.Location = new Point(20 + 260*(i - 5), 80);
                    }
                    else if (i >= 10 && i <= 14)
                    {
                        button.Location = new Point(20 + 260*(i - 10), 140);
                    }
                    else if (i >= 15 && i <= 19)
                    {
                        button.Location = new Point(20 + 260*(i - 15), 200);
                    }

                    //将groubox添加到页面上
                    groupBox1.Controls.Add(button);
                    button.MouseClick += new MouseEventHandler(button_MouseClick);
                    timer_count_10s = 0;
                }
            }
            else
            {
                timer_count_10s++;
            }
        }

        private int selectedNum = 0;

        public void button_MouseClick(object sender, EventArgs e)
        {

            Button button = (Button) sender;
            //label1
            Control control_show=null;
            try
            { 
                 control_show = Controls.Find("label_show", true)[0];

            }
            catch (Exception)
            {
                Console.Write("123");
            }
           
            this.Controls.Remove(control_show);
          
            label2.Text = "当前选择餐次 : "+button.Text;

           

            //保存选择数字到selectedNum，然后再提交
            string numarray =( button.Name.Split('*'))[1];
            selectedNum = Convert.ToInt16(numarray);
           // MessageBox.Show(selectedNum.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Focus();
        }

    }
}
