using System;

namespace TestScoresProject {
    class Program {
        static void Main(string[] args) {
            int[] scores = new int[12] { 71, 78, 89, 73, 68, 73, 96, 71, 72, 65, 87, 63 };
            int avg = 0;
            int total = 0;
            int index = 0;
            while (index < 12) {
                total = total + scores[index];
                index = index + 1;
                avg = total / 12;

            }
            Console.WriteLine($"The Average is {avg}%");
        }
    }
}
