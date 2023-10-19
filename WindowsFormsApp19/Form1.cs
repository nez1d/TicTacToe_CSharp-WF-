using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp19
{
    public partial class Form1 : Form
    {
        private int count = 0;

        private bool win = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(Control c in panel1.Controls)
            {
                if (c is Button)
                {
                    c.Click += new System.EventHandler(btn_click);
                }
            }
        }

        public void btn_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.Text.Equals(""))
            {
                if (count % 2 == 0)
                {
                    btn.Text = "X";
                    this.Text = "0 Turn Now";
                    getTheWinner();                  
                }
                else
                {
                    btn.Text = "0";
                    this.Text = "X Turn Now";
                    getTheWinner();
                }
            }
            count++;
        }

        public void getTheWinner()
        {
            if (button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "")
            {
                winEffect(button1, button2, button3);
                MessageBox.Show($"Win: {button1.Text}", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                win = true;
                gameReload();
            }
            if (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "")
            {
                winEffect(button4, button5, button6);
                MessageBox.Show($"Win: {button4.Text}", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                win = true;
                gameReload();
            }
            if (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != "")
            {
                winEffect(button7, button8, button9);
                MessageBox.Show($"Win: {button7.Text}", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                win = true;
                gameReload();
            }
            if (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "")
            {
                winEffect(button1, button4, button7);
                MessageBox.Show($"Win: {button4.Text}", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                win = true;
                gameReload();
            }
            if (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "")
            {
                winEffect(button2, button5, button8);
                MessageBox.Show($"Win: {button2.Text}", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                win = true;
                gameReload();
            }
            if (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != "")
            {
                winEffect(button3, button6, button9);
                MessageBox.Show($"Win: {button3.Text}", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                win = true;
                gameReload();
            }
            if (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "")
            {
                winEffect(button1, button5, button9);
                MessageBox.Show($"Win: {button1.Text}", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                win = true;
                gameReload();
            }
            if (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != "")
            {
                winEffect(button3, button5, button7);
                MessageBox.Show($"Win: {button3.Text}", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                win = true;
                gameReload();
            }

            if(AllBtnLength(0) == 9 && win == false)
            {
                MessageBox.Show("No one Win!", "Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gameReload();
            }
        }

        private int AllBtnLength(int allTextButtonsLength)
        {
            allTextButtonsLength = 0;
            foreach (Control c in panel1.Controls)
            {
                if (c is Button)
                {
                    allTextButtonsLength += c.Text.Length;
                }
            }
            return allTextButtonsLength;
        }

        private void winEffect(Button b1, Button b2, Button b3)
        {

            b1.ForeColor = Color.Red;
            b2.ForeColor = Color.Red;
            b3.ForeColor = Color.Red;

            this.Text = b1.Text + " Win!";
        } 

        private void gameReload()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";

            button1.ForeColor = Color.Lime;
            button2.ForeColor = Color.Lime;
            button3.ForeColor = Color.Lime;
            button4.ForeColor = Color.Lime;
            button5.ForeColor = Color.Lime;
            button6.ForeColor = Color.Lime;
            button7.ForeColor = Color.Lime;
            button8.ForeColor = Color.Lime;
            button9.ForeColor = Color.Lime;        
        }
    }
}
