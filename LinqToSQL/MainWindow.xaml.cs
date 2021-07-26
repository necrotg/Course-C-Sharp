using System;
using System.Collections.Generic;
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
using System.Data.SqlClient;
using System.Configuration;
using System.Security;

namespace LinqToSQL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary> 
    public partial class MainWindow : Window
    {
        DataClasses1DataContext dataContext;

        public MainWindow()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings["LinqToSQL.Properties.Settings.DataBaseConnectionString"].ConnectionString;
            dataContext = new DataClasses1DataContext(connectionString);
            //  InsertUniversities();
            // InsertStudants();
            //  InsertLectures();
            InsertStudantLecture();

        }

        public void InsertUniversities()
        {
            //dataContext.ExecuteCommand("delete from University");

            University yale = new University();
            yale.Name = "Yale";
            dataContext.Universities.InsertOnSubmit(yale);
            University UCLA = new University();
            UCLA.Name = "UCLA";
            dataContext.Universities.InsertOnSubmit(UCLA);
            dataContext.SubmitChanges();

            DataGrid.ItemsSource = dataContext.Universities;
        }

        public void InsertStudants()
        {
            University yale = dataContext.Universities.First(un => un.Name.Equals("Yale"));
            University UCLA = dataContext.Universities.First(un => un.Name.Equals("UCLA"));
            List<Studant> studants = new List<Studant>();

            studants.Add(new Studant { Name = "Rafael", Age = 23, Gender = "Gerder-Fluid", UniversityId = yale.Id });
            studants.Add(new Studant { Name = "Rhayssa", Age = 20, Gender = "Female", University = UCLA});
            dataContext.Studants.InsertAllOnSubmit(studants);
            dataContext.SubmitChanges();
            DataGrid.ItemsSource = dataContext.Studants;

        }
        public void InsertLectures()
        {
            List<Lecture> lectures = new List<Lecture>();
            lectures.Add(new Lecture { Name = "MATH" });
            lectures.Add(new Lecture { Name = "Chemistry" });
            lectures.Add(new Lecture { Name = "English" });
            dataContext.Lectures.InsertAllOnSubmit(lectures);
            dataContext.SubmitChanges();
            DataGrid.ItemsSource = dataContext.Lectures;
        }
        public void InsertStudantLecture()
        {
            Studant Rafael = dataContext.Studants.First(st => st.Name.Equals("Rafael"));
            Studant Rhayssa = dataContext.Studants.First(st => st.Name.Equals("Rhayssa"));
            Lecture Math = dataContext.Lectures.First(lc => lc.Name.Equals("MATH"));
            Lecture Chemistry = dataContext.Lectures.First(lc => lc.Name.Equals("Chemistry"));
            Lecture English = dataContext.Lectures.First(lc => lc.Name.Equals("English"));

            dataContext.StudantLectures.InsertOnSubmit(new StudantLecture { Studant = Rafael, Lecture = Math });
            dataContext.StudantLectures.InsertOnSubmit(new StudantLecture { Studant = Rhayssa, Lecture = English});
            dataContext.SubmitChanges();
            DataGrid.ItemsSource = dataContext.StudantLectures;

        }
    }
}
