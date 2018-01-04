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
        protected bool flag = false;
        protected string store;
        protected double first_num=0;
        protected double second_num=0;
        protected double total=0;
        
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            flag = true;
        }
      
        private void numberClick(object sender, EventArgs e)
        {
            
            Button btn = (Button)sender;

            if (flag == true) textBox1.Text = null;
            flag = false;


            //button_event
          

            textBox1.Text += btn.Text;






        }
        private void processClick(object sender, EventArgs e)
        {
            Form1 formCalc = new Form1();
            Button btn = (Button)sender;
           if (btn.Name == "clear" || btn.Name=="clearE")
            {
                textBox1.Text = "0";
                flag = true;
                first_num = 0;
                second_num = 0;
                total = 0;
            }

          

            if (btn.Name == "equals")
            {

                second_num = Convert.ToDouble(textBox1.Text);
                if (store == "add")
                {
                    total = first_num + second_num;
                }

                if (store == "divide")
                {
                    total = first_num / second_num;
                }

                if (store == "multiply")
                {
                    total = first_num * second_num;
                }

                if (store == "subtract")
                {
                    total = first_num - second_num;
                }


                textBox1.Text = Convert.ToString(total);
                first_num = 0;
                second_num = 0;
                total = 0;
                flag = true;
            }

            if (btn.Name == "plus")
            {
                //textBox1.Text = "hello";

                if (first_num == 0)
                {
                    first_num = Convert.ToDouble(textBox1.Text);
                    store = "add";
                    flag = true;
                }
                

            }

            if (btn.Name == "divide")
            {
                //textBox1.Text = "hello";

                if (first_num == 0)
                {
                    first_num = Convert.ToDouble(textBox1.Text);
                    store = "divide";
                    flag = true;
                }


            }

            if (btn.Name == "multiply")
            {
                //textBox1.Text = "hello";

                if (first_num == 0)
                {
                    first_num = Convert.ToDouble(textBox1.Text);
                    store = "multiply";
                    flag = true;
                }


            }

            if (btn.Name == "subtract")
            {
                //textBox1.Text = "hello";

                if (first_num == 0)
                {
                    first_num = Convert.ToDouble(textBox1.Text);
                    store = "subtract";
                    flag = true;
                }


            }


           
            if (btn.Name == "percentage")
            {
                 MessageBox.Show("still on dev");


            }

        }
    }
}


