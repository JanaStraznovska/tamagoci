namespace tamagoci
{
    public abstract class Animal : IActivities, IAnimalInfo
    {
        private int _fullness;
        private int _energy;
        private int _entertainment;
        private int _health;
        private int _cleanness;
        public int Fullness { get => _fullness; set => _fullness = LimitZeroTo100(value); }
        public int Energy { get => _energy; set => _energy = LimitZeroTo100(value); }
        public int Entertainment { get => _entertainment; set => _entertainment = LimitZeroTo100(value); }
        public int Health { get => _health; set => _health = LimitZeroTo100(value); }
        public int Age { get; set; }
        public int Cleanness { get => _cleanness; set => _cleanness = LimitZeroTo100(value); }
        public int StageOfLife { get; set; }
        public bool IsAlive { get; set; }

        private int LimitZeroTo100(int value)
        {
            if (value < 0)
            {
                return 0;
            }
            else if (value > 100)
            {
                return 100;
            }
            else
            {
                return value;
            }
        }

        public abstract void DoNothing();
        public abstract void Eat();
        public abstract void Heal();
        public abstract void Play();
        public abstract void Shower();
        public abstract void Sleep();
        public abstract void Train();
        public virtual void WriteInfo()
        {
            if (IsAlive == true)
            {
                Console.WriteLine($"Fullness:      {Fullness}");
                Console.WriteLine($"Energy:        {Energy}");
                Console.WriteLine($"Entertaiment:  {Entertainment}");
                Console.WriteLine($"Health:        {Health}");
                Console.WriteLine($"Age:           {Age}");
                Console.WriteLine($"Cleanness:     {Cleanness}");
                Console.WriteLine($"Stage of life: {GetStageOfLifeName()}");


            }
            else
            {
                Console.WriteLine("Your animal is dead :-(");
                string className = this.GetType().Name;
                int totalWidth = 13;
                int padding = (totalWidth - className.Length) / 2;
                string centeredText = "|" + new string(' ', padding) + className + new string(' ', totalWidth - padding - className.Length) + "|";
                Console.Write(@"
      _________
     /         \
    /   R.I.P.  \ 
   |             |
   ");

                Console.Write(centeredText);

                Console.WriteLine(@"
   |             |
   |             |
   |_____________|
   ");

            }
        }

        private string GetStageOfLifeName()
        {
            string StageOfLifeName = "";
            switch (StageOfLife)
            {
                case 0:
                    {
                        StageOfLifeName = "Egg";
                        break;
                    }
                case 1:
                    {
                        StageOfLifeName = "Young";
                        break;
                    }
                case 2:
                    {
                        StageOfLifeName = "Adult";
                        break;
                    }
                case 3:
                    {
                        StageOfLifeName = "Old";
                        break;
                    }
            }
            return StageOfLifeName;
        }

        public virtual void CheckAnimal()
        {
            if (_health == 0)
            {
                IsAlive = false;
            }

            if (Age >= 70)
            {
                IsAlive = false;
            }

            if (Age == 0)
            {
                Console.Beep();
                Console.Beep();
                Console.Beep();
                StageOfLife = 0;
            }
            else if (Age == 10)
            {
                Console.Beep();
                Console.Beep();
                Console.Beep();             
                StageOfLife = 1;
            }
            else if (Age == 30)
            {
                Console.Beep();
                Console.Beep();
                Console.Beep();   
                StageOfLife = 2;
            }
            else if (Age == 50)
            {
                Console.Beep();
                Console.Beep();
                Console.Beep();   
                StageOfLife = 3;
            }
        }
    }
}