using Ejer2;

List<FiguraGeometrica> list = new List<FiguraGeometrica>();


Cuadrado cuadrado = new Cuadrado();
Rectangulo rectangulo = new Rectangulo();
Circulo circulo = new Circulo();

rectangulo.Altura = 2;
rectangulo.Base = 4;

cuadrado.Lado = 99;

circulo.Radio = 77;

list.Add(cuadrado);
list.Add(rectangulo);
list.Add(circulo);

foreach (FiguraGeometrica item in list)
{
    Console.WriteLine("Area: "+item.CalcularArea());
    Console.WriteLine("Perimetro: "+item.CalcularPerimetro());
}

