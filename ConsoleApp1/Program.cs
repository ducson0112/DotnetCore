using System;
namespace ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            VuKhi vukhi1 = new VuKhi();
            vukhi1.shoot();
            // VuKhi vukhi2 = new VuKhi();
            // vukhi2.tenvukhi = "sung truong";
            // vukhi2.dosatthuong = 3;
            VuKhi vukhi3 = new VuKhi();
            vukhi3.SetTenVuKhi("Sung baret");
            vukhi3.SetDoSatThuong(6);

            vukhi1.shoot();
            //vukhi2.shoot();
            vukhi3.shoot();
        }
    }
}