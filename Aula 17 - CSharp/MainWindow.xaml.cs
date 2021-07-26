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

namespace Aula_17___CSharp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            List<Matches> list = new List<Matches>();
            list.Add(new Matches() { Team1 = "Flamengo", Team2 = "Pain", Score1 = 12, Score2 = 25, Progression = 55 });
            list.Add(new Matches() { Team1 = "Vorax", Team2 = "Pain", Score1 = 12, Score2 = 25, Progression = 55 });
            list.Add(new Matches() { Team1 = "Flamengo", Team2 = "INTZ", Score1 = 12, Score2 = 25, Progression = 55 });
            list.Add(new Matches() { Team1 = "COMI", Team2 = "SUA MAE", Score1 = 12, Score2 = 25, Progression = 55 });
            lbMatches.ItemsSource = list;
        }
    }

    public class Matches
    {
        public string Team1{ get; set; }
        public int Score1{ get; set; }
        public int Score2{ get; set; }
        public string Team2 { get; set; }
        public int Progression { get; set; }
    }
}
