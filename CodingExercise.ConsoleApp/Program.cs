using System;
using System.Collections.Generic;
using CodingExercise.ConsoleApp.Exercises;
using CodingExercise.ConsoleApp.Exercises.Interfaces;
using CodingExercise.ConsoleApp.Params;
using CodingExercise.ConsoleApp.Params.Interfaces;

namespace CodingExercise.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            // var paramsEx1 = new List<IParameter>();
            // ArrayIntSumExercise ex1 = new ArrayIntSumExercise();
            // Parameter<int[]> p1 = new Parameter<int[]>("p1") { Value = new int[] { 1, 0, 0, 1}};
            // paramsEx1.Add(p1);
            // ex1.AssignValueParams(paramsEx1);
            // var result = ex1.SolveIt();

            // Console.WriteLine("Result");
            // foreach(var i in result)
            // {
            //     Console.WriteLine($"{i}");
            // }

            // Console.ReadLine();
            
            // ArrayIntParam p1 = new ArrayIntParam();
            // p1.param = new int[5] { 1, 0, 1, 9, 9 };
            // // List<IExerciseParam> ex1Params = new List<IExerciseParam>();

            // List<IExerciseParam> ex1Params = new List<IExerciseParam>();
            // ex1Params.Add(new ArrayIntParam());
            // ex1.DoIt(ex1Params);
            // Exercise1 ex1 = new Exercise1();
            // int[] array = new int[4];
            // ex1.DoIt(array);
        }
    }
}
