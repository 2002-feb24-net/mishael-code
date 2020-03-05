using System;

namespace bubble
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] item = getInput(100000,0,100);
            printArray(condense(item, 1000));
            System.Console.WriteLine("\n");
            // bubbleSort(item);
            // quickSort(item);
            mergeSort(item);
            printArray(condense(item, 1000));
            System.Console.WriteLine(isSorted(item));
            // printArray(item);

        }
        static int[] getInput(int length, int Min, int Max)
        {
            int[] output = new int[length];

            Random randNum = new Random();
            for (int i = 0; i < output.Length; i++)
            {
                output[i] = randNum.Next(Min, Max);
            }

            return output;
        }

        static void printArray(int[] x)
        {
            string output = "";
            for(int i=0;i<x.Length;i++)
            {
                output+= x[i] + "\t";
                if (i%15 == 14)
                {
                    System.Console.Write(output+"\n");
                    output = "";
                }
            }
            System.Console.WriteLine(output);
        }

        static bool isSorted(int[] x)
        {
            bool sorted = true;
            for (int i=0;i<x.Length-1;i++)
            {
                sorted = sorted && x[i]<=x[i+1];
            }
            return sorted;
        }

        static int[] condense(int[] x, int spaceing)
        {
            int[] output = new int[x.Length/spaceing];
            for (int i = 0; i < output.Length; i++) output[i] = x[i*spaceing];
            return output;
        }

        static void bubbleSort(int[] x)
        {
            for(int k=x.Length-2;k>0;k--)
            {
                for(int i=0;i<=k;i++)
                {
                    if(x[i]>x[i+1])
                    {
                        int temp = x[i];
                        x[i] = x[i+1];
                        x[i+1] = temp;
                    }
                }
            }
        }

        static void quickSort(int[] x) { quickSortRec(x,0,x.Length-1); }

        static void quickSortRec(int[] x, int first, int last)
        {
            if(first == last) return;
            if(last-first <= 100)
            {
                bubbleSortAssist(x,first,last);
                return;
            }
            int index = first;
            for (int i = index+1; i <= last; i++)
            {
                if(x[i]<x[index])
                {
                    int temp = x[index];
                    x[index] = x[i];
                    x[i] = x[index+1];
                    x[index+1] = temp;
                    index++;
                }
            }
            quickSortRec(x,first,index-1);
            quickSortRec(x,index+1,last);
        }
        
        static void bubbleSortAssist(int[] x, int start, int end)
        {
            for(int k=end-1;k>=start;k--)
            {
                for(int i=start;i<=k;i++)
                {
                    if(x[i]>x[i+1])
                    {
                        int temp = x[i];
                        x[i] = x[i+1];
                        x[i+1] = temp;
                    }
                }
            }
        }

        static void mergeSort(int[] x) { mergeRec(x,0,x.Length-1); }

        static void mergeRec(int[] x, int l, int r)
        {
            if(r-l>5)
            {
                int m = (l+r)/2;
                mergeRec(x,l,m-1);
                mergeRec(x,m,r);
                merge(x,l,m,r);
            }else bubbleSortAssist(x,l,r);
        }

        static void merge(int[] x, int l, int m, int r)
        {
            while(l<r&&m<=r)
            {
                if(x[l]<=x[m]) l++;
                else
                {
                    for(int i=m;i>l;i--)
                    {
                        int temp = x[i];
                        x[i] = x[i-1];
                        x[i-1] = temp;
                    }
                    m++;
                    l++;
                }
            }
        }
    }
}
