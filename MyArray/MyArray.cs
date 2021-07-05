using System.Collections.Generic;

namespace MyArray
{
    class MyArray
    {
        public Dictionary<int, int> Counter()
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            foreach (var e in a)
            {
                if (dic.ContainsKey(e))  dic.Add(e, 0);
                dic[e]++;

            }
            return dic;
        }

        int[] a;
 
        public MyArray(int n)
        {
            a = new int[n];
       
        }

        public MyArray(int n,int start, int step)
        {
            a = new int[n];
            a[0] = start;
            for (int i = 1; i < n; i++)
                a[i] = a[i-1] + step;
        }

        public int[] Inverse()
        {
            int []t = new int[a.Length];
            for (int i = 0; i < a.Length; i++) t[i] = -a[i];
            return t;
        }

        public void Multi( int multi)
        {

            int[] t = new int[a.Length];
            for (int i = 0; i < a.Length; i++) t[i] = a[i]*multi;
        }


        public int Sum
        {
            get
            {
                int sum= a[0];
                for (int i = 1; i < a.Length; i++)
                    sum = sum + a[i];
                return sum;
            }
        }

        public int MaxCount
        {
            get
            {
                int max = a[0];
                int maxcount=0;
                for (int i = 1; i < a.Length; i++)
                    if (a[i] > max) max = a[i];
                for (int i = 0; i < a.Length; i++)
                    if (a[i] == max) maxcount++;
                return maxcount;


            }
        }
        public int Max
        {
            get
            {
                int max = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] > max) max = a[i];
                return max;
            }
        }
        public int Min
        {
            get
            {
                int min = a[0];
                for (int i = 1; i < a.Length; i++)
                    if (a[i] < min) min = a[i];
                return min;
            }
        }
        public int CountPositiv
        {
            get
            {
                int count = 0;
                for (int i = 0; i < a.Length; i++)
                    if (a[i] > 0) count++;
                return count;
            }
        }
        public override string ToString()
        {
            string s = "";
            foreach (int v in a)
                s = s + v + " ";
            return s;
        }
    }
}
