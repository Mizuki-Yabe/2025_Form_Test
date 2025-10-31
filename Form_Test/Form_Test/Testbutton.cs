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
        private Color _onColor = Color.LightBlue;
        private Color _offColor = Color.Yellow;

        private bool _enable;



        public void SetEnable(bool on)
        {
            _enable = on;
            if (on)
            {
                BackColor = _onColor;
            }
            else
            {
                BackColor = _offColor;
            }
        }


        public Testbutton(Point position,Size size, string text)
        {
            Location = position;  //ボタンの大きさ
            Size = size;  //
            Text = text;


            SetEnable(false);

            Click += ClickEvent;
        }
        private void ClickEvent(object sender, EventArgs e)
        {
            SetEnable(!_enable);

        }


    }
}
