// See https://aka.ms/new-console-template for more information
using System;

Singly linkedList = new Singly();
linkedList.AddLast(10);
linkedList.AddLast(20);
linkedList.AddLast(30);
linkedList.AddLast(40);
linkedList.AddLast(11);
linkedList.AddLast(0);
linkedList.AddLast(211);
linkedList.Display();
Console.Write("Enter the k element: ");
int k = int.Parse(Console.ReadLine()!);
linkedList.Rotate(k);
linkedList.Display();





