using System;
using System.Collections.Generic;

namespace AtvPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número de figuras geométricas a serem criadas: ");
            int n = Convert.ToInt32(Console.ReadLine());
            List<FiguraGeometrica> figuras = new List<FiguraGeometrica>();
            for(int i = 1; i <= n; i++)
            {
                Console.Clear();
                Console.WriteLine("A figura {0} é de que tipo?", i);
                string tipo = Console.ReadLine();
                if(tipo == "Triangulo")
                {
                    Console.WriteLine("Digite a base da figura {0}", i);
                    double Base = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite a altura da figura {0}", i);
                    double Altura = Convert.ToDouble(Console.ReadLine());
                    figuras.Add(new Triangulo(Base, Altura));
                }
                else if (tipo == "Retangulo")
                {
                    Console.WriteLine("Digite a base da figura {0}", i);
                    double Base = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite a altura da figura {0}", i);
                    double Altura = Convert.ToDouble(Console.ReadLine());
                    figuras.Add(new Retangulo(Base, Altura));
                }
                else if (tipo == "Circulo")
                {
                    Console.WriteLine("Digite o raio da figura {0}", i);
                    double raio = Convert.ToDouble(Console.ReadLine());
                    figuras.Add(new Circulo(raio));
                }
                else
                {
                    figuras.Add(new OutraFigura());
                    Console.WriteLine("Figura registrada!");
                }
            }
            foreach (FiguraGeometrica figura in figuras)
            {
                Console.Clear();
                figura.quemSouEu();
                figura.qualMinhaArea();
                Console.WriteLine("\nPressiona qualquer tecla para continuar");
                Console.ReadKey();
            }
        }
    }
    public abstract class FiguraGeometrica 
    {
        public abstract double calcularArea();
        public virtual void quemSouEu()
        {
            Console.WriteLine("Sou uma figura Geométrica");
        }
        public virtual void qualMinhaArea()
        {
            Console.WriteLine("Minha area é: {0}", calcularArea());
        }
    }
    public class Triangulo : FiguraGeometrica
    {
        double Base;
        double Altura;
        public Triangulo(double Base, double Altura)
        {
            this.Base = Base;
            this.Altura = Altura;
        }
        public override double calcularArea()
        {
            return Base*Altura/2;
        }
        public override void quemSouEu()
        {
            Console.WriteLine("Sou um triangulo");
        }
    }
    public class Retangulo : FiguraGeometrica
    {
        double Base;
        double Altura;
        public Retangulo(double Base, double Altura)
        {
            this.Base = Base;
            this.Altura = Altura;
        }
        public override double calcularArea()
        {
            return Base*Altura;
        }
        public override void quemSouEu()
        {
            Console.WriteLine("Sou um retangulo");
        }
    }
    public class Circulo : FiguraGeometrica
    {
        double raio;
        public Circulo(double raio)
        {
            this.raio = raio;
        }
        public override double calcularArea()
        {
            return 3.14159*raio*raio;
        }
        public override void quemSouEu()
        {
            Console.WriteLine("Sou um circulo");
        }
    }
    public class OutraFigura : FiguraGeometrica
        public override double calcularArea()
        {
            return 0;
        }
        public override void qualMinhaArea()
        { }

    }
}
