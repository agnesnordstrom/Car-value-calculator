using System;

class Program
{
    static void Main()
    {
        Car myCar = new Car();
        myCar.StartCar();

       Pet myPet = new Pet();
       myPet.StartPet();

        Album myAlbum = new Album();
        myAlbum.StartAlbum();

        TicketSeller myTicketSeller = new TicketSeller();
        myTicketSeller.StartTicketSeller();
    }
}
