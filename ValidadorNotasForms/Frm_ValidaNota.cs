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
using NovoProjetoValidaNotasForms;

namespace ValidadorNotasForms
{
    public partial class Frm_ValidaNota : Form
    {
        List<Aluno> lstAluno = new List<Aluno>();
        Aluno aluno = new Aluno();
        Notas notas = new Notas();
        int recebeAlunoID = 0;

        List<NomeMateria> materia = new List<NomeMateria>();
        NomeMateria addMateria = new NomeMateria();



        public Frm_ValidaNota()
        {
            InitializeComponent();
        }
        // Registra o nome do Aluno
        private void btnSalvaNome_Click(object sender, EventArgs e)
        {
            // Cria a conexão.
            using (SqlConnection conectar = new SqlConnection(Properties.Settings.Default.connString))
            {
                // Crie um SqlCommand e identifique-o como um procedimento armazenado.
                using (SqlCommand sqlCommand = new SqlCommand("INSERT INTO Aluno(AlunoNome) OUTPUT INSERTED.AlunoID VALUES (@AlunoNome)", conectar))
                {
                    sqlCommand.CommandType = CommandType.Text;
                    // Adicione o parâmetro de entrada para o procedimento armazenado e especifique o que usar como valor.
                    sqlCommand.Parameters.Add(new SqlParameter("@AlunoNome", SqlDbType.NVarChar, 40));
                    sqlCommand.Parameters["@AlunoNome"].Value = txtNomeAluno.Text;

                    try
                    {
                        conectar.Open();

                        // Executa o procedimento armazenado e obtém o ID gerado.
                        recebeAlunoID = Convert.ToInt32(sqlCommand.ExecuteScalar());
                        aluno.AlunoNome = txtNomeAluno.Text;
                        lstAluno.Add(aluno);
                        MessageBox.Show("Nome do aluno registrado. ID: " + recebeAlunoID);
                        txtNomeAluno.Clear();
                    }
                    catch
                    {
                        MessageBox.Show("Por favor, registre o nome.");
                    }
                    finally
                    {
                        conectar.Close();

                    }
                }
            }
        }

        //Registra as notas do Aluno
        private void btnSalvaNota_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                connection.Open();

                using (SqlCommand sqlcommand = new SqlCommand("INSERT INTO Notas(AlunoID, NomeMateriaID, RecebeNotas) VALUES (@AlunoID, 9, @Matematica)", connection))
                {
                    sqlcommand.CommandType = CommandType.Text;
                    sqlcommand.Parameters.Add(new SqlParameter("@AlunoID", SqlDbType.Int));
                    sqlcommand.Parameters["@AlunoID"].Value = recebeAlunoID;

                    sqlcommand.Parameters.Add(new SqlParameter("@Matematica", SqlDbType.Int));
                    sqlcommand.Parameters["@Matematica"].Value = Convert.ToInt32(txtNotaMat.Text);

                    try
                    {
                        sqlcommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao registrar notas de Matemática: " + ex.Message);
                    }
                }
                using (SqlCommand sqlcommand = new SqlCommand("INSERT INTO Notas(AlunoID, NomeMateriaID, RecebeNotas) VALUES (@AlunoID, 10, @Português)", connection))
                {
                    sqlcommand.CommandType = CommandType.Text;
                    sqlcommand.Parameters.Add(new SqlParameter("@AlunoID", SqlDbType.Int));
                    sqlcommand.Parameters["@AlunoID"].Value = recebeAlunoID;

                    sqlcommand.Parameters.Add(new SqlParameter("@Português", SqlDbType.Int));
                    sqlcommand.Parameters["@Português"].Value = Convert.ToInt32(txtNotaPor.Text);

                    try
                    {
                        sqlcommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao registrar notas de Português: " + ex.Message);
                    }
                }
                using (SqlCommand sqlcommand = new SqlCommand("INSERT INTO Notas(AlunoID, NomeMateriaID, RecebeNotas) VALUES (@AlunoID, 11, @Artes)", connection))
                {
                    sqlcommand.CommandType = CommandType.Text;
                    sqlcommand.Parameters.Add(new SqlParameter("@AlunoID", SqlDbType.Int));
                    sqlcommand.Parameters["@AlunoID"].Value = recebeAlunoID;

                    sqlcommand.Parameters.Add(new SqlParameter("@Artes", SqlDbType.Int));
                    sqlcommand.Parameters["@Artes"].Value = Convert.ToInt32(txtNotaArt.Text);

                    try
                    {
                        sqlcommand.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao registrar notas de Artes: " + ex.Message);
                    }
                }
                using (SqlCommand sqlcommand = new SqlCommand("INSERT INTO Notas(AlunoID, NomeMateriaID, RecebeNotas) VALUES (@AlunoID, 12, @Fisica)", connection))
                {
                    sqlcommand.CommandType = CommandType.Text;

                    sqlcommand.Parameters.Add(new SqlParameter("@AlunoID", SqlDbType.Int));
                    sqlcommand.Parameters["@AlunoID"].Value = recebeAlunoID;

                    sqlcommand.Parameters.Add(new SqlParameter("@Fisica", SqlDbType.Int));
                    sqlcommand.Parameters["@Fisica"].Value = Convert.ToInt32(txtNotaFis.Text);

                    try
                    {
                        sqlcommand.ExecuteNonQuery();
                        MessageBox.Show("Notas Registradas");
                        txtNotaMat.Focus();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao registrar notas de Fisica: " + ex.Message);
                    }
                }
                connection.Close();
            }
        }

        //Limpa o nome do Aluno
        private void btLimpaNome_Click(object sender, EventArgs e)
        {
            txtNomeAluno.Clear();
        }

        //Limpa o nome do Aluno
        private void button1_Click(object sender, EventArgs e)
        {
            txtNomeAluno.Clear();
        }

        //Limpa nota do aluno
        private void btnLimpaNota_Click(object sender, EventArgs e)
        {
            LimpaNotas();
        }

        //Exibe resultado do Aluno
        private void btnExibirResul_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                {
                    connection.Open();
                    string query = "SELECT Aluno.AlunoID, Aluno.AlunoNome, NomeMateria.NomeMateria, Notas.RecebeNotas " +
                                   "FROM ((Aluno " +
                                   "INNER JOIN Notas ON Aluno.AlunoID = Notas.AlunoID) " +
                                   "INNER JOIN NomeMateria ON Notas.NomeMateriaID = NomeMateria.IDNomeMateria)";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        if (dataTable.Rows.Count > 0)
                        {
                            dgvExibeNotas.DataSource = null;
                            dgvExibeNotas.Columns.Clear();

                            DataTable resultTable = new DataTable();
                            resultTable.Columns.Add("AlunoID", typeof(int));
                            resultTable.Columns.Add("NomeAluno", typeof(string));

                            var materiasDistinct = dataTable.AsEnumerable().Select(row => row.Field<string>("NomeMateria")).Distinct();

                            foreach (var materia in materiasDistinct)
                            {
                                resultTable.Columns.Add(materia, typeof(double));
                            }

                            resultTable.Columns.Add("Total", typeof(double));

                            foreach (DataRow row in dataTable.Rows)
                            {
                                int alunoID = row.Field<int>("AlunoID");
                                string alunoNome = row.Field<string>("AlunoNome");
                                string materia = row.Field<string>("NomeMateria");
                                double nota = Convert.ToDouble(row.Field<object>("RecebeNotas") ?? 0);

                                DataRow resultRow;
                                var existingRow = resultTable.AsEnumerable().FirstOrDefault(r => r.Field<int>("AlunoID") == alunoID);

                                if (existingRow == null)
                                {
                                    resultRow = resultTable.NewRow();
                                    resultRow["AlunoID"] = alunoID;
                                    resultRow["NomeAluno"] = alunoNome;
                                    resultTable.Rows.Add(resultRow);
                                }
                                else
                                {
                                    resultRow = existingRow;
                                }

                                resultRow[materia] = nota;
                            }

                            foreach (DataRow row in resultTable.Rows)
                            {
                                double total = materiasDistinct.Sum(materia => Convert.ToDouble(row.Field<object>(materia) ?? 0));
                                row["Total"] = total;
                            }

                            dgvExibeNotas.DataSource = resultTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex);
            }
        }

        //Fecha formulário 
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Limpa as notas 
        private void LimpaNotas()
        {
            txtNotaMat.Clear();
            txtNotaPor.Clear();
            txtNotaFis.Clear();
            txtNotaArt.Clear();
        }

        private void btnExibeAprov_Click(object sender, EventArgs e)
        {
            try
            {
                //Cria a conexão
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                {
                    connection.Open();
                    //Consulta para a conexão 
                    string query = "SELECT Aluno.AlunoID, Aluno.AlunoNome, NomeMateria.NomeMateria, Notas.RecebeNotas " +
                                   "FROM ((Aluno " +
                                   "INNER JOIN Notas ON Aluno.AlunoID = Notas.AlunoID) " +
                                   "INNER JOIN NomeMateria ON Notas.NomeMateriaID = NomeMateria.IDNomeMateria)";

                    //Inicia a conexão com os parametros do SqlConnection com o adpatador 
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        //Cria um dataTable
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        //Realiza a consulta por Linha	
                        if (dataTable.Rows.Count > 0)
                        {
                            //Zera os dados anteriores da tabela (Caso tenha Algo anteriormente) 
                            dgvExibeNotas.DataSource = null;
                            dgvExibeNotas.Columns.Clear();

                            //Cria um novo dataTable com os parametros 
                            DataTable resultTable = new DataTable();
                            resultTable.Columns.Add("AlunoID", typeof(int));
                            resultTable.Columns.Add("NomeAluno", typeof(string));

                            // Retira as informações da coluna para uma variavel 
                            var materiasDistinct = dataTable.AsEnumerable().Select(row => row.Field<string>("NomeMateria")).Distinct();

                            //Realiza a consulta realiza a consulta das linhas inclusas na variavel 
                            foreach (var materia in materiasDistinct)
                            {
                                //adiciona a coluna com o dado retirado da variavel
                                resultTable.Columns.Add(materia, typeof(double));
                            }

                            // Cria um nova coluna, com o resultado total ( Sem parametro ainda) 
                            resultTable.Columns.Add("Total", typeof(string));

                            // Cria um datarow (datarow e a consulta por linhas do datatable)
                            foreach (DataRow row in dataTable.Rows)
                            {
                                //Parametros que estão sendo retirado da coluna e inserido em variavel 
                                int alunoID = row.Field<int>("AlunoID");
                                string alunoNome = row.Field<string>("AlunoNome");
                                string materia = row.Field<string>("NomeMateria");
                                double nota = Convert.ToDouble(row.Field<object>("RecebeNotas") ?? 0);

                                //Cria um novo datarow 
                                DataRow resultRow;

                                //retira os valores os ID do aluno e transforma em variavel 
                                var existingRow = resultTable.AsEnumerable().FirstOrDefault(r => r.Field<int>("AlunoID") == alunoID);

                                //Verifica se existe aluno, caso for nullo não cria linha 								
                                if (existingRow == null)
                                {
                                    resultRow = resultTable.NewRow();
                                    resultRow["AlunoID"] = alunoID;
                                    resultRow["NomeAluno"] = alunoNome;
                                    resultTable.Rows.Add(resultRow);
                                }
                                //Se o aluno não for nulo, cria os dados no gridview
                                else
                                {
                                    resultRow = existingRow;
                                }
                                //Insere os dados na coluna connforme cada materia
                                resultRow[materia] = nota;
                            }

                            //Realiza a soma das notas e adiciona na coluna total
                            foreach (DataRow row in resultTable.Rows)
                            {
                                double total = materiasDistinct.Sum(materia => Convert.ToDouble(row.Field<object>(materia) ?? 0));

                                if (total >= 28)
                                {
                                    row["Total"] = "Provado";
                                }
                                else
                                {
                                    row["Total"] = "Exame";
                                }



                                //row["Total"] = total;
                            }

                            //Insere todos os dados conforme o código assima no datagridview
                            dgvExibeNotas.DataSource = resultTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex);
            }
        }

        private void btnExcluiAluno_Click(object sender, EventArgs e)
        {
            try
            {
                string recebeNome = txtNomeAluno.Text;

                if (!string.IsNullOrEmpty(recebeNome))
                {
                    using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                    {
                        connection.Open();

                        using (SqlTransaction transacao = connection.BeginTransaction())
                        {
                            try
                            {
                                string queryDeleteNotas = "DELETE FROM Notas WHERE AlunoID IN (SELECT AlunoID FROM Aluno WHERE AlunoNome = @NomeAluno)";
                                using (SqlCommand comandoDeleteNotas = new SqlCommand(queryDeleteNotas, connection, transacao))
                                {
                                    comandoDeleteNotas.Parameters.AddWithValue("@NomeAluno", recebeNome);
                                    comandoDeleteNotas.ExecuteNonQuery();
                                }
                                string queryDeleteAluno = "DELETE FROM Aluno WHERE AlunoNome = @NomeAluno";
                                using (SqlCommand comandoDeleteAluno = new SqlCommand(queryDeleteAluno, connection, transacao))
                                {
                                    comandoDeleteAluno.Parameters.AddWithValue("@NomeAluno", recebeNome);
                                    comandoDeleteAluno.ExecuteNonQuery();
                                }
                                transacao.Commit();

                                MessageBox.Show("Aluno e suas notas excluido com sucesso");

                            }
                            catch (Exception ex)
                            {
                                transacao.Rollback();
                                MessageBox.Show("Erro : " + ex);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, insira o nome do aluno.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex);
            }
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            try
            {
                string recebeNome = txtNomeAluno.Text;
                if (!string.IsNullOrEmpty(recebeNome))
                {
                    using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                    {

                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
