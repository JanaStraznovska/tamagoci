namespace tamagoci
{
    public class Bird : Animal
    {
        public Bird()
        {
            Fullness = 50;
            Energy = 50;
            Entertainment = 50;
            Health = 100;
            Age = 0;
            Cleanness = 50;
            IsAlive = true;
            StageOfLife = 0;
        }

        public override void DoNothing()
        {
            Age++;
            if (StageOfLife == 0)
            {
                Fullness -= 1;
                Energy -= 1;
                Entertainment -= 1;
                Health -= 1;
                Cleanness -= 1;
                Console.WriteLine("Egg is doing nothing.");
            }
            else
            {
                Fullness -= 5;
                Energy -= 5;
                Entertainment -= 5;
                Health -= 5;
                Cleanness -= 5;
                Console.WriteLine("Bird is doing nothing.");
            }

            CheckAnimal();
        }

        public override void Eat()
        {
            Age++;
            if (StageOfLife > 0)
            {
                Fullness += 30;
                Cleanness -= 10;
                Health -= 7;
                Console.WriteLine("Bird is eating.");
            }
            else
            {
                Console.WriteLine("Egg cannot eat.");
            }

            CheckAnimal();
        }

        public override void Heal()
        {
            Age++;
            if (StageOfLife > 0)
            {
                Health += 20;
                Entertainment -= 25;
                Energy -= 15;
                Console.WriteLine("Bird is healing.");
            }
            else
            {
                Console.WriteLine("Egg cannot heal.");
            }
            CheckAnimal();
        }

        public override void Play()
        {
            Age++;
            if (StageOfLife > 0)
            {
                Entertainment += 40;
                Fullness -= 20;
                Console.WriteLine("Bird is playing.");
            }
            else
            {
                Console.WriteLine("Egg cannot play.");
            }

            CheckAnimal();
        }

        public override void Shower()
        {
            Age++;
            if (StageOfLife > 0)
            {
                Cleanness += 50;
                Entertainment -= 15;
                Console.WriteLine("Bird is showering.");
            }
            else
            {
                Console.WriteLine("Egg cannot shower.");
            }
            CheckAnimal();
        }

        public override void Sleep()
        {
            Age++;
            if (StageOfLife > 0)
            {
                Energy += 50;
                Entertainment -= 15;
                Console.WriteLine("Bird is sleeping.");
            }
            else
            {
                Console.WriteLine("Egg cannot sleep.");
            }
            CheckAnimal();
        }

        public override void Train()
        {

            Age++;
            if (StageOfLife > 0)
            {
                Health += 25;
                Energy -= 10;
                Console.WriteLine("Bird is training.");
            }
            else
            {
                Console.WriteLine("Egg cannot train.");
            }

            CheckAnimal();
        }

        public override void WriteInfo()
        {
            base.WriteInfo();

            if (!IsAlive)
            {
                return;
            }
            
            switch (StageOfLife)
            {
                case 0:
                    Console.WriteLine(@"

  ___  
 /   \ 
|     |
 \___/
 ");
                    break;
                case 1:
                    Console.WriteLine(@"


  (o>
 <) )
  ^^
  ");
                    break;
                case 2:
                    Console.WriteLine(@"
     \\
     (o>
\\_//)
 \_/_)
  ^^
  ");
                    break;
                case 3:
                    Console.WriteLine(@"
     \\
    -(x>
\\_///)
 \_/_/
  vv
  ");
                    break;

            }
            
        }

        public override void CheckAnimal()
        {
            base.CheckAnimal();
        }
        
    }

}