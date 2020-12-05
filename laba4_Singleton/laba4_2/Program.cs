using System;

namespace laba4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Indivdual ind = new Indivdual();
            ind.Launch("Гаврилов");
            Console.WriteLine(ind.Surname.Name);

            ind.Surname = Surname.getInstance("Лунёв");
            Console.WriteLine(ind.Surname.Name);

            Console.ReadLine();
        }
    }
    class Indivdual
    {
        public Surname Surname { get; set; }
        public void Launch(string SurnameName)
        {
            Surname = Surname.getInstance(SurnameName);
        }
    }
    class Surname
    {
        private static Surname instance;

        public string Name { get; private set; }

        protected Surname(string name)
        {
            this.Name = name;
        }

        public static Surname getInstance(string name)
        {
            if (instance == null)
                instance = new Surname(name);
            return instance;
        }
    }
}
