using System.Diagnostics.Metrics;

namespace Lb_6_2
{
    public partial class Lab7 : Form
    {
        public Lab7()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // здесь ваш код
            int counter = 0; // количество слагаемых
            double sum = 0; // сумма
            double summand = 0.0; // слагаемое
            double x;
            double precision;
            //...
            bool f = false;
            if (double.TryParse(txtPrecision.Text, out precision))
            {
                f = true;
            }
            do
            {
                counter++;
                if (double.TryParse(txtX.Text, out x))
                {
                    summand = double.Parse(txtX.Text) / counter;
                }
                sum += summand;
            } while (f && Math.Abs(summand) > precision);
            lblResult.Text = "сумма = " + sum + ", количество = " + counter;
            
        }

        private void txtPrecision_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //...

    }
}