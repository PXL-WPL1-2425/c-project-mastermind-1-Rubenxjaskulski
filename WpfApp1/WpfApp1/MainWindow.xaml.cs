using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace MijnMastermind

{
  
    public partial class MainWindow : Window
    {
        private string[] beschikbareKleuren = { "Rood", "Geel", "Oranje", "Wit", "Groen", "Blauw" };
        private string[] geheimeCode = new string[4];
        private Random willekeurig = new Random();

        public MainWindow()
        {
            
            GenereerGeheimeCode();
            
        }

       

        private void GenereerGeheimeCode()
        {
            for (int i = 0; i < 4; i++)
            {
                geheimeCode[i] = beschikbareKleuren[willekeurig.Next(beschikbareKleuren.Length)];
            }

            this.Title = "Geheime Code: " + string.Join(", ", geheimeCode);
        }
    }
}