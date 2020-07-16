using CodingExercise.ConsoleApp.Domain.Exercise;
using CodingExercise.ConsoleApp.Domain.Parameter;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CodingExercise.ConsoleApp.Factory
{
    public static class ExerciseFactory
    {
        public static RealExercise Create(string exerciseAssemblyName, ParameterTypeEnum parameterTypeEnum)
        {
            var objectType = Type.GetType(exerciseAssemblyName);
            // var exercise = (RealExercise)Activator.CreateInstance(exerciseAssemblyName, ServiceLocator.Resolve<IParameter>());

            return Activator.CreateInstance(objectType) as RealExercise;
        }
    }
}
