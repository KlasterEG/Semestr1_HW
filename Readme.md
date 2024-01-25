# Итоговая контрольная работа по основному блоку

## Алгоритм работы программы
Алгоритм работы размещён в файле **algorithm/Algorithm.drawio**. Работа программы заключается в следующем:
1. Ожидание ввода пользователем номера массива со строками.
2. Проверка введённого номера массива на попадание в диапазон 1-3. Если введено отличное от этого диапазона число, предлагать снова ввести номер массива.
3. Если выбран корректный номер массива, то массив под данным номером выбирается в качестве текущего рабочего массива.
4. Далее происходит поэлементный обход массива, в котором вычислятеся количество символов в элементе (строке). Если длина элемента меньше или равна 3, то элемент добавляется в результирующий массив.
5. После обхода всех элементов рабочего массива, результирующий массив выводится на экран для отображения пользователю.

## Код программы