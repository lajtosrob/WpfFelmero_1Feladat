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


//todo a) Nevezze át az ablakot a minta szerint! Az ablak mérete 300x200 legyen!
//todo b) Alakítsa ki GRID rácsban a minta szerinti képernyőképet! A rács 2 oszlopból és 3 sorból áll. A beviteli mezők szélessége 100, a betűk mérete 20 DIU.
//todo c) A gomb lenyomására adja össze a beírt két számot és jelenítse meg az eredményt!
namespace WpfFelmero_1Feladat
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

        private void btnOsszead_Click(object sender, RoutedEventArgs e)
        {
            lblEredmeny.Content = Convert.ToDouble(txtElsoSzam.Text) + Convert.ToDouble(txtMasodikSzam.Text);        }
    }
}
