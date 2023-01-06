using System.Collections.Generic;
namespace MyCodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // int n= 1;
            //   for (int i = 4; i < 20; i+=4)
            //   {
            //        Console.WriteLine(n);

            //        n+=i;


            //   }  

            // int[,] matrix = new int[2, 2];

            // int counter = 0;
            // int counter2 = 0;


            // for (int i = 0; i < matrix.GetLength(0); i++)
            // {
            //     for (int j = 0; j < matrix.GetLength(1); j++)
            //     {
            //         Console.Write($"Element of index {i},{j}-");
            //         matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            //     }
            // }
            // for (int i = 0; i < matrix.GetLength(0); i++)
            // {
            //     for (int j = 0; j < matrix.GetLength(1); j++)
            //     {
            //         if (matrix[i, j] == 0)
            //         {
            //             matrix[i, j] = counter;
            //             continue;
            //         }
            //         counter2 += matrix[i, j];
            //     }
            // }
            // Console.Write(counter2 + " ");
            // Console.WriteLine();

            //           string numbers = Console.ReadLine();


            // string firstHalf = numbers.Substring(0, numbers.Length / 2);
            // string secondHalf = numbers.Substring(numbers.Length / 2);

            // int firstSum = 0;
            // int secondSum = 0;

            // for(int i = 0; i < firstHalf.Length; i++) {
            //     firstSum += (firstHalf[i] - '0');
            //     secondSum += (secondHalf[i] - '0');
            // }

            //Console.WriteLine(firstSum == secondSum? true : false);

            //   DateTime currentDate = DateTime.Now;
            // Console.WriteLine(currentDate.ToString());
            // string text = "11/11/2001";
            // DateTime parsedDate = DateTime.Parse(text);
            // Console.WriteLine(parsedDate);

            // string text = "11/12/2001";
            // string format = "MM/dd/yyyy";
            // DateTime parsedDate = DateTime.ParseExact(
            // text, format, provider: CultureInfo.InvariantCulture);
            // Console.WriteLine("Day: {0}\nMonth: {1}\nYear: {2}",
            // parsedDate.Day, parsedDate.Month, parsedDate.Year);
            // int[] numbers = new int[8];
            // for (int i = 0; i < numbers.Length; i++)
            // {
            //     Console.Write("Elements {0}- ", i);
            //     numbers[i] = Convert.ToInt32(Console.ReadLine());
            // }

            // for (int i = 0; i < numbers.Length - 1; i++)
            // {
            //     int minindex = i;
            //     for (int j = i + 1; j < numbers.Length; j++)
            //     {
            //         if (numbers[j] == -1)
            //         {
            //             continue;
            //         }
            //         if (numbers[j] < numbers[minindex])
            //         {
            //             minindex = j;
            //         }
            //     }
            //     int temp = numbers[i];
            //     numbers[i] = numbers[minindex];
            //     numbers[minindex] = temp;
            // }

            // for (int i = 0; i < numbers.Length; i++)
            // {
            //     Console.Write("{0} ", numbers[i]);
            // }

            // Console.Write("Enter characters: ");
            // string input = Console.ReadLine();
            // string b = input.Substring(input.IndexOf("("),input.LastIndexOf(")"));
            // char[] a = b.ToCharArray();
            // string reverse = "";
            // for (int i = a.Length - 1; i > -1; i--)
            // {

            //     reverse += a[i+1];
            // }
            // Console.Write(reverse);
            // int[] array = { 50, 60, 60, 45,70 };
            // int odd = 0;
            // int even = 0;
            // int i;
            // for (i = 0; i < array.Length; i++)
            // {
            //     if (i % 2 == 0)
            //     {
            //         even += array[i];
            //         continue;
            //     }
            //     odd += array[i];
            // }

            // Console.Write(even+ " "+ odd);

            // char[,] c = new char[2, 3];

            // for (int i = 0; i < c.GetLength(0); i++)
            // {
            //     for (int j = 0; j < c.GetLength(1); j++)
            //     {
            //         Console.Write($"row-{i} colum-{j}- ");
            //         c[i, j] = Convert.ToChar(Console.ReadLine());
            //     }
            // }

            // for (int i = 0; i < c.GetLength(0); i++)
            // {
            //     for (int j = 0; j < c.GetLength(1); j++)
            //     {
            //         Console.Write(c[i, j]);
            //     }

            //     Console.WriteLine();
            // }
            // Console.Write("Enter yor Name: ");
            // string name = Console.ReadLine();
            // Console.Write("Agents available are: ");
            // int agent = Convert.ToInt32(Console.ReadLine());
            // int count = 0;
            // Console.Write("Other names are: ");
            // List<string> lst = new List<string>(Console.ReadLine().Split(" "));
            // lst.Add(name);
            // lst.Sort();
            // string[] arr = lst.ToArray();

            // for (int i = 0; i < arr.Length; i++)
            // {
            //     if (agent == 5 || agent > 5)
            //     {
            //         count += 20;
            //         break;
            //     }
            //     else
            //     {
            //         if (agent == 1)
            //         {
            //             if (arr[i] != name)
            //             {
            //                 count += 20;
            //                 continue;
            //             }
            //             count += 20;
            //             break;
            //         }
            //         if (agent == 2)
            //         {
            //             if (arr[i] == name || arr[i + 1] == name)
            //             {
            //                 count += 20;
            //                 break;
            //             }
            //             count += 20;
            //             continue;
            //         }
            //         if (agent == 3)
            //         {
            //             if (arr[i] == name || arr[i + 1] == name || arr[i + 2] == name)
            //             {
            //                 count += 20;
            //                 break;
            //             }
            //             count += 20;
            //             continue;
            //         }
            //         if (agent == 4)
            //         {
            //             if (arr[i] == name || arr[i + 1] == name || arr[i + 2] == name || arr[i + 4] == name)
            //             {
            //                 count += 20;
            //                 break;
            //             }
            //             count += 20;
            //             continue;
            //         }
            //     }
            // }
            // Console.WriteLine($"It took {count} minutes to get your license");

            // string result = Palindrome();
            // Console.WriteLine(result);
            // string sentence = "I have a ball";
            // int index = sentence.Length;
            // Console.WriteLine(index);
        
          Console.Write("Enter string: ");
            string text = Console.ReadLine();
            var result =  NoNumeral(text);
            Console.WriteLine(result);
        }
        public static string Palindrome()
        {
            string[] name = new string[4];

            List<string> names = new List<string>();
            for (int i = 0; i < name.Length; i++)
            {
                Console.Write("Names are: ");
                name[i] = Console.ReadLine().ToLower();
            }

            for (int i = 0; i < name.Length; i++)
            {
                string revs = "";
                string letters = name[i].ToString();
                for (int j = letters.Length - 1; j >= 0; j--)
                {
                    revs += letters[j];
                }
                names.Add(revs);
            }
            string[] words = names.ToArray();
            int count = 0;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == name[i])
                {
                    count += 1;
                }
            }
            return count >= 1 ? "Open" : "Trash";
        }
        public static string NoNumeral(string words)
        {
            Dictionary<int, string> numerals = new()
            {
                {0, "zero"},
                {1, "one"},
                {2, "two"},
                {3,"three"},
                {4 ,"four"},
                {5 ,"five"},
                {6 ,"six"},
                {7,"seven"},
                {8 ,"eight"},
                {9 ,"nine"},


            };

            var text = words.Split(" ");
         for (int i = 0; i < text.Length; i++)
         {
            if (int.TryParse(text[i], out int num))
            {
               if(num >= 0 && num <= 9)
               {
                    text[i] = numerals[num];
               }
            }
         }
            
             
            return String.Join(" ", text);
        }
    }
}