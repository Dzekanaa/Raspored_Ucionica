﻿using Raspored_Ucionica.Model;

namespace Raspored_Ucionica
{
    public class SviPodaci
    {
        protected readonly List<Odeljenje>? lista_odeljenja;
        protected readonly List<Ucionica>? lista_ucionica;
        protected readonly Raspored? ponedeljak, utorak, sreda, cetvrtak, petak;
        public SviPodaci()
        {
            ponedeljak = new(new List<List<string>> // optimizovao
            {
                new List<string>() {"info", "", "", "", "reg", "", "", "", "", "verska", "", "reg", "reg", "verska", "reg", "", "", "", "", "reg","reg", "", "", "", "", "", "", "info", "", "", "reg", ""},
                new List<string>() {"info", "reg", "reg", "reg", "reg", "reg", "reg", "info", "ist", "reg", "reg", "reg", "n/f/i/r", "reg", "n/f/i/r", "reg", "reg", "reg", "reg", "","prnauke", "reg", "reg", "reg", "g1", "", "hem/reg", "info", "hem", "info", "reg", "fv"},
                new List<string>() {"reg", "info", "reg", "hem", "reg", "reg", "reg", "info", "reg", "ist", "fv", "reg/reg", "reg", "reg/reg", "reg", "reg", "dreg", "reg", "reg", "reg/info","reg", "fv", "reg", "reg", "reg", "reg", "hem/reg", "reg", "reg", "info", "reg", "reg"},
                new List<string>() {"reg", "info", "reg", "n/f/r", "n/f/i/r", "reg", "info", "n/f/i/r", "reg", "reg", "hem", "reg", "reg", "reg", "reg", "reg", "reg", "reg", "reg", "reg/info","reg", "hem", "reg/info", "reg", "reg", "reg", "reg", "reg", "reg", "reg", "fv", "reg"},
                new List<string>() {"reg", "hem", "reg", "reg", "reg", "reg", "info", "reg", "reg", "reg", "reg", "reg", "hem/info", "hem", "fv", "reg", "reg", "info", "reg/reg", "reg","reg", "info/reg", "reg", "fv", "reg", "reg", "reg", "nem/reg/f", "n/f/e", "reg", "nem/reg", "reg"},
                new List<string>() {"fv", "reg", "hem", "reg", "reg", "reg", "reg", "reg", "reg", "reg", "info", "reg/hem", "hem/info", "reg", "reg", "reg", "reg", "info", "reg", "reg","reg", "reg", "fv", "reg", "reg", "reg", "info/reg", "reg", "reg", "n/f/e", "reg", "n/f/e"},
                new List<string>() { "reg", "fv", "reg", "fv", "reg", "", "reg", "reg", "reg", "reg", "info", "reg", "info", "reg", "verska", "verska", "reg", "info", "hem", "reg", "reg", "reg", "reg/strani", "reg", "n/reg/f", "reg", "reg", "info/reg", "reg", "reg", "reg", "", "reg"},
                new List<string>() { "info", "reg", "fv", "reg", "", "", "", "fv", "reg", "reg", "", "reg", "info", "reg", "", "", "reg", "info", "", "", "", "", "reg", "", "reg", "reg", "reg", "", "verska", "verska", "", "reg"}
            });

            utorak = new(new List<List<string>>
            {
                new List<string>() {"", "", "verska", "verska", "reg", "", "reg", "", "", "", "", "", "", "", "", "", "", "", "", "","", "", "", "", "info", "", "reg", "reg", "", "reg", "reg", ""},
                new List<string>() {"info", "reg", "reg", "reg", "reg", "reg", "reg", "reg", "info", "reg", "reg/reg", "fv", "reg", "", "reg", "reg", "reg", "info", "reg", "reg","reg", "reg", "reg", "reg", "info", "reg", "reg", "reg", "info", "reg", "reg", "reg"},
                new List<string>() {"info", "reg", "reg", "reg", "reg", "reg", "reg", "reg", "info", "reg", "reg", "reg", "reg", "fv", "reg/reg", "reg", "reg", "info", "reg", "reg","reg", "reg", "reg/reg", "reg", "info", "reg", "reg", "reg", "info", "reg", "reg", "reg"},
                new List<string>() {"info", "info", "reg", "reg", "reg", "reg", "reg", "reg", "reg", "reg", "reg", "reg", "n/f/e", "reg", "n/f/e", "reg/reg", "fv", "info", "reg", "reg","reg/info", "reg", "reg", "reg", "info", "reg", "reg", "reg", "reg", "reg", "fv", "reg"},
                new List<string>() {"info", "info", "reg", "reg", "reg", "reg", "reg", "reg", "reg", "reg", "fv", "reg/reg", "reg", "reg", "reg", "reg", "info", "reg", "reg", "fv","reg", "reg", "reg", "reg/info", "info", "reg", "reg", "reg", "reg", "reg", "reg", "reg"},
                new List<string>() {"info", "reg", "reg/hem", "reg", "fv", "reg", "reg", "reg", "reg", "info", "reg", "reg", "reg", "reg", "reg", "reg", "info", "info", "reg", "reg","reg/reg", "reg", "reg", "reg/info", "info", "fv", "reg", "reg", "reg", "reg", "reg", "reg"},
                new List<string>() { "info", "reg", "reg/hem", "reg", "reg", "fv", "reg", "reg", "reg", "info", "reg", "info", "reg/reg", "reg", "reg", "fv", "info", "reg", "info", "verska","reg", "reg", "verska", "reg", "info", "reg", "reg", "reg", "reg", "reg", "reg", "reg"},
                new List<string>() { "", "reg", "reg", "", "reg", "verska", "fv", "verska", "reg", "reg", "reg", "info", "g(valentina)", "reg", "reg", "reg", "info","reg" ,"info", "reg", "fv", "", "", "", "info", "g(vojin)", "g(vojin)","g(vojin)" ,"reg", "", "reg/info", ""}
            });
            sreda = new(new List<List<string>>
            {
                new List<string>() {"", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "","", "", "", "", "", "", "", "", "", "", "", ""},
                new List<string>() {"info", "reg", "reg", "reg", "reg", "reg", "reg", "info", "ist", "reg", "reg", "reg", "n/f/i/r", "reg", "n/f/i/r", "reg", "reg", "reg", "reg", "","prnauke", "reg", "reg", "reg", "g1", "", "hem/reg", "info", "hem", "info", "reg", "fv"},
                new List<string>() {"reg", "info", "reg", "hem", "reg", "reg", "reg", "info", "reg", "ist", "fv", "reg/reg", "reg", "reg/reg", "reg", "reg", "dreg", "reg", "reg", "reg/info","reg", "fv", "reg", "reg", "reg", "reg", "hem/reg", "reg", "reg", "info", "reg", "reg"},
                new List<string>() {"reg", "info", "reg", "n/f/r", "n/f/i/r", "reg", "info", "n/f/i/r", "reg", "reg", "hem", "reg", "reg", "reg", "reg", "reg", "reg", "reg", "reg", "reg/info","reg", "hem", "reg/info", "reg", "reg", "reg", "reg", "reg", "reg", "reg", "fv", "reg"},
                new List<string>() {"reg", "hem", "reg", "reg", "reg", "reg", "info", "reg", "reg", "reg", "reg", "reg", "hem/info", "hem", "fv", "reg", "reg", "info", "reg/reg", "reg","reg", "info/reg", "reg", "fv", "reg", "reg", "reg", "nem/reg/f", "n/f/e", "reg", "nem/reg", "reg"},
                new List<string>() {"fv", "reg", "hem", "reg", "reg", "reg", "reg", "reg", "reg", "reg", "info", "reg/hem", "hem/info", "reg", "reg", "reg", "reg", "info", "reg", "reg","reg", "reg", "fv", "reg", "reg", "reg", "info/reg", "reg", "reg", "n/f/e", "reg", "n/f/e"},
                new List<string>() { "reg", "fv", "reg", "fv", "reg", "", "reg", "reg", "reg", "reg", "info", "reg", "info", "reg", "verska", "verska", "reg", "info", "hem", "reg", "reg", "reg", "reg/strani", "reg", "n/reg/f", "reg", "reg", "info/reg", "reg", "reg", "reg", "", "reg"},
                new List<string>() { "info", "reg", "fv", "reg", "", "", "", "fv", "reg", "reg", "", "reg", "info", "reg", "", "", "reg", "info", "", "", "", "", "reg", "", "reg", "reg", "reg", "", "verska", "verska", "", "reg"}
            });
            cetvrtak = new(new List<List<string>>
            {
                new List<string>() {"info", "", "", "", "reg", "", "", "", "", "verska", "", "reg", "reg", "verska", "reg", "", "", "", "", "reg","reg", "", "", "", "", "", "", "info", "", "", "reg", ""},
                new List<string>() {"info", "reg", "reg", "reg", "reg", "reg", "reg", "info", "ist", "reg", "reg", "reg", "n/f/i/r", "reg", "n/f/i/r", "reg", "reg", "reg", "reg", "","prnauke", "reg", "reg", "reg", "g1", "", "hem/reg", "info", "hem", "info", "reg", "fv"},
                new List<string>() {"reg", "info", "reg", "hem", "reg", "reg", "reg", "info", "reg", "ist", "fv", "reg/reg", "reg", "reg/reg", "reg", "reg", "dreg", "reg", "reg", "reg/info","reg", "fv", "reg", "reg", "reg", "reg", "hem/reg", "reg", "reg", "info", "reg", "reg"},
                new List<string>() {"reg", "info", "reg", "n/f/r", "n/f/i/r", "reg", "info", "n/f/i/r", "reg", "reg", "hem", "reg", "reg", "reg", "reg", "reg", "reg", "reg", "reg", "reg/info","reg", "hem", "reg/info", "reg", "reg", "reg", "reg", "reg", "reg", "reg", "fv", "reg"},
                new List<string>() {"reg", "hem", "reg", "reg", "reg", "reg", "info", "reg", "reg", "reg", "reg", "reg", "hem/info", "hem", "fv", "reg", "reg", "info", "reg/reg", "reg","reg", "info/reg", "reg", "fv", "reg", "reg", "reg", "nem/reg/f", "n/f/e", "reg", "nem/reg", "reg"},
                new List<string>() {"fv", "reg", "hem", "reg", "reg", "reg", "reg", "reg", "reg", "reg", "info", "reg/hem", "hem/info", "reg", "reg", "reg", "reg", "info", "reg", "reg","reg", "reg", "fv", "reg", "reg", "reg", "info/reg", "reg", "reg", "n/f/e", "reg", "n/f/e"},
                new List<string>() { "reg", "fv", "reg", "fv", "reg", "", "reg", "reg", "reg", "reg", "info", "reg", "info", "reg", "verska", "verska", "reg", "info", "hem", "reg", "reg", "reg", "reg/strani", "reg", "n/reg/f", "reg", "reg", "info/reg", "reg", "reg", "reg", "", "reg"},
                new List<string>() { "info", "reg", "fv", "reg", "", "", "", "fv", "reg", "reg", "", "reg", "info", "reg", "", "", "reg", "info", "", "", "", "", "reg", "", "reg", "reg", "reg", "", "verska", "verska", "", "reg"}
            });
            petak = new(new List<List<string>>
            {
                new List<string>() {"info", "", "", "", "reg", "", "", "", "", "verska", "", "reg", "reg", "verska", "reg", "", "", "", "", "reg","reg", "", "", "", "", "", "", "info", "", "", "reg", ""},
                new List<string>() {"info", "reg", "reg", "reg", "reg", "reg", "reg", "info", "ist", "reg", "reg", "reg", "n/f/i/r", "reg", "n/f/i/r", "reg", "reg", "reg", "reg", "","prnauke", "reg", "reg", "reg", "g1", "", "hem/reg", "info", "hem", "info", "reg", "fv"},
                new List<string>() {"reg", "info", "reg", "hem", "reg", "reg", "reg", "info", "reg", "ist", "fv", "reg/reg", "reg", "reg/reg", "reg", "reg", "dreg", "reg", "reg", "reg/info","reg", "fv", "reg", "reg", "reg", "reg", "hem/reg", "reg", "reg", "info", "reg", "reg"},
                new List<string>() {"reg", "info", "reg", "n/f/r", "n/f/i/r", "reg", "info", "n/f/i/r", "reg", "reg", "hem", "reg", "reg", "reg", "reg", "reg", "reg", "reg", "reg", "reg/info","reg", "hem", "reg/info", "reg", "reg", "reg", "reg", "reg", "reg", "reg", "fv", "reg"},
                new List<string>() {"reg", "hem", "reg", "reg", "reg", "reg", "info", "reg", "reg", "reg", "reg", "reg", "hem/info", "hem", "fv", "reg", "reg", "info", "reg/reg", "reg","reg", "info/reg", "reg", "fv", "reg", "reg", "reg", "nem/reg/f", "n/f/e", "reg", "nem/reg", "reg"},
                new List<string>() {"fv", "reg", "hem", "reg", "reg", "reg", "reg", "reg", "reg", "reg", "info", "reg/hem", "hem/info", "reg", "reg", "reg", "reg", "info", "reg", "reg","reg", "reg", "fv", "reg", "reg", "reg", "info/reg", "reg", "reg", "n/f/e", "reg", "n/f/e"},
                new List<string>() { "reg", "fv", "reg", "fv", "reg", "", "reg", "reg", "reg", "reg", "info", "reg", "info", "reg", "verska", "verska", "reg", "info", "hem", "reg", "reg", "reg", "reg/strani", "reg", "n/reg/f", "reg", "reg", "info/reg", "reg", "reg", "reg", "", "reg"},
                new List<string>() { "info", "reg", "fv", "reg", "", "", "", "fv", "reg", "reg", "", "reg", "info", "reg", "", "", "reg", "info", "", "", "", "", "reg", "", "reg", "reg", "reg", "", "verska", "verska", "", "reg"}
            });


            lista_ucionica = new()
            {
                new Ucionica("P4", 15, true),
                new Ucionica("hemijski_kabinet", 15, true),
                new Ucionica("6", 16, true),
                new Ucionica("23b", 16, true),
                new Ucionica("5", 20, true),
                new Ucionica("23a", 20, true),
                new Ucionica("jezicka1", 20, true),
                new Ucionica("jezicka2", 20, true),
                new Ucionica("8", 20, true),
                new Ucionica("22", 22, true),
                new Ucionica("11", 22, true),
                new Ucionica("29", 22, true),
                new Ucionica("33", 24, true),
                new Ucionica("7", 24, true),
                new Ucionica("30", 24, true),
                new Ucionica("33", 24, true),
                new Ucionica("biblioteka", 25, true),
                new Ucionica("10", 26, true),
                new Ucionica("21", 26, true),
                new Ucionica("35", 26, true),
                new Ucionica("39", 28, true),
                new Ucionica("P3", 28, true),
                new Ucionica("multimedijska", 30, true),
                new Ucionica("P1", 30, true),
                new Ucionica("28", 30, true),
                new Ucionica("42", 30, true),
                new Ucionica("13", 32, true),
                new Ucionica("25", 32, true),
                new Ucionica("26", 32, true),
                new Ucionica("27", 32, true),
                new Ucionica("37", 32, true),
                new Ucionica("24", 35, true),
                new Ucionica("P2", 36, true),
                new Ucionica("20", 36, true),
                new Ucionica("31", 36, true),
                new Ucionica("32", 36, true),
                new Ucionica("36", 36, true),
                new Ucionica("40", 36, true),
                new Ucionica("41", 36, true),
                new Ucionica("9", 40, true),
                new Ucionica("10", 40, true),

            };
            lista_odeljenja = new()
            {
                new Odeljenje("I-1", 19),//lutajuca
                new Odeljenje("I-2",19),//lutajuca
                new Odeljenje("I-3",18),//lutajuca
                new Odeljenje("I-4",30, lista_ucionica.First(ucionica => ucionica.Ime_ucionice == "28").Id), // svuda da se stavi
                new Odeljenje("I-5",35, lista_ucionica.First(ucionica => ucionica.Ime_ucionice == "31").Id),
                new Odeljenje("I-6",35, lista_ucionica.First(ucionica => ucionica.Ime_ucionice == "10").Id),
                new Odeljenje("I-7",32, lista_ucionica.First(ucionica => ucionica.Ime_ucionice == "25").Id),
                new Odeljenje("I-8",29, lista_ucionica.First(ucionica => ucionica.Ime_ucionice == "37").Id),
                new Odeljenje("II-1", 19),//lutajuca
                new Odeljenje("II-2",20),//lutajuca
                new Odeljenje("II-3",17),//lutajuca
                new Odeljenje("II-4",28, lista_ucionica.First(ucionica => ucionica.Ime_ucionice == "27").Id),
                new Odeljenje("II-5",34, lista_ucionica.First(ucionica => ucionica.Ime_ucionice == "24").Id),
                new Odeljenje("II-6",36, lista_ucionica.First(ucionica => ucionica.Ime_ucionice == "20").Id),
                new Odeljenje("II-7",29, lista_ucionica.First(ucionica => ucionica.Ime_ucionice == "42").Id),
                new Odeljenje("II-8",31, lista_ucionica.First(ucionica => ucionica.Ime_ucionice == "26").Id),
                new Odeljenje("III-1", 20, lista_ucionica.First(ucionica => ucionica.Ime_ucionice == "35").Id),
                new Odeljenje("III-2",18, lista_ucionica.First(ucionica => ucionica.Ime_ucionice == "39").Id), 
                new Odeljenje("III-3",18, lista_ucionica.First(ucionica => ucionica.Ime_ucionice == "11").Id), 
                new Odeljenje("III-4",23, lista_ucionica.First(ucionica => ucionica.Ime_ucionice == "21").Id),
                new Odeljenje("III-5",35, lista_ucionica.First(ucionica => ucionica.Ime_ucionice == "40").Id),
                new Odeljenje("III-6",35, lista_ucionica.First(ucionica => ucionica.Ime_ucionice == "32").Id),
                new Odeljenje("III-7",31, lista_ucionica.First(ucionica => ucionica.Ime_ucionice == "13").Id),
                new Odeljenje("III-8",32, lista_ucionica.First(ucionica => ucionica.Ime_ucionice == "36").Id),
                new Odeljenje("IV-1", 19, lista_ucionica.First(ucionica => ucionica.Ime_ucionice == "30").Id),
                new Odeljenje("IV-2",21, lista_ucionica.First(ucionica => ucionica.Ime_ucionice == "33").Id),
                new Odeljenje("IV-3",19, lista_ucionica.First(ucionica => ucionica.Ime_ucionice == "11").Id),
                new Odeljenje("IV-4",29, lista_ucionica.First(ucionica => ucionica.Ime_ucionice == "P3").Id),
                new Odeljenje("IV-5",30, lista_ucionica.First(ucionica => ucionica.Ime_ucionice == "P1").Id),
                new Odeljenje("IV-6",27, lista_ucionica.First(ucionica => ucionica.Ime_ucionice == "P2").Id),
                new Odeljenje("IV-7",37, lista_ucionica.First(ucionica => ucionica.Ime_ucionice == "9").Id),
                new Odeljenje("IV-8",36, lista_ucionica.First(ucionica => ucionica.Ime_ucionice == "41").Id),
            };
        }
    }
}
