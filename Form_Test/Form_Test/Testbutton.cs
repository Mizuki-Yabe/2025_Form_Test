using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Form_Test
{
    internal class Testbutton : Button
    {
        public Testbutton(Point position,Size size, string text)
        {
            Location = position;  //ボタンの大きさ
            Size = size;  //
            Text = text;


            Click += ClickEvent;
        }
        private void ClickEvent(object sender, EventArgs e)
        {
            MessageBox.Show("マダガスカル！\nでも普通じゃない？\n府中！！");

        }


    }
}
