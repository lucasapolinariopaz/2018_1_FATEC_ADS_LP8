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
    public partial class Consulta_Acidente : Form
    { 
          
        public Consulta_Acidente()
        {
            InitializeComponent();
        }
        
        
        private void btnbusca_Click(object sender, EventArgs e)
        {
            SqlConnection conn = Conexao.obterConexao();
            SqlCommand comm = new SqlCommand("select c.modelo,c.marca,c.placa,c.ano_modelo,c.ano_fabricao," +
                "c.chassi,a.local,a.cod_aci,a.descricao,a.hora, a.data from carro c, acidente a where a.cod_carro=c.cod_car and c.placa='" + txtplaca.Text + "';", conn);
            comm.CommandType = CommandType.Text;
            comm.Parameters.Add(new SqlParameter("@modelo", "modelo"));
            comm.Parameters.Add(new SqlParameter("@marca", "marca"));
            comm.Parameters.Add(new SqlParameter("@ano_modelo", "ano_modelo"));
            comm.Parameters.Add(new SqlParameter("@ano_fabricao", "ano_fabricao"));
            comm.Parameters.Add(new SqlParameter("@chassi", "chassi"));
            comm.Parameters.Add(new SqlParameter("@local", "local"));
            comm.Parameters.Add(new SqlParameter("@data", "data"));
            comm.Parameters.Add(new SqlParameter("@hora", "hora"));
            comm.Parameters.Add(new SqlParameter("@cod_aci", "cod_aci"));
            comm.Parameters.Add(new SqlParameter("@descricao", "descricao"));


            Conexao.obterConexao();
            DbDataReader dr = comm.ExecuteReader();
            while (dr.Read())
            {
                txtmodelo.Text = dr["modelo"].ToString();
                txtmarca.Text = dr["marca"].ToString();
                txtanomodelo.Text = dr["ano_modelo"].ToString();
                txtfabricao.Text = dr["ano_fabricao"].ToString();
                txtchassi.Text = dr["chassi"].ToString();
                txtlocal.Text = dr["local"].ToString();
                txtdata.Text = dr["data"].ToString();
                txthora.Text = dr["hora"].ToString();
                txtaci.Text = dr["cod_aci"].ToString();
                txtdescricao.Text = dr["descricao"].ToString();

            }
            Conexao.fecharConexao();

        }

        private void btnALTERAR_Click(object sender, EventArgs e)
        {
            txtdata.Enabled = true;
            txthora.Enabled = true;
            txtlocal.Enabled = true;
            txtdescricao.Enabled = true;
            btnsalvar.Enabled = true;

            }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE acidente SET local=@local, data=@data, hora=@hora, descricao=@descricao ";
            SqlConnection conn = Conexao.obterConexao();
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.Parameters.Add(new SqlParameter("@local", txtlocal.Text));
            comm.Parameters.Add(new SqlParameter("@data", txtdata.Text));
            comm.Parameters.Add(new SqlParameter("@hora", txthora.Text));
            comm.Parameters.Add(new SqlParameter("@descricao", txtdescricao.Text));
            comm.CommandType = CommandType.Text;
            Conexao.obterConexao();
            try
            {
                int i = comm.ExecuteNonQuery();
                if (i > 0)
                    MessageBox.Show("Registro atualizado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                Conexao.fecharConexao();
            }
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
    }
