using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorAssign
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Number_Click(object sender, EventArgs e)
        {
            if (sender == btnBcksp)
            {
                TXTdisPLAY.Text = "0";
            }
            if ((sender == btnDel) && !(TXTdisPLAY.Text == "0") && (TXTdisPLAY.Text.Length >0))
            { 
                TXTdisPLAY.Text = TXTdisPLAY.Text.Remove(TXTdisPLAY.Text.Length - 1);
                if (TXTdisPLAY.Text.Length < 1 )
                {
                    TXTdisPLAY.Text = "0";
                }
            }
        }

        private void Number1_Click(object sender, EventArgs e)
        {
            if (TXTdisPLAY.Text == "0")
            {
                TXTdisPLAY.Text = "";
            }
            if (sender == btnZero)
            {
                TXTdisPLAY.Text = TXTdisPLAY.Text + btnZero.TabIndex;
            }
            else if (sender == btnOne)
            {
                TXTdisPLAY.Text = TXTdisPLAY.Text + btnOne.TabIndex;
            }
            else if (sender == btn2)
            {
                TXTdisPLAY.Text = TXTdisPLAY.Text + btn2.TabIndex;
            }
            else if (sender == btn3)
            {
                TXTdisPLAY.Text = TXTdisPLAY.Text + btn3.TabIndex;
            }
            else if (sender == btn4)
            {
                TXTdisPLAY.Text = TXTdisPLAY.Text + btn4.TabIndex;
            }
            else if (sender == btn5)
            {
                TXTdisPLAY.Text = TXTdisPLAY.Text + btn5.TabIndex;
            }
            else if (sender == btn6)
            {
                TXTdisPLAY.Text = TXTdisPLAY.Text + btn6.TabIndex;
            }
            else if (sender == btn7)
            {
                TXTdisPLAY.Text = TXTdisPLAY.Text + btn7.TabIndex;
            }
            else if (sender == btn8)
            { 
                TXTdisPLAY.Text = TXTdisPLAY.Text + btn8.TabIndex;
            }
            else if (sender == btn9)
            {
                TXTdisPLAY.Text = TXTdisPLAY.Text + btn9.TabIndex;
            }

        }

        private void Operator__Click(object sender, EventArgs e)
        {
            if (TXTdisPLAY.Text.EndsWith("+") || TXTdisPLAY.Text.EndsWith("*") || TXTdisPLAY.Text.EndsWith("/") || TXTdisPLAY.Text.EndsWith("-"))
            {
                TXTdisPLAY.Text = TXTdisPLAY.Text.Remove(TXTdisPLAY.Text.Length - 1);
            }

            if (!TXTdisPLAY.Text.Contains("+") && !TXTdisPLAY.Text.Contains("-") && !TXTdisPLAY.Text.Contains("*") && !TXTdisPLAY.Text.Contains("/"))
            {
                if (sender == btnAdd)
                {
                    TXTdisPLAY.Text = TXTdisPLAY.Text + btnAdd.Text;
                }

                if (sender == btnSubs)
                {
                    TXTdisPLAY.Text = TXTdisPLAY.Text + btnSubs.Text;
                }
                if (sender == btnDiv)
                {
                    TXTdisPLAY.Text = TXTdisPLAY.Text + btnDiv.Text;
                }
                if (sender == btnMult)
                {
                    TXTdisPLAY.Text = TXTdisPLAY.Text + btnMult.Text;
                }
            }
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            String[] operands = TXTdisPLAY.Text.Split('+');
            int answer = Convert.ToInt32(operands[0]) + Convert.ToInt32(operands[1]);
            { 
                TXTdisPLAY.Text = answer.ToString();
            }
            
            //String[] operands2 = TXTdisPLAY.Text.Split('-');
            //int answer2 = Convert.ToInt32(operands[0]) - Convert.ToInt32(operands[1]);
            //{
            //    TXTdisPLAY.Text = answer2.ToString();
            //}

        }
    }
}
    

