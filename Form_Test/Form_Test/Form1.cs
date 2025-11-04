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
        //constをつけると初期化時のみ値の変更ができる
        const int BUTTON_SIZE_X = 100;
        const int BUTTON_SIZE_Y = 100;

        const int BOARD_SIZE_X = 3;
        const int BOARD_SIZE_Y = 3;

        private Testbutton[,] _buttonArray;

        public Testbutton GetTestbutton(int x, int y)
        {
            return _buttonArray[y, x];
        }

        public Form1()
        {
            InitializeComponent();
            _buttonArray = new Testbutton[BOARD_SIZE_Y, BOARD_SIZE_X];

            for (int i = 0; i < BOARD_SIZE_X; i++)
            {
                for (int d = 0; d < BOARD_SIZE_Y; d++)
                {
                    Testbutton testbutton = new Testbutton(this,
                                                           i,d,
                                                           new Size(BUTTON_SIZE_X, BUTTON_SIZE_Y),"府中");


                    _buttonArray[d,i] = testbutton;

                    testbutton.SetEnable(false);
                    //コントロールにボタンを追加
                    Controls.Add(testbutton);
                 }
            }

            GetTestbutton(0,0).SetEnable(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("マダガスカル！\nでも普通じゃない？\n府中！！");

        }
    }
}
