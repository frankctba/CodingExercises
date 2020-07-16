using System;
using System.Collections.Generic;
using System.Text;

namespace CodingExercise.ConsoleApp.Domain.Parameter
{
    public class ParameterValue : IParameter
    {
        public ParameterValue(object value)
        {
            this.Value = value;
        }

        public object Value { get; set; }
    }      
}
