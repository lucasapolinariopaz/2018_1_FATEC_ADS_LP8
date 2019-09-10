using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace seguradora
{
    class Conexao
    {

        private static string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=E:\\seguradora v1.03\\seguradora\\seguradora.mdf;Integrated Security=True;User Instance=False";

        // representa a conexão com o banco
        private static SqlConnection conn = null;

        // método que permite obter a conexão
        public static SqlConnection obterConexao()
        {
            // vamos criar a conexão
            conn = new SqlConnection(connString);

            // a conexão foi feita com sucesso?
            try
            {
                // abre a conexão e a devolve ao chamador do método
                conn.Open();
            }
            catch (SqlException ex )
            {
                conn = null;
                MessageBox.Show("Erro: " + ex.ToString());
                // ops! o que aconteceu?
                // uma boa idéia aqui é gravar a exceção em um arquivo de log
            }

            return conn;
        }

        public static void fecharConexao()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }
    }



















}

