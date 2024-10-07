using versenyzo;

List<Data> datas = [];
using StreamReader sr = new(@"..\..\..\src\forras.txt");
while (!sr.EndOfStream) datas.Add(new(sr.ReadLine()!));

var linqsum = datas.Count(d => d.Kat == "elit");
Console.WriteLine($"Az elit-ek száma: {linqsum}");

var linqavg = datas.Count(d => d.Sex = false);
Console.WriteLine($"A női versenyzők átlagéletkora: {linqavg.}");

var linqkerekpar = datas.Sum(d => d.idok[]);
Console.WriteLine($"A versenyzők kerékpározással töltött összideje órában: ");

var linquszas = datas.Average(d => d.idok);


var feri = datas.





