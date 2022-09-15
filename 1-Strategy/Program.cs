using _1_Strategy.Implementations;
using _1_Strategy.Models;

Car car = new Car(5, "Lada", new PetrolEngine());
car.Move();
car.SwapEngine(new GasEngine());
car.Move();
car.SwapEngine(new HybridEngine());
car.Move();

Console.ReadLine();