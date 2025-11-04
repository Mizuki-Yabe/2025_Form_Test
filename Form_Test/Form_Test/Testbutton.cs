using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Form_Test
{
    public class Testbutton : Button
    {
        private Color _onColor = Color.LightBlue;
        private Color _offColor = Color.Yellow;

        private bool _enable;

        private Form1 _form1;

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


        public Testbutton(Form1 form1,Point position,Size size, string text)
        {
            _form1 = form1;

            Location = position;  //ボタンの大きさ
            Size = size;  //
            Text = text;


            SetEnable(false);

            Click += ClickEvent;
        }
        private void ClickEvent(object sender, EventArgs e)
        {
            //
            _form1.GetTestbutton(1, 1).SetEnable(true);

        }


    }
}
