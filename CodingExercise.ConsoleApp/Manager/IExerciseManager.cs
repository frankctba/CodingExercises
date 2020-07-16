using CodingExercise.ConsoleApp.Domain.Exercise;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingExercise.ConsoleApp.Manager
{
    public interface IExerciseManager
    {
        IEnumerable<IExercise> GetAll();
        IExercise GetById(int id);
        ExerciseResult<T> ExecuteExercise<T>(string parameterValue, IExercise exercise);
    }
}
