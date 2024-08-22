using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAdv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 이름ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 도구ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 도움말보기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://learn.microsoft.com/ko-kr/visualstudio/ide/not-in-toc/welcome-to-visual-studio-docs?view=vs-2022&f1url=%3FappId%3DDev17IDEF1%26l%3DKO-KR%26k%3Dk(vs.ViewHelp)%3Bk(TargetFrameworkMoniker-.NETFramework%2CVersion%253Dv4.7.2)%3Bk(DevLang-csharp)%26rd%3Dtrue");
        }

        private void 확대ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (toolStripProgressBar1.Maximum < toolStripProgressBar1.Value - toolStripProgressBar1.Step)
            {
                toolStripProgressBar1.Value = toolStripProgressBar1.Maximum;
            } else
            {
                toolStripProgressBar1.Value -= toolStripProgressBar1.Step;
            }
        }

        private void 축소ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripProgressBar1.Value -= 10;
        }

        private void 확대하기축소하기기본값복원ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripProgressBar1.Value = 50;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
