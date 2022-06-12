using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //string[] names = { "Adam", "Abbas", "Vuqar" };

            //bool AllWordsA = true;

            //for (int i = 0; i < names.Length; i++)
            //{
            //    if (names[i][0] != 'A')
            //    {

            //        AllWordsA = false;
            //        break;
            //    } 


            //}
            //if (AllWordsA == true)
            //{
            //    Console.WriteLine("butun sozler 'A' herfi ile baslayir");
            //}
            //else Console.WriteLine("butun sozler 'A' herfi i le baslamir");



            //Verilmiş artan sıra ilə düzülmüş ədədlər siyahısındaki 
            //    n ədədinin yerləşdiyi indexi tapan method(binary search)


            //int[] numbers = { 7, 9, 3, 6, };
            //int n = 12;

            //AddElement(ref numbers, n);
            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            int[] numbers1 = { 2, 3, 6, };
            int[] numbers2 = { 10, 55, 1, 8, 2, 3, 9, 6 };

            Array(numbers1, numbers2);
            
            {
                Console.WriteLine( Array(numbers1, numbers2)); 
            }

        }
       static int FindIndex (int[] numbers, int n)
        {
            int min = 0;
            int max = numbers.Length - 1;
            int index = -1;
            while (min < max)
            {
                int mid = (min + max) / 2;
                if (n == numbers[mid])
                {
                    index = mid;
                    return index;
                } 
               
                else if (n > numbers[mid])
                {
                    min = mid + 1;

                }
                else
                {
                    max = mid -1 ;

                    
                }


            }
            return index;
            
            

        }



        //for (int i = 0; i < nums.length; i++)
        //{
        //if (nums[i] % 2 == 0)
        //{
        //    console.writeline(nums[i]);

        //}



        //int index = 0;
        //while (index < nums.Length)

        //{
        //    if (nums[index] % 2 == 0)

        //        Console.WriteLine(nums[index]);

        //    index++;


        //}
        //for (int i = 0; i < nums.Length; i++)
        //{
        //    if (nums[i] % 2 != 0)
        //    {
        //        Console.WriteLine(nums[i]);
        //    }

        //}


      

        //int[] numbers = { 1, 3, 54, 213, 678, 23, 1, 2, 7 };

        //int[] Evens = GetEvenNums(numbers);
        //foreach (var item in Evens)
        //{
        //    Console.WriteLine(item);
        //}


        //string [] words= { "alma", "", "aliabbas", "bagdagul"};


        //Console.WriteLine(Countlongerthan5(words));


        //Verilmis adlar siyahisinda(string array) nece adin
        //    uzunlugunun 5-den boyuk oldugunu tapan metod
       static int Countlongerthan5(string[] names)
        {

            int count = 0;

            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Length > 5)
                    count++;

            }
            return count;

        }


        //Verilmis ededler siyahisindaki cut ededlerden 
        // ibraret yeni bir array qaytaran method.


        //static int[] GetEvenNums (int[] nums)
        //{
        //    int[] EvenNumbers = new int[0];
        //    for (int i = 0; i < nums.Length; i++)
        //    {

        //        if (nums[i] % 2 == 0)
        //        {
        //            Array.Resize(ref EvenNumbers, EvenNumbers.Length + 1);
        //            EvenNumbers[EvenNumbers.Length - 1] = nums[i];
        //        }
        //    }
        //    return EvenNumbers
        //}



        //Parameter olaraq integer array variable-i ve bir integer 
        // value qebul eden ve hemin integer value-nu
        // integer array-e yeni element kimi elave eden metod.

        //static void AddElement ( ref int[] numbers, int a)
        //{
        //    Array.Resize(ref numbers, numbers.Length + 1);
        //    numbers[numbers.Length - 1] = a;
        //}




        //Verilmiş iki ədədlər siyahısından birincisinin
        //ikincisinin içində olub olmadığını tapan metod
        static bool Array (int[] numbers1, int [] numbers2)
        {
            bool check = false;
            for (int i = 0; i < numbers1.Length; i++)
            {
                for (int j = 0; j < numbers2.Length; j++)
                {
                    if (numbers1[i] == numbers2[j])
                    {
                        check = true;
                        break;

                    }
                    else check = false;
                }

            }
            return check;



        }


    }
}




