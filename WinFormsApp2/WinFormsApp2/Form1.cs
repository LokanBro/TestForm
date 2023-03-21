namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private readonly Calculator _calculator;
        public Form1()
        {
            InitializeComponent();
            _calculator = new Calculator();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var from = ConverToDecimal(textBox2.Text);
            var till = ConverToDecimal(textBox1.Text);
            var newdigital = _calculator.Digitalnumbersinrange(from, till);
            var fivedigital = _calculator.Digital5(newdigital);
            textBox3.Text = string.Join(",", newdigital);
            textBox4.Text = string.Join(",", fivedigital);
            textBox5.Text = newdigital.Sum().ToString();
        }

        private decimal ConverToDecimal(string value)
        {
            if (!decimal.TryParse(value.Replace('.', ','), out var result))
            {
                MessageBox.Show("Ошибка");
                return 0;
            }
            else if (result > int.MaxValue)
            {
                MessageBox.Show("Слишком большое число");
                return 0;
            }
            return result;
        }


    }
}