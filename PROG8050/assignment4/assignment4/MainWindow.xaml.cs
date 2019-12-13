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
using assignment3;
using System.IO;

namespace assignment4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CustomersList customers = null;
        CustomersList output = null;
        public MainWindow()
        {            
            InitializeComponent();
            customers = new CustomersList();
            output = new CustomersList();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            bool result = true;
            int size = 0;
            int bulbs = 0;
            int outlets = 0;
            int i = -1;
            string cc = string.Empty;
            if ( (!int.TryParse(TxtSize.Text.Trim(), out size)) || (size < 1000) || (size > 50000))
            {
                result = false;
                TxtSize.Foreground = Brushes.Red;
            }
            if(!(int.TryParse(TxtBulbs.Text.Trim(), out bulbs)) || (bulbs < 1) || (bulbs > 20))
            {
                result = false;
                TxtBulbs.Foreground = Brushes.Red;
            }
            if(!(int.TryParse(TxtOutlets.Text.Trim(), out outlets)) || (outlets < 1) || (outlets > 50))
            {
                result = false;
                TxtOutlets.Foreground = Brushes.Red;
            }
            cc = TxtCC.Text.Trim();
            if (!Program.CheckCard(cc))
            {
                result = false;
                TxtCC.Foreground = Brushes.Red;
            }
            switch (TxtType.Text.Trim())
            {
                default:
                    TxtType.Foreground = Brushes.Red;
                    break;
                case "Barn":
                    if (result)
                    {
                        customers.Add(new Barn(size, bulbs, outlets, cc));
                        i++;
                        WriteToFile(customers[i]);               
                        ClearData();
                    }
                    break;
                case "Garage":
                    if (result)
                    {
                        customers.Add(new Garage(size, bulbs, outlets, cc));
                        i++;
                        WriteToFile(customers[i]);
                        ClearData();
                    }
                    break;
                case "House":
                    if (result)
                    {
                        customers.Add(new House(size, bulbs, outlets, cc));
                        i++;
                        WriteToFile(customers[i]);
                        ClearData();
                    }
                    break;
            }           
        }
        private void BtnDisplay_Click(object sender, RoutedEventArgs e)
        {
            output = ReadFromFile();
            TB.Text = string.Empty;
            output.Sort();
            foreach(Building b in output)
            {
                
                TB.Text += b.ToString() + "\n" + "\n";
            }

        }
        private void WriteToFile(IBuilding b)
        {
            FileStream fs = null;
            try
            {                
                fs = new FileStream("customers.txt", FileMode.Append, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);               
                bw.Write((int)b.T);
                bw.Write(b.Size);
                bw.Write(b.Outlets);
                bw.Write(b.Bulbs);
                bw.Write(b.CustomerCC);
                bw.Close();
            }
            catch (IOException ioe)
            {
                string ex = ioe.ToString();
            }
            finally
            {
                fs.Close();
            }
        }
        private CustomersList ReadFromFile()
        {
            FileStream fs = null;
            CustomersList c = new CustomersList();           
            int type, size, outlets, bulbs;
            string cc;            
            try
            {
                fs = new FileStream("customers.txt", FileMode.OpenOrCreate, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                while (br.BaseStream.Position != br.BaseStream.Length)
                {
                    type = br.ReadInt32();
                    size = br.ReadInt32();
                    outlets = br.ReadInt32();
                    bulbs = br.ReadInt32();
                    cc = br.ReadString();
                    switch (type)
                    {
                        case 1:
                            c.Add(new Barn(size, bulbs, outlets, cc));
                            break;
                        case 2:
                            c.Add(new Garage(size, bulbs, outlets, cc));
                            break;
                        case 3:
                            c.Add(new House(size, bulbs, outlets, cc));
                            break;
                    }
                }
                return c;
            }
            catch (IOException ioe)
            {
                string ex = ioe.ToString();
                return null;
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
                
            }
        }
        private void ClearData()
        {
            TxtType.Text = string.Empty;
            TxtCC.Text = string.Empty;
            TxtSize.Text = string.Empty;
            TxtBulbs.Text = string.Empty;
            TxtOutlets.Text = string.Empty;
        }
        private void TxtType_TextChanged(object sender, TextChangedEventArgs e)
        {
            TxtType.Foreground = Brushes.Black;
        }
        private void TxtBulbs_TextChanged(object sender, TextChangedEventArgs e)
        {
            TxtBulbs.Foreground = Brushes.Black;
        }
        private void TxtOutlets_TextChanged(object sender, TextChangedEventArgs e)
        {
            TxtOutlets.Foreground = Brushes.Black;
        }
        private void TxtCC_TextChanged(object sender, TextChangedEventArgs e)
        {
            TxtCC.Foreground = Brushes.Black;
        }
        private void TxtSize_TextChanged(object sender, TextChangedEventArgs e)
        {
            TxtSize.Foreground = Brushes.Black;
        }
        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
