Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Порядок решения:
1. Создаем исходный массив.

    1.1 Объявляем массив, задаем размер с клавиатуры.

    1.2 Заполняем массив через цикл с клавиатуры.

2. Создаем метод принимающий на вход исходный массив и возвращающий массив из строк с 3 символами.

    2.1 Создаем массив того же размера, что и исходный (в него запишем нужные значения).

    2.2 Создаем цикл который по length строки в исходном массиве будет искать строки с 3 символами и записывать в новый массив увеличивая счетчик.

    2.3 Создаем новый массив размером счетчика, и записываем в него значения.
    
    2.4 Выводим получившийся массив на экран