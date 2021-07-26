using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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

namespace Zoooo
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

            string connectionString = ConfigurationManager.ConnectionStrings["Zoooo.Properties.Settings.DataBaseConnectionString"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);
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
            string query = "delete from AnimalZoo where AnimalZoo.ZooId = @ZooId;delete from Zoo where Zoo.Id = @ZooId;";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            sqlCommand.Parameters.AddWithValue("@ZooId", listZoo.SelectedValue);
            sqlCommand.ExecuteScalar();
            sqlConnection.Close();
            ShowAnimals();
            ShowZoos();
        }
    }
}
