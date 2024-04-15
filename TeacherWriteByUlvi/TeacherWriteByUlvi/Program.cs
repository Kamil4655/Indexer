namespace TeacherWriteByUlvi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Test test = new Test();
            //test[0] = 11;
            //test[1] = 15;
            //test[2] = 114;
            //test[3] = 19;
            //for (int i = 0; i < test.Length; i++) 
            //{
            //    Console.WriteLine(test[i]);
            //}
            foreach (var item in typeof(Test).GetProperties()) 
            {
                Console.WriteLine(item.Name);
            }
        }
        class Test
        {
            public int Length => arr.Length;    
            public int[] arr { get; set; }
            public int this[int i]
            {
                get
                {
                    return arr[i];
                }
                set
                {
                    if (value < 0)
                    
                        throw new ArgumentException("sifirdan kicik olaa bilmezz");
                    
                    if (i >= arr.Length)
                    
                        throw new IndexOutOfRangeException("bla bla bla");
                        arr[i] = value;
                    
                }
            }
            public Test()
            {
                arr = new int[10];
            }
        }
    }
}
