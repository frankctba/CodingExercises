using System;
using System.Collections.Generic;
using System.Text;

namespace CodingExercise.ConsoleApp.Domain.Exercise
{
    public class ExerciseResult<T>
    {
        public bool Success { get; set; }
        public T ResultValue { get; set; }
    }
}
