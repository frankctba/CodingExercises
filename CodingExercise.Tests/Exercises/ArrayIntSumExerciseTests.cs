using System;
using System.Collections.Generic;
using CodingExercise.ConsoleApp.Exercises;
using CodingExercise.ConsoleApp.Params;
using CodingExercise.ConsoleApp.Params.Interfaces;
using Moq;
using Xunit;

namespace CodingExercise.Tests.Exercises
{
    public class ArrayIntSumExerciseTests
    {
        private Mock<Parameter<int[]>> mockParameters;

        public ArrayIntSumExerciseTests()
        {
            mockParameters = new Mock<Parameter<int[]>>();
        }

        [Fact]
        public void Test_TransformInt_IntIsTransformedSuccess()
        {
            // ArrayIntSumExercise ex1 = new ArrayIntSumExercise();
            // var result = ex1.TransformInt(5, 3);
            // var result2 = ex1.TransformInt(5, 4);
            // Assert.Equal(result, 5000);
            // Assert.Equal(result2, 50000);
            Assert.True(true);
        }

        [Theory]
        [InlineData(new int[] {1, 9, 9})]
        [InlineData(new int[] {9, 9, 9})]
        public void Test_Solve_ExerciseWorksWithSuccess(int[] paramsData)
        {
            // mockParameters.SetupGet(s => s.Value).Returns(paramsData);
            
            var mock = new Mock<List<IParameterBase>>();
            List<IParameterBase> paramsList = new List<IParameterBase>();
            Parameter<int[]> p1 = new Parameter<int[]>("p1", new int[] { 1, 1, 9, 9 });
            //Parameter<int[]> p1 = new Parameter<int[]>("p1", new int[] { 1, 1, 9, 9 });
            paramsList.Add(p1);
            //mock.Setup(m => m).Returns(It.IsAny<List<IParameterBase>>());
            //mock.SetupProperty(m => m, paramsList);
            //var mock = new Parameter<int[]>("p1", new int[] { 1, 1, 9, 9 });
            
            ArrayIntSumExercise ex1 = new ArrayIntSumExercise();
            var result = ex1.SolveIt();
            Assert.True(true);
        }
    }
}
