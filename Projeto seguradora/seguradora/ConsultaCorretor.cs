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
    public partial class ConsultaCorretor : Form
    {
        int pk_regi_corretor;
        public ConsultaCorretor()
        {
            InitializeComponent();
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Conexao.obterConexao();
            SqlCommand comm = new SqlCommand("SELECT cor.nome, cor.endereco, " +
                "cor.telefone, cor.regi_corretor, emp.cod_empresa  FROM " +
                "corretor cor INNER JOIN empresa emp ON cor.cod_empresa = emp.cod_empresa WHERE " +
                "cor.regi_corretor = '" + textpesquisa.Text + "';", conn);
            comm.CommandType = CommandType.Text;
            comm.Parameters.Add(new SqlParameter("@corretor", "corretor"));
            comm.Parameters.Add(new SqlParameter("@endereco", "endereco"));
            comm.Parameters.Add(new SqlParameter("@telefone", "telefone"));
            comm.Parameters.Add(new SqlParameter("@registro", "regi_corretor"));

            Conexao.obterConexao();
            DbDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                txtcorretor.Text = dr["nome"].ToString();
                txtendereco.Text = dr["endereco"].ToString();
                txttelefone.Text = dr["telefone"].ToString();
                txtcodempresa.Text = dr["cod_empresa"].ToString();
                txtregistro.Text = dr["regi_corretor"].ToString();
                pk_regi_corretor = int.Parse(dr["regi_corretor"].ToString());
            }
            Conexao.fecharConexao();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
