namespace ClassLibraryCalcApp
{
    public class Class1
    {
        public static float MathCalc(float num1,float num2, string operate)
        {
            switch (operate)
            {
                case "+":
                    return (num1 + num2);

                case "-":
                    return (num1 - num2);

                case "*":
                    return (num2 * num1);

                case "/":
                    return (num2 / num1);

                default:
                    return (0);
            }
        }

        }
}