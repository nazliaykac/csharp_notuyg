namespace csharp_notuyg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double s1, s2, p1, ort;
            string durum;
            s1=double.Parse(textBox1.Text);
            s2=double.Parse(textBox2.Text);
            p1 = double.Parse(textBox3.Text);
            ort = (s1 + s2 + p1) / 3;
            if (ort <= 50)
            {
                durum = "geçti";


                textBox4.Text = ort.ToString("0.00") + "/" + durum;
            }
            if (ort > 50)
            {
                durum = "kaldý";
                textBox4.Text = ort.ToString("0.00")+"/"+durum;
            }
        }
    }
}
