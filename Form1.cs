namespace Sinema_Büfe_Satiş
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kasatutar = 0;

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int misir, su, çay, bilet, toplam;
            misir = Convert.ToInt16(TxtMısır.Text);
            su = Convert.ToInt16(TxtSu.Text);
            çay = Convert.ToInt16(TxtÇay.Text);
            bilet = Convert.ToInt16(TxtBilet.Text);
            toplam = misir * 50 + su * 5 + çay * 15 + bilet * 100;
            labelToplam.Text = toplam.ToString();
            kasatutar = kasatutar + toplam;
            labelKasaTutar.Text = kasatutar.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtMısır.Text = "";
            TxtSu.Text = "";
            TxtÇay.Text = "";
            TxtBilet.Text = "";
            TxtMısır.Focus();
        }
    }
}