using System.Data;

namespace provaa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            string ser = textBox4.Text;
            string valor = textBox5.Text;



            //1
            if (ser == "1")
            {
                if (valor == "1")
                {
                    double re = 100 - (100 * 0.20);
                    MessageBox.Show(Convert.ToString(re));
                }
                else if (valor == "2")
                {
                    double re = 100 - (100 * 0.10);
                    MessageBox.Show(Convert.ToString(re));
                }
                else
                {
                    double re = 100;
                    MessageBox.Show(Convert.ToString(re));
                }
            }
            //2
            else if (ser == "2")
            {
                if (valor == "1")
                {
                    double re = 50 - (50 * 0.20);
                    MessageBox.Show(Convert.ToString(re));
                }
                else if (valor == "2")
                {
                    double re = 50 - (50 * 0.10);
                    MessageBox.Show(Convert.ToString(re));
                }
                else
                {
                    double re = 50;
                    MessageBox.Show(Convert.ToString(re));
                }
            }

            //3
            else
            {
                if (valor == "1")
                {
                    double re = 200 - (200 * 0.20);
                    MessageBox.Show(Convert.ToString(re));
                }
                else if (valor == "2")
                {
                    double re = 200 - (200 * 0.10);
                    MessageBox.Show(Convert.ToString(re));
                }
                else
                {
                    double re = 200;
                    MessageBox.Show(Convert.ToString(re));
                }
            }


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tx1 = textBox1.Text;
            string tx2 = textBox2.Text;
            string tx3 = textBox4.Text;
            string tx4 = textBox5.Text;
         
            
        }
    }
}