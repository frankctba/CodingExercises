namespace CodingExercise.ConsoleApp.Params.Interfaces
{
    public interface IParameter<T> : IParameterBase
    {
        T Value { get; set; }
    }
}