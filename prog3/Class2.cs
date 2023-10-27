using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izvp_lab_1
{
    interface ICreator<out T>
    {
        T FactoryMethod();
    }

    class ConcreteCreator<T> : ICreator<T> where T : new()
    {
        public T FactoryMethod()
        {
            return new T();
        }
    }

    internal abstract class Tehnique
    {
        protected string name;
        public Tehnique(string productName = "Product")
        {
            this.name = productName;
        }
    }

    class Apple : Tehnique
    {
        public Apple(string name = "Apple") : base(name) { }
        public Apple() : this("Apple") { }

        public override string ToString()
        {
            return name;
        }
    }

    class Samsung : Tehnique
    {
        public Samsung(string name = "Samsung") : base(name) { }
        public Samsung() : this("Samsung") { }

        public override string ToString()
        {
            return name;
        }
    }

    class Xiomi : Tehnique
    {
        public Xiomi(string name = "Xiomi") : base(name) { }
        public Xiomi() : this("Xiomi") { }

        public override string ToString()
        {
            return name;
        }
    }
}