using izvp_lab_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Technology> technologies = new List<Technology>();
            ICreator<Technology> creator = new ConcreteCreator<Apple>();
            technologies.Add(creator.FactoryMethod());
            creator = new ConcreteCreator<Samsung>();
            technologies.Add(creator.FactoryMethod());
            creator = new ConcreteCreator<Xiomi>();
            technologies.Add(creator.FactoryMethod());

            foreach (Technology item in technologies)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("///");

            List<ITechnologyFactory<IType, IBrand>> technologyFactories = new List<ITechnologyFactory<IType, IBrand>>();
            technologyFactories.Add(new AppleFactory());
            technologyFactories.Add(new SamsungFactory());
            technologyFactories.Add(new XiomiFactory());

            foreach (ITechnologyFactory<IType, IBrand> item in technologyFactories)
            {
                Client client = new Client(item);
                client.Run();
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
