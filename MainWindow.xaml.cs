//Charles Milender
//4-15-2024
//CSI 122
//Lecture 4 notes
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

namespace Prog_122_L4_Notes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Product[] movies = new Product[4];
        public MainWindow()
        {
            InitializeComponent();//<--Don't delete this

            //creating an INSTANCE of out class
            //we have created a variable name "movie1" relating to an empty Prodcut object
            Product movie1 = new Product("Paprika", "Satoshi Kon", "R", 27.99m);
            movies[0] = movie1;
            //movie1._title = "Paprika";
            //movie1._director = "Satoshi Kon";
            //movie1._price = 27.99m;
            //movie1._rating = "R";

            //runDisplay.Text = "Title: " + movie1._title + "\n";
            //runDisplay.Text += "Diector " + movie1._director + "\n";
            //runDisplay.Text += "Rating" + movie1._rating + "\n";
            //runDisplay.Text += "Price" + movie1._price.ToString("c") + "\n";
            //runDisplay.Text += "\n";

            Product movie2 = new Product("El Dorado", "Howard Hawks", "NR", 14.99m);
            movies[1] = movie2;
            //movie2._title = "El Dorado";
            //movie2._director = "Howard Hawks";
            //movie2._rating = "NR";
            //movie2._price = 14.99m;
            Product movie3 = new Product("Real Steel", "Huge Jackman", "PG", 19.99m);
            movies[2] = movie3;

            movies[3] = new Product("Robocop (89)", "Paul Verhoven", "R", 14.00m);

            for(int i = 0; i < movies.Length; i++)
            {
                Product selectedMovie = movies[i];
                DisplayMovie(selectedMovie);
            }

            //DisplayMovie(movie1);
            //DisplayMovie(movie2);
            //DisplayMovie(movie3);
            



        }//end of MainWindow

        public void DisplayMovie(Product movie)
        {
            runDisplay.Text += "Title: " + movie._title + "\n";
            runDisplay.Text += "Diector " + movie._director + "\n";
            runDisplay.Text += "Rating " + movie._rating + "\n";
            runDisplay.Text += "Price " + movie._price.ToString("c") + "\n";
            runDisplay.Text += "\n";
        }

        //Classes
        //IN objecto oriented Programming are how wew define what a collection of data
        //and actions look like to the computer

        //Business case
        //

    }//end of the class



}//end of the namespace