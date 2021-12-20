using LibrarieConsoleApp;

/// Qustion 1

//string[] arrayOfNames = {"Ermias","Matan","Markus","keren","Lior","Eden","Avi"};
//List<string> listOfNames = (from name in arrayOfNames
//                            where name.ToUpper().StartsWith('E')
//                            select name).ToList();

//foreach (string name in listOfNames)
//{
//    Console.WriteLine(name);
//}


/// Qustion 2

//int [] arrayOfAges = new int [10];

//for (int i = 0; i < arrayOfAges.Length; i++)
//{
//    Random randomNumber = new Random();
//    arrayOfAges[i] = randomNumber.Next(50);
//}

//List<int> listOfAges = (from age in arrayOfAges
//                       where age > 20
//                       select age).ToList();


/// Qustion 3 + Qustion 4
//Random randomNumberOfPages = new Random();
//randomNumberOfPages.Next(500);
//Book[] arryOfBooks = new Book[]
//{
//    new Book("hobbit","tulkin",randomNumberOfPages.Next(500)),
//    new Book("Jert","tulkin",randomNumberOfPages.Next(500)),
//    new Book("tool","sid",randomNumberOfPages.Next(500)),
//    new Book("cill","sid",randomNumberOfPages.Next(500)),
//    new Book("dortman","gol",randomNumberOfPages.Next(500)),
//    new Book("payment","gol",randomNumberOfPages.Next(500))
//};

/// Qustion 5
//List<Book> listOfBooks = (from book in arryOfBooks
//                          where book.numberOfPages > 200
//                          select book).ToList();
/// Qustion 6
//List<Book> listOfBooks = (from book in arryOfBooks
//                          where book.author.Length > 4
//                          select book).ToList();            
/// Qustion 7
//List<Book> listOfBooks = arryOfBooks.ToList();
//Book bookLessThen500Pages = listOfBooks.Find(book => book.numberOfPages > 150);
//Console.WriteLine($"{bookLessThen500Pages.name} {bookLessThen500Pages.author} {bookLessThen500Pages.numberOfPages}");
/// Qustion 8
//List<Book> listOfBooks = (from book in arryOfBooks
//                          where book.name.ToLower().EndsWith('Y')
//                          select book).ToList();

/// Qustion 9 + Qustion 10 + Qustion 11
//var listOfBooks = (from book in arryOfBooks
//                   group book by book.author);

//foreach (var group in listOfBooks)
//{
//    Console.WriteLine($"Group Name : {group.Key}");
//    foreach (Book book in group)
//    {
//        Console.WriteLine(book.author);
//    }
//}
                          



