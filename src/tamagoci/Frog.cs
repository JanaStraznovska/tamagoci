using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tamagoci
{
    public class Frog : Animal
    {
        public Frog()
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
                Fullness -= 10;
                Energy -= 10;
                Entertainment -= 10;
                Health -= 10;
                Cleanness -= 10;
                Console.WriteLine("Frog is doing nothing.");
            }

            CheckAnimal();
        }

        public override void Eat()
        {
            Age++;
            if (StageOfLife > 0)
            {
                Fullness += 30;
                Cleanness -= 20;
                Health -= 15;
                Console.WriteLine("Frog is eating.");
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
                Health += 25;
                Entertainment -= 30;
                Energy -= 25;
                Console.WriteLine("Frog is healing.");
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
                Entertainment += 30;
                Fullness -= 25;
                Console.WriteLine("Frog is playing.");
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
                Cleanness += 30;
                Entertainment -= 15;
                Console.WriteLine("Frog is showering.");
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
                Energy += 30;
                Entertainment -= 20;
                Console.WriteLine("Frog is sleeping.");
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
                Health += 20;
                Energy -= 25;
                Console.WriteLine("Frog is training.");
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

 ____
(o__o)====
 
  
  ");
                    break;
                case 2:
                    Console.WriteLine(@"

  @..@
 (----)
( >__< )
^^    ^^
  ");
                    break;
                case 3:
                    Console.WriteLine(@"

    @..@
   ( -.-)
  (  >__>
   vv  vv
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