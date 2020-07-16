using CodingExercise.ConsoleApp.Domain.Parameter;
using System;
using System.Linq;

namespace CodingExercise.ConsoleApp.Factory
{
    public static class ParamFactory
    {
        public static ParameterValue CreateParameter(string parameterValue, ParameterTypeEnum parameterTypeEnum)
        {
            // not needed anymore
            //if (!ValidateType(parameterTypeEnum))
            //    throw new Exception("Invalid type");

            return new ParameterValue(ConvertStringToCorrespondentValue(parameterValue, parameterTypeEnum));
        }

        private static object ConvertStringToCorrespondentValue(string parameterValue, ParameterTypeEnum parameterTypeEnum)
        {
            if (parameterTypeEnum == ParameterTypeEnum.ArrayInt)
                return ConvertStringToArrayInt(parameterValue);

            if (parameterTypeEnum == ParameterTypeEnum.ArrayDouble)
                return ConvertStringToArrayDouble(parameterValue);

            return true;
        }

        private static int ConvertStringToInt(string value)
        {
            if (string.IsNullOrEmpty(value))
                throw new Exception("String value is empty and can not be converted to a Integer");

            int integerValue;
            var converted = Int32.TryParse(value, out integerValue);

            if (!converted)
                throw new Exception("String value can not be converted to a Integer");
            
            return integerValue;

        }

        private static int[] ConvertStringToArrayInt(string value)
        {
            if (string.IsNullOrEmpty(value))
                return Array.Empty<int>();

            //char[] charArray = value.ToCharArray();
            //int[] intArray = new int[charArray.Length];

            //for(var index = 0; index < charArray.Length; index++)
            //{
            //    var singleChar = charArray[index];
            //    var converted = Int32.TryParse(singleChar.ToString(), out int integerValue);
            //    if (!converted)
            //        throw new Exception("String value can not be converted to Array of Integer");

            //    intArray[index] = integerValue;
            //}

            string[] splitted = value.Split(' ');
            int[] intArray = new int[splitted.Length];

            for (int i = 0; i < splitted.Length; i++)
            {
                intArray[i] = int.Parse(splitted[i]);
            }

            return intArray;
        }

        private static double[] ConvertStringToArrayDouble(string value)
        {
            if (string.IsNullOrEmpty(value))
                return Array.Empty<double>();

            char[] charArray = value.ToCharArray();
            double[] doubleArray = new double[charArray.Length];

            for (var index = 0; index < charArray.Length; index++)
            {
                var singleChar = charArray[index];
                var converted = Double.TryParse(singleChar.ToString(), out double doubleValue);
                if (!converted)
                    throw new Exception("String value can not be converted to Array of Double");

                doubleArray[index] = doubleValue;
            }

            return doubleArray;
        }
    }
}
