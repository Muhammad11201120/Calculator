using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float numberOne = 0;
        string operation = "";

        private void button_Click( object sender, EventArgs e )
        {

            if ( textBox1.Text == "0" )
            {
                textBox1.Clear();
            }
            Button btn = ( Button ) sender;
            textBox1.Text = textBox1.Text + btn.Text;
            label1.Text = textBox1.Text;
        }

        private void btnExit_Click( object sender, EventArgs e )
        {
            this.Close();
        }



        private void btnOperation_Click( object sender, EventArgs e )
        {

            numberOne = float.Parse( textBox1.Text );
            textBox1.Clear();
            Button btn = ( Button ) sender;
            operation = btn.Text;
            label1.Text += operation;
            if ( operation == "x2" )
            {
                textBox1.Text = ( numberOne * numberOne ).ToString();
            }
            if ( operation == "sqrt" )
            {
                textBox1.Text = ( Math.Sqrt( numberOne ) ).ToString();
            }
        }
        private void btnEqual_Click( object sender, EventArgs e )
        {

            switch ( operation )
            {
                case "+":
                    textBox1.Text = ( numberOne + float.Parse( textBox1.Text ) ).ToString();
                    break;
                case "*":
                    textBox1.Text = ( numberOne * float.Parse( textBox1.Text ) ).ToString();
                    break;
                case "-":
                    textBox1.Text = ( numberOne - float.Parse( textBox1.Text ) ).ToString();
                    break;
                case "/":
                    textBox1.Text = ( numberOne / float.Parse( textBox1.Text ) ).ToString();
                    break;
                case "%":
                    textBox1.Text = ( numberOne % float.Parse( textBox1.Text ) ).ToString();
                    break;
            }
        }

        private void btnClear_Click( object sender, EventArgs e )
        {
            textBox1.Text = "0";
            label1.Text = "0";
        }

        private void btnDot_Click( object sender, EventArgs e )
        {
            if ( textBox1.Text.Contains( "." ) )
            {
                return;
            }
            else
            {
                textBox1.Text += ".";
            }
        }
    }
}
