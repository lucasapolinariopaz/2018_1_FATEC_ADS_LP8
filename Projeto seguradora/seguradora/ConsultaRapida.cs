using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace seguradora
{
    public partial class ConsultaRapida : Form
    {
       
        public ConsultaRapida()
        {
            InitializeComponent();
        }

       

        private void ConsultaRapida_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'seguradoraDataSet.carro' table. You can move, or remove it, as needed.
            this.carroTableAdapter.Fill(this.seguradoraDataSet.carro);

        }
    }
}
