// See https://aka.ms/new-console-template for more information
using CollectionExample;
using System.Collections;

Console.WriteLine("Hello, World!");


MovieInfo movie1 = new MovieInfo() { ID = 1, IsReleased = true, MovieGenre = "Action", MovieTitle = "Top Gun", MovieVote = 7 };
MovieInfo movie2 = new MovieInfo() { ID = 2, IsReleased = true, MovieGenre = "Action", MovieTitle = "Indiana Jones", MovieVote = 8 };

//List operations
var moviesList = new List<MovieInfo>();
moviesList.Add(movie1);
moviesList.Add(movie2);
foreach (var item in moviesList)
    Console.WriteLine("Movie info list (insert): {0},{1},{2},{3},{4}", item.ID, item.MovieTitle, item.MovieGenre, item.IsReleased, item.MovieVote);
moviesList.RemoveAt(1);
foreach (var item in moviesList)
    Console.WriteLine("Movie info list (remove): {0},{1},{2},{3},{4}", item.ID, item.MovieTitle, item.MovieGenre, item.IsReleased, item.MovieVote);


//Stack operations
var moviesStack = new Stack<MovieInfo>();
moviesStack.Push(movie1);
moviesStack.Push(movie2);
foreach (var item in moviesStack)
    Console.WriteLine("Movie info stack (insert): {0},{1},{2},{3},{4}", item.ID, item.MovieTitle, item.MovieGenre, item.IsReleased, item.MovieVote);
moviesStack.Pop();
foreach (var item in moviesStack)
    Console.WriteLine("Movie info stack (remove): {0},{1},{2},{3},{4}", item.ID, item.MovieTitle, item.MovieGenre, item.IsReleased, item.MovieVote);


//Queue operations
var moviesQueue = new Queue<MovieInfo>();
moviesQueue.Enqueue(movie1);
moviesQueue.Enqueue(movie2);
foreach (var item in moviesQueue)
    Console.WriteLine("Movie info queue (insert): {0},{1},{2},{3},{4}", item.ID, item.MovieTitle, item.MovieGenre, item.IsReleased, item.MovieVote);
moviesQueue.Dequeue();
foreach (var item in moviesQueue)
    Console.WriteLine("Movie info queue (remove): {0},{1},{2},{3},{4}", item.ID, item.MovieTitle, item.MovieGenre, item.IsReleased, item.MovieVote);


//HashTable operations
var moviesHashTable = new Hashtable();
moviesHashTable.Add(1, movie1);
moviesHashTable.Add(2, movie2);
foreach (DictionaryEntry item in moviesHashTable) 
{
    MovieInfo tableInfo = moviesHashTable[item.Key] as MovieInfo;
    Console.WriteLine("Movie info hashtable (insert): {0},{1},{2},{3},{4}", tableInfo.ID, tableInfo.MovieTitle, tableInfo.MovieGenre, tableInfo.IsReleased, tableInfo.MovieVote);
}
moviesHashTable.Remove(1);
foreach (DictionaryEntry item in moviesHashTable)
{
    MovieInfo tableInfo = moviesHashTable[item.Key] as MovieInfo;
    Console.WriteLine("Movie info hashtable (remove): {0},{1},{2},{3},{4}", tableInfo.ID, tableInfo.MovieTitle, tableInfo.MovieGenre, tableInfo.IsReleased, tableInfo.MovieVote);
}


//LinkedList operations
var moviesLinkedList = new LinkedList<MovieInfo>();
moviesLinkedList.AddLast(movie1);
moviesLinkedList.AddFirst(movie2);
foreach (var item in moviesLinkedList)
    Console.WriteLine("Movie info linked list (insert): {0},{1},{2},{3},{4}", item.ID, item.MovieTitle, item.MovieGenre, item.IsReleased, item.MovieVote);
moviesLinkedList.RemoveLast();
foreach (var item in moviesLinkedList)
    Console.WriteLine("Movie info linked list (remove): {0},{1},{2},{3},{4}", item.ID, item.MovieTitle, item.MovieGenre, item.IsReleased, item.MovieVote);
