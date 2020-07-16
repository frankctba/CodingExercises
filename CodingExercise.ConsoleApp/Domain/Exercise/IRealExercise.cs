using CodingExercise.ConsoleApp.Domain.Parameter;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingExercise.ConsoleApp.Domain.Exercise
{
    public interface IRealExercise
    {
        object Execute(IParameter parameter);
    }
}
