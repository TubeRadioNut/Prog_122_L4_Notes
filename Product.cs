using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog_122_L4_Notes
{
    //in your new class change internal to public
    public class Product
    {
        //Fields
        //fields are variables that are associated with class object
        //place underscore in front of your field tieles(_fieldName)
        public string _title;
        public string _director;
        public string _rating;
        public decimal _price;
        //Constructor
        //new Product() is a constructor<------Default constructor
        //a constructor is built like a method but
        //-no return type
        // -same exact name as class
        public Product(string title, string director, string rating, decimal price)
        {
            _title = title;
            _director = director;
            _rating = rating;
            _price = price;
        }
        //Properties

    }//end of the class
}//end of namespace
