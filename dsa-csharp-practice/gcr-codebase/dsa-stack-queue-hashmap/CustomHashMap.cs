using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Marshalling;

class CustomHashMap
{
    private const int sizee = 10;
    private LinkedList<(int key, int value)>[] table;
    public CustomHashMap()
    {
        table = new LinkedList<(int, int)>[sizee];
    }
    public int hash(int key) => key % sizee;
    public void Put(int key, int value)
    {
        int idx = hash(key);
        if (table[idx] == null)
        {
            table[idx] = new LinkedList<(int, int)>();
        }
        foreach (var pair in table[idx])
        {
            if (pair.key == key)
            {
                table[idx].Remove(pair);
                break;
            }
        }
        table[idx].AddLast((key, value));
    }
    public int Get(int key)
    {
        int idx = hash(key);
        if (table[idx] != null)
        {
            foreach (var pair in table[idx])
            {
                if (pair.key == key)
                {
                    return pair.value;
                }
            }
        }
        return -1;
    }
    public static void Main()
    {
        CustomHashMap map = new CustomHashMap();
        map.Put(1, 50);
        map.Put(2, 60);

        Console.WriteLine(map.Get(1));
        Console.WriteLine(map.Get(3));
    }
}