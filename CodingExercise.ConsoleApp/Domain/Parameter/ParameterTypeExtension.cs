using System;

namespace CodingExercise.ConsoleApp.Domain.Parameter
{
    public static class ParameterTypeExtension
    {
        public static bool IsTypeEqualToParameterTypeEnum(this Type type, ParameterTypeEnum parameterTypeEnum)
        {
            switch(parameterTypeEnum)
            {
                case ParameterTypeEnum.ArrayInt:
                    return (type == typeof(int[]));
                case ParameterTypeEnum.Int:
                    return (type == typeof(int));
                case ParameterTypeEnum.ArrayString:
                    return (type == typeof(string[]));
                case ParameterTypeEnum.String:
                    return (type == typeof(string));
                case ParameterTypeEnum.ArrayChar:
                    return (type == typeof(char[]));
                case ParameterTypeEnum.Char:
                    return (type == typeof(char));
                case ParameterTypeEnum.ArrayDouble:
                    return (type == typeof(double[]));
                case ParameterTypeEnum.Double:
                    return (type == typeof(double));
                default:
                    return false;
            }
        }

        //private static bool ValidateType(ParameterTypeEnum parameterTypeEnum)
        //{
        //    if (parameterTypeEnum == ParameterTypeEnum.ArrayInt)
        //        return true;
        //    if (parameterTypeEnum == ParameterTypeEnum.Int)
        //        return true;
        //    if (parameterTypeEnum == ParameterTypeEnum.String)
        //        return true;
        //    if (parameterTypeEnum == ParameterTypeEnum.ArrayString)
        //        return true;
        //    if (parameterTypeEnum == ParameterTypeEnum.Char)
        //        return true;
        //    if (parameterTypeEnum == ParameterTypeEnum.ArrayChar)
        //        return true;
        //    if (parameterTypeEnum == ParameterTypeEnum.Double)
        //        return true;
        //    if (parameterTypeEnum == ParameterTypeEnum.ArrayDouble)
        //        return true;

        //    return false;
        //}
    }
}
