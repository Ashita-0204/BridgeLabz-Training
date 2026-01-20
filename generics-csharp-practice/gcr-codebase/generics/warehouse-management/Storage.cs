using System;
class Storage<T> where T : WarehouseItem
{
    private T[] items;
    private int idx = 0;
    public Storage(int size)
    {
        items = new T[size];
    }
    public void AddItem(T item)
    {
        items[idx++] = item;
    }
    public void Displayy()
    {
        for (int i = 0; i < idx; i++)
        {
            items[i].Display();
        }
    }

}