using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1
{
    internal class Class
    {
        class AbStract
        {
            abstract class Shape
            {
                protected float m_Height = 5;
                protected float m_Width = 10;
                public abstract void CalculateArea();
                public abstract void CalculateCircumference();
                public void PrintHeight()
                {
                    Console.WriteLine("Height = {0}", m_Height);
                }
                public void PrintWidth()
                {
                    Console.WriteLine("Width = {0}", m_Width);
                }
            }

            class Rectangle : Shape
            {
                public Rectangle()
                {
                    m_Height = 20; m_Width = 30;
                }
                public override void CalculateArea()
                {
                    Console.WriteLine("Area : {0}", m_Height * m_Width);
                }
                public override void CalculateCircumference()
                {
                    Console.WriteLine("Circumference =  {0}", (m_Height + m_Width) * 2);
                }
            }
            class Test
            {
                static void Main(string[] args)
                {
                    Rectangle objRec = new Rectangle();
                    objRec.CalculateArea();
                    objRec.CalculateCircumference();
                }
            }
        }
        class Polymorphism
        {
            class Animal
            {
                public Animal()
                {
                    Console.WriteLine("Animal constructor");
                }
                public virtual void Talk()
                {
                    Console.WriteLine("Animal talk");
                }
            }

            class Dog : Animal
            {
                public Dog()
                {
                    Console.WriteLine("Dog constructor");
                }
                public override void Talk()
                {
                    Console.WriteLine("Dog talk");
                }
            }

            class Test
            {
                static void Main(string[] args)
                {
                    Animal objA = new Animal();
                    Dog objD = new Dog();
                    objA = objD;
                    objA.Talk();
                }
            }
        }
        class Overriding
        {
            class Animal
            {
                public Animal()
                {
                    Console.WriteLine("Animal constructor");
                }
                public void Talk()
                {
                    Console.WriteLine("Animal talk");
                }
            }

            class Dog : Animal
            {
                public Dog()
                {
                    Console.WriteLine("Dog constructor");
                }
                public new void Talk()
                {
                    Console.WriteLine("Dog talk");
                }
            }
            class Test
            {
                static void Main(string[] args)
                {
                    Animal a1 = new Animal();
                    a1.Talk();
                    Dog d1 = new Dog();
                    d1.Talk();
                }
            }

        }
        class Heritage
        {
            class Software
            {
                private int m_z;
                public int m_v;
                protected int m_x;
                public Software()
                {
                    m_x = 100;
                }
                public Software(int y)
                {
                    m_x = y;
                }
            }
            class MicrosoftSoftware : Software
            {
                public MicrosoftSoftware()
                {
                    Console.WriteLine(m_x);
                }
            }
            class IBMSoftware : Software
            {
                public IBMSoftware(int y) : base(y)
                {
                    Console.WriteLine(m_x);
                }
                public IBMSoftware(string s, int f) : this(f)
                {
                    Console.WriteLine(s);
                }
            }
            static void Main(string[] args)
            {
                MicrosoftSoftware objMS = new MicrosoftSoftware();

                IBMSoftware objIBM1 = new IBMSoftware(50);

                IBMSoftware objIBM2 = new IBMSoftware("test", 75);

                Console.ReadLine();
            }

        }
    }
}
