namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var functions = new Functions();

            var arrayNumber = functions.ReadNumber();

            var validateInput = functions.ValidateInput(arrayNumber);

            while(!validateInput)
            {
                arrayNumber = functions.ReadNumber();
                validateInput = functions.ValidateInput(arrayNumber);
            }

            var workingArray = functions.GetArrayByNumber(arrayNumber);

            var result = functions.ProcessArray(workingArray);

            Console.WriteLine("Исходный массив:");
            functions.PrintStringArray(workingArray);
            Console.WriteLine("Обработанный массив:");
            functions.PrintStringArray(result);

        }
    }
}
