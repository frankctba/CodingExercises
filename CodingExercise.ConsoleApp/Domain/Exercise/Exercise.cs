using CodingExercise.ConsoleApp.Domain.Parameter;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingExercise.ConsoleApp.Domain.Exercise
{
    public class Exercise : IExercise
    {
        public Exercise()
        { }

        public Exercise(int id, string name, string assemblyName, ParameterTypeEnum parameterTypeEnum, ParameterTypeEnum resultTypeEnum)
        {
            Id = id;
            Name = name;
            AssemblyName = assemblyName;
            ParameterTypeEnum = parameterTypeEnum;
            ResultTypeResult = resultTypeEnum;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string AssemblyName { get; set; }
        public ParameterTypeEnum ParameterTypeEnum { get; set; }
        public ParameterTypeEnum ResultTypeResult { get; set; }
        
        public override string ToString()
        {
            return $"Exercise: {Id} - {Name}";
        }
    }
}
