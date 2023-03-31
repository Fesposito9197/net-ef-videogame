using net_ef_videogame;

using (VideogameContext db = new VideogameContext())
{

Console.WriteLine("Aggiungi una nuova SoftwareHouse!");

Console.WriteLine("Inserisci il nome: ");
var userInputName = Console.ReadLine();

Console.WriteLine("Inserisci la città: ");
var userInputCity = Console.ReadLine();

Console.WriteLine("Inserisci il paese: ");
var userInputCountry = Console.ReadLine();

SoftwareHouse softwareHouse = new SoftwareHouse { name = userInputName, city = userInputCity, country = userInputCountry };
db.Add(softwareHouse);
db.SaveChanges();

    while (true)
    {
        Console.WriteLine("Inserisci il nuovo videogioco!");

        Console.WriteLine("Inserisci il nome del gioco: ");
        var newGameName = Console.ReadLine();

        Console.WriteLine("Inserisci la descrizione del gioco: ");
        var newGameDesc = Console.ReadLine();

        Console.WriteLine("Scegli a quale softwarehouse abbinare il videogioco!");



        Console.WriteLine("Inserisci l'ID della softwarehouse produttrice del gioco: ");
        var newGameSoftHouseId = Convert.ToInt32(Console.ReadLine());

        Videogame newVideoGame = new Videogame { SoftwareHouseId = newGameSoftHouseId, name = newGameName, overview = newGameDesc };
        db.Add(newVideoGame);
        db.SaveChanges();

        Console.WriteLine("Gioco salvato correttamente!");

        break;
    
    }



}

//Create Software House
//SoftwareHouse nuovasoftwareHouse = new SoftwareHouse { name = "Ubisoft", city = "Montreal", country = "Canada" };
//db.Add(nuovasoftwareHouse);
//db.SaveChanges();

//Create Videogame
//Videogame aggiungivideogmae = new Videogame { SoftwareHouseId = 1, name = "call of duty", overview = "prova" };
//db.Add(aggiungivideogmae);
//db.SaveChanges();

//Read
//Console.WriteLine("Lista giochi");
//List<Videogame> videogames = db.videogames.ToList<Videogame>();


//Delete
//db.Remove(nuovasoftwareHouse);
//db.SaveChanges();