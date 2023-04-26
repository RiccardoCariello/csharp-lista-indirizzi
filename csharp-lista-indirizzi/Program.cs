/*
 nome progetto: csharp-lista-indirizzi
nome repo: csharp-lista-indirizzi
Oggi esercitazione sui file, ossia vi chiedo di prendere dimestichezza con quanto appena visto sui file in classe, in particolare nel live-coding di oggi.
In questo esercizio dovrete leggere un file CSV, che cambia poco da quanto appena visto nel live-coding in classe anche rispetto un file di testo txt 
(a dire il vero quello che vi ho creato questa mattina non era un txt ma propriamente un csv), 
e salvare tutti gli indirizzi contenuti al sul interno all’interno di una lista di oggetti istanziati a partire dalla classe Indirizzo.

Attenzione: gli ultimi 3 indirizzi presentano dei possibili “casi particolari” che possono accadere a questo genere di file: vi chiedo di pensarci 
e di gestire come meglio crediate queste casistiche. 
 */

using csharp_lista_indirizzi;

StreamReader file = File.OpenText("C:\\Users\\tuono\\source\\repos\\csharp-lista-indirizzi\\csharp-lista-indirizzi\\addresses.csv");

int contatore= 0;

List <Indirizzo> listaIndirizzi = new List <Indirizzo>();


//Name,Surname,Street,City,Province,ZIP
while (!file.EndOfStream)
{

    contatore ++;
    string rigaTesto = file.ReadLine(); //ora la variabile rigaTesto contiene una riga del file.
    
    //ora eseguiremo questo blocco solo se ci troviamo dalla riga 2 in poi
    if (contatore > 1)
    {
        //immagazzino in questo array una stringa inclusa nelle virgole del file per ogni spazio dell'array.
        string[] informazioniSeparate = rigaTesto.Split(',');
        
        // ora contiene tutte le info in una riga e le passo al costruttore, ma prima verifico che siano 6 elementi, come previsto.
        if (informazioniSeparate.Length == 6) //cosi mi arricuro che siano 6 elementi
        {
            try
            {
                Indirizzo indirizzo = new Indirizzo(informazioniSeparate[0], informazioniSeparate[1], informazioniSeparate[2], informazioniSeparate[3], informazioniSeparate[4], informazioniSeparate[5]);
                listaIndirizzi.Add(indirizzo);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine($"Errore alla riga : {contatore}");
                
            }
        }
        else
        {
            Console.WriteLine($"Il numero di elementi nell'indirizzo N° {contatore} non è idoneo");
        }

    }
    
    
}
file.Close();

foreach (Indirizzo indirizzo in listaIndirizzi)
{
    Console.WriteLine(indirizzo.ToString());
}