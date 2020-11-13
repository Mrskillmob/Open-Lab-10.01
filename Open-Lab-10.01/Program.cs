using System;

namespace Open_Lab_10._00
{
    public class Book
    {
        public string title;
        private int pages;

        public void Pepega(int j)
        {
            pages = j;
            Console.WriteLine(pages);
        }


    }
        class Program
        {

        static void Main(string[] args)
        {

            Book LOTR = new Book();
            LOTR.title = "Lord of the Rings";
            

            Console.WriteLine(LOTR.title);
            LOTR.Pepega(16);

        }

        }
        




    
}
