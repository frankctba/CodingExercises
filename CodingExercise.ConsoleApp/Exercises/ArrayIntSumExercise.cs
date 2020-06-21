using System;
using System.Collections.Generic;
using System.Linq;
using CodingExercise.ConsoleApp.Params;
using CodingExercise.ConsoleApp.Params.Interfaces;

namespace CodingExercise.ConsoleApp.Exercises
{
    public class ArrayIntSumExercise : Exercise<int[]>
    {
        // private List<IParameterBase> parameter;
        // public ArrayIntSumExercise(List<IParameterBase> parameter)
        // {
        //     this.parameter = parameter;
        // }

        // public override void CreateParams()
        // {
        //     // Parameter<int[]> param1 = new Parameter<int[]>("Array of integers");
        //     // Params.Add(param1);
        // }

        // public override void ValidateParams()
        // {
        //     if (Params == null)
        //         throw new Exception();

        //     if (Params.Count() <= 0)
        //         throw new Exception();
            
        //     if (Params[0].GetType() != typeof(int[]))
        //         throw new Exception();
        // }

        // public override void AssignValueParams(List<IParameter> paramValues)
        // {
        //     var param1 = (paramValues[0] as Parameter<int[]>);
        //     var param1Value = (paramValues[0] as Parameter<int[]>).Value;
        //     param1.Value = param1Value;
        //     Params[0] = param1;
        // }

        // public override int[] SolveIt()
        // {
        //     var param1 = (Params[0] as Parameter<int[]>).Value;

        //     int finalValue = 1;

        //     for(int i=0; i<param1.Length; i++)
        //     {
        //         finalValue += TransformInt(param1[i], (param1.Length-i-1) );
        //     }

        //     return finalValue.ToString().Select(o=> Convert.ToInt32(o)).ToArray();
        // }

        public int[] SolveIt()
        {
            // if (parameter == null)
            //     throw new Exception("Error! This exercise can not be solved. No parameters have been added");

            // var param1 = (parameter[0] as Parameter<int[]>).Value;
            //var param1 = parameter.Value;

            int finalValue = 1;

            // for(int i=0; i<param1.Length; i++)
            // {
            //     finalValue += TransformInt(param1[i], (param1.Length-i-1) );
            // }

            return finalValue.ToString().Select(o=> Convert.ToInt32(o)).ToArray();
        }

        public int TransformInt(int intValue, int decimalCaseCount)
        {
            return intValue * (Convert.ToInt32(Math.Pow(10, decimalCaseCount)));
        }
    }
}