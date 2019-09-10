using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace seguradora
{
    class Conexao
    {   
        private String _stringConexao;
        private SqlConnection _conexao;
        public Conexao(String dadosConexao)
        {
            this._conexao = new SqlConnection();
            this._stringConexao = dadosConexao;
            this._conexao.ConnectionString = dadosConexao;
        }
       
        public String StringConexao
        {
            get { return this._stringConexao; }
            set { this._stringConexao = value; }
        }
        public SqlConnection ObejtoConexao
        {
            get { return this._conexao; }
            set { this._conexao = value; }

        }
        public void Conectar()
        {
            this._conexao.Open();
        }
        public void desconectar()
        {
            this._conexao.Close();
        }





















    }
}
