using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           

            for (int i = 0; i < 6; i++)
            {
                for (int d = 0; d < 4; d++)
                {
                    Testbutton testbutton = new Testbutton();

                    //ボタンの位置
                    testbutton.Location = new Point(50 * i, 50*d);
                    //ボタンのサイズ変更
                    testbutton.Size = new Size(50, 50);
                    //ボタンのテキスト変更
                    testbutton.Text = "府中";

                    //コントロールにボタンを追加
                    Controls.Add(testbutton);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("マダガスカル！\nでも普通じゃない？\n府中！！");

        }
    }
}
