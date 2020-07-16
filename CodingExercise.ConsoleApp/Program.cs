using CodingExercise.ConsoleApp.Domain.Parameter;
using CodingExercise.ConsoleApp.Factory;
using CodingExercise.ConsoleApp.Manager;
using CodingExercise.ConsoleApp.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace CodingExercise.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercises!");

            // My goal here
            // I want to see all available exercises in the system
            // I select one specific exercise and see the basic information about it (description, parameters, example, test action)
            // Test action: executes the test with the provided parameters and returns the result            
            // exercise.Execute

            var collection = new ServiceCollection();
            collection.AddScoped<IExerciseRepository, ExerciseRepository>();
            collection.AddScoped<IExerciseManager, ExerciseManager>();
            collection.AddScoped<IParameter, ParameterValue>();

            var serviceProvider = collection.BuildServiceProvider();
            var manager = serviceProvider.GetService<IExerciseManager>();
            var exercises = manager.GetAll();

            foreach(var exercise in exercises)
            {
                Console.WriteLine(exercise.ToString());
            }

            var arrayIntSumExercise = exercises.ElementAt(0);
            var exerciseInstance = ExerciseFactory.Create(arrayIntSumExercise.AssemblyName, arrayIntSumExercise.ParameterTypeEnum);
            var param = ParamFactory.CreateParameter("1 2 9 10", ParameterTypeEnum.ArrayInt);
            var expectedResult = new int[5] { 1, 2, 9, 1, 1 };
            var result = exerciseInstance.Execute(param);
            
            if (result == expectedResult)
                Console.WriteLine("Test: Ok");
            else
                Console.WriteLine("Test: Failed");

            // My goal in future
            // I want to see all available exercises in the system
            // I select one specific exercise and see the basic information about it (description, parameters, example, submit code, see results)
            // Submit code action: system interprets the code (must have the same parameters), compiles and executes using unit tests (mock data)
            // See results action: system show results of unit tests (when they finish)

            Console.ReadLine();
        }
    }
}
