namespace ikiSayiyiToplayanÖrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {


         int    sayi1 = Convert.ToInt32(textBox1.Text);
         int    sayi2 = Convert.ToInt32(textBox2.Text);

            int sonuc = sayi1+sayi2 ;


            label4.Text = Convert.ToString(sonuc);
        }
    }
}