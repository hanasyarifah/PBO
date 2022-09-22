using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_PBO_PRT_1
{
    class Ban
    {
        public string merk;
        public Ban(string Merk)
        {
            this.merk = Merk;
        }
    }
    class Michelin : Ban
    {
        public Michelin(): base("Michelin")
        {

        }
    }
    class Bridgestone : Ban
    {
        public Bridgestone(): base("Bridgestone")
        {

        }
    }
    class Mobil
    {
        public string merk;
        public string tipe;
        public Ban ban;
        public Mobil(string Merk, string Tipe, Ban ban)
        {
            this.merk = Merk;
            this.tipe = Tipe;
            this.ban = ban;
        }
        public void NyalakanMesin()
        {
            Console.WriteLine($"Mesin mobil {this.merk} bertipe {this.tipe} menyala");
        }
        public void MatikanMesin()
        {
            Console.WriteLine($"Mesin mobil {this.merk} bertipe {this.tipe} mati");
        }
    }
    class Toyota : Mobil
        {
            public Toyota(string Tipe, Ban ban): base("Toyota", Tipe, ban)
            {

            }
        }
    class Agya : Toyota
        {
            public Agya(Ban ban): base("Agya", ban)
            {

            }
        }
    class Avanza : Toyota
        {
            public Avanza(Ban ban): base("Avanza", ban)
            {

            }
            public void NyalakanLampu()
            {
                Console.WriteLine($"Lampu mobil {this.merk} bertipe {this.tipe} menyala");
            }
        }
    class Innova : Toyota
        {
            public Innova(Ban ban): base("Innova", ban)
            {

            }
        }
    class Daihatsu : Mobil
        {
            public Daihatsu(string Tipe, Ban ban): base("Daihatsu", Tipe, ban)
            {

            }
        }
    class Ayla : Daihatsu
    {
        public Ayla(Ban ban): base("Ayla", ban)
        {

        }
    }
    class Xenia : Daihatsu
    {
        public Xenia(Ban ban): base("Xenia", ban)
        {

        }
    }
    class Honda : Mobil
    {
        public Honda(string Tipe, Ban ban): base("Honda", Tipe, ban)
        {

        }
    }
    class Brio : Honda
    {
        public Brio(Ban ban): base("Brio", ban)
        {

        }
    }
    class Civic : Honda
    {
        public Civic(Ban  ban): base("Civic", ban)
        {

        }
        public void VtecKickedIn()
        {
            Console.WriteLine($"Ngeeeng Wooosh!!!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        Ban ban1 = new Michelin();
        Ban ban2 = new Bridgestone();
        Mobil mobil1 = new Agya(ban1);
        mobil1.NyalakanMesin();
        mobil1.MatikanMesin();
        Console.WriteLine(mobil1.ban);

        Mobil mobil2 = new Avanza(ban2);
        ((Avanza)mobil2).NyalakanLampu();
        Console.WriteLine(mobil1.ban.merk);

        Civic civic1 = new Civic(ban2);
        civic1.VtecKickedIn();

        Honda honda1 = civic1;
        ((Civic)honda1).VtecKickedIn();
        }
    }
}
