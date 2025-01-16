namespace Demo
{


    internal class Program
    {

        //public static int SumOfArrayList(ArrayList arraylist)
        //{
        //    int Sum = 0;
        //    if (arraylist is not null)
        //    {

        //        for (int i = 0; i < arraylist.Count; i++)
        //        {
        //            Sum += (int ? arraylist)[i] ?? 0;

        //        }
        //        return Sum;

        //    }
        //}


        //public static int SumOfList(List<int> list)
        //{
        //    int Sum = 0;
        //    if (list is not null)
        //    {

        //        for (int i = 0; i < list.Count; i++)
        //        {
        //            Sum += (int ? list)[i] ?? 0;

        //        }
        //        return Sum;

        //    }
        //}
        static void Main(string[] args)
        {
            #region Session 02

            #region Non-Generic Collections (ArrayList)
            #region Ex1
            //ArrayList arrayList = new ArrayList();
            //Console.WriteLine($"Count ={arrayList.Count}, Capacity = {arrayList.Capacity}");
            //arrayList.Add(1);
            //arrayList.Add(2);
            //arrayList.AddRange(new int[] { 3, 4 });
            //Console.WriteLine("After Adding Elements");
            //Console.WriteLine($"Count ={arrayList.Count}, Capacity = {arrayList.Capacity}");
            //arrayList.Add(5);
            //Console.WriteLine("After Adding 5th Element");
            //Console.WriteLine($"Count ={arrayList.Count}, Capacity = {arrayList.Capacity}");
            //arrayList.TrimToSize();
            //Console.WriteLine("After Trimming");
            //Console.WriteLine($"Count ={arrayList.Count}, Capacity = {arrayList.Capacity}");
            #endregion

            //ArrayList arrayList = new ArrayList(5) { 1, 2, 3, 4, 5 };
            //Console.WriteLine($"Count ={arrayList.Count}, Capacity = {arrayList.Capacity}");
            //arrayList.Add(6);
            //Console.WriteLine("After Adding the 6th element");
            //Console.WriteLine($"Count ={arrayList.Count}, Capacity = {arrayList.Capacity}");

            //-------------------------------
            //ArrayList arraylist = new ArrayList();
            //arraylist.Add(1); //Casting from int value Type to object [ref type] boxing
            //arraylist.Add(2);
            //arraylist.Add(3);
            //arraylist.Add(4);
            //arraylist.Add("Hamada");
            ////Compiler can not enforce type safty


            //int Result = SumOfArrayList(arraylist);
            //Console.WriteLine($"The Result = {Result}");
            #endregion

            #region Generic Collections (List)
            #region List Methods
            List<int> list = new List<int>();
            // EX1
            Console.WriteLine($"Count ={list.Count}, Capacity = {list.Capacity}");
            list.Add(1);
            list.Add(2);
            list.AddRange(new int[] { 3, 4 });
            Console.WriteLine("After Adding Elements");
            Console.WriteLine($"Count ={list.Count}, Capacity = {list.Capacity}");
            list.Add(5);
            Console.WriteLine("After Adding 5th Element");
            Console.WriteLine($"Count ={list.Count}, Capacity = {list.Capacity}");
            list.TrimExcess();
            Console.WriteLine("After Trimming");
            Console.WriteLine($"Count ={list.Count}, Capacity = {list.Capacity}");
            //// list.Add("Mohab"); /// Error
            //int Result = SumOfList(list);
            //Console.WriteLine($"The result is {Result}");


            /// list indexer  ---> set    get    add
            list[2] = 10;  /// use indexer for setter
            Console.WriteLine(list[2]);  /// use indexer for get
            list[4] = 5;    /// indexer for adding

            #endregion



            #endregion



            #region Ensure Capacity

            #endregion

            #endregion
        }
    }
}