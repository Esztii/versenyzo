using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace versenyzo
{
    internal class Data
    {
        public string Nev { get; set; }
        public int Szuletesev { get; set; }
        public int Rajtszam { get; set; }
        public bool Sex { get; set; }
        public string Kat { get; set; }
        public Dictionary<string, TimeSpan> idok = new Dictionary<string, TimeSpan>();
        public override string ToString()
        {
            return $"{Nev}, {Szuletesev}, {Rajtszam}, {(Sex? "f" : "n")}";
        }

        public Data(string beolvasottSor)
        {
            string[] d = beolvasottSor.Split(";");
            Nev = d[0];
            Szuletesev = int.Parse(d[1]);
            Rajtszam = int.Parse(d[2]);
            Sex = d[3] == "f";
            Kat = d[4];
            idok.Add("uszas", TimeSpan.Parse(d[5]));
            idok.Add("elsodepo", TimeSpan.Parse(d[6]));
            idok.Add("kerekpar", TimeSpan.Parse(d[7]));
            idok.Add("masodikdepo", TimeSpan.Parse(d[8]));
            idok.Add("futas", TimeSpan.Parse(d[9]));


        }
    }
}
