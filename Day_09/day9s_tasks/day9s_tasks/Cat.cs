namespace day9s_tasks
{
    class Cat
    {   private int _foodAmount = 10;
        string _Name;
        string _Breed;
        int _Age;
        string _Gender;

        public string Name { 
            
            get { return _Name; }
            set { _Name = value; }
        }

        public string Breed { get; set; }
        public int Age {
            get { return _Age; }
            set { 
                if(value > 0)
                    _Age = value;
                else
                    Console.WriteLine("age is not valid");
            }
        }

        public string Gender {
            get { return _Gender; }
            set { _Gender = value; }
        }

        public void Meow(int meowing_time) {
            for (int i = 0; i < meowing_time; i++)
            {
                Console.WriteLine("Meowing ...");
            }
        }

        public void Eat(int amount) {
            Console.WriteLine(_Name + " start eating");
            while (amount > 0)
            {   
                Console.WriteLine("Eating ...");
                amount =  amount - _foodAmount;
            }
            Console.WriteLine(_Name + " finished eating");
        }
    }
}
