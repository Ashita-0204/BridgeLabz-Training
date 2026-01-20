using System;

namespace AadharRadixSort
{

    public class AadharManager
    {

        private long[] aadharNumbers;
        private RadixSorter sorter;
        private BinarySearcher searcher;

        public AadharManager()
        {
            sorter = new RadixSorter();
            searcher = new BinarySearcher();

            aadharNumbers = new long[]{
                789654133.12365478965,745982175681,785182172
            };
        }

        public void Display()
        {
            foreach (long num in aadharNumbers)
            {
                Console.WriteLine(num);
            }
        }

        public void SortAadhar()
        {
            sorter.Sort(aadharNumbers);
            Console.WriteLine("Aadhar Numbers Sorted Successfully");
        }

        public void SearchAadhar(long key)
        {
            int index = searcher.Search(aadharNumbers, key);
            if (index != -1)
                Console.WriteLine("Aadhar Found at index: " + index);
            else
                Console.WriteLine("Aadhar Not Found");
        }
    }
}
