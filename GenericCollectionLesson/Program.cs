using System;
using System.Collections.Generic;

namespace GenericCollectionLesson {
    class Program {
        static void Main(string[] args) {

            Random rnd = new Random();
            var ints = new List<int>();
            var Cds = new List<CD>();
            ints.RemoveAll(x => x < 5 || x > 25);

            for(var idx = 0; idx < 10; idx++) {
                var score = rnd.Next(0, 31);
                ints.Add(score);
            }

            var total = 0;
            foreach(var i in ints) {
                total = total + i;
            }

            Console.WriteLine($"Total is {total}");

        }
    }
}
