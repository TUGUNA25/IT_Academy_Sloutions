using Solutions;


//N1
static void GenericSwap<T>(T[]arr,T element1, T element2) { 
    int pos1 = Array.IndexOf(arr,element1);
    int pos2 = Array.IndexOf(arr,element2);
    if (pos1 == -1 || pos2 == -1) {
        Console.WriteLine("This Element Is Not in Array");
    }
    else
    {
        T container = arr[pos1];
        arr[pos1] = arr[pos2];
        arr[pos2] = container;
        Console.WriteLine("Swap Completed Successfully");
    }
    
}

//N2
static T GenericMaximumFinder<T>(T[] arr) where T : IComparable<T> { 
    T max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].CompareTo(max)>0)
            max = arr[i];
    }

    return max;
}

