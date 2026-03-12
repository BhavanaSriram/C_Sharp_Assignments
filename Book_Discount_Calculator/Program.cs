using System;

class Program
{
    static void Main()
    {
        Book b1 = new Book("Dot net basics", "Jack", 600, true);
        Book b2 = new Book("java basics", "Jill", 450, false);

        b1.Display();
        b2.Display();
    }
}