using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorChallenge {
    class Program {


        static void Main(string[] args) {

            //I've built in a function to this iterator that allows you to print through all the numbers that it would iterate through
            MyIterator iterator1 = new MyIterator(7, 100);
            MyIterator iterator2 = new MyIterator(8, 200);
            MyIterator iterator3 = new MyIterator(9, 300);







            iterator1.print(); //Using the print function that I've set up in the iterator. 
            iterator2.print(); //Using the print function that I've set up in the iterator. 

            IEnumerable enumerator = iterator3.getIterator();  //Now I'm pulling the numbers iterator and excecuting code outside of the MyIterator object. This offers additional flexibility
            Console.WriteLine("--Now printing directly from inumeration instead of the print list.");
            foreach(int number in enumerator) { 
                 Console.WriteLine(number); 
                }
            Console.ReadKey();






            }



        }
    }
