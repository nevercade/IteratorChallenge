using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorChallenge {
    class MyIterator {
        //Stores a list of numbers iterating over a multiple until they hit a limit.
        ArrayList nums;
        int multiple;
        int limit;

        public MyIterator(int multiple, int limit) {
            //Constructor Method
            nums = new ArrayList();

            rebuild(multiple, limit);
            Console.WriteLine($"--Iterator from {multiple} to {limit} set up.");
            }

        public void rebuild(int multiple, int limit) {
            //Builds the iterator using modulo
            this.multiple = multiple;
            this.limit = limit;

            for(int i = 1; i <= limit; i++) {
                if(i % multiple == 0) {
                    nums.Add(i);
                    }
                }

            }

        public void print() {
            //Prints all of the numbers.
            Console.WriteLine($"--Printing all numbers in the iterator of {multiple} until {limit}");
            foreach(int number in nums) { //the numbers are iterated over here.
                Console.WriteLine(number);
                }
            }
        public IEnumerable getIterator() {
            //returns the arraylist as an enumerable
            return nums;
            }

        }
    }
