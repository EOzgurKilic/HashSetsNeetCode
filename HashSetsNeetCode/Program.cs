namespace HashSetsNeetCode;

class Program
{
    static void Main(string[] args)
    {
        //HashSets
        //HashSet in C# is an unordered collection of unique elements.It is generally used when we want to prevent duplicate elements from being placed in the collection.
        //The performance of the HashSet is much better in comparison to the list. 
        HashSet<int> hashSet = new();
        
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
            Console.WriteLine(VARIABLE);
    }
}