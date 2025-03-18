using System.Diagnostics;

namespace rabota2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            double sum;
            int period;
            double percent;
            double profit;
            sum = System.Convert.ToDouble(textBox1.Text);
            period = System.Convert.ToInt32(textBox2.Text);
            if (sum < 10000)
            {
                percent = 3.5;
            }
            else
            {
                percent = 4.5;
            }
            profit = sum * (percent / 100 / 12) * period;
            label2.Text = "Процентная ставка: " + percent.ToString("n") + "%\n" + "Доход: " + profit.ToString("c");

            void label5_Click(object sender, EventArgs e)
            {
                label2.Text = "";

            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        public void label5_Click(object sender, EventArgs e)
        {
          

        }
    }
}