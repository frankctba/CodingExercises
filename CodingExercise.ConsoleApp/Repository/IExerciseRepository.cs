using CodingExercise.ConsoleApp.Domain.Exercise;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingExercise.ConsoleApp.Repository
{
    public interface IExerciseRepository
    {
        IEnumerable<IExercise> GetAll();
        IExercise GetById(int id);
    }
}
