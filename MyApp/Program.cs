var today = new DailyTemperature(28.5, 14.2);
Console.WriteLine(today.HighTemp);
public readonly record struct DailyTemperature(double HighTemp, double LowTemp);
