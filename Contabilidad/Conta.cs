using static System.Runtime.InteropServices.JavaScript.JSType;
using Basededatos;

namespace Contabilidad
{
    public partial class Conta : Form
    {
        
        public Conta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var NombreC = NombreConta.Text;
            var DepartamentoC = DepartamentoConta.Text;
            Basededatos objDatos = new Basededatos();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}