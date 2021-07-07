using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorChallenge {
    class Program {
        //Iterator program for 2i Iterator Challenge
        //Author: Matthew Harrison (matthewharrisondev@gmail.com)


        static void Main(string[] args) {

           //setting up the iterators
            MyIterator iterator1 = new MyIterator(7, 100);
            MyIterator iterator2 = new MyIterator(8, 200);
            MyIterator iterator3 = new MyIterator(9, 300);

            //I've built in a function to this iterator that allows you to print through all the numbers that it would iterate through
            iterator1.print(); //Using the print function that I've set up in the iterator. 
            iterator2.print(); //Using the print function that I've set up in the iterator. 

            IEnumerable enumerator = iterator3.getIterator();  //Now I'm pulling the numbers iterator and excecuting code outside of the MyIterator object. This offers additional flexibility
            Console.WriteLine("--Now printing directly from inumeration.");
            foreach(int number in enumerator) { 
                 Console.WriteLine(number); /*I've got it set up to print the numbers which is idential to the print function, 
                                            * but you could do anything here using the iterator */
                }
            Console.ReadKey();






            }



        }
    }
