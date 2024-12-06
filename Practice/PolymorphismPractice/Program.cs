namespace PolymorphismPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Dog dog = new Dog();
            Pig pig = new Pig();

            animal.AnimalSound();
            dog.AnimalSound();
            pig.AnimalSound();  

        }
    }
     class Animal
     {
        public virtual void AnimalSound()
        {
        Console.WriteLine("The Animals Makes Sounds");
        }
     }
     class Dog : Animal
     {
        public override void AnimalSound()
        {
        Console.WriteLine("The Dogs make bow! bow! sounds");
        }
     }

    class Pig : Animal
    {
        public override void AnimalSound()
        {
        Console.WriteLine("The Pigs make pee! pee! sounds");
        }
    }
}
