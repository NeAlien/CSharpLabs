namespace Animals
{
    [MyAttribute("Abstract class of animals")]
    abstract public class Animal
    {
        protected eClassificationAnimal Classification;
        public string Country { get; set; }

        public string Name { get; set; }
        public string WhatAnimal { get; set; }

        public List<Animal> HideFromOtherAnimals { get; set; }
        public Animal()
        {
            Country = new("");
            HideFromOtherAnimals = new List<Animal>();
            Name = new("");
            WhatAnimal = "Animal";
        }

        public Animal(string country, List<Animal> hideFromOtherAnimals, string name)
        {
            Country = country;
            HideFromOtherAnimals = hideFromOtherAnimals;
            Name = name;
            WhatAnimal = new string("");
        }

        public void Deconstruct(out string country, out List<Animal> hideFrom, out string name, out string whatAnimal)
        {
            country = Country;
            hideFrom = HideFromOtherAnimals;
            name = Name;
            whatAnimal = WhatAnimal;
        }

        public eClassificationAnimal GetClassificationAnimal() => Classification;

        public abstract eFavouriteFood GetFavouriteFood();

        public abstract void SayHello();
    }

    [MyAttribute("Animals can be different classifications")]
    public enum eClassificationAnimal
    {
        Herbivores,
        Carnivores,
        Omnivores
    }

    [MyAttribute("Animals have favourite food")]
    public enum eFavouriteFood
    {
        Meat,
        Plants,
        Everything
    }

    [MyAttribute(@"It's a cow")]
    public class Cow: Animal
    {
        public Cow(): base()
        {
            WhatAnimal = "Cow";
            Classification = eClassificationAnimal.Herbivores;
        }
        public Cow(string country, List<Animal> hideFromOtherAnimals, string name): 
            base(country, hideFromOtherAnimals, name)
        {
            WhatAnimal = "Cow";
            Classification = eClassificationAnimal.Herbivores;
        }

        public override eFavouriteFood GetFavouriteFood() => eFavouriteFood.Plants;

        public override void SayHello() => Console.WriteLine($"Cow says hi{Environment.NewLine}@{Name}");
    }

    [MyAttribute(@"It's a lion")]
    public class Lion: Animal
    {
        public Lion() : base()
        {
            WhatAnimal = "Lion";
            Classification = eClassificationAnimal.Carnivores;
        }
        public Lion(string country, List<Animal> hideFromOtherAnimals, string name):
            base (country, hideFromOtherAnimals, name)
        {
            WhatAnimal = "Lion";
            Classification = eClassificationAnimal.Carnivores;
        }

        public override eFavouriteFood GetFavouriteFood() => eFavouriteFood.Meat;

        public override void SayHello() => Console.WriteLine($"Lion says hi{Environment.NewLine}@{Name}");
    }

    [MyAttribute(@"It's a pig")]
    public class Pig: Animal
    {
        public Pig() : base()
        {
            WhatAnimal = "Pig";
            Classification = eClassificationAnimal.Omnivores;
        }
        public Pig(string country, List<Animal> hideFromOtherAnimals, string name):
            base (country, hideFromOtherAnimals, name)
        {
            WhatAnimal = "Pig";
            Classification = eClassificationAnimal.Omnivores;
        }

        public override eFavouriteFood GetFavouriteFood() => eFavouriteFood.Everything;

        public override void SayHello() => Console.WriteLine($"Pig says hi{Environment.NewLine}@{Name}");
    }
}