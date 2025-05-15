namespace ConsoleApp
{
    internal class VuKhi 
    {
        
        int dosatthuong;
        string tenvukhi;

        // Constructor 
        public VuKhi()
        {
            this.tenvukhi = "Sungluc";
            this.dosatthuong = 1;
        }

        //Contructor 
        public VuKhi(int dosatthuong, string tenvukhi)
        {
            this.dosatthuong = dosatthuong;
            this.tenvukhi = tenvukhi;
        }


        public int GetDoSatThuong()
        {
            return this.dosatthuong;
        }

        public void SetDoSatThuong(int _dosatthuong)
        {
            this.dosatthuong = _dosatthuong;
        }

        public string GetTenVuKhi()
        {
            return tenvukhi;
        }

        public void SetTenVuKhi(string _tenvukhi)
        {
            this.tenvukhi = _tenvukhi;
        }
        public void shoot()
        {
            Console.Write($"{tenvukhi}: \t");
            for (int i = 0; i < dosatthuong; i++)
            {
                Console.Write("+");
            }
            Console.WriteLine();
        }
    }
}