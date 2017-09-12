using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TaskPlanningManagementTool
{
    public partial class CreateTaskTypePanel : Form
    {
        //private static string directory_path = "d:\\任务管理";

        public CreateTaskTypePanel()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 确认,创建任务目录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string target_TaskDirectoy = Form1.directory_path + "\\"+richTextBox1.Text;
            try
            {
                Directory.CreateDirectory(target_TaskDirectoy);
                DialogResult result= MessageBox.Show("目录创建成功!", "提示",MessageBoxButtons.OK);
                if (result == DialogResult.OK) {
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("磁盘操作错误,原因：" + Convert.ToString(ex), "警报");
            }
        }

        /// <summary>
        /// 取消,关闭当前窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
