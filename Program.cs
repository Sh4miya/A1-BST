using System;
using System.IO;

namespace A1_BST
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                BST tree1 = new BST();
                BST tree2 = new BST(); //create new binary search trees
                BST tree3 = new BST();

                string[] lines1 = File.ReadAllLines(@"C:\Users\the_1\source\repos\A1-BST\assignment3\file1.txt");
                string[] lines2 = File.ReadAllLines(@"C:\Users\the_1\source\repos\A1-BST\assignment3\file2.txt"); //read all the text files
                string[] lines3 = File.ReadAllLines(@"C:\Users\the_1\source\repos\A1-BST\assignment3\file3.txt");

                int[] array1 = Array.ConvertAll(lines1, int.Parse); //convert the text from the file into an array
                for (int i = 0; i < array1.Length; i++)
                {
                    Node p = new Node(array1[i]); //iterate through the array and add to the BST
                    tree1.insert(p);
                }

                int[] array2 = Array.ConvertAll(lines2, int.Parse);
                for (int i = 0; i < array2.Length; i++)
                {
                    Node p = new Node(array2[i]);
                    tree2.insert(p);
                }

                int[] array3 = Array.ConvertAll(lines3, int.Parse);
                for (int i = 0; i < array3.Length; i++)
                {
                    Node p = new Node(array3[i]);
                    tree3.insert(p);
                }

                Console.WriteLine("\nTree 1: ");
                tree1.printByLevel(tree1.root); //print the tree level by level

                Console.WriteLine("\nTree 1 prime numbers:");
                printPrime(array1); //print the prime numbers of the tree

                Console.WriteLine("\nTree 2: ");

                tree2.printByLevel(tree2.root);

                Console.WriteLine("\nTree 2 prime numbers:");
                printPrime(array2);

                Console.WriteLine("\nTree 3: ");
                tree3.printByLevel(tree3.root);

                Console.WriteLine("\nTree 3 prime numbers:");
                printPrime(array3);
            }

            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press any key to continue");
            }
            catch (FormatException ex2)
            {
                Console.WriteLine(ex2.Message);
                Console.WriteLine("Press any key to continue");
            }
            catch (OverflowException ex3)
            {
                Console.WriteLine(ex3.Message);
                Console.WriteLine("Press any key to continue");
            }
            catch (Exception ex4)
            {
                Console.WriteLine(ex4.Message);
                Console.WriteLine("Press any key to continue");
            }

            Console.ReadKey();
        }

        private static Boolean checkPrime(int num1)
        {
            Boolean num = true;
            int i;

            for (i = 2; i <= num1 / 2; i++)
            {
                if (num1 % i == 0)
                {
                    return false;
                }
            }
            return num;
        }
        private static void printPrime(int[] arrP)
        {
            int j;

            for (j = 0; j < arrP.Length; j++)
            {
                if (checkPrime(arrP[j]))
                {
                    Console.WriteLine(arrP[j]);
                }
            }

        }
    }
}
