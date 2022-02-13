namespace BinarySearchAlgorithm;

public static class BinarySearch
{
    public static readonly List<string> SortedSureNames = new()
    {
        "Balaam",
        "Bennett",
        "Bone",
        "Briggs",
        "Brown",
        "Bruce",
        "Byrne",
        "Chaudhry",
        "Dempsey",
        "Dodd",
        "Findlay",
        "Flynn",
        "Forbes",
        "Ford",
        "Griffith",
        "Harper",
        "Homes",
        "Johnston",
        "Kaufman",
        "Kelly",
        "Lau",
        "Martin",
        "McDougall",
        "McKenna",
        "McMillan",
        "Nicol",
        "Noble", 
        "Nugent",
        "Parker",
        "Pettigrew",
        "Poyner",
        "Roberts",
        "Rogerson",
        "Roose",
        "Rose",
        "Sahni",
        "Singh",
        "Smyth",
        "Steer",
        "Stewart",
        "Tate",
        "Taylor",
        "Till",
        "Twigg",
        "Vincent",
        "Ward",
        "Warner",
        "Wilkins",
        "Winchester",
        "Wright"
    };

    public static void Main()
    {
        var searchIndex0 = Search(SortedSureNames, 0, SortedSureNames.Count() - 1, "Balaam");
        Console.WriteLine($"Balaam found at index: {searchIndex0}");
        Console.WriteLine();
        
        var searchIndex1 = Search(SortedSureNames, 0, SortedSureNames.Count() - 1, "Parker");
        Console.WriteLine($"Found searched Parker at index: {searchIndex1}");
        Console.WriteLine();
        
        var searchIndex2 = Search(SortedSureNames, 0, SortedSureNames.Count() - 1, "Ros");
        Console.WriteLine($"Ros do not exist in collection {searchIndex2}");
        Console.WriteLine();
        
        var searchIndex3 = Search(SortedSureNames, 0, SortedSureNames.Count() - 1, "Wright");
        Console.WriteLine($"Wright found on index {searchIndex3}");
    }

    public static int Search(List<string> data, int leftEnd, int rightEnd, string search)
    {
        if (leftEnd > rightEnd)
        {
            return -1;
        }
        
        var mid = (leftEnd + rightEnd) / 2;
        Console.WriteLine($"Current value: {data[mid]}, index: {mid}");

        if (search == data[mid])
        {
            return mid;
        }
        else if (search.CompareTo(data[mid]) < 0)
        {
            return Search(data, leftEnd, mid-1, search);
        }
        
        return Search(data,mid+1,rightEnd,search);
    }
}