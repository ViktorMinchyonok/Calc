using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool isClickMouse = false;
        private Point currentPosition = new Point(0, 0);
        double MemoryStore = 0;

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            isClickMouse = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isClickMouse)
            {
                return;
            }
            Point buf = new Point(this.Location.X, this.Location.Y);
            buf.X += e.X - currentPosition.X;
            buf.Y += e.Y - currentPosition.Y;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            isClickMouse = true;
            currentPosition = new Point(e.X, e.Y);
        }
        private bool isPoint = false;
        private bool isNum2 = false;
        private string num1 = null;
        private string num2 = null;
        string result = null;

        private string CurrentOperation = "";
        private void AddNum(string txt)
        {
            if (isNum2)
            {
                num2 += txt;
                textBox2.Text = num2;
                textbox.Text += num2;
            }
            else
            {
                num1 += txt;
                textBox2.Text = num1;
                textbox.Text = num1;
            }
        }
        private void SetNum(string txt)
        {
            if (isNum2)
            {
                num2 = txt;
                textBox2.Text = num2;
            }
            else
            {
                num1 = txt;
                textBox2.Text = num1;
            }
        }
        private void buttonNumberClick(object obj, EventArgs e)
        {
            var txt = ((Button)obj).Text;
            {
                if (isPoint && txt == ",") { return; }
                if (txt == ",") { isPoint = true; }
            }
            if (txt == "+/-")
            {
                if (textBox2.Text.Length > 0)
                    if (textBox2.Text[0] == '-')
                    {
                        textBox2.Text = textBox2.Text.Substring(1, textBox2.Text.Length - 1);
                        textbox.Text = textbox.Text.Substring(1, textbox.Text.Length - 1);
                    }
                    else
                    {
                        textBox2.Text = "-" + textBox2.Text;
                       if(textbox.Text!=num1)
                        textbox.Text = num1 + CurrentOperation + "-" + num2;
                       else textbox.Text = "-" + textbox.Text;

                    }
                SetNum(textBox2.Text);
                return;
            }
            AddNum(txt);
        }
        private void buttonOperationClick(object obj, EventArgs e)
        {
            if (num1 == null)
            {
                if (textBox2.Text.Length > 0)
                {
                    num1 = textBox2.Text;
                }
                else 
                {
                    return;
                }

            }
            isNum2 = true;
            CurrentOperation = ((Button)obj).Text;
            SetResult(CurrentOperation);
        }
        private void SetResult(string operation)
        {
            result = null;
            switch(operation)
            {
                case "+": { result = Operations.Add(num1, num2); break; }
                case "-": { result = Operations.Sub(num1, num2); break; }
                case "×": { result = Operations.Multiply(num1, num2); break; }
                case "÷": { result = Operations.Divide(num1, num2); break; }
                case "%": { result = Operations.PDivide(num1, num2); break; }
                default:break;
            }
            OutputResult(result, operation);
            if (isNum2) 
            {
                if (result != null) num1 = result; 
            
            }
            else { num1 = null; }
            isPoint = false;
        }
        private void OutputResult(string result, string operation)
        {

            if (num2 != null)
            {
                textbox.Text = num1 + operation + num2 + "=";

            }
            else
            {
                if (num1 != null)
                {
                    textbox.Text = num1 + operation;

                }

            }



            num2 = null;
            if (result != null)
            {
                textbox.Text += result;
                textBox2.Text = result;
            }
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textbox.Text = "";
            isNum2 = false;
            num1 = null;
            num2 = null;
            isPoint = false;
        }

        private void button_equals_Click(object sender, EventArgs e)
        {
           
            SetResult(CurrentOperation);
            isNum2 = false;
            num1 = null;
            num2 = null;

        }
        private void button_back_Click(object sender, EventArgs e)
        {
            if (textbox.Text.Length <= 0) return;
            textbox.Text = textbox.Text.Substring(0,textbox.Text.Length-1);
            SetNum(textbox.Text);
        }

        private void mc_button_Click(object sender, EventArgs e)
        {
            MemoryStore = 0;
            return;
        }
        private void mrecall_button_Click(object sender, EventArgs e)
        {
            textBox2.Text = MemoryStore.ToString();
            return;
        }

        private void msubtract_button_Click(object sender, EventArgs e)
        {
                MemoryStore = Double.Parse(textBox2.Text);
            return;
        }

        private void mminus_button_Click(object sender, EventArgs e)
        {
            MemoryStore -= Double.Parse(textBox2.Text);
            return;
        }

        private void mplus_button_Click(object sender, EventArgs e)
        {
            MemoryStore += Double.Parse(textBox2.Text);
            return;
        }
    }
}
