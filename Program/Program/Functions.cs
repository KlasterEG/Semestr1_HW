using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Functions
    {
        //Массивы по условиям задачи
        private string[] array1 = ["Hello", "2", "world", ":-)"];
        private string[] array2 = ["1234", "1567", "-2", "computer science"];
        private string[] array3 = ["Russia", "Denmark", "Kazan"];


        /// <summary>
        /// Показываем пользователю предложение ввода номера массива и возвращаем введённый номер или 0, если введено не число
        /// </summary>
        public int ReadNumber()
        {
            Console.WriteLine("Выберите номер массива от 1 до 3: ");
            return int.Parse(Console.ReadLine() ?? "0");
        }


        /// <summary>
        /// Проверяем, попадает ли введённый номер в диапазон от 1 до 3
        /// </summary>
        public bool ValidateInput(int input)
        {
            return input > 0 && input < 4;
        }


        /// <summary>
        /// Возвращаем массив по запрошенному номеру
        /// </summary>
        public string[] GetArrayByNumber(int number)
        {
            return number switch
            {
                1 => array1,
                2 => array2,
                3 => array3,
                _ => [],
            };
        }


        /// <summary>
        /// Проверяем каждый элемент массива на соответствие условиям задачи и возвращаем новый результирующий массив с соответствующием элементами
        /// </summary>
        public string[] ProcessArray(string[] inputArray)
        {
            var result = new List<string>();

            foreach (var input in inputArray)
            {
                if (input.Length < 4)
                {
                    result.Add(input);
                }
            }

            return result.ToArray();
        }


        //Выводим массив на экран одной строкой через запятую
        public void PrintStringArray(string[] arrayForPrint)
        {
            var str = "[";

            for (int i = 0; i < arrayForPrint.Length; i++)
            {
                str = str + "\"" + arrayForPrint[i] + "\", ";
            }

            // если строка не пустая и её длина больше 2 символов, то убираем последние 2 символа, чтобы не отображать запятую в конце
            if (str.Length > 2)
            {
                str = str.Remove(str.Length - 2);
            }

            str += "]";

            Console.WriteLine(str.Trim());
        }
    }
}
