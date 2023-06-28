using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace PDV.Model
{
    class Funcionario
    {
        public string id { get; set; }
        public string nome { get; set; }

        public string cpf { get; set; }

        public static DataTable GetFuncionarios(string filtro = "")
        {
            var dt = new DataTable();
            string sql;
            if (filtro == "")
            {
                sql = "SELECT * FROM `pdv`.`funcionarios` ";
            }
            else
            {
                sql = $"SELECT * FROM `pdv`.`funcionarios`";
            }
            try
            {
                using (var cn = new MySqlConnection(Database.strConn))
                {
                    cn.Open();
                    using (var da = new MySqlDataAdapter(sql, cn))
                    {
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return dt;
        }
    }
}
