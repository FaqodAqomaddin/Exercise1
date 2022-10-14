using System;

namespace Exercise1
{
    class Program
    {
        
        private int[] faq = new int[82];

        
        private int n;

        
        public void read()
        {
            
            while (true)
            {
                Console.Write("Masukkan Banyak Data : ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 82)
                    break;
                else
                    Console.WriteLine("\n Data mempunyai maksimal 82.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("----------------------");
            Console.WriteLine("Masukkan Data ");
            Console.WriteLine("----------------------");

            
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                String s1 = Console.ReadLine();
                faq[i] = Int32.Parse(s1);
            }
        }
        public void display()
        {
           
            Console.WriteLine("");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Data-Data yang telah tersusun");
            Console.WriteLine("---------------------------------");
            for (int Fa = 0; Fa < n; Fa++)
            {
                Console.WriteLine(faq[Fa]);
            }
            Console.WriteLine("");
        }
        public void BubbleSortArray()
        {
            for (int i = 1; i < n; i++) 
            {
                
                for (int Fa = 0; Fa < n - i; Fa++)
                {
                    if (faq[Fa] > faq[Fa + 1]) 
                    {
                       
                        int temp;
                        temp = faq[Fa];
                        faq[Fa] = faq[Fa + 1];
                        faq[Fa + 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            
            Program mylist = new Program();

            
            mylist.read();
           
            mylist.BubbleSortArray();
           
            mylist.display();
            
            Console.WriteLine("\n\nTekan Tombol Apa Saja Untuk Keluar.");
            Console.Read();
        }
    }
}