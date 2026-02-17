//Nombre de los integrantes: 
//Luis Paulo Espinoza Sandoval - 1202925
//Cristopher Abdul De la Cruz Galvez - 1064625
//Ruben Dario Paredes Flores - 1152225

using System;

class Program
{
    static void Main()
    {
        Elevador e = new Elevador(1,1);
        Persona p = new Persona();
        e.setPiso();
        p.setPosicion();

        Console.WriteLine("Informacion inicial: ");
        Console.WriteLine("Te encuentras en el piso: " + p.posicionActual);
        Console.WriteLine("El elevador esta en el piso: " + e.pisoActual);

        Thread.Sleep(3500);

        
        if (e.pisoActual == p.posicionActual)
        {
            Console.WriteLine("El elevador llegó a tu piso, ingresa en el elevador antes que se vaya");
            Thread.Sleep(2000);
        }
        else
        {
            Console.WriteLine("El elevador no está en tu piso, espera a que llegue...");
            do
            {
                if(e.pisoActual < p.posicionActual)
                {
                    e.subirPiso();
                }
                else if(e.pisoActual > p.posicionActual)
                {
                    e.bajarPiso();
                }
            } while(e.pisoActual != p.posicionActual);
             Console.WriteLine("El elevador llegó a tu piso, ingresa en el elevador antes que se vaya");

        }
    }
}

class Elevador
{
    Random random = new Random();
    public int pisoActual;
    public const int pisoMax = 10;
    public const int pisoMin = 1;

    public Elevador(int pisoActual, int tiempoRestante)
    {
        this.pisoActual = pisoActual;
    }

    public void setPiso()
    {
        pisoActual = random.Next(pisoMin, pisoMax + 1);
    }

    public void bajarPiso()
    {
        if (pisoActual > pisoMin)
        {
            Console.WriteLine("El elevador está bajando");
            pisoActual--;
            Thread.Sleep(3000);
            Console.WriteLine("Piso actual: " + pisoActual);
        }
    }

    public void subirPiso()
    {
        if (pisoActual < pisoMax)
        {
            Console.WriteLine("El elevador está subiendo");
            pisoActual++;
            Thread.Sleep(3000);
            Console.WriteLine("Piso actual: " + pisoActual);
        }
    }
}

class Persona
{
    Random random = new Random();
    public int posicionActual = 0;

    public Persona(){}

    public void setPosicion()
    {
        posicionActual = random.Next(1, 11);
    }
}

