using Ejer3;

Auto audi = new Auto();
Moto Honda = new Moto();

audi.Marca = "A3";
Honda.Cilindrada = 150;

List<IVehiculo> vehiculos = new List<IVehiculo>();

vehiculos.Add(audi);
vehiculos.Add(Honda);

foreach (var item in vehiculos)
{
    Console.Write("\n");
    item.Encender();
    item.Acelerar(60);
    item.Acelerar(120);
    item.Frenar();
    item.Apagar();
    Console.Write("\n");
}


