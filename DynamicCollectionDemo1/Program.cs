namespace DynamicCollectionDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Client Dev 3
            // accept n number of string then display 
            DynamicCollection<string> array = new DynamicCollection<string>();
            array.Add("1");
            array.Add("2.4");
            array.Add("3");
            array.Add("4.3");
            //array.Add(5);
            //array.Add(6.6);
            //array.Add(7);
            //array.Add(8);

            //array.Add(1);
            //array.Add(2);
            //array.Add(3);
            //array.Add(4);
            //array.Add(5);
            //array.Add(6);
            //array.Add(7);
            //array.Add(8);

            for (int i = 0; i < array.Count; i++)
            {
                string a = array.Get(i);
                Console.WriteLine(a);
            }
        }
    }

    // Lib Dev
    public class DynamicCollection<T>
    {
        private T[] array = new T[5];
        private int index = 0;
        public void Add(T x)
        {
            if (index < array.Length) // array is empty
            {
                array[index++] = x;
            }
            else // its full - reallocate
            {
                Console.WriteLine("Reallocating");
                //int[] temp = new int[array.Length * 2];
                ////temp = [.. array];
                //Array.Copy(array, temp, array.Length);
                //array = temp;

                Array.Resize(ref array, array.Length * 2);

                array[index++] = x;
            }
        }

        public T Get(int x)
        {
            return array[x];
        }

        public int Count { get { return index; } }
    }



    //public class DynamicDoubleCollection
    //{
    //    private double[] array = new double[5];
    //    private int index = 0;
    //    public void Add(double x)
    //    {
    //        if (index < array.Length) // array is empty
    //        {
    //            array[index++] = x;
    //        }
    //        else // its full - reallocate
    //        {
    //            Console.WriteLine("Reallocating");
    //            //int[] temp = new int[array.Length * 2];
    //            ////temp = [.. array];
    //            //Array.Copy(array, temp, array.Length);
    //            //array = temp;

    //            Array.Resize(ref array, array.Length * 2);

    //            array[index++] = x;
    //        }
    //    }

    //    public double Get(int x)
    //    {
    //        return array[x];
    //    }

    //    public int Count { get { return index; } }
    //}
}
