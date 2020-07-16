using CodingExercise.ConsoleApp.Domain.Parameter;

namespace CodingExercise.ConsoleApp.Domain.Exercise
{
    public interface IExercise
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AssemblyName { get; set; }
        public ParameterTypeEnum ParameterTypeEnum { get; set; }
        public ParameterTypeEnum ResultTypeResult { get; set; }
    }
}
