using System;
using System.Collections.Generic;

class StockSpan
{
    static int[] CalculateSpan(int[] prices)
    {
        int n = prices.Length;
        int[] span = new int[n];
        Stack<int> st = new Stack<int>();

        for (int i = 0; i < n; i++)
        {
            while (st.Count > 0 && prices[st.Peek()] <= prices[i])
            {
                st.Pop();
            }
            span[i] = (st.Count == 0) ? i + 1 : i - st.Peek();
            st.Push(i);
        }
        return span;
    }
    public static void Main()
    {
        int[] prices = { 100, 90, 80, 70, 60, 50, 85 };
        int[] result = CalculateSpan(prices);

        foreach (int x in result)
            Console.Write(x + " ");
    }
}