using CodingExercise.ConsoleApp.Domain.Exercise;
using CodingExercise.ConsoleApp.Domain.Parameter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingExercise.ConsoleApp.Repository
{
    public class ExerciseRepository : IExerciseRepository
    {
        private IList<IExercise> _exercises;
        public ExerciseRepository()
        {
            _exercises = new List<IExercise>()
            {
                new Exercise(1, "ArrayIntSumExercise", "CodingExercise.ConsoleApp.Domain.Exercise.Catalog.ArrayIntSumExercise, CodingExercise.ConsoleApp", ParameterTypeEnum.ArrayInt, ParameterTypeEnum.ArrayInt),
                new Exercise(2, "MultipleFrom3And5Log", "CodingExercise.ConsoleApp.Domain.Exercise.Catalog.MultipleFrom3And5Log, CodingExercise.ConsoleApp", ParameterTypeEnum.Int, ParameterTypeEnum.ArrayString),
            };
        }

        public IEnumerable<IExercise> GetAll()
        {
            return _exercises;
        }

        public IExercise GetById(int id)
        {
            var exercise = _exercises.Where(e => e.Id == id);

            return exercise.Any() ? exercise.SingleOrDefault() : null;
        }
    }
}
