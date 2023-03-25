using System.Drawing;
using OC;
using Contabilidad;

namespace Principal
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

        private void button1_Click(object sender, EventArgs e)
        {
            Conta mv = new Conta();
            mv.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OrdendeCompra mv = new OrdendeCompra();
            mv.Show();
        }
    }
}