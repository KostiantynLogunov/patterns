using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. base case
            /*
                        Context context = new Context(new StateA());
                        context.Request(); // Переход в состояние StateB
                        context.Request();  // Переход в состояние StateA
            */

            // 2. stupid case
            /*
                        Water water = new Water(WaterState.LIQUID);
                        water.Heat();
                        water.Frost();
                        water.Frost();
            */
            // 3.Smart case with State pattern
            Water water = new Water(new LiquidWaterState());
            water.Heat();
            water.Frost();
            water.Frost();
        }
    }

    // for 3 case
    class Water
    {
        public IWaterState State { get; set; }

        public Water(IWaterState ws)
        {
            State = ws;
        }

        public void Heat()
        {
            State.Heat(this);
        }
        public void Frost()
        {
            State.Frost(this);
        }
    }

    interface IWaterState
    {
        void Heat(Water water);
        void Frost(Water water);
    }

    class SolidWaterState : IWaterState
    {
        public void Heat(Water water)
        {
            Console.WriteLine("Превращаем лед в жидкость");
            water.State = new LiquidWaterState();
        }

        public void Frost(Water water)
        {
            Console.WriteLine("Продолжаем заморозку льда");
        }
    }
    class LiquidWaterState : IWaterState
    {
        public void Heat(Water water)
        {
            Console.WriteLine("Превращаем жидкость в пар");
            water.State = new GasWaterState();
        }

        public void Frost(Water water)
        {
            Console.WriteLine("Превращаем жидкость в лед");
            water.State = new SolidWaterState();
        }
    }
    class GasWaterState : IWaterState
    {
        public void Heat(Water water)
        {
            Console.WriteLine("Повышаем температуру водяного пара");
        }

        public void Frost(Water water)
        {
            Console.WriteLine("Превращаем водяной пар в жидкость");
            water.State = new LiquidWaterState();
        }
    }

    // for 2 case
    /*enum WaterState
    {
        SOLID,
        LIQUID,
        GAS
    }
    class Water
    {
        public WaterState State { get; set; }

        public Water(WaterState ws)
        {
            State = ws;
        }

        public void Heat()
        {
            if (State == WaterState.SOLID)
            {
                Console.WriteLine("Превращаем лед в жидкость");
                State = WaterState.LIQUID;
            }
            else if (State == WaterState.LIQUID)
            {
                Console.WriteLine("Превращаем жидкость в пар");
                State = WaterState.GAS;
            }
            else if (State == WaterState.GAS)
            {
                Console.WriteLine("Повышаем температуру водяного пара");
            }
        }
        public void Frost()
        {
            if (State == WaterState.LIQUID)
            {
                Console.WriteLine("Превращаем жидкость в лед");
                State = WaterState.SOLID;
            }
            else if (State == WaterState.GAS)
            {
                Console.WriteLine("Превращаем водяной пар в жидкость");
                State = WaterState.LIQUID;
            }
        }
    }*/
}
