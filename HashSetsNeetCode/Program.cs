namespace HashSetsNeetCode;

class Program
{
    static void Main(string[] args)
    {
        //HashSets
        //HashSet in C# is an unordered collection of unique elements.It is generally used when we want to prevent duplicate elements from being placed in the collection.
        //The performance of the HashSet is much better in comparison to the list. 
        /*HashSet<int> hashSet = new();
        
        //Adding Elements
        hashSet.Add(1);
        hashSet.Add(2);
        hashSet.Add(3);
        hashSet.Add(4);
        hashSet.Add(5);
        
        //Accessing Elements
        //We generally use a foreach loop to iterate through the elements of a HashSet.
        foreach (int item in hashSet)
            Console.WriteLine(item);
        
        //Remove(T): This method is used to remove the specified element from a HashSet object.
        hashSet.Remove(2);
        
        //RemoveWhere(Predicate): This method is used to remove all elements that match the conditions defined by the specified predicate from a HashSet collection.
        
        //Clear: This method is used to remove all elements from a HashSet object.
        hashSet.Clear();
        
        //Set Operations
        //The HashSet class also provides some methods that are used to perform different operations on sets and the methods are:
        //UnionWith(IEnumerable): This method is used to modify the current HashSet object to contain all elements that are present in itself, the specified collection, or both.
        List<int> list = new(){1,2,3,4,5,6};
        hashSet.UnionWith(list);
        foreach (var VARIABLE in hashSet)
            Console.WriteLine(VARIABLE);
        //IntersectWith(IEnumerable): This method is used to modify the current HashSet object to contain only elements that are present in that object and the specified collection.
        list.Remove(3);
        hashSet.IntersectWith(list);
        foreach (var VARIABLE in hashSet)
            Console.WriteLine(VARIABLE);
        //ExceptWith(IEnumerable): This method is used to remove all elements in the specified collection from the current HashSet object.
        list.Remove(4);
        list.Remove(0);
        hashSet.ExceptWith(list);
        foreach (var VARIABLE in hashSet)
            Console.WriteLine(VARIABLE);*/
        
        
        //Method Exercise
        //Scenerio;
        /*You are given two student clubs: the Chess Club and the Music Club. Each club stores member names using a HashSet<string>. 
        Your task is to perform various set operations and demonstrate commonly used HashSet methods.*/
        /*Tasks:
        1. Initialize two HashSet<string> instances with initial members.
        2. Add a new student to each club.
        3.Check if a particular student is a member of each club.
        4.Find students who are in both clubs.
        5.Find students who are in either club.
        6.Find students who are in Chess Club but not in Music Club.
        7.Compare if both clubs have the same members.
        8.Remove a student from a club.
        9.Clear one club.
        10.Print results at each step.*/
        /*//1-
        HashSet<string>  _chessClub= new();
        HashSet<string>  _musicClub= new();
        //2-
        _chessClub.Add("Carla");
        _chessClub.Add("Carl");
        _chessClub.Add("Candice");
        _chessClub.Add("Greg");
        _musicClub.Add("Candice");
        _musicClub.Add("Sarah");
        _musicClub.Add("Bojack");
        _musicClub.Add("Greg");
        //3-
        Console.WriteLine(_chessClub.Contains("Carla"));
        Console.WriteLine(_musicClub.Contains("Carla"));
        //4-
        HashSet<string> temp = new();
        temp.UnionWith(_musicClub);
        temp.IntersectWith(_musicClub);
        foreach (var VARIABLE in temp)
        Console.Write(VARIABLE + " ");
        Console.WriteLine();
        temp.Clear();
        //5-
        temp.UnionWith(_chessClub);
        temp.UnionWith(_musicClub);
        foreach (var VARIABLE in temp)
            Console.Write(VARIABLE + " ");
        Console.WriteLine();
        //6-
        temp.ExceptWith(_chessClub);
        foreach (var VARIABLE in temp)
            Console.Write(VARIABLE + " ");
        Console.WriteLine();
        //7-
        Console.WriteLine(_chessClub.SetEquals(_musicClub));
        //8-
        _chessClub.Remove("Carla");
        foreach (var VARIABLE in _chessClub)
            Console.Write(VARIABLE + " ");
        //9-
        _musicClub.Clear();
        //10-
        //Done*/
    }
    
    
}