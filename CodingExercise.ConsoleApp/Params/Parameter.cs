using CodingExercise.ConsoleApp.Params.Interfaces;

namespace CodingExercise.ConsoleApp.Params
{
    public class Parameter<T> : ParameterBase<T>
    {
        public Parameter(string name, T value)
            : base(name, value)
        {
            this.Name = name;
            this.Value = value;
        }

        // private string _name;
        // private T _value;

        // public string Name
        // {
        //     get
        //     {
        //         // insert desired logic here
        //         return _name;
        //     }
        //     set
        //     {
        //         // insert desired logic here
        //         _name = Name;
        //     }
        // }

        // public T Value
        // {
        //     get
        //     {
        //         // insert desired logic here
        //         return _value;
        //     }
        //     set
        //     {
        //         // insert desired logic here
        //         _value = value;
        //     }
        // }

        // public static implicit operator PType(Parameter<PType> param)
        // {
        //     return param.Value;
        // }

        // public static implicit operator Parameter<PType>(PType value)
        // {
        //     return new Parameter<PType>(name) { Value = value };
        // }   
    }
}