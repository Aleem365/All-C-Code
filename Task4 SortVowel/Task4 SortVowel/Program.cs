namespace Task4_SortVowel
{
    internal class Program
    {
        public static bool checkVol(Char c)
        {
            switch (c)
            {
                case 'a':
                    return true;
                   break;
                case 'e':
                    return true;
                    break;
                case 'i':
                    return true;
                    break;
                case 'o':
                    return true;
                    break;
                case 'u':
                    return true;
                    break;
                    default: return false;
                    break;

            }
        }
        public static Array swap(int a, int b, char[] c)
        {
            char temp = c[a];

            c[a] = c[b];
            c[b] = temp;
            return c;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter String :");
            string str = Console.ReadLine();
            str = str.ToLower();
            int len = str.Length;
            int templen = len - 1;
            char[] arr = new char[len];
            char Start;
            char End;

            for(int i = 0; i < str.Length; i++)
            {
                arr[i] = str[i];
            }
           for(int i = 0; i < templen; i++)
            {
                
                if (checkVol(arr[i]) ) {
                    Start = arr[i];
                    if (checkVol(arr[templen]))
                    {
                     End = arr[templen];
                        char holder;
                        holder = Start;
                        Start = End;
                        End = holder;
                        templen--;
                    }
                  
                    templen--;

                }

            }
           string sortStr= String.Join("", arr);
            Console.WriteLine(sortStr);

        }
    }
}