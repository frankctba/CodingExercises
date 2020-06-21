using System.Collections.Generic;
using CodingExercise.ConsoleApp.Exercises.Interfaces;
using CodingExercise.ConsoleApp.Params.Interfaces;

namespace CodingExercise.ConsoleApp.Exercises
{
    public abstract class Exercise<T> : IExercise<T>
    {
        /*
        private List<IParameter> _params = new List<IParameter>();
        
        public Exercise()
        {
            this.CreateParams();
        }

        public List<IParameter> Params
        {
            get
            {
                return _params;
            }
        }

        public abstract void CreateParams();

        public abstract void ValidateParams();

        public abstract void AssignValueParams(List<IParameter> paramValues);

        public abstract TResultType SolveIt();
        */
        public int Id { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        public string Name { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }
}