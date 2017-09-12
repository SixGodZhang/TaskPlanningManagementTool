using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskPlanningManagementTool
{
    public partial class Form1 : Form
    {

        public static string directory_path = "d:\\任务管理";

        public Form1()
        {
            InitializeComponent();
            System.Diagnostics.Process.Start("Explorer.exe", directory_path);
        }

        /// <summary>
        /// 打开创建任务类别窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createTaskTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //防止重复打开窗口
            foreach (Form item in this.MdiChildren)
            {
                if (item.Name == "CreateTaskTypePanel")
                {
                    item.Visible = true;//窗口可见
                    item.Activate();//激活窗口,获取焦点
                    return;
                }
            }

            CreateTaskTypePanel cttp = new CreateTaskTypePanel();
            cttp.MdiParent = this;
            cttp.Show();

        }
    }
}
