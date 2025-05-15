namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Khai báo biến: có 14 loại biến.
            int diem_toan = 10; //(32 bit) -2 ty -> 2 ty
            byte diem_tin = 10; // 8 bit co dau, -128 -> 127
            sbyte _toan = 10; // 8 bit 0 -> 256
            short _tin = 10; // 16 bit -32k -> 32k
            ushort chieucao = 164;// 16 bit 0 -> 65k
            long khoang_cach = -435345345345345; //64 bit -9 ty ty -> 9 ty ty
            ulong kHoang_cach_2 = 12312312312123123; //64 bit 0 -> 18 ty

            float khoang_cah = 3.13123f; // 32 bit
            double can_nang = 23423.234234d; // 64 bit
            decimal anc_cnsa = 12312312.123123M; // 128bit

            char a = 'B';
            char b = '!';
            string tenhocsinh = "adfasdfasdf123";
            bool co_mat = true;
            object toi = new object();


            Console.WriteLine(diem_toan);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(diem_tin);
            Console.ResetColor();
            Console.WriteLine(anc_cnsa);
            Console.WriteLine();
            string ca = Console.ReadLine();
            Console.WriteLine(ca);

        }
    }
}
