using net_ef_videogame;

using (VideogameContext db = new VideogameContext())
{
    //Create Software House
    SoftwareHouse nuovasoftwareHouse = new SoftwareHouse { name = "Ubisoft", city = "Montreal", country = "Canada" };
    db.Add(nuovasoftwareHouse);
    db.SaveChanges();

    //Create Videogame
    Videogame aggiungivideogmae = new Videogame { SoftwareHouseId = 2, name = "call of duty", overview = "prova" };
    db.Add(aggiungivideogmae);
    db.SaveChanges();
}