namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //создаём новый экземпляр класса Functions
            var functions = new Functions();

            //Предлагаем пользователю выбрать номер массива
            var arrayNumber = functions.ReadNumber();

            //Производим валидацию ввода
            var validateInput = functions.ValidateInput(arrayNumber);

            //Если введен некорректный номер массива, то предлагаем ввести его снова.
            while(!validateInput)
            {
                arrayNumber = functions.ReadNumber();
                validateInput = functions.ValidateInput(arrayNumber);
            }

            //выбираем соответствующий масмив для дальнейшей обработки
            var workingArray = functions.GetArrayByNumber(arrayNumber);

            //обрабатываем массив в соответствии с условием задачи
            var result = functions.ProcessArray(workingArray);


            //отображаем полученный результат
            Console.WriteLine("Исходный массив:");
            functions.PrintStringArray(workingArray);
            Console.WriteLine("Обработанный массив:");
            functions.PrintStringArray(result);

        }
    }
}
