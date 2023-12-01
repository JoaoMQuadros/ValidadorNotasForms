using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ValidadorNotasForms
{
    public partial class Frm_ValidaNota : Form
    {
        List<Aluno> lstAluno = new List<Aluno>();
        Aluno aluno = new Aluno();
        Notas notas = new Notas();

        public Frm_ValidaNota()
        {
            InitializeComponent();
        }
        // Cria um novo cliente chamando o procedimento armazenado
        private void btnSalvaNome_Click(object sender, EventArgs e)
        {
            // Cria a conexão.
            using (SqlConnection conectar = new SqlConnection(Properties.Settings.Default.connString))
            {
                // Crie um SqlCommand e identifique-o como um procedimento armazenado.
                using (SqlCommand sqlCommand = new SqlCommand("ValidadorNotasForms.uspNewCustomer", conectar))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    // Adicione o parâmetro de entrada para o procedimento armazenado e especifique o que usar como valor.
                    sqlCommand.Parameters.Add(new SqlParameter("@NomeAluno", SqlDbType.NVarChar, 50));
                    sqlCommand.Parameters["@NomeAluno"].Value = txtNomeAluno.Text;

                    // Adicione o parâmetro de saída.
                    sqlCommand.Parameters.Add(new SqlParameter("@IdAluno", SqlDbType.Int));
                    sqlCommand.Parameters["@IdAluno"].Direction = ParameterDirection.Output;         

                    try
                    {
                        conectar.Open();

                        sqlCommand.ExecuteNonQuery();

                        aluno.NomeAluno = (string)sqlCommand.Parameters["@NomeAluno"].Value;

                        txtNomeAluno.Text = Convert.ToString(aluno.NomeAluno);                        
                    }
                    catch
                    {
                        MessageBox.Show("Não deu certo");
                    }
                    finally
                    {
                        conectar.Close();
                    }
                }
            }
        }
    }
}
