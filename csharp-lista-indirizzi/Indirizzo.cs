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
        { get { return name; }
            set 
            { 
                if (value != "")
                {
                    name = value;
                }
                else
                {
                    throw new ArgumentException("Valore del Nome non valido \n");
                }
            }
        }

        public string Surname
        { get { return surname; }
            set
            {
                if (value != "")
                {
                    surname = value;
                }
                else
                {
                    throw new ArgumentException("Valore del Cognome non valido \n");
                }
            }
        }

        public string Street
        {
            get { return street; }
            set
            {
                if (value != "")
                {
                    street = value;
                }
                else
                {
                    throw new ArgumentException("Valore della strada non valido \n");
                }
            }
        }

        public string City
        { get { return city; }
            set
            {
                if (value != "")
                {
                    city = value;
                }
                else
                {
                    throw new ArgumentException("Valore della città non valido \n");
                }
            } }

        public string Province
        {
            get { return province; }
            set
            {
                if (value != "")
                {
                    province = value;
                }
                else
                {
                    throw new ArgumentException("Valore della provincia non valido \n");
                }
            }
        }

        public string Zip
        {
            get { return zip; }
            set
            {
                if (value != "")
                {
                    zip = value;
                }
                else
                {
                    throw new ArgumentException("Valore del Codice postale non valido \n");
                }
            }
        }


        //Name,Surname,Street,City,Province,ZIP
        public Indirizzo(string name, string surname, string street, string city, string province, string zip)
        { 
            this.Name = name;
            this.Surname = surname;
            this.Street = street;
            this.City = city;
            this.Province = province;
            this.Zip = zip;
        
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
