using CodingExercise.ConsoleApp.Params.Interfaces;

namespace CodingExercise.ConsoleApp.Params
{
    public abstract class ParameterBase<T> : IParameter<T>
    {
        public T Value { get; set; }
        public string Name { get; set; }

        public ParameterBase(string name, T value)
        {
            this.Name = name;
            this.Value = value;
        }
    }
}