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
        private Color _offColor = Color.LightGreen;

        private bool _enable;

        private Form1 _form1;

        //横の位置
        private int _x;

        //縦の位置
        private int _y;


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


        public Testbutton(Form1 form1,int x, int y,Size size, string text)
        {
            //横位置を保管
            _x = x;
            //縦位置を保管
            _y = y;

            _form1 = form1;
            
            Location = new Point(x*size.Width,y*size.Width);  //ボタンの大きさ
            Size = size;  //
            Text = text;


            SetEnable(false);

            Click += ClickEvent;
        }
        private void ClickEvent(object sender, EventArgs e)
        {
            //かえたい変数などにカーソルを合わせてctrlおしながらR二回
            _form1.GetTestbutton(_x,_y).SetEnable(true);

        }


    }
}
