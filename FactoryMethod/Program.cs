using FactoryMethod;

const int nClients = 10;
Random rnd = new Random();

Console.WriteLine( nClients.ToString() + " clients came to our EV dealerships and here is what happenned:" );
Console.WriteLine();

var dealerships = new List<EVShop>
{
    new TeslaShop(),
    new BYDShop()
};

for ( var iClient = 1; iClient <= nClients; iClient++ )
{
    var car = dealerships[ rnd.Next( 0, 2 ) ].AddCar();

    Console.WriteLine("Client " + iClient + " bought a " + car.Model);
}
