/*
 * Advent of Code 2022
 * Rock Paper Scissors, Day 2
 */

Dictionary<string, int> results
{
    { "A X",  }
};

var data = File.ReadAllLines("day2.txt");

foreach (var line in data)
{
    var results = line.Split(' ');

    var opponent = results[0];
    var self = results[1];
}

var stop = 0;