using System;
using System.Threading;
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
        public int brojac { get; set; }
        bool win = false;
        public int x = 0;
        public int o = 0;
        public void Reset()
        {
            btn1.Text = btn2.Text = btn3.Text = btn4.Text = btn5.Text = btn6.Text = btn7.Text = btn8.Text = btn9.Text = "";
            btn1.BackColor = btn2.BackColor = btn3.BackColor = btn4.BackColor = btn5.BackColor = btn6.BackColor = btn7.BackColor = btn8.BackColor = btn9.BackColor = Color.White;
        }
        public void IspisiPobjednika(Button btn, bool Win)
        {
            if (win == true)
            {
                if (btn.Text == "X") { x_igrac.Text = "Player X: " + (x += 1).ToString(); }
                if (btn.Text == "O") { o_igrac.Text = "Player O: " + (o += 1).ToString(); }
                MessageBox.Show(btn.Text + " WON!");
                Reset();
            }
        }
        public void getTheWinner()
        {
            if (!btn1.Text.Equals("") && btn1.Text.Equals(btn2.Text) && btn1.Text.Equals(btn3.Text))
            {
                winEffect(btn1, btn2, btn3);
                win = true;
                IspisiPobjednika(btn1, win);
            }
            if (!btn4.Text.Equals("") && btn4.Text.Equals(btn5.Text) && btn4.Text.Equals(btn6.Text))
            {
                winEffect(btn4, btn5, btn6);
                win = true;
                IspisiPobjednika(btn4, win);

            }
            if (!btn7.Text.Equals("") && btn7.Text.Equals(btn8.Text) && btn7.Text.Equals(btn9.Text))
            {
                winEffect(btn7, btn8, btn9);
                win = true;
                IspisiPobjednika(btn7, win);

            }
            if (!btn1.Text.Equals("") && btn1.Text.Equals(btn4.Text) && btn1.Text.Equals(btn7.Text))
            {
                winEffect(btn1, btn4, btn7);
                win = true;
                IspisiPobjednika(btn1, win);

            }
            if (!btn2.Text.Equals("") && btn2.Text.Equals(btn5.Text) && btn2.Text.Equals(btn8.Text))
            {
                winEffect(btn2, btn5, btn8);
                win = true;
                IspisiPobjednika(btn2, win);

            }
            if (!btn3.Text.Equals("") && btn3.Text.Equals(btn6.Text) && btn3.Text.Equals(btn9.Text))
            {
                winEffect(btn3, btn6, btn9);
                win = true;
                IspisiPobjednika(btn3, win);

            }
            if (!btn1.Text.Equals("") && btn1.Text.Equals(btn5.Text) && btn1.Text.Equals(btn9.Text))
            {
                winEffect(btn1, btn5, btn9);
                win = true;
                IspisiPobjednika(btn1, win);

            }
            if (!btn3.Text.Equals("") && btn3.Text.Equals(btn5.Text) && btn3.Text.Equals(btn7.Text))
            {
                winEffect(btn3, btn5, btn7);
                win = true;
                IspisiPobjednika(btn3, win);
            }
        }
        public void winEffect(Button b1, Button b2, Button b3)
        {
            b1.BackColor = Color.Green;
            b2.BackColor = Color.Green;
            b3.BackColor = Color.Green;

            b1.ForeColor = Color.White;
            b2.ForeColor = Color.White;
            b3.ForeColor = Color.White;
        }
        void ClickForFun(object kliknutiButton)
        {
            Button btn = kliknutiButton as Button;

            if (btn.Text == "")
            {
                if (brojac % 2 == 0)
                {
                    btn.Text = "X";
                    btn.BackColor = Color.LightBlue;
                }
                else
                {
                    btn.Text = "O";
                    btn.BackColor = Color.LightSalmon;
                }
                getTheWinner();
                brojac++;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Dobrodosli u iks-oks igricu");
            MessageBox.Show("Prvi na redu je X");
        }

        private void btn1_Click(object sender, EventArgs e)
        {

            ClickForFun(btn1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            ClickForFun(btn2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            ClickForFun(btn3);
        }
        private void btn4_Click_1(object sender, EventArgs e)
        {
            ClickForFun(btn4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            ClickForFun(btn5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            ClickForFun(btn6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            ClickForFun(btn7);

        }

        private void btn8_Click(object sender, EventArgs e)
        {
            ClickForFun(btn8);

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            ClickForFun(btn9);
        }
        private void btn_reset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
