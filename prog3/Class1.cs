using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace izvp_lab_1
{
    interface IType
    {
        void ShowType();
    }

    interface IBrand
    {
        void ShowBrand();
    }

    interface ITechnologyFactory<out IType, out IBrand>
    {
        string Name { get; }
        IType CreateType();
        IBrand CreateBrand();
    }

    class Apple : IType
    {
        public void ShowType()
        {
            Console.WriteLine("Technology type: Apple");
        }
    }

    class Samsung : IType
    {
        public void ShowType()
        {
            Console.WriteLine("Technology type: Samsung");
        }
    }

    class Xiomi : IType
    {
        public void ShowType()
        {
            Console.WriteLine("Technology type: Xiomi");
        }
    }

    class Tesla : IBrand
    {
        public void ShowBrand()
        {
            Console.WriteLine("Technology brand: Tesla");
        }
    }

    class SamsungBrand : IBrand
    {
        public void ShowBrand()
        {
            Console.WriteLine("Technology brand: Samsung");
        }
    }

    class XiomiBrand : IBrand
    {
        public void ShowBrand()
        {
            Console.WriteLine("Technology brand: Xiomi");
        }
    }

    class AppleFactory : ITechnologyFactory<IType, IBrand>
    {
        public string Name { get; }
        public AppleFactory(string name = "Create: Apple")
        {
            Name = name;
        }

        public IType CreateType()
        {
            return new Apple();
        }

        public IBrand CreateBrand()
        {
            return new Tesla();
        }
    }

    class SamsungFactory : ITechnologyFactory<IType, IBrand>
    {
        public string Name { get; }
        public SamsungFactory(string name = "Create: Samsung")
        {
            Name = name;
        }

        public IType CreateType()
        {
            return new Samsung();
        }

        public IBrand CreateBrand()
        {
            return new SamsungBrand();
        }
    }

    class XiomiFactory : ITechnologyFactory<IType, IBrand>
    {
        public string Name { get; }
        public XiomiFactory(string name = "Create: Xiomi")
        {
            Name = name;
        }

        public IType CreateType()
        {
            return new Xiomi();
        }

        public IBrand CreateBrand()
        {
            return new XiomiBrand();
        }
    }

    class Client
    {
        IType type;
        IBrand brand;
        public Client(ITechnologyFactory<IType, IBrand> factory)
        {
            type = factory.CreateType();
            brand = factory.CreateBrand();
            Console.WriteLine(factory.Name);
        }

        public void Run()
        {
            type.ShowType();
            brand.ShowBrand();
        }
    }
}
