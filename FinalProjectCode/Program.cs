using FinalProjectCode.Model;
using Helper;
using System;
using System.IO;

namespace FinalProjectCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            int a = StartMenu();
            switch (a)
            {
                case 1:
                    {
                        Console.Clear();
                        Author[] authors = new Author[0];

                        Start:
                        int m = Menu();
                        switch (m)
                        {
                            case 1:
                                {
                                    string authorName = ClassHelper.ReadText("Muellif adi:", 1);

                                    Array.Resize(ref authors, authors.Length + 1);
                                    authors[authors.Length - 1] = new Author(authorName);
                                    Console.Clear();
                                    break;
                                }
                            case 2:
                                {
                                    int Authorid = ClassHelper.TryInt("Muellifin iDsi:");

                                    int secilen = Array.FindIndex(authors, a => a.id == Authorid);


                                    if (secilen == -1)
                                    {
                                        Console.WriteLine($"{secilen} ID li Muellif Tapilmadi");
                                    }
                                    else
                                    {
                                        string authorName = ClassHelper.ReadText("Muellif adini daxil edin:", 1);
                                        authors[secilen].Name = authorName;
                                    }

                                    Console.Clear();
                                    break;
                                }
                            case 3:
                                {
                                    int Authorid = ClassHelper.TryInt("Muellifin iDsi:");

                                    int secilen = Array.FindIndex(authors, a => a.id == Authorid);


                                    if (secilen == -1)
                                    {
                                        Console.WriteLine($"{secilen} ID li Muellif Tapilmadi");
                                    }
                                    else
                                    {
                                        for (int i = secilen; i < authors.Length - 1; i++)
                                        {
                                            authors[secilen] = authors[secilen + 1];
                                        }
                                        Array.Resize(ref authors, authors.Length - 1);
                                    }

                                    Console.Clear();
                                    break;
                                }

                            case 4:
                                Console.Clear();
                                {
                                    foreach (var author in authors)
                                    {
                                        Console.WriteLine($"=={author}==");
                                    }

                                }

                                break;
                            case 5:

                                {
                                    Console.Clear();
                                    foreach (var author in authors)
                                    {

                                        string axtaris = ClassHelper.ReadText("Axtrais metnini daxil edin:", 1);
                                        if (author.Name.StartsWith(axtaris))
                                        {
                                            Console.WriteLine($"{author}");
                                        }
                                        else
                                        {

                                            Console.WriteLine("Axtaris zamani netice tapilmadi");
                                        }
                                    }

                                }

                                break;
                            case 6:
                                Console.Clear();
                                {
                                    foreach (var author in authors)
                                    {
                                        using (StreamWriter sw = new StreamWriter("author.txt", append: true))
                                        {
                                            sw.WriteLine(author);
                                        }

                                    }

                                }

                                break;
                        }
                        goto Start;

                    }
                case 2:
                    {
                        Console.Clear();
                        Book[] books = new Book[0];
                        Start:
                        int b = Bookmenu();

                        switch (b)
                        {

                            case 1:
                                {
                                    string bookName = ClassHelper.ReadText("Kitab adi:", 1);
                                    int bookpage = ClassHelper.TryInt("Kitabin sehife sayini daxil edin:");
                                    Array.Resize(ref books, books.Length + 1);
                                    books[books.Length - 1] = new Book(bookName, bookpage);
                                    Console.Clear();
                                    break;
                                }


                            case 2:
                                {
                                    int Bookid = ClassHelper.TryInt("Kitabin iDsi:");

                                    int secilen = Array.FindIndex(books, a => a.id == Bookid);


                                    if (secilen == -1)
                                    {
                                        Console.WriteLine($"{secilen} ID li Kitab Tapilmadi");
                                    }
                                    else
                                    {
                                        string bookName = ClassHelper.ReadText("Kitabin adini daxil edin:", 1);
                                        int bookpage = ClassHelper.TryInt("Kitabin sehifesini daxil edin:");
                                        books[secilen].Name = bookName;
                                        books[secilen].page = bookpage;
                                    }

                                    Console.Clear();
                                    break;

                                }
                            case 3:
                                {
                                    int Bookid = ClassHelper.TryInt("Kitabin iDsi:");

                                    int secilen = Array.FindIndex(books, a => a.id == Bookid);


                                    if (secilen == -1)
                                    {
                                        Console.WriteLine($"{secilen} ID li Kitab Tapilmadi");
                                    }
                                    else
                                    {
                                        for (int i = secilen; i < books.Length - 1; i++)
                                        {
                                            books[secilen] = books[secilen + 1];
                                        }
                                        Array.Resize(ref books, books.Length - 1);
                                    }

                                    Console.Clear();
                                    break;
                                }
                            case 4:
                                Console.Clear();
                                {
                                    foreach (var book in books)
                                    {
                                        Console.WriteLine($"---{book}---");
                                    }
                                    break;

                                }
                            case 5:

                                {
                                    Console.Clear();
                                    foreach (var book in books)
                                    {

                                        string axtaris = ClassHelper.ReadText("Axtrais metnini daxil edin:", 1);
                                        if (book.Name.StartsWith(axtaris))
                                        {
                                            Console.WriteLine($"{book}");
                                        }
                                        else
                                        {

                                            Console.WriteLine("Axtaris zamani netice tapilmadi");
                                        }
                                    }
                                    break;

                                }
                            case 6:
                                Console.Clear();
                                {
                                    foreach (var book in books)
                                    {
                                        using (StreamWriter sw = new StreamWriter("book.txt", append: true))
                                        {
                                            sw.WriteLine(book);
                                        }

                                    }
                                    break;

                                }

                        }
                        
                        goto Start;
                    }





            }





        }

        static int Menu()
        {
            Console.WriteLine("*****************COMMANDS*****************");
            Console.WriteLine("1:Add Author");
            Console.WriteLine("2:Edit Author");
            Console.WriteLine("3:Delete Author");
            Console.WriteLine("4:Select All Authors");
            Console.WriteLine("5:Filter Author");
            Console.WriteLine("6:Save All Authors");
            int menucode = ClassHelper.TryInt("Secim Edin:");

            return menucode;
        }
        static int Bookmenu()
        {
            Console.WriteLine("*****************BOOK COMMANDS*****************");
            Console.WriteLine("1:Add Book");
            Console.WriteLine("2:Edit Book");
            Console.WriteLine("3:Delete Book");
            Console.WriteLine("4:Select All Books");
            Console.WriteLine("5:Filter Book");
            Console.WriteLine("6:Save All Books");
            int bookmenucode = ClassHelper.TryInt("Secim Edin:");

            return bookmenucode;
        }
        static int StartMenu()
        {
            Console.WriteLine("*****************COMMANDS FOR CHOOSE*****************");
            Console.WriteLine("1:Author Menu");
            Console.WriteLine("2:Book Menu");
            int startmenucode = ClassHelper.TryInt("Secim Edin:");

            return startmenucode;
        }
    }
}
