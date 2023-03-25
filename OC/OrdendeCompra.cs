using Basededatos;
using System.Data;

namespace OC
{
    

    public partial class OrdendeCompra : Form
    {
        public OrdendeCompra()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Nombreoc = NombreOc.Text;
            var Departamentooc = DepartamentoOc.Text;
            
        }

        private void NombreOc_TextChanged(object sender, EventArgs e)
        {

        }

        private void DepartamentoOc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}