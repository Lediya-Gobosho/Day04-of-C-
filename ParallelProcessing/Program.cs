﻿using ParallelProcessing;
using System.Diagnostics;

Console.WriteLine("Hello, World!");
ParallelTesting pt = new ParallelTesting();

Stopwatch stopwatch = new Stopwatch();

stopwatch.Start();
pt.Task1();
pt.Task2();
stopwatch.Stop();

Console.WriteLine($"Sequential execution took " +
    $"{stopwatch.ElapsedMilliseconds} ms ");


stopwatch.Restart();
Parallel.Invoke(() => pt.Task1(), () => pt.Task2());
stopwatch.Stop();

Console.WriteLine($"Parallel execution " +
    $"took {stopwatch.ElapsedMilliseconds} ms");



int numberofCores = Environment.ProcessorCount;

Console.WriteLine("Number of logical " +
    $"processor: {numberofCores}");
