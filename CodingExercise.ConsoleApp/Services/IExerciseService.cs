using CodingExercise.ConsoleApp.Exercises.Interfaces;

namespace CodingExercise.ConsoleApp.Services
{
    public interface IExerciseService
    {
        IExerciseBase GetExercises();
        string ExecuteExercise(IExerciseBase exercise);
    }
}