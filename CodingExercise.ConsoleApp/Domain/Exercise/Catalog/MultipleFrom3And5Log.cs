using CodingExercise.ConsoleApp.Domain.Parameter;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingExercise.ConsoleApp.Domain.Exercise.Catalog
{
    public class MultipleFrom3And5Log : RealExercise
    {
        //private IParameter _parameter;

        //public MultipleFrom3And5Log(IParameter parameter)
        //{
        //    this._parameter = parameter;
        //}

        public override object Execute(IParameter parameter)
        {
            base.ValidateParameter(parameter);

            var number = parameter.Value as int?;
            string result = string.Empty;

            for (int i = 1; i <= number; i++)
            {
                var print = "";
                print += isMultipleOf3(number.Value) ? "Fizz" : "";
                print += isMultipleOf5(number.Value) ? "Buzz" : "";
                print = string.IsNullOrEmpty(print) ? i.ToString() : print;

                result += print + '\0';
            }

            return result;
        }

        private bool isMultipleOf3(int n)
        {
            return ((n >= 3) && (n % 3 == 0));
        }

        private bool isMultipleOf5(int n)
        {
            return ((n >= 5) && (n % 5 == 0));
        }
    }
}
