using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace Week4_lesson1
{
    class Program
    {

        static char[] ExchangeValue(string word)
        {
      
            char [] reverse = new char[word.Length];

            reverse[0] = word[word.Length-1];
            reverse[reverse.Length-1] = word[0];

            for(int i = 1; i <=word.Length-2;i++)
            {
                reverse[i] = word[i];
            }

            return reverse;
          
        }
        static bool Sequence(int[] sequence, int[] tab)
        {
            if (sequence.Length > tab.Length)
            {
                return false;
            }
            int cpt = 0;
            for (int i = 0; i < tab.Length; i++)
            {

                if (tab[i] != sequence[cpt])
                {
                    cpt = 0;
                }
                if (tab[i] == sequence[cpt])
                {
                    cpt++;
                    if (cpt == sequence.Length)
                    {
                        return true;
                    }
                }

            }
            return false;
        }


        static void  Asciia()
        {
            Console.WriteLine("Give a char : ");

            char c = Convert.ToChar(Console.ReadLine());

            Console.WriteLine((int)c);

        }

    
   

        static char[] Q3b()
        {
            

            Console.WriteLine("Give a word :");
            string word = Console.ReadLine();

            int[] tab = new int[word.Length];
              char[] tab2 = new char[word.Length];

              for (int i = 0; i < tab.Length; i++)
              {
                  tab[i] = (int)word[i];

              }

              for (int i = 0; i < tab2.Length; i++)
              {
                  Console.Write(word[i] + " ");

              }
              Console.Write("\n ");
            int index1 = 0;
            int index2 = 0;

            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = 0; j < tab.Length - 1; j++)
                {
                    if (tab[j] < tab[j + 1])
                    {
                        int tmp = tab[index1];
                        tab[index1] = tab[index2];
                        tab[index2] = tmp;


                    }


                }

            }


              for (int i = 0; i < tab2.Length; i++)
              {
                  tab2[i] = (char)tab[i];

              }

              for (int i = 0; i < tab2.Length; i++)
              {
                  Console.Write(tab2[i] + " ");

              }

            

            return tab2;

        }

        static void Q4(string word)
        {
            char[] array = new char[word.Length];

            int cpt = 1;
            int j = 0;

            for(int i = 0; i < word.Length-1;i++)
            {
                if(word[i] == word[i+1])
                {
                    cpt++;

                    array[j] = word[i];
                    array[j + 1] = (char) cpt;
                }
                else
                {
                    cpt = 1;
                    j = j + 2;
                }

            }

            for(int k = 0; k < word.Length;k++)
            {
                Console.Write(word[k]);
            }

            Console.WriteLine();

            for (int a = 0; a < array.Length; a++)
            {
                if(a%2 == 0)
                {
                    Console.Write(array[a]);
                }
                else
                {
                    Console.Write((int) array[a]);
                }

                if(array[a] == 0)
                {
                    break;
                }
                
            }

        }

        static void Q5()
        {
            for (int i = 0; i <= 999; i++)
            {
                int a = 0, b = 0, c = 0;

                a = i / 100 - (i % 100 / 100); // hundreds
                c = i % 100;
                b = (c - (c % 10)) / 10; // dozens
                c = c % 10; // units

                if (a * a * a + b * b * b + c * c * c == i)
                {
                    Console.WriteLine("The number " + i + " is Armstrong");
                }
            }
        }


        static void Q6(int[] tab)
        {
            if(tab != null && tab.Length > 0)
            {
                int cpt = 0;

                for(int i = 0;i < tab.Length;i++)
                {
                    for(int x = 0; x < tab.Length;x++)
                    {
                        if(tab[i] == tab[x])
                        {
                            cpt++;
                        }

                    }
                    Console.WriteLine(tab[i] + " is " + cpt + " times ");
                    cpt = 0;
                }
  
            }
        }

        static int Q7(int i)
        {
            
           if (i <= 1)
            {
                return 1;
            }
                    
            return i * Q7(i - 1);
           
        }

        static int Q7bis(int i)
        {
            int factoriel = 1;
            for(int j = i; j < 1;j--)
            {
                factoriel = factoriel * j;
            }

            return factoriel;
        }

        static void Q8()
        {
            string s = "My Name is Lucas";
            Console.WriteLine(s);
            int c = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    c++;
                }
            }
            Console.WriteLine(c);
        }

        static void ArrayOfPerson()
        {
            Person[] listPerson = new Person[3];
            Console.WriteLine("Give three name :");
            listPerson[0] = new Person(Console.ReadLine());
            listPerson[1] = new Person(Console.ReadLine());
            listPerson[2] = new Person(Console.ReadLine());


            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(listPerson[i]);
                

            }
          
        }

        static void Main(string[] args)
        {
            /* Console.WriteLine("Write a word to change the firts and last letter");
             string word = Convert.ToString(Console.ReadLine());
             Console.WriteLine(ExchangeValue(word));
            */

            /*  Console.WriteLine("Give the sequence :");
              string seq = Convert.ToString(Console.ReadLine());
              int [] sequence = new int[seq.Length];

              for (int i = 0; i < seq.Length; i++)
              {
                  sequence[i] = seq[i];
              }
              Console.WriteLine("Give the array :");
              string tab = Convert.ToString(Console.ReadLine());
              int[] tab2 = new int[tab.Length];
              for (int i = 0; i < tab.Length; i++)
              {
                  tab2[i] = tab[i];
              }
              bool test = Sequence(sequence,tab2 );
              if (test == true)
              {
                  Console.WriteLine("True");
              }
              else
              {
                  Console.WriteLine("False");
              }
            */

            // Asciia();
            // Q3b();
            // Q4("aaaabbcccc");

            /*int[] tab = { 5, 7, 5, 2, 2, 4, 5 };
            Q6(tab);
            */
            // Console.Write(Q7(4));

            // Q8();

            ArrayOfPerson();

            Console.ReadKey();

        }
    }
}
