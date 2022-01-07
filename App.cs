using MarsRover.Core;
using System;

namespace MarsRover
{
    public class App
    {
        private readonly IMovementService movementService;

        public App(IMovementService movementService)
        {
            this.movementService = movementService;
        }

        public void Start()
        {
            Console.WriteLine("Enter Map Size:");
            var mapSize = Console.ReadLine();
            Console.WriteLine("Enter First Vehicle Position:");
            var firstVehiclePosition = Console.ReadLine();
            Console.WriteLine("Enter First Vehicle Commands:");
            var firstVehicleCommands = Console.ReadLine();

            Console.WriteLine("Enter Second Vehicle Position:");
            var secondVehiclePosition = Console.ReadLine();
            Console.WriteLine("Enter Second Vehicle Commands:");
            var secondVehicleCommands = Console.ReadLine();


            var map = new Map(mapSize);
            var firstRover = new Rover().CreateVehicle(new RequestModel(firstVehiclePosition, firstVehicleCommands), map);
            var secondRover = new Rover().CreateVehicle(new RequestModel(secondVehiclePosition, secondVehicleCommands), map);

            firstRover = movementService.Move(firstRover);
            secondRover = movementService.Move(secondRover);

            Console.WriteLine(new ResponseModel(firstRover).GetCurrentPosition());
            Console.WriteLine(new ResponseModel(secondRover).GetCurrentPosition());
        }
    }


}
