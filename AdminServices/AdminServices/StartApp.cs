using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
namespace AdminServices
{
    public partial class presentacion: Form
    {
        List<Clientes> listaClientes;
        public presentacion()
        {
            InitializeComponent();
        }

        private void presentacion_Load(object sender, EventArgs e)
        {   
            loadClients();
        }
        private void loadClients()
        {
            try
            {
                NegocioClientes negocioCientes = new NegocioClientes();
                listaClientes = negocioCientes.ListClients();
                dgvClients.DataSource = listaClientes;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

        }
    }
}
