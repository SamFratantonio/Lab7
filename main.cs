using System;

class MainClass {
  public static double CalculateCharges(double hp)
  {
    double result = 2;
    if (hp > 3) {
      double temp = hp - 3;
      result += (temp * 0.50);
    }
    if (result > 10) { result = 10; }
    return(result);
  }
  public static void Main (string[] args) {
    while (true)
    {
      Console.Write("Enter Hours Parked: ");
      double hp = double.Parse(Console.ReadLine());
      Console.WriteLine("Parking Fee: $" + CalculateCharges(hp));
      Console.WriteLine("Are There Any More Customers? (y/n)");
      string answer = Console.ReadLine();
      if (answer == "y"){continue;}
      else{break;}
    }
  }
}