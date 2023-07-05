namespace _3_Sayıdan_EnBüyük_ve_EnKüçük__OlanSayıyıBulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sayi3, enBuyuk, enKucuk;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            sayi3 = Convert.ToInt32(textBox3.Text);

            //En Büyük Sayıyı Bulma
            if (sayi1 > sayi2 && sayi1 > sayi3)
                enBuyuk = sayi1;
            else if (sayi2 > sayi3 && sayi2 > sayi1)
                enBuyuk = sayi2;
            else
                enBuyuk = sayi3;



            if (sayi1 < sayi2 && sayi1 < sayi3)
                enKucuk = sayi1;
            else if (sayi2 < sayi3 && sayi2 < sayi1)
                enKucuk = sayi2;
            else
                enKucuk = sayi3;


            textBox4.Text = enBuyuk.ToString();
            textBox5.Text = enKucuk.ToString();
        }
    }
}