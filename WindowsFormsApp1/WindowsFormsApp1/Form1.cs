using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private static RichTextBox m_hLog;
        public static void logWrite(string msg,bool bNewline = true)
        {
            if (m_hLog is null) return;
            m_hLog.AppendText($"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")} {msg} {(bNewline ? System.Environment.NewLine : " ")}";
        }

        public void logLink()
        {
            m_hLog = this.txtLog;
        }

        public Form1()
        {
            InitializeComponent();
            logLink();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("확인 버튼이 눌렸습니다");
            Button btn = (Button)sender;
            //btn.Enabled = false;
            logWrite($"[INFO] {btn.Name}::Clicked");            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
