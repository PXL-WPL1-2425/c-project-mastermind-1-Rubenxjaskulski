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
        private string color1, color2, color3, color4;

        public MainWindow()
        {
            InitializeComponent();
            GenereerGeheimeCode(out color1, out color2, out color3, out color4);
            Title = "MijnMastermind" + color1 + color2 + color3 + color4;
        }

       

        private void GenereerGeheimeCode(out string color1, out string color2, out string color3, out string color4)
        { Random random = new Random();
            List <string> colorList = new List <string>();
            string randomColor;
            for (int i = 0; i < 4; i++) 
            {
                randomColor = random.Next(1,7).ToString();
                switch (randomColor)
                {
                    case "1": randomColor = "Rood";
                        break;
                    case "2": randomColor = "Blauw";
                        break;
                    case "3": randomColor = "Geel";
                        break;
                    case "4": randomColor = "Groen";
                        break;
                    case "5": randomColor = "Oranje";
                        break;
                    case "6": randomColor = "Wit";
                        break;
                }
                colorList.Add(randomColor);
            }
            color1 = colorList[0];
            color2 = colorList[1];
            color3 = colorList[2];
            color4 = colorList[3];
            

           
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

        private void codeKnop_Click(object sender, RoutedEventArgs e)
        {
            List<string> gColors = new List<string>
            {
                color1, color2, color3,color4
            };
            string chosenColor1 = comboBox1.Text;
            string chosenColor2 = comboBox2.Text;
            string chosenColor3 = comboBox3.Text;
            string chosenColor4 = comboBox4.Text;

            List<string> vColors = new List<string>
            {
                chosenColor1 , chosenColor2 , chosenColor3 , chosenColor4
            };
            for (int i = 0; i < 4; i++)
            {
                Label temporaryLabel = null;
                switch (i)
                {
                    case 0:
                        temporaryLabel = label1;
                        break;
                    case 1:
                        temporaryLabel = label2;
                        break;
                    case 2:
                        temporaryLabel = label3;
                        break;

                    case 3:
                        temporaryLabel = label4;
                        break;
                }
                if (gColors[i] == vColors[i])
                {
                    temporaryLabel.BorderBrush = Brushes.DarkRed;
                    temporaryLabel.BorderThickness = new Thickness(5);
                }
                else if (gColors.Contains(vColors[i]))
                {
                    temporaryLabel.BorderBrush = Brushes.Wheat;
                    temporaryLabel.BorderThickness = new Thickness(5);
                }
            }
        }
    }
}