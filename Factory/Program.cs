using System;

public interface IVehicle
{
    void Drive();
}

public class Car : IVehicle
{
    public void Drive() => Console.WriteLine("Легковой автомобиль едет!");
}
public class Truck : IVehicle
{
    public void Drive() => Console.WriteLine("Грузовик перевозит груз!");
}
public class Motorcycle : IVehicle
{
    public void Drive() => Console.WriteLine("Мотоцикл мчится по дороге!");
}

// Базовый класс-фабрика
public abstract class VehicleCreator
{
    // Фабричный метод (создаёт транспортное средство)
    public abstract IVehicle CreateVehicle();

    // Метод, использующий фабричный метод
    public void SomeOperation()
    {
        IVehicle vehicle = CreateVehicle();
        Console.WriteLine("Создан объект транспортного средства.");
        vehicle.Drive();
    }
}

// Фабрика для автомобилей
public class CarCreator : VehicleCreator
{
    public override IVehicle CreateVehicle() => new Car();
}

// Фабрика для грузовиков
public class TruckCreator : VehicleCreator
{
    public override IVehicle CreateVehicle() => new Truck();
}

// Фабрика для мотоциклов
public class MotorcycleCreator : VehicleCreator
{
    public override IVehicle CreateVehicle() => new Motorcycle();
}

class Program
{
    static void Main()
    {
        VehicleCreator[] creators = { new CarCreator(), new TruckCreator(), new MotorcycleCreator() };

        foreach (var creator in creators)
        {
            creator.SomeOperation();
            Console.WriteLine();
        }
    }
}

