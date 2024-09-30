using classi;

Console.WriteLine("Gestione Biblioteca");

Console.WriteLine("inserimento Libri");


bool continua = true;
while (continua)
{         
    Libro libro = new Libro();

    Console.WriteLine("Inserisci il titolo");
    string titolo = Console.ReadLine();
    Console.WriteLine("Inserisci L' autore");
    string autore = Console.ReadLine();
    Console.WriteLine("Inserisci il numero di pagine");
    string pagine = Console.ReadLine();
    Console.WriteLine("Inserisci il prezzo");
    decimal prezzo = decimal.Parse(Console.ReadLine());


    Console.WriteLine("vuoi inserire un altro libro?  (S/N)");
    string risposta = Console.ReadLine();
    if (risposta == "N")  continua = false;

}
