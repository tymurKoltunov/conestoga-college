using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using assignment3;
using System.IO;
using System.Xml.Serialization;

namespace assignment4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        private ObservableCollection<IBuilding> obs = null;
        CustomersList customers = null;
        CustomersList output = null;
        Barn barn = new Barn(0, 0, 0, " ");
        public Barn Barn { get => barn; set => barn = value; }
        
        public MainWindow()
        {            
            InitializeComponent();
            
            customers = new CustomersList();
            output = new CustomersList();
            obs = new ObservableCollection<IBuilding>();
            cmbType.Items.Add("Barn");
            cmbType.Items.Add("Garage");
            cmbType.Items.Add("House");
            DataContext = this;
            
            
        }
        public ObservableCollection<IBuilding> Obs
        {
            get => obs;
            set => obs = value;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            
            if (Validation.GetErrors(TxtSize).Count > 0 ||
                Validation.GetErrors(TxtBulbs).Count > 0 || 
                Validation.GetErrors(TxtOutlets).Count > 0 ||
                Validation.GetErrors(TxtCC).Count > 0)
            {
                BtnAdd.IsEnabled = false;
                return;
            }           
            int size = int.Parse(TxtSize.Text.Trim());
            int bulbs = int.Parse(TxtBulbs.Text.Trim());
            int outlets = int.Parse(TxtOutlets.Text.Trim());
            int i = -1;
            string cc = TxtCC.Text;
            switch (cmbType.SelectedIndex)
            {
                default:
                    MessageBox.Show("Choose building type");
                    break;
                case 0:
                    
                        customers.Add(new Barn(size, bulbs, outlets, cc));
                        i++;
                        
                        obs.Clear();
                        obs.Add(new Barn(size, bulbs, outlets, cc));
                        if (Grid.ItemsSource != obs)
                        {
                            Grid.ItemsSource = obs;
                        }
                        D_TB.Text = "Showing JUST ADDED";
                        ClearData();
                    
                    break;
                case 1:
                    
                        customers.Add(new Garage(size, bulbs, outlets, cc));
                        i++;
                        
                        obs.Clear();
                        obs.Add(new Garage(size, bulbs, outlets, cc));
                        if (Grid.ItemsSource != obs)
                        {
                            Grid.ItemsSource = obs;
                        }
                        ClearData();
                    
                    break;
                case 2:
                    
                        customers.Add(new House(size, bulbs, outlets, cc));
                        i++;                        
                        obs.Clear();
                        obs.Add(new House(size, bulbs, outlets, cc));
                        if (Grid.ItemsSource != obs)
                        {
                            Grid.ItemsSource = obs;
                        }
                        
                        ClearData();
                    
                    break;
            }           
        }
        private void BtnLoad_Click(object sender, RoutedEventArgs e)
        {
            output = ReadFromFile();            
            output.Sort();
            Grid.ItemsSource = output;
            D_TB.Text = "Showing ALL";

        }
        private void WriteToFile(CustomersList c)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(CustomersList));
            TextWriter tw = new StreamWriter("customers.xml");
            serializer.Serialize(tw, c);
            tw.Close();
        }
        private CustomersList ReadFromFile()
        {
            string curFile = @".\customers.xml";
            if (File.Exists(curFile))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(CustomersList));
                TextReader tr = new StreamReader("customers.xml");
                output = (CustomersList)serializer.Deserialize(tr);
                tr.Close();
                customers = output;
                return output;
            }
            return output;
        }
        private void ClearData()
        {
            cmbType.SelectedIndex = -1;
            TxtCC.Text = string.Empty;
            TxtSize.Text = string.Empty;
            TxtBulbs.Text = string.Empty;
            TxtOutlets.Text = string.Empty;
        }       
        
        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            WriteToFile(customers);
        }

        private void BtnFilter_Click(object sender, RoutedEventArgs e)
        {
            string filter = TxtFilter.Text;
            TxtFilter.Text = string.Empty;
            if(filter == Enum.GetName(typeof(BuildingType), 1) || filter == Enum.GetName(typeof(BuildingType), 2) || filter == Enum.GetName(typeof(BuildingType), 3))
            {
                var query = from building in customers where Enum.GetName(typeof(BuildingType), building.T) == filter orderby building.Size select building;
                Grid.ItemsSource = query;
                D_TB.Text = string.Format("Showing {0}s", filter);
            }
            
        }
        protected void ValidationError(object sender, ValidationErrorEventArgs e)
        {
            
            
        }

        private void TxtBulbs_GotFocus(object sender, RoutedEventArgs e)
        {
            if(TxtBulbs.Text == "0")
            {
                TxtBulbs.Text = "";
            }            
        }
        private void TxtSize_GotFocus(object sender, RoutedEventArgs e)
        {
            if (TxtSize.Text == "0")
            {
                TxtSize.Text = "";
            }
        }
        private void TxtOutlets_GotFocus(object sender, RoutedEventArgs e)
        {
            if (TxtOutlets.Text == "0")
            {
                TxtOutlets.Text = "";
            }
        }
        private void TxtFilter_GotFocus(object sender, RoutedEventArgs e)
        {
            TxtFilter.Text = "";
        }

        private void TxtSize_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(TxtSize.Text == "0" || TxtSize.Text == "")
            {
                BtnAdd.IsEnabled = false;
            }
            else
                BtnAdd.IsEnabled = true;
        }

        private void TxtBulbs_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TxtBulbs.Text == "0"|| TxtBulbs.Text == "")
            {
                BtnAdd.IsEnabled = false;
            }
            else
                BtnAdd.IsEnabled = true;
        }

        private void TxtOutlets_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TxtOutlets.Text == "0"|| TxtOutlets.Text == "")
            {
                BtnAdd.IsEnabled = false;
            }
            else
                BtnAdd.IsEnabled = true;
        }

        private void TxtCC_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (TxtCC.Text == " " || TxtCC.Text == "")
            {
                BtnAdd.IsEnabled = false;
            }
            else
                BtnAdd.IsEnabled = true;
        }

        private void TxtCC_GotFocus(object sender, RoutedEventArgs e)
        {
            if (TxtCC.Text == " ")
            {
                TxtCC.Text = "";
            }
        }
    }
}
