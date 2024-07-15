namespace PracticeVariable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 25;
            Console.WriteLine(age);
            float pi = 3.14f;
            Console.WriteLine(pi);
            double temperature = 36.6;
            double exponent = 10e5;
            Console.WriteLine(temperature);
            Console.WriteLine(exponent);
            char dollar = '$';
            Console.WriteLine(dollar);
            string word = "Hello";
            Console.WriteLine(word);

            byte variableByte = 25; // Positive only
            Console.WriteLine(variableByte); 
            sbyte sighnedByteVariable = -30; // Positive or negative 
            Console.WriteLine(sighnedByteVariable);
            short variableShort = -330; // Positive or negative
            Console.WriteLine(variableShort);
            ushort unsignedVariableShort = 330; // Positive only
            Console.WriteLine(unsignedVariableShort);
            long variableLong = -2551000000000000; // Positive only
            Console.WriteLine(variableLong);
            ulong unsighnedVariableLong = 33555; // Positive or negative
            Console.WriteLine(unsighnedVariableLong);

            char uniCode = '\u0043';
            Console.WriteLine(uniCode);
            char ascii = (char)65;
            Console.WriteLine(ascii);
        }
    }
}
