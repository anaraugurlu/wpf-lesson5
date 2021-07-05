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

namespace wpf_lesson5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      
        public List<Book> Books { get; set; } = new List<Book>
        {
            new Book
            {
                Id=1,
                Author ="richter",
                Genre ="Fun",
                Pages=1100,
                Publisher ="Baku INC",
                Tittle="little prinve",

            },
             new Book
            {
                Id=2,
                Author ="gof",
                Genre ="Fun",
                Pages=1100,
                Publisher ="Baku INC",
                Tittle="little prinve",

            },
              new Book
            {
                Id=3,
                Author ="exupery",
                Genre ="Fun",
                Pages=1100,
                Publisher ="Baku INC",
                Tittle="little prinve",

            }
        };
        public MainWindow()
        {
            InitializeComponent();
            //listview.ItemsSource = Books;
            DataContext = this;
        }
        public int MyWidth { get; set; } = 350;
    }
}
