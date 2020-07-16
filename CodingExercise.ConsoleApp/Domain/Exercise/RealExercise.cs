using CodingExercise.ConsoleApp.Domain.Parameter;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingExercise.ConsoleApp.Domain.Exercise
{
    public abstract class RealExercise : IRealExercise
    {
        //protected Exercise exercise { get; set; }

        public abstract object Execute(IParameter parameter);

        public virtual void ValidateParameter(IParameter parameter)
        {
            //if (!parameter.GetType().IsTypeEqualToParameterTypeEnum(exercise.ParameterTypeEnum))
                //throw new Exception("Invalid parameter for this exercise");
        }
    }
}
