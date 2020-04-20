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

    }
}
