using CodingExercise.ConsoleApp.Domain.Parameter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingExercise.ConsoleApp.Domain.Exercise.Catalog
{
    // Description: Given a array of integers, calculate the sum of the int representation of the array with 1 and return a new array of int
    // Example: Parameter [20] - The method must return a new array representing 171410021 -> [2,1]
    // Example: Parameter [2,0] - The method must return a new array representing 171410021 -> [2,1]
    // Example: Parameter [29] - The method must return a new array representing 171410021 -> [3,0]
    // Example: Parameter [9,9,9] - The method must return a new array representing 171410021 -> [1,0,0,0]
    // Example: Parameter [1,7,14,10,0,20] - The method must return a new array representing 171410021 -> [1,7,1,4,1,0,0,2,1]
    // Example: Parameter [1,7,1,4,1,0,0,2,0] - The method must return a new array representing 171410021 -> [1,7,1,4,1,0,0,2,1]

    public class ArrayIntSumExercise : RealExercise
    {
        //private IParameter _parameter;

        //public ArrayIntSumExercise(IParameter parameter)
        //{
        //    this._parameter = parameter;
        //}

        public override object Execute(IParameter parameter)
        {
            base.ValidateParameter(parameter);

            var param1 = (parameter.Value as int[]);

            int result = 1;

            for (int i = 0; i < param1.Length; i++)
            {
                result += TransformInt(param1[i], (param1.Length - i - 1));
            }

            return result.ToString().Select(o => Convert.ToInt32(o)).ToArray();
        }

        private int TransformInt(int intValue, int decimalCaseCount)
        {
            return intValue * (Convert.ToInt32(Math.Pow(10, decimalCaseCount)));
        }
    }
}
