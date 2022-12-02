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

namespace WPF_Samostoyatelnaya
{
    /// <summary>
    /// Логика взаимодействия для PageTours.xaml
    /// </summary>
    public partial class PageTours : Page
    {
        public PageTours()
        {
            InitializeComponent();

            listBoxTourType.ItemsSource = Base.EM.Type.ToList();
            listBoxTourType.SelectedValuePath = "Id";
            listBoxTourType.DisplayMemberPath = "Name";


            listViewTours.ItemsSource = Base.EM.Tour.ToList();
        }
    }
}
