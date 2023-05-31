using System;
using System.Collections.Generic;
using System.IO;
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

namespace HelsinkiWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        public static int Helyezes(int helyezes)
        {
            int pontszam = 0;

            if (helyezes == 1)
            {
                pontszam = 7;
            }
            else if (helyezes == 2)
            {
                pontszam = 5;
            }
            else if (helyezes == 3)
            {
                pontszam = 4;
            }
            else if (helyezes == 4)
            {
                pontszam = 3;
            }
            else if (helyezes == 5)
            {
                pontszam = 2;
            }
            else if (helyezes == 6)
            {
                pontszam = 1;
            }
            else
            {
                pontszam = 0;
            }
            return pontszam;
        }
        List<HelsinkiClass> list = new List<HelsinkiClass>();
        public MainWindow()
        {
            InitializeComponent();

            StreamReader reader = new StreamReader("helsinki.txt");
            while (!reader.EndOfStream)
            {
                HelsinkiClass egyrecord = new HelsinkiClass(reader.ReadLine());
                list.Add(egyrecord);
            }
            reader.Close();

            dtg_adatok.ItemsSource= list;
        }

        private void btn_Torles_Click(object sender, RoutedEventArgs e)
        {
            list.RemoveAt(dtg_adatok.SelectedIndex);
            dtg_adatok.Items.Refresh();
        }

        private void btn_Mentes_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                StreamWriter writer = new StreamWriter("helsinki2.txt");
                foreach (var record in list)
                {
                    writer.WriteLine($"{record.Helyezes} {record.SportolokSzama} {record.SportagNeve} {record.VersenySzamNeve} {record.Pontszam}");
                }
                writer.Close();
                MessageBox.Show("Sikeres mentés!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
