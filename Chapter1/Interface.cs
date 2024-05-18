namespace Chapter1
{
    internal static class Interface
    {
        interface ITest
        {
            void Print();
        }
        class Base : ITest
        {
            public void Print()
            {
                Console.WriteLine("Print method called");
            }
        }
        static void Main(string[] args)
        {
            Base obj = new Base();
            obj.Print();
            //Gọi phương thức Print() bằng  interface  ITest
            ITest ib = (ITest)obj;
            ib.Print();
            //Gọi phương thức Print() bằng cách ép kiểu Interface ITest về lớp Base
            Base ojB = (Base)ib;
            ojB.Print();
        }
    }
}
