using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace csharp_lista_indirizzi
{
    internal class Indirizzo
    {
        private string name;
        private string surname;
        private string street;
        private string city;
        private string province;
        private string zip;

        //Properties

        public string Name
        { get { return name; } }

        public string Surname
        { get { return surname; } }

        public string Street
        {
            get { return street; }
        }

        public string City
        { get { return city; } }

        public string Province
        { get { return province; } }

        public string Zip
        {
            get { return zip; }
        }


        //Name,Surname,Street,City,Province,ZIP
        public Indirizzo(string name, string surname, string street, string city, string province, string zip)
        { 
            this.name = name;
            this.surname = surname;
            this.street = street;
            this.city = city;
            this.province = province;
            this.zip = zip;
        
        }

        public override string ToString()
        {
            string stringa = $"Nome : {name} \n" +
                $"Cognome : {surname} \n" +
                $"Via : {street} \n" +
                $"Città : {city} \n" +
                $"Provincia : {province} \n" +
                $"Codice postale : {zip} \n" +
                $"-------------------------";

            return stringa;
        }




    }
}
