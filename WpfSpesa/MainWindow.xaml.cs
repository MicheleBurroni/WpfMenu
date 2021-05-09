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
using System.IO;

namespace WpfSpesa
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();
                   
        }
        private void btnScegli_Click(object sender, RoutedEventArgs e)
        {
                       
        }

        private void cmbAntipasto_Loaded(object sender, RoutedEventArgs e)
        {
            using (StreamReader r = new StreamReader("antipasto.txt"))
            {
                List<string> antipasto = new List<string>();
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    antipasto.Add(line);
                    cmbAntipasto.Items.Add(line);
                }
            }
        }

        private void cmbPrimo_Loaded(object sender, RoutedEventArgs e)
        {
            using (StreamReader r = new StreamReader("primo.txt"))
            {
                List<string> primo = new List<string>();
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    primo.Add(line);
                    cmbSecondo.Items.Add(line);
                }
            }
        }

        private void cmbSecondo_Loaded(object sender, RoutedEventArgs e)
        {
            using (StreamReader r = new StreamReader("secondo.txt"))
            {
                List<string> secondo = new List<string>();
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    secondo.Add(line);
                    cmbDolce.Items.Add(line);
                }
            }
        }

        private void cmbDolce_Loaded(object sender, RoutedEventArgs e)
        {
            using (StreamReader r = new StreamReader("dolce.txt"))
            {
                List<string> dolce = new List<string>();
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    dolce.Add(line);
                    cmbDolce.Items.Add(line);
                }
            }
        }

        private void btnAggiungi_Click(object sender, RoutedEventArgs e)
        {
            if (cmbAntipasto.SelectedIndex != -1 && cmbPrimo.SelectedIndex != -1 && cmbSecondo.SelectedIndex != -1 && cmbDolce.SelectedIndex != -1)
            {
                lboStampa.Items.Add(cmbAntipasto.SelectedItem);
                lboStampa.Items.Add(cmbPrimo.SelectedItem);
                lboStampa.Items.Add(cmbSecondo.SelectedItem);
                lboStampa.Items.Add(cmbDolce.SelectedItem);
                lboStampa.SelectedIndex = -1;
                lboStampa.SelectedIndex = -1;
                lboStampa.SelectedIndex = -1;
                cmbDolce.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("attenzione selezionare tutte e 4 le scelte", "attenzione", MessageBoxButton.OK);
                lboStampa.Items.Clear();
            }
        }

        private void btnRimuovi_Click(object sender, RoutedEventArgs e)
        {
            if (lboStampa.SelectedIndex != -1)
            {
                lboStampa.Items.RemoveAt(lboStampa.SelectedIndex);
            }
            else
            {
                MessageBox.Show("attenzione selezionare almeno un elemento", "attenzione", MessageBoxButton.OK);
            }
        }
    }
}
