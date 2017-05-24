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
using ThinkLib;

namespace project1turtles
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Turtle tess;              // Define a variable to refer to our turtle
        Turtle alex;              // Define a variable to refer to our turtle

        public MainWindow()
        {
            /*  opdracht 12: */
            InitializeComponent();
            tess = new Turtle(playground2, 250.0, 100.0);  // Create a turtle in the playground.
            tess.BrushWidth = 5.1;                       // Set some properties.
          //opdracht 1:   
            

            alex = new Turtle(playground, 250.0, 100.0); // Create another turtle
            alex.LineBrush = Brushes.Blue;               // Make its lines blue
            alex.BodyBrush = Brushes.Blue;               // and make its body blue too
            alex.BrushWidth = 1;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            tess.Forward(80.0);   // Make Tess draw a square
            tess.Right(90.0);
            tess.Forward(80.0);
            tess.Right(90.0);
            tess.Forward(80.0);
            tess.Right(90.0);
            tess.Forward(80.0);
            tess.Right(90.0);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            // Draw a broken line by picking up the brush in the middle
            alex.Forward(40.0);
            alex.BrushDown = false;
            alex.Forward(40.0);
            alex.BrushDown = true;
            alex.Forward(40.0);
            alex.Right(95);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            alex.WarpTo(200.0, 200.0);    // Warp without drawing
            alex.BrushDown = false;       // Pick up the brush
            double size = 15.0;
            int i = 0;
            while (i < 30)
            {
                alex.Stamp();             // Stamp a footprint
                size = size + 2.0;
                alex.Forward(size);
                alex.Right(24.0);
                i = i + 1;
            }

        }
        /*  opdracht 4:*/
        //DRIEHOEK
        private void button3_Click(object sender, RoutedEventArgs e)
        {
            alex.WarpTo(200.0, 200.0);    // Warp without drawing
            alex.BrushDown = true;       // Pick up the brush
            for (int i =0 ; i < 3 ; i++)
            {   
                alex.Forward(60);
                alex.Right(120.0);
            }
        }
        //VIERKANT
        private void button3_Click_1(object sender, RoutedEventArgs e)
        {
            alex.WarpTo(200.0, 200.0);    // Warp without drawing
            alex.BrushDown = true;       // Pick up the brush
            for (int i = 0; i < 4; i++)
            {
                alex.Forward(60);
                alex.Right(90.0);
            }
        }
        //HEXAGON
        private void button4_Click(object sender, RoutedEventArgs e)
        {
            alex.WarpTo(200.0, 200.0);    // Warp without drawing
            alex.BrushDown = true;       // Pick up the brush
            for (int i = 0; i < 6; i++)
            {
                alex.Forward(60);
                alex.Right(60.0);
            }
        }
        //OCTOGON
        private void button6_Click(object sender, RoutedEventArgs e)
        {
            alex.WarpTo(200.0, 200.0);    // Warp without drawing
            alex.BrushDown = true;       // Pick up the brush
            for (int i = 0; i < 8; i++)
            {
                alex.Forward(60);
                alex.Right(45.0);
            }
        }
        /*  opdracht 6: */
        private void button7_Click(object sender, RoutedEventArgs e)
        {
            tess.Clear();
            alex.Clear();
        }
        /*  opdracht 7: */
        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (alex != null)
            { alex.BrushWidth = e.NewValue; }
        }
        /*  opdracht 8: */
        private void button8_Click(object sender, RoutedEventArgs e)
        {
            alex.LineBrush = Brushes.Yellow;
            alex.BodyBrush = Brushes.Yellow;
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            alex.LineBrush = Brushes.Red;
            alex.BodyBrush = Brushes.Red;
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            alex.LineBrush = Brushes.Blue;
            alex.BodyBrush = Brushes.Blue;
        }
        /*  opdracht 9:  720/5 = 144 graden */
        //&&
        /*  opdracht 10: */
        private void button11_Click(object sender, RoutedEventArgs e)
        {
            alex.WarpTo(200.0, 200.0);    // Warp without drawing
            alex.BrushDown = true;       // Pick up the brush
            for (int x = 0; x <= 6; x++)
            {
                for (int i = 0; i < 5; i++)
                {
                    alex.Forward(60);
                    alex.Right(144.0);
                }
                alex.WarpTo(200.0+(x*60), 200.0);
            }
        }
        /*  opdracht 2: gaat met 10 naar voren 24 opzij en herhaalt dit 30 keer.
24*30= 720 / 360 graden = 2 hij maakt dus 2 rondjes waarbij hij in dezelfde positie komt ongeveer.*/
        /*  opdracht 3: als de heading op 0 wordt gezet en de alex.left op 3645 dan maakt alex een soort propellor en wanneer hij klaar is blijft hij op die positie.*/
        /*  opdracht 5: angle = 20.*/
        /*  opdracht 13: Bale of turtles. */

    }
}
 