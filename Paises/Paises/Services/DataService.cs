using Paises.Modelos;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paises.Services
{
    public class DataService
    {
        public Pais Country { get; set; }

        private SQLiteConnection connection;

        private SQLiteCommand command;

        private DialogService dialogService;


        public DataService()
        {
            dialogService = new DialogService();

            if (!Directory.Exists("Data"))
            {
                Directory.CreateDirectory("Data");
            }

            var path = @"Data\Countries.sqlite";

            try
            {
                connection = new SQLiteConnection("Data Source=" + path);
                connection.Open();

                //COLOCAR SEM FALTA NO FIM UM PARENTENSES PARA FECHAR A TABELA
                string sqlcommand = "CREATE TABLE Languages(alpha3code varchar(3) null, isoUm varchar(20) NULL, isoDois varchar(20) NULL, name varchar(50) null, nativeName varchar(50) null); CREATE TABLE AltSpellings(alpha3code varchar(3) NULL,descricao varchar(50) NULL); CREATE TABLE CallingCodes(alpha3code varchar(3) NULL, descricao varchar(5) NULL); CREATE TABLE  Countries(name varchar(100) NULL, alpha2code varchar(2) NULL, alpha3code varchar(3) NOT NULL, region varchar(20) NULL, subregion varchar(20) NULL, population int NULL, demonym varchar(50) NULL, area real NULL, gini real NULL, nativeName varchar(100) NULL, numericCode varchar(10) NULL, cioc varchar(10) NULL, flag varchar(200) NULL); CREATE TABLE Currencies(alpha3code varchar(3) NULL, code varchar(10) NULL, name varchar(50) NULL, symbol varchar(5) NULL); CREATE TABLE Latlng(alpha3code varchar(3) NULL, descricao real NULL); CREATE TABLE Otheracronyms(alpha3code varchar(3) NULL, descricao varchar(50) NULL); CREATE TABLE OtherNames(alpha3code varchar(3) NULL, otherNames varchar(200) NULL); CREATE TABLE Regionalblocs(alpha3code varchar(3) NULL, acronym varchar(20) NULL, name varchar(100) NULL); CREATE TABLE Timezones(alpha3code varchar(3) NULL, descricao varchar(20) NULL); CREATE TABLE TopLevelDomain(alpha3code varchar(3) NULL, descricao varchar(20) NULL); CREATE TABLE Translations(alpha3code varchar(3) NULL, de varchar(50) NULL, es varchar(50) NULL, fr varchar(50) NULL, ja varchar(50) NULL, it varchar(50) NULL, br varchar(50) NULL, pt varchar(50) NULL, nl varchar(50) NULL, hr varchar(50) NULL, fa varchar(50) NULL);";


                command = new SQLiteCommand(sqlcommand, connection);

                command.ExecuteNonQuery();
                connection.Close();
            }

            catch (Exception e)
            {

                dialogService.ShowMessage("Erro", e.Message);
            }

            //SOLUÇÃO PARA AS PELICAS






        }

        public async Task SaveData(List<Pais> Countries)
        {

            try
            {
                string a = "";

                foreach (var country in Countries)
                {
                    //insert in Countries

                    if (country.name.Contains("'"))
                    {
                        country.name = country.name.Replace("'", "^");
                    }

                    if (country.capital.Contains("'"))
                    {
                        country.capital = country.capital.Replace("'", "^");
                    }

                    if (country.nativeName.Contains("'"))
                    {
                        country.nativeName = country.nativeName.Replace("'", "^");
                    }


                    string sql = $" Insert into Countries values('{country.name}','{country.alpha2Code}','{country.alpha3Code}','{country.region}','{country.subregion}','{country.population}','{country.demonym}','{country.area}','{country.gini}','{country.nativeName}','{country.numericCode}','{country.cioc}','{country.flag}');";

                    a = a + sql;





                    for (int i = 0; i < country.altSpellings.Count; i++)
                    {
                        if (country.altSpellings[i].Contains("'"))
                        {
                            country.altSpellings[i] = country.altSpellings[i].Replace("'", "^");
                        }

                        string altsp = $" Insert into AltSpellings values('{country.alpha3Code}','{country.altSpellings[i]}');";

                        a = a + altsp;



                    }


                    for (int i = 0; i < country.callingCodes.Count; i++)
                    {
                        string callc = $" Insert into callingCodes values('{country.alpha3Code}','{country.callingCodes[i]}');";

                        a = a + callc;



                    }

                    foreach (Language lang in country.languages)
                    {
                        if (lang.nativeName.Contains("'"))
                        {
                            lang.nativeName = lang.nativeName.Replace("'", "^");
                        }

                        string lingua = $" Insert into Languages values('{country.alpha3Code}','{lang.iso639_1}','{lang.iso639_2}','{lang.name}','{lang.nativeName}');";

                        a = a + lingua;
                    }

                    foreach (Currency alto in country.currencies)
                    {
                        if (alto.name != null)
                        {
                            if (alto.name.Contains("'"))
                            {
                                alto.name = alto.name.Replace("'", "^");
                            }
                        }


                        string bla = $" Insert into Currencies values('{country.alpha3Code}','{alto.code}','{alto.name}','{alto.symbol}');";

                        a = a + bla;

                    }

                    //utilizar ciclo for

                    for (int i = 0; i < country.latlng.Count; i++)
                    {
                        string altsp = $" Insert into Latlng values('{country.alpha3Code}','{country.latlng[i]}');";

                        a = a + altsp;

                    }


                    //ver other acronyms

                    //fazer com for
                    foreach (Regionalbloc reg in country.regionalBlocs)
                    {
                        string regblocs = $" Insert into RegionalBlocs values('{country.alpha3Code}','{reg.Acronym}','{reg.Name}');";


                        a = a + regblocs;


                        for (int i = 0; i < reg.OtherAcronyms.Count; i++)
                        {
                            string acro = $" Insert into Otheracronyms values('{country.alpha3Code}','{reg.OtherAcronyms[i]}');";


                            a = a + acro;

                        }

                        for (int i = 0; i < reg.OtherNames.Count; i++)
                        {
                            string other = $" Insert into Othernames values('{country.alpha3Code}','{reg.OtherNames[i]}');";


                            a = a + other;

                        }


                    }


                    if (country.translations.fr != null)
                    {
                        if (country.translations.fr.Contains("'"))
                        {
                            country.translations.fr = country.translations.fr.Replace("'", "^");
                        }
                    }

                    if (country.translations.it != null)
                    {
                        if (country.translations.it.Contains("'"))
                        {
                            country.translations.it = country.translations.it.Replace("'", "^");
                        }
                    }


                    string trans = $" Insert into translations values('{country.alpha3Code}','{country.translations.de}','{country.translations.es}','{country.translations.fr}','{country.translations.ja}','{country.translations.it}','{country.translations.br}','{country.translations.pt}','{country.translations.nl}','{country.translations.hr}','{country.translations.fa}');";

                    a = a + trans;

                    for (int i = 0; i < country.timezones.Count; i++)
                    {
                        string tzones = $" Insert into Timezones values('{country.alpha3Code}','{country.timezones[i]}');";

                        a = a + tzones;

                    }

                    for (int i = 0; i < country.topLevelDomain.Count; i++)
                    {
                        string topdomain = $" Insert into TopLevelDomain values('{country.alpha3Code}','{country.topLevelDomain[i]}');";


                        a = a + topdomain;

                    }


                }

                connection.Open();
                command = new SQLiteCommand(a, connection);

                await command.ExecuteNonQueryAsync();
                connection.Close();
            }
            catch (Exception e)
            {

                dialogService.ShowMessage("Erro", e.Message);
            }



        }

        public void SaveDataDois(List<Pais> Countries)
        {

            try
            {
                string a = "";
                connection.Open();
                foreach (var country in Countries)
                {
                    //insert in Countries

                    if (country.name.Contains("'"))
                    {
                        country.name = country.name.Replace("'", "^");
                    }

                    if (country.capital.Contains("'"))
                    {
                        country.capital = country.capital.Replace("'", "^");
                    }

                    if (country.nativeName.Contains("'"))
                    {
                        country.nativeName = country.nativeName.Replace("'", "^");
                    }


                    string sql = $"Insert into Countries values('{country.name}','{country.alpha2Code}','{country.alpha3Code}','{country.region}','{country.subregion}','{country.population}','{country.demonym}','{country.area}','{country.gini}','{country.nativeName}','{country.numericCode}','{country.cioc}','{country.flag}');";



                    command = new SQLiteCommand(sql, connection);

                    command.ExecuteNonQuery();



                    for (int i = 0; i < country.altSpellings.Count; i++)
                    {
                        if (country.altSpellings[i].Contains("'"))
                        {
                            country.altSpellings[i] = country.altSpellings[i].Replace("'", "^");
                        }

                        string altsp = $"Insert into AltSpellings values('{country.alpha3Code}','{country.altSpellings[i]}');";



                        command = new SQLiteCommand(altsp, connection);

                        command.ExecuteNonQuery();

                    }


                    for (int i = 0; i < country.callingCodes.Count; i++)
                    {
                        string callc = $"Insert into callingCodes values('{country.alpha3Code}','{country.callingCodes[i]}');";



                        command = new SQLiteCommand(callc, connection);

                        command.ExecuteNonQuery();

                    }

                    foreach (Language lang in country.languages)
                    {
                        if (lang.nativeName.Contains("'"))
                        {
                            lang.nativeName = lang.nativeName.Replace("'", "^");
                        }

                        string lingua = $"Insert into Languages values('{country.alpha3Code}','{lang.iso639_1}','{lang.iso639_2}','{lang.name}','{lang.nativeName}');";
                    }

                    foreach (Currency alto in country.currencies)
                    {
                        if (alto.name != null)
                        {
                            if (alto.name.Contains("'"))
                            {
                                alto.name = alto.name.Replace("'", "^");
                            }
                        }


                        string bla = $"Insert into Currencies values('{country.alpha3Code}','{alto.code}','{alto.name}','{alto.symbol}');";


                        command = new SQLiteCommand(bla, connection);

                        command.ExecuteNonQuery();

                    }

                    //utilizar ciclo for

                    for (int i = 0; i < country.latlng.Count; i++)
                    {
                        string altsp = $"Insert into Latlng values('{country.alpha3Code}','{country.latlng[i]}');";

                        command = new SQLiteCommand(altsp, connection);

                        command.ExecuteNonQuery();

                    }


                    //ver other acronyms

                    //fazer com for
                    foreach (Regionalbloc reg in country.regionalBlocs)
                    {
                        string regblocs = $"Insert into RegionalBlocs values('{country.alpha3Code}','{reg.Acronym}','{reg.Name}');";


                        command = new SQLiteCommand(regblocs, connection);

                        command.ExecuteNonQuery();


                        for (int i = 0; i < reg.OtherAcronyms.Count; i++)
                        {
                            string acro = $"Insert into Otheracronyms values('{country.alpha3Code}','{reg.OtherAcronyms[i]}');";


                            command = new SQLiteCommand(acro, connection);

                            command.ExecuteNonQuery();

                        }

                        for (int i = 0; i < reg.OtherNames.Count; i++)
                        {
                            string other = $"Insert into Othernames values('{country.alpha3Code}','{reg.OtherNames[i]}');";


                            command = new SQLiteCommand(other, connection);

                            command.ExecuteNonQuery();

                        }


                    }


                    if (country.translations.fr != null)
                    {
                        if (country.translations.fr.Contains("'"))
                        {
                            country.translations.fr = country.translations.fr.Replace("'", "^");
                        }
                    }

                    if (country.translations.it != null)
                    {
                        if (country.translations.it.Contains("'"))
                        {
                            country.translations.it = country.translations.it.Replace("'", "^");
                        }
                    }



                    string trans = $"Insert into translations values('{country.alpha3Code}','{country.translations.de}','{country.translations.es}','{country.translations.fr}','{country.translations.ja}','{country.translations.it}','{country.translations.br}','{country.translations.pt}','{country.translations.nl}','{country.translations.hr}','{country.translations.fa}');";



                    for (int i = 0; i < country.timezones.Count; i++)
                    {
                        string tzones = $"Insert into Timezones values('{country.alpha3Code}','{country.timezones[i]}')";

                        command = new SQLiteCommand(tzones, connection);

                        command.ExecuteNonQuery();

                    }

                    for (int i = 0; i < country.topLevelDomain.Count; i++)
                    {
                        string topdomain = $"Insert into TopLevelDomain values('{country.alpha3Code}','{country.topLevelDomain[i]}')";


                        command = new SQLiteCommand(topdomain, connection);

                        command.ExecuteNonQuery();

                    }


                }

                connection.Close();
            }
            catch (Exception e)
            {

                dialogService.ShowMessage("Erro", e.Message);
            }



        }

        public List<Pais> GetDataCountries()
        {
            List<Pais> countries = new List<Pais>();

            var path = @"Data\Countries.sqlite";

            connection = new SQLiteConnection("Data Source=" + path);

            string paises = "SELECT * FROM Countries";

            try
            {
                connection.Open();

                SQLiteDataReader reader = new SQLiteCommand(paises, connection).ExecuteReader();

                while (reader.Read())
                {
                    Pais pais = new Pais
                    {
                        name = (string)reader["name"],
                        alpha2Code = (string)reader["alpha2code"],
                        alpha3Code = (string)reader["alpha2code"],
                        region = (string)reader["regio"],
                        subregion = (string)reader["subregion"],
                        population = (int)reader["population"],
                        demonym = (string)reader["demonym"],
                        area = (double)reader["area"],
                        gini = (double)reader["gini"],
                        nativeName = (string)reader["nativeName"],
                        numericCode = (string)reader["numericCode"],
                        cioc = (string)reader["cioc"],
                        flag = (string)reader["flag"]

                    }; //pais


                    string chave = pais.alpha3Code; //espécie de chave primária


                    try
                    {

                        string alts = $"SELECT * FROM AltSpellings WHERE alpha3code = '{chave}'";
                        command = new SQLiteCommand(alts, connection);


                        SQLiteDataReader readerAlts = command.ExecuteReader();


                        while (readerAlts.Read())
                        {
                            pais.altSpellings.Add((string)readerAlts["descricao"]);

                        }

                    }
                    catch (Exception e)
                    {
                        dialogService.ShowMessage("Error", e.Message);
                        return null;
                    } // alsSpellings

                    try
                    {

                        string calling = $"SELECT * FROM CallingCodes WHERE alpha3code = '{chave}'";
                        command = new SQLiteCommand(calling, connection);


                        SQLiteDataReader readerCalling = command.ExecuteReader();


                        while (readerCalling.Read())
                        {
                            pais.callingCodes.Add((string)readerCalling["descricao"]);
                        }

                    }
                    catch (Exception e)
                    {
                        dialogService.ShowMessage("Error", e.Message);
                        return null;
                    } // callingCodes



                    try
                    {

                        string regblo = $"SELECT * FROM Regionalblocs WHERE alpha3code = '{chave}'";
                        command = new SQLiteCommand(regblo, connection);

                        SQLiteDataReader readerReg = command.ExecuteReader();

                        List<Regionalbloc> regionalblocs = new List<Regionalbloc>();


                        while (readerReg.Read())
                        {
                            Regionalbloc reg = new Regionalbloc();
                            reg.Acronym = (string)readerReg["acronym"];
                            reg.Name = (string)readerReg["name"];

                            try
                            {

                                string otherNames = $"SELECT * FROM OtherNames WHERE alpha3code = '{chave}'";
                                command = new SQLiteCommand(otherNames, connection);


                                SQLiteDataReader readerOther = command.ExecuteReader();
                                List<string> others = new List<string>();

                                while (readerOther.Read())
                                {
                                    others.Add((string)readerOther["descricao"]);
                                }
                                reg.OtherNames = others;

                            }
                            catch (Exception e)
                            {
                                dialogService.ShowMessage("Error", e.Message);
                                return null;
                            } // OtherAcronyms

                            try
                            {

                                string otherAcro = $"SELECT * FROM OtherAcronyms WHERE alpha3code = '{chave}'";
                                command = new SQLiteCommand(otherAcro, connection);


                                SQLiteDataReader readerOther = command.ExecuteReader();
                                List<string> acros = new List<string>();

                                while (readerOther.Read())
                                {
                                    acros.Add((string)readerOther["descricao"]);
                                }
                                reg.OtherAcronyms = acros;

                            }
                            catch (Exception e)
                            {
                                dialogService.ShowMessage("Error", e.Message);
                                return null;
                            } // OtherAcro

                            regionalblocs.Add(reg);

                        }


                        pais.regionalBlocs = regionalblocs;
                    }

                    catch (Exception e)
                    {
                        dialogService.ShowMessage("Error", e.Message);
                        return null;
                    }   //RegionalBlocs


                    //pause


                    try
                    {

                        string lat = $"SELECT * FROM Latlng WHERE alpha3code = '{chave}'";
                        command = new SQLiteCommand(lat, connection);


                        SQLiteDataReader readerLat = command.ExecuteReader();


                        while (readerLat.Read())
                        {
                            pais.latlng.Add((double)readerLat["descricao"]);
                        }

                    }
                    catch (Exception e)
                    {
                        dialogService.ShowMessage("Error", e.Message);
                        return null;
                    } // latlng

                    try
                    {

                        string moedas = $"SELECT * FROM Currencies WHERE alpha3code = '{chave}'";
                        command = new SQLiteCommand(moedas, connection);


                        SQLiteDataReader readerMoedas = command.ExecuteReader();
                        List<Currency> currencies = new List<Currency>();

                        while (readerMoedas.Read())
                        {
                            currencies.Add(new Currency
                            {
                                code = (string)readerMoedas["code"],
                                name = (string)readerMoedas["name"],
                                symbol = (string)readerMoedas["symbol"]
                            });
                        }
                        pais.currencies = currencies;

                    }
                    catch (Exception e)
                    {
                        dialogService.ShowMessage("Error", e.Message);
                        return null;
                    } // moedas


                    try
                    {

                        string tzones = $"SELECT * FROM Timezones WHERE alpha3code = '{chave}'";
                        command = new SQLiteCommand(tzones, connection);


                        SQLiteDataReader readerTzones = command.ExecuteReader();


                        while (readerTzones.Read())
                        {
                            pais.timezones.Add((string)readerTzones["descricao"]);
                        }

                    }
                    catch (Exception e)
                    {
                        dialogService.ShowMessage("Error", e.Message);
                        return null;
                    } // Timezones

                    try
                    {

                        string tldomain = $"SELECT * FROM TopLevelDomain WHERE alpha3code = '{chave}'";
                        command = new SQLiteCommand(tldomain, connection);


                        SQLiteDataReader readerTDomain = command.ExecuteReader();


                        while (readerTDomain.Read())
                        {
                            pais.topLevelDomain.Add((string)readerTDomain["descricao"]);
                        }

                    }
                    catch (Exception e)
                    {
                        dialogService.ShowMessage("Error", e.Message);
                        return null;
                    } // TopLevelDomain


                    try
                    {

                        string lang = $"SELECT * FROM Languages WHERE alpha3code = '{chave}'";
                        command = new SQLiteCommand(lang, connection);

                        SQLiteDataReader readerLingua = command.ExecuteReader();

                        List<Language> languages = new List<Language>();

                        while (readerLingua.Read())
                        {
                            languages.Add(new Language
                            {
                                iso639_1 = (string)readerLingua["isoUm"],
                                iso639_2 = (string)readerLingua["isoDois"],
                                name = (string)readerLingua["name"],
                                nativeName = (string)readerLingua["nativeName"]
                            });
                        }
                        pais.languages = languages;
                    }
                    catch (Exception e)
                    {
                        dialogService.ShowMessage("Error", e.Message);
                        return null;
                    } //Linguas


                    try
                    {

                        string trad = $"SELECT * FROM Translations WHERE alpha3code = '{chave}'";

                        command = new SQLiteCommand(trad, connection);

                        SQLiteDataReader traducoes = command.ExecuteReader();

                        while (traducoes.Read())
                        {
                            Translations translations = new Translations
                            {
                                de = (string)traducoes["de"],
                                es = (string)traducoes["es"],
                                fr = (string)traducoes["fr"],
                                ja = (string)traducoes["ja"],
                                it = (string)traducoes["it"],
                                br = (string)traducoes["br"],
                                pt = (string)traducoes["pt"],
                                nl = (string)traducoes["nl"],
                                hr = (string)traducoes["gr"],
                                fa = (string)traducoes["fa"]


                            };
                            pais.translations = translations;
                        }
                    }
                    catch (Exception e)
                    {
                        dialogService.ShowMessage("Error", e.Message);
                        return null;
                    } //traducoes


                    
                    countries.Add(pais);
                }


                countries = TiraPelicas(countries);

                return countries;
            }
            catch (Exception e)
            {
                dialogService.ShowMessage("Error", e.Message);
                return null;
            }
        }


        public List<Pais> TiraPelicas(List<Pais> paises)
        {


            foreach (Pais country in paises)
            {

                if (country.name.Contains("^"))
                {
                    country.name = country.name.Replace("^", "'");
                }

                if (country.capital.Contains("^"))
                {
                    country.capital = country.capital.Replace("^", "'");
                }

                if (country.nativeName.Contains("^"))
                {
                    country.nativeName = country.nativeName.Replace("^", "'");
                }



                for (int i = 0; i < country.altSpellings.Count; i++)
                {
                    if (country.altSpellings[i].Contains("^"))
                    {
                        country.altSpellings[i] = country.altSpellings[i].Replace("^", "'");
                    }

                }


                foreach (Language lang in country.languages)
                {
                    if (lang.nativeName.Contains("^"))
                    {
                        lang.nativeName = lang.nativeName.Replace("^", "'");
                    }

                    
                }

                foreach (Currency alto in country.currencies)
                {
                    if (alto.name != null)
                    {
                        if (alto.name.Contains("^"))
                        {
                            alto.name = alto.name.Replace("^", "'");
                        }
                    }


                }



                if (country.translations.fr != null)
                {
                    if (country.translations.fr.Contains("^"))
                    {
                        country.translations.fr = country.translations.fr.Replace("^", "'");
                    }
                }


                if (country.translations.it != null)
                {
                    if (country.translations.it.Contains("^"))
                    {
                        country.translations.it = country.translations.it.Replace("^", "'");
                    }
                }

            }

            return paises;
        }













    }
}
