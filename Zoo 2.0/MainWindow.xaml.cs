using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;

namespace Zoo_2._0
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection sqlConnection;
        public MainWindow()
        {
            InitializeComponent();

            
            string connetionString = ConfigurationManager.ConnectionStrings["Zoo_2._0.Properties.Settings.DataBase" +
                "ConnectionString"].ConnectionString;
            sqlConnection = new SqlConnection(connetionString);
            ShowZoos();
            ShowAllAnimals();
        }
        public void ShowZoos()
        {
            try
            {
                string query = "select * from Zoo";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);

                using (sqlDataAdapter)
                {
                    DataTable zooTable = new DataTable();
                    sqlDataAdapter.Fill(zooTable);
                    listZoo.DisplayMemberPath = "Location";
                    listZoo.SelectedValuePath = "Id";
                    listZoo.ItemsSource = zooTable.DefaultView;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        public void ShowAnimals()
        {
            try
            {
                string query = "select a.Id, a.Name from Animal a inner join AnimalZoo az on a.Id = az.AnimalId inner join Zoo z on az.ZooId = z.Id where az.ZooId = @ZooId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                using (sqlDataAdapter)
                {
                    sqlCommand.Parameters.AddWithValue("@ZooId", listZoo.SelectedValue);
                    DataTable aniTable = new DataTable();
                    sqlDataAdapter.Fill(aniTable);
                    listZooAnimals.DisplayMemberPath = "Name";
                    listZooAnimals.SelectedValuePath = "Id";
                    listZooAnimals.ItemsSource = aniTable.DefaultView;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void listZoo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ShowAnimals();
            ShowZooClickedListItem();
        }
        public void ShowAllAnimals()
        {
            try
            {
                string query = "select * from Animal";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);

                using (sqlDataAdapter)
                {
                    DataTable aniiTable = new DataTable();
                    sqlDataAdapter.Fill(aniiTable);
                    listAnimals.DisplayMemberPath = "Name";
                    listAnimals.SelectedValuePath = "Id";
                    listAnimals.ItemsSource = aniiTable.DefaultView;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void DeleteZoo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "delete from Zoo where Zoo.Id = @ZooId;";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@ZooId", listZoo.SelectedValue);
                sqlCommand.ExecuteScalar();
            }
            catch (Exception i)
            {
                MessageBox.Show(i.ToString());
            }
            finally
            {
                sqlConnection.Close();
                ShowZoos();
            }
            
            
        }
       
        private void DeleteAnimal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "delete from Animal where Animal.Id = @AnimalId;";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@AnimalId", listZooAnimals.SelectedValue);
                sqlCommand.ExecuteScalar();
            }
            catch (Exception i)
            {
                MessageBox.Show(i.ToString());
            }
            finally
            {
                sqlConnection.Close();
                ShowAllAnimals();
            }
        }

        private void AddAnimalToZoo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "insert into AnimalZoo values (@AnimalId,@ZooId)";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@AnimalId", listAnimals.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@ZooId", listZoo.SelectedValue);
                sqlCommand.ExecuteScalar();
            }
            catch (Exception i)
            {
                MessageBox.Show(i.ToString());
            }
            finally
            {
                sqlConnection.Close();

                ShowZoos();
                ShowAnimals();
            }
        }

        private void AddZoo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "insert into Zoo values ('" + TxBox.Text + "')";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.ExecuteScalar();
            }
            catch (Exception i)
            {
                MessageBox.Show(i.ToString());
            }
            finally
            {
                sqlConnection.Close();
                ShowZoos();
            }
        }

        private void AddAnimal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "insert into Animal values ('" + TxBox.Text + "')";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.ExecuteScalar();
            }
            catch (Exception i)
            {
                MessageBox.Show(i.ToString());
            }
            finally
            {
                sqlConnection.Close();
                ShowZoos();
            }
        }

        private void RemoveAnimal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "delete from AnimalZoo where AnimalZoo.AnimalId = @AnimalId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@AnimalId", listZooAnimals.SelectedValue);
                sqlCommand.ExecuteScalar();
            }
            catch (Exception i)
            {
                MessageBox.Show(i.ToString());
            }
            finally
            {
                sqlConnection.Close();

                ShowZoos();
                ShowAnimals();
            }
        }
        private void ShowZooClickedListItem()
        {
            try
            {
                string query = "select Location from Zoo where Zoo.Id = @ZooId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                using (sqlDataAdapter)
                {
                    sqlCommand.Parameters.AddWithValue("@ZooId", listZoo.SelectedValue);
                    DataTable zooTable = new DataTable();
                    sqlDataAdapter.Fill(zooTable);
                    TxBox.Text = zooTable.Rows[0]["Location"].ToString();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        private void ShowAnimalClickedListItem()
        {
            try
            {
                string query = "select Name from Animal where Animal.Id = @AnimalId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                using (sqlDataAdapter)
                {
                    sqlCommand.Parameters.AddWithValue("@AnimalId", listAnimals.SelectedValue);
                    DataTable zooTable = new DataTable();
                    sqlDataAdapter.Fill(zooTable);
                    TxBox.Text = zooTable.Rows[0]["Name"].ToString();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void listAnimals_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ShowAnimalClickedListItem();
        }

        private void UpdateZoo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "update Zoo set Location = @Location where Zoo.Id = @ZooId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@Location", TxBox.Text);
                sqlCommand.Parameters.AddWithValue("@ZooId", listZoo.SelectedValue);
                sqlCommand.ExecuteScalar();
            }
            catch (Exception i)
            {
                MessageBox.Show(i.ToString());
            }
            finally
            {
                sqlConnection.Close();
                ShowZoos();
            }
        }

        private void UpdateAnimal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string query = "update Animal set Name = @Name where Animal.Id = @AnimalId";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlConnection.Open();
                sqlCommand.Parameters.AddWithValue("@Name", TxBox.Text);
                sqlCommand.Parameters.AddWithValue("@AnimalId", listAnimals.SelectedValue);
                sqlCommand.ExecuteScalar();
            }
            catch (Exception i)
            {
                MessageBox.Show(i.ToString());
            }
            finally
            {
                sqlConnection.Close();
                ShowAllAnimals();
            }
        }
    }
}
