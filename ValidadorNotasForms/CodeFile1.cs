//// Storage for IDENTITY values returned from database.
//private int parsedCustomerID;
//private int orderID;

///// <summary>
///// Verifies that the customer name text box is not empty.
///// </summary>
//private bool IsCustomerNameValid()
//{
//    if (txtCustomerName.Text == "")
//    {
//        MessageBox.Show("Please enter a name.");
//        return false;
//    }
//    else
//    {
//        return true;
//    }
//}

///// <summary>
///// Verifies that a customer ID and order amount have been provided.
///// </summary>
//private bool IsOrderDataValid()
//{
//    // Verify that CustomerID is present.
//    if (txtCustomerID.Text == "")
//    {
//        MessageBox.Show("Please create customer account before placing order.");
//        return false;
//    }
//    // Verify that Amount isn't 0.
//    else if ((numOrderAmount.Value < 1))
//    {
//        MessageBox.Show("Please specify an order amount.");
//        return false;
//    }
//    else
//    {
//        // Order can be submitted.
//        return true;
//    }
//}

///// <summary>
///// Clears the form data.
///// </summary>
//private void ClearForm()
//{
//    txtCustomerName.Clear();
//    txtCustomerID.Clear();
//    dtpOrderDate.Value = DateTime.Now;
//    numOrderAmount.Value = 0;
//    this.parsedCustomerID = 0;
//}


//// Cria um novo cliente chamando o procedimento armazenado Sales.uspNewCustomer.
//private void btnCreateAccount_Click(object sender, EventArgs e)
//{
//    if (IsCustomerNameValid())
//    {
//        // Cria a conexão.
//        using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
//        {
//            // Crie um SqlCommand e identifique-o como um procedimento armazenado.
//            using (SqlCommand sqlCommand = new SqlCommand("Sales.uspNewCustomer", connection))
//            {
//                sqlCommand.CommandType = CommandType.StoredProcedure;

//                // Adicione o parâmetro de entrada para o procedimento armazenado e especifique o que usar como valor.
//                sqlCommand.Parameters.Add(new SqlParameter("@CustomerName", SqlDbType.NVarChar, 40));
//                sqlCommand.Parameters["@CustomerName"].Value = txtCustomerName.Text;

//                // Adicione o parâmetro de saída.
//                sqlCommand.Parameters.Add(new SqlParameter("@CustomerID", SqlDbType.Int));
//                sqlCommand.Parameters["@CustomerID"].Direction = ParameterDirection.Output;

//                try
//                {
//                    connection.Open();

//                    //Executa o procedimento armazenado.
//                    sqlCommand.ExecuteNonQuery();

//                    // ID do cliente é um valor IDENTITY do banco de dados.
//                    this.parsedCustomerID = (int)sqlCommand.Parameters["@CustomerID"].Value;

//                    // Coloque o valor do ID do cliente na caixa de texto somente leitura.
//                    this.txtCustomerID.Text = Convert.ToString(parsedCustomerID);
//                }
//                catch
//                {
//                    MessageBox.Show("Customer ID was not returned. Account could not be created.");
//                }
//                finally
//                {
//                    connection.Close();
//                }
//            }
//        }
//    }
//}

///// Chama o procedimento armazenado Sales.uspPlaceNewOrder para fazer um pedido.
//private void btnPlaceOrder_Click(object sender, EventArgs e)
//{
//    // Certifique-se de que a entrada necessária esteja presente.
//    if (IsOrderDataValid())
//    {
//        // Cria a conexão.
//        using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
//        {
//            // Cria SqlCommand e identifica-o como um procedimento armazenado.
//            using (SqlCommand sqlCommand = new SqlCommand("Sales.uspPlaceNewOrder", connection))
//            {
//                sqlCommand.CommandType = CommandType.StoredProcedure;

//                // Adicione o parâmetro de entrada @CustomerID, obtido de uspNewCustomer.
//                sqlCommand.Parameters.Add(new SqlParameter("@CustomerID", SqlDbType.Int));
//                sqlCommand.Parameters["@CustomerID"].Value = this.parsedCustomerID;

//                // Adicione o parâmetro de entrada @OrderDate.
//                sqlCommand.Parameters.Add(new SqlParameter("@OrderDate", SqlDbType.DateTime, 8));
//                sqlCommand.Parameters["@OrderDate"].Value = dtpOrderDate.Value;

//                // Adicione o parâmetro de entrada do valor do pedido @Amount.
//                sqlCommand.Parameters.Add(new SqlParameter("@Amount", SqlDbType.Int));
//                sqlCommand.Parameters["@Amount"].Value = numOrderAmount.Value;

//                // Adicione o parâmetro de entrada de status do pedido @Status.
//                // Para um novo pedido, o status é sempre O (aberto).
//                sqlCommand.Parameters.Add(new SqlParameter("@Status", SqlDbType.Char, 1));
//                sqlCommand.Parameters["@Status"].Value = "O";

//                // Adicione o valor de retorno do procedimento armazenado, que é o ID do pedido.
//                sqlCommand.Parameters.Add(new SqlParameter("@RC", SqlDbType.Int));
//                sqlCommand.Parameters["@RC"].Direction = ParameterDirection.ReturnValue;

//                try
//                {
//                    //Abre conexão.
//                    connection.Open();

//                    //Executa o procedimento armazenado.
//                    sqlCommand.ExecuteNonQuery();

//                    //Exibe o número do pedido.
//                    this.orderID = (int)sqlCommand.Parameters["@RC"].Value;
//                    MessageBox.Show("Order number " + this.orderID + " has been submitted.");
//                }
//                catch
//                {
//                    MessageBox.Show("Order could not be placed.");
//                }
//                finally
//                {
//                    connection.Close();
//                }
//            }
//        }
//    }
//}


///// Clears the form data so another new account can be created.
//private void btnAddAnotherAccount_Click(object sender, EventArgs e)
//{
//    this.ClearForm();
//}


///// Closes the form/dialog box.
//private void btnAddFinish_Click(object sender, EventArgs e)
//{
//    this.Close();
//}