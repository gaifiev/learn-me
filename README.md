# **Итоговая проверочная работа по I четверти**
# Задания:
1. Создать репозиторий на GitHub.
2. Нарисовать блок-схему алгоритма.
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md).
4. Написать программу, решающую поставленную задачу.
5. Использовать контроль версий в работе над этим небольшим проектом (минимум 3-4 этапа разных коммитов)
# Задача:
*Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.* 

```
Например:   ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
            ["1234", "1567, "-2", "computer science"] -> [-2]
            ["Russia", "Denmark", "Kazan"] -> []
```
# Решение задачи:
Создаем два строковых массива, первый массив заполнен строками, второй массив с выделением памяти - размером равен количественному счетчику элементов. Далее, в цикле проходим по всем элементам массива, равен длине или меньше 3 символа и во втором массиве повторно проходит по цикле и равен длине или меньше 3 символа. После завершения подсчета печатает посчитанный массив в консоле.