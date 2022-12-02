/*
 * Advent of Code 2022
 * Calorie calculator
 */

var read = File.ReadAllText("day1.txt");

var lines = read.Split("\r\n\r\n");
var calories = new List<int>();

foreach (var line in lines)
{
    var cals = line.Split("\r\n").ToList();
    var tot = 0;

    foreach (var cal in cals)
    {
        tot += int.Parse(cal);
    }

    calories.Add(tot);

}

var most = calories.Max();

Console.WriteLine($"The elf carrying the most calories has {most} calories in their inventory.");