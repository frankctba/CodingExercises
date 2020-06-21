using System.Collections.Generic;
using CodingExercise.ConsoleApp.Params.Interfaces;

namespace CodingExercise.ConsoleApp.Exercises.Interfaces
{
    public interface IExercise<T> : IExerciseBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        // void CreateParams();
        // void ValidateParams();
        // void AssignValueParams(List<IParameter> paramValues);
        //TResultType SolveIt();
    }
}