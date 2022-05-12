using System;

namespace Lab2_3__OP
{
    public class Bird
    {
        private Wings wings;
        private Beak beak;
        public string Name { get; set; }
        public float Weight { get; set; }
        public Bird(string name, float weight)
        {
            Name = name;
            Weight = weight;
            wings = new Wings();
            beak = new Beak();
        }
        public void Fly()
        {
            Console.WriteLine("Fly() method from Wings class");
            Console.WriteLine("I am a " + Name);
            wings.Fly();
        }
        public void Attack()
        {
            Console.WriteLine("Attack() method from Beak class");
            Console.WriteLine("I am a " + Name);
            beak.Attack();

        }
        public void Eat()
        {
            Console.WriteLine("Eat() method from Beak class");
            Console.WriteLine("I am a " + Name);
            beak.Eat();
        }
        public void Land()
        {
            Console.WriteLine("Land() method from Wings class");
            Console.WriteLine("I am a " + Name);
            wings.Land();
        }
        public override bool Equals(object obj)
        {

            Bird bird = obj as Bird;
            if (bird == null)
            {
                return false;
            }
            Console.Write($"{Name} equals {bird.Name}:");
            return this.Name == bird.Name && this.Weight == bird.Weight;
        }
        public override int GetHashCode()
        {
            int name;
            if (Name == "Woodpecker")
            {
                name = 0;
            }
            else
            {
                name = 1;
            }
            return (int)Weight + name;
        }
        public override string ToString()
        {
            return $"Name:{Name}\tWeight:{Weight}";
        }
    }
}
