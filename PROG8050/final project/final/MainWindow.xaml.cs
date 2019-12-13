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
using System.IO;
using System.Xml.Serialization;


namespace final
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<IItem> obs = null;
        string[] pl = new string[2] { "Is not plastic", "Is plastic" };
        string[] rf = new string[2] { "Is not refurbished", "Is refurbished"  };
        string[] wd = new string[2] { "Is not wooden", "Is wooden" };
        string[] sp = new string[1] { "Select item type" };
        UserList users = null;
        Toys toy = new Toys((ConditionType)1,0," "," "," "," ",Convert.ToBoolean(0)," ");
        public Toys Toy { get => toy; set => toy = value; }
        public MainWindow()
        {
            InitializeComponent();            
            ItTypeCombo.ItemsSource = Enum.GetValues(typeof(ItemType));
            ItConCombo.ItemsSource = Enum.GetValues(typeof(ConditionType));
            SpCondCombo.ItemsSource = sp;
            users = new UserList();
            obs = new ObservableCollection<IItem>();
            DataContext = this;
        }
        public ObservableCollection<IItem> Obs
        {
            get => obs;
            set => obs = value;
        }

        private void Display_Click(object sender, RoutedEventArgs e)
        {
            Display dis = new Display(users);
            dis.ShowDialog();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void ItTypeCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (ItTypeCombo.SelectedIndex)
            {
                default:
                    SpCondCombo.ItemsSource = "";
                    break;
                case 0:
                    SpCondCombo.ItemsSource = wd;
                    break;
                case 1:
                    SpCondCombo.ItemsSource = rf;
                    break;
                case 2:
                    SpCondCombo.ItemsSource = pl;
                    break;
            }
             
        }

        private void Add_Item_Click(object sender, RoutedEventArgs e)
        {

            if (Validation.GetErrors(FNameTxt).Count > 0 ||
                Validation.GetErrors(LNameTxt).Count > 0 ||
                Validation.GetErrors(CcTxt).Count > 0 ||
                Validation.GetErrors(ItNameTxt).Count > 0 ||
                Validation.GetErrors(ItDesc).Count > 0 ||
                Validation.GetErrors(ItPriceTxt).Count > 0)
            {
                Add_Item.IsEnabled = false;
                return;
            }
            switch (ItTypeCombo.SelectedIndex)
            {
                default:
                    MessageBox.Show("Choose item type");
                    break;
                case 0:
                    if (ItConCombo.SelectedIndex == -1)
                    {
                        MessageBox.Show("Choose condition");
                        return;
                    }
                    else if(SpCondCombo.SelectedIndex == -1)
                    {
                        MessageBox.Show("Choose special condition");
                        return;
                    }
                    users.Add(new Furniture((ConditionType)ItConCombo.SelectedIndex,
                                            int.Parse(ItPriceTxt.Text.Trim()),
                                            ItDesc.Text.Trim(),
                                            FNameTxt.Text.Trim(),
                                            LNameTxt.Text.Trim(),
                                            CcTxt.Text,
                                            Convert.ToBoolean(SpCondCombo.SelectedIndex),
                                            ItNameTxt.Text.Trim() )); 
                    obs.Clear();
                    obs.Add(users[users.Count() - 1]);
                    if (Grid.ItemsSource != obs)
                    {
                        Grid.ItemsSource = obs;
                    }
                    ClearData();
                    LComment.Content = "You successfully added:";
                    break;
                case 1:
                    if (ItConCombo.SelectedIndex == -1)
                    {
                        MessageBox.Show("Choose condition");
                        return;
                    }
                    else if (SpCondCombo.SelectedIndex == -1)
                    {
                        MessageBox.Show("Choose special condition");
                        return;
                    }
                    users.Add(new Appliances((ConditionType)ItConCombo.SelectedIndex,
                                            int.Parse(ItPriceTxt.Text.Trim()),
                                            ItDesc.Text.Trim(),
                                            FNameTxt.Text.Trim(),
                                            LNameTxt.Text.Trim(),
                                            CcTxt.Text,
                                            Convert.ToBoolean(SpCondCombo.SelectedIndex),
                                            ItNameTxt.Text.Trim()));
                    obs.Clear();
                    obs.Add(users[users.Count() - 1]);
                    if (Grid.ItemsSource != obs)
                    {
                        Grid.ItemsSource = obs;
                    }
                    ClearData();
                    LComment.Content = "You successfully added:";
                    break;
                case 2:
                    if (ItConCombo.SelectedIndex == -1)
                    {
                        MessageBox.Show("Choose condition");
                        return;
                    }
                    else if (SpCondCombo.SelectedIndex == -1)
                    {
                        MessageBox.Show("Choose special condition");
                        return;
                    }
                    users.Add(new Toys((ConditionType)ItConCombo.SelectedIndex,
                                       int.Parse(ItPriceTxt.Text.Trim()),
                                       ItDesc.Text.Trim(),
                                       FNameTxt.Text.Trim(),
                                       LNameTxt.Text.Trim(),
                                       CcTxt.Text,
                                       Convert.ToBoolean(SpCondCombo.SelectedIndex),
                                       ItNameTxt.Text.Trim()));
                    obs.Clear();                    
                    obs.Add(users[users.Count() - 1]);
                    if (Grid.ItemsSource != obs)
                    {
                        Grid.ItemsSource = obs;
                    }
                    ClearData();
                    LComment.Content = "You successfully added:";
                    break;

            }
        }
        private void ClearData()
        {
            ItConCombo.SelectedIndex = -1;
            ItTypeCombo.SelectedIndex = -1;
            SpCondCombo.SelectedIndex = -1;
            ItDesc.Text = string.Empty;
            FNameTxt.Text = string.Empty;
            LNameTxt.Text = string.Empty;
            CcTxt.Text = string.Empty;
            ItNameTxt.Text = string.Empty;
            ItPriceTxt.Text = string.Empty;
        }

        private void FNameTxt_GotFocus(object sender, RoutedEventArgs e)
        {
            if (FNameTxt.Text == " ")
            {
                FNameTxt.Text = "";
            }
        }

        private void FNameTxt_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (FNameTxt.Text == "")
            {
                Add_Item.IsEnabled = false;
            }
            else
                Add_Item.IsEnabled = true;
        }

        private void LNameTxt_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (LNameTxt.Text == "")
            {
                Add_Item.IsEnabled = false;
            }
            else
                Add_Item.IsEnabled = true;
        }

        private void LNameTxt_GotFocus(object sender, RoutedEventArgs e)
        {
            if (LNameTxt.Text == " ")
            {
                LNameTxt.Text = "";
            }
        }

        private void CcTxt_GotFocus(object sender, RoutedEventArgs e)
        {
            if (CcTxt.Text == " ")
            {
                CcTxt.Text = "";
            }
        }

        private void CcTxt_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (CcTxt.Text == "")
            {
                Add_Item.IsEnabled = false;
            }
            else
                Add_Item.IsEnabled = true;
        }

        private void ItNameTxt_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ItNameTxt.Text == "")
            {
                Add_Item.IsEnabled = false;
            }
            else
                Add_Item.IsEnabled = true;
        }

        private void ItNameTxt_GotFocus(object sender, RoutedEventArgs e)
        {
            if (ItNameTxt.Text == " ")
            {
                ItNameTxt.Text = "";
            }
        }

        private void ItDesc_GotFocus(object sender, RoutedEventArgs e)
        {
            if (ItDesc.Text == " ")
            {
                ItDesc.Text = "";
            }
        }

        private void ItDesc_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ItDesc.Text == "")
            {
                Add_Item.IsEnabled = false;
            }
            else
                Add_Item.IsEnabled = true;
        }

        private void ItPriceTxt_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ItPriceTxt.Text == "0" || ItPriceTxt.Text == "")
            {
                Add_Item.IsEnabled = false;
            }
            else
                Add_Item.IsEnabled = true;
        }

        private void ItPriceTxt_GotFocus(object sender, RoutedEventArgs e)
        {
            if (ItPriceTxt.Text == "0")
            {
                ItPriceTxt.Text = "";
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            WriteToFile(users);
            LComment.Content = "Saved successfully";
        }

        private void Load_Click(object sender, RoutedEventArgs e)
        {
            ReadFromFile();
            LComment.Content = "Loaded successfully";
        }
        private void WriteToFile(UserList c)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(UserList));
            TextWriter tw = new StreamWriter("users.xml");
            serializer.Serialize(tw, c);
            tw.Close();
        }
        private void ReadFromFile()
        {
            string curFile = @".\users.xml";
            if (File.Exists(curFile))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(UserList));
                TextReader tr = new StreamReader("users.xml");
                users.AddRange((UserList)serializer.Deserialize(tr));
                tr.Close();                
            }            
        }
    }
}
