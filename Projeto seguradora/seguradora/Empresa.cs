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

namespace seguradora
{
    public partial class Empresa : Form
    {
        public Empresa()
        {
            InitializeComponent();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Empresa_Load(object sender, EventArgs e)
        {
            SqlConnection conn = Conexao.obterConexao();
            SqlCommand comm = new SqlCommand("SELECT * from empresa", conn);
            comm.CommandType = CommandType.Text;
            comm.Parameters.Add(new SqlParameter("@nome", "nome"));
            comm.Parameters.Add(new SqlParameter("@razao", "razao_social"));

            Conexao.obterConexao();
            DbDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                lblempresa.Text = dr["nome"].ToString();
                txtrazao.Text = dr["razao_social"].ToString();
            }
            Conexao.fecharConexao();
        }
    }
}
