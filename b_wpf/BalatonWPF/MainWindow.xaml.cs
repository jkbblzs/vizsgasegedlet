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

namespace BalatonWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<BalatonClass> list = new List<BalatonClass>();
        List<char> Adokategoriak = new List<char>() { 'A', 'B', 'C' };
        public MainWindow()
        {
            InitializeComponent();
            StreamReader reader = new StreamReader("utca.txt");
            string[] adoSavok = reader.ReadLine().Split(' ');
            int A_adosav = Convert.ToInt32(adoSavok[0]);
            int B_adosav = Convert.ToInt32(adoSavok[1]);
            int C_adosav = Convert.ToInt32(adoSavok[2]);
            while (!reader.EndOfStream)
            {
                BalatonClass egyAdat = new BalatonClass(reader.ReadLine());
                list.Add(egyAdat);
            }
            reader.Close();
            cmb_box.ItemsSource = Adokategoriak;
            cmb_box.SelectedIndex = 0;
            dtg_adatok.ItemsSource = list;
        }

        private void Modosit_Click(object sender, RoutedEventArgs e)
        {
            list[dtg_adatok.SelectedIndex].AdoSav = cmb_box.Text;
            dtg_adatok.Items.Refresh();
        }

        private void Mentes_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                StreamWriter writer = new StreamWriter("modositottadatok.txt");
                foreach (var item in list)
                {
                    writer.WriteLine($"{item.Adoszam} {item.UtcaNeve} {item.HazSzam} {item.AdoSav} {item.Alapterulet}");
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
