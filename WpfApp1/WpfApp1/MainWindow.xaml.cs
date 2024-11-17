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

        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (comboBox1.SelectedIndex) 
            { case 0: label1.Background = Brushes.Red;
                    break;
                case 1: label1.Background = Brushes.Blue; 
                    break;
                case 2: label1.Background = Brushes.Yellow; 
                    break;
                case 3: label1.Background = Brushes.Green; 
                    break;
                case 4: label1.Background= Brushes.Orange;
                    break;
                case 5: label1.Background = Brushes.White;
                    break;
            }


        }

        private void comboBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0: label2.Background = Brushes.Red;
                    break;
                case 1: label2.Background = Brushes.Blue; 
                    break;
                case 2: label2.Background = Brushes.Yellow; 
                    break;
                case 3: label2.Background= Brushes.Green;
                    break;
                case 4: label2.Background = Brushes.Orange; 
                    break;
                case 5: label2.Background = Brushes.White; 
                    break;
            }
        }

        private void comboBox3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (comboBox3.SelectedIndex)
            {
                case 0: label3.Background = Brushes.Red; 
                    break;
                case 1: label3.Background = Brushes.Blue; 
                    break;
                case 2: label3.Background = Brushes.Yellow;
                    break;
                case 3: label3.Background = Brushes.Green;
                    break;
                case 4: label3.Background= Brushes.Orange;
                    break;
                case 5: label3.Background= Brushes.White;
                    break;

                     
            }
        }

        private void comboBox4_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (comboBox4.SelectedIndex)
            {
                case 0: label4.Background = Brushes.Red;
                    break;
                case 1: label4.Background = Brushes.Blue;
                    break;
                case 2: label4.Background= Brushes.Yellow;
                    break;
                case 3: label4.Background= Brushes.Green;
                    break;
                case 4: label4.Background= Brushes.Orange;
                    break;
                case 5: label4.Background= Brushes.White;
                    break;
            }

        }
    }
}