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
using System.Windows.Shapes;
using System.Linq;

namespace final
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Display : Window
    {
        private UserList u = null;
        public UserList U { get => u; set => u = value; }
        string[] filters = new string[6] { "New", "Used", "Damaged", "Toys", "Furniture", "Appliances" };
        public Display(UserList users)
        {
            InitializeComponent();
            CmbFilter.ItemsSource = filters;
            U = users;
            //GridDisp.ItemsSource = U;            
            if(users == null)
            {
                BtnFilter.IsEnabled = false;
            }
            DataContext = this;
            
        }

        private void BtnDispClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnFilter_Click(object sender, RoutedEventArgs e)
        {
            
            switch (CmbFilter.SelectedIndex)
            {
                default:
                    MessageBox.Show("Choose something");
                    break;
                case 0:
                    var queryNew = from item in U where item.Condition == ConditionType.New orderby item.Price select item;                    
                    GridDisp.ItemsSource = queryNew;
                    break;
                case 1:
                    var queryUsed = from item in U where item.Condition == ConditionType.Used orderby item.Price select item;
                    GridDisp.ItemsSource = queryUsed;
                    break;
                case 2:
                    var queryDamaged = from item in U where item.Condition == ConditionType.Damaged orderby item.Price select item;
                    GridDisp.ItemsSource = queryDamaged;
                    break;
                case 3:
                    var queryToy = from item in U where item.Type == ItemType.Toys orderby item.Price select item;
                    GridDisp.ItemsSource = queryToy;
                    break;
                case 4:
                    var queryFur = from item in U where item.Type == ItemType.Furniture orderby item.Price select item;
                    GridDisp.ItemsSource = queryFur;
                    break;
                case 5:
                    var queryApp = from item in U where item.Type == ItemType.Appliances orderby item.Price select item;
                    GridDisp.ItemsSource = queryApp;
                    break;
            }
        }

        private void BtnAll_Click(object sender, RoutedEventArgs e)
        {
            GridDisp.ItemsSource = u;
        }
    }
}
