using CodingExercise.ConsoleApp.Domain.Exercise;
using CodingExercise.ConsoleApp.Factory;
using CodingExercise.ConsoleApp.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingExercise.ConsoleApp.Manager
{
    public class ExerciseManager : IExerciseManager
    {
        private IExerciseRepository exerciseRepository;
        public ExerciseManager(IExerciseRepository exerciseRepository)
        {
            this.exerciseRepository = exerciseRepository;
        }

        public IEnumerable<IExercise> GetAll()
        {
            return exerciseRepository.GetAll();
        }

        public IExercise GetById(int id)
        {
            return exerciseRepository.GetById(id);
        }

        public ExerciseResult<T> ExecuteExercise<T>(string parameterValue, IExercise exercise)
        {
            // 1 - Instantiate the Exercise
            var execution = ExerciseFactory.Create(exercise.AssemblyName, exercise.ParameterTypeEnum);

            // 2 - Convert the provided parameter values to the respective parameter of the exercise
            var parameterValueConverted = ParamFactory.CreateParameter(parameterValue, exercise.ParameterTypeEnum);

            // 3 - Execute the exercise based on the parameter values
            var result = execution.Execute(parameterValueConverted);

            return new ExerciseResult<T>()
            {
                Success = true,
                ResultValue = (T) result
            };
        }
    }
}
