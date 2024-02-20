using Kinetic_Energy_Calculator;

Console.WriteLine("Kinetic Energy Calculator");


Console.Write("Enter the mass of the object (kg): ");
double mass = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the velocity of the object (m/s): ");
double velocity = Convert.ToDouble(Console.ReadLine());

KineticEnergyCalculator calculator = new KineticEnergyCalculator(mass, velocity);
double kineticEnergy = calculator.CalculateKineticEnergy();

Console.WriteLine($"The kinetic energy is: {kineticEnergy} Joules");

Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();
