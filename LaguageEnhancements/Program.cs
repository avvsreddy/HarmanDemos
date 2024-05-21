namespace LaguageEnhancements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Local type inference
            var a = 10;
            var name = "sdfsdfsdf";
            var map = new Dictionary<int, string>();

            // Object Intialization Syntax
            // create item object and initialize
            Item item = new Item();// instantiation
            item.ID = 123;
            item.Name = "IPhone";
            item.Price = 99999;

            Item item2 = new Item { ID = 111, Name = "IPhone 16", Price = 99999 };
            Item item3 = new Item
            {
                ID = 222,
                Name = "IPhone 16"
            };

            // Anonymous Types

            // var abc = "sdfsdfsdf";

            // want to store person info and then use it
            var p = new { Pid = 111, Name = "Sachin", Email = "sachin@mail.com" };
            Console.WriteLine(p.Name);


            // Extension Methods

            string msg = "this is a string message";
            msg.ToUpper();

            //msg.

            msg.Encrypt();
            msg.Encrypt();
            string ent = MyUtil.Encrypt(msg);


        }
    }

    class MyString// : String
    {

    }

    public static class MyUtil
    {
        public static string Encrypt(this string data)
        {
            return "#$#RSDERT#$%";
        }
    }

    sealed class Anonymouse3434234234
    {

    }

    class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        //public Item()
        //{

        //}
        //public Item(int id, string name)
        //{
        //    this.ID = id;
        //    this.Name = name;

        //}
        //public Item(int id, string name, int price) : this(id, name)
        //{
        //    //this.ID = id;
        //    //this.Name = name;
        //    this.Price = price;
        //}
    }
}
