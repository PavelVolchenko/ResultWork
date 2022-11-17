# Итогова проверочная работа.

## Задача. 
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

    ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
    ["1234", "1567", "-2", "computer science"] -> ["-2"]
    ["Russia", "Denmark", "Kazan"] -> []                                     

## Решение.
Первоначальный массив строк задается пользователем с клавиатуры. Перед этим пользователь задает размерность массива.

Сначала необходимо определить размерность результирующего массива, в который войдут элементы первоначального массива, длина строки которых не будет превышать трёх символов.

Далее первоначальный массив строк поочередно проверятся на условие поставленной задачи. Если длина строки элемента меньше или равняется трём символам, то такой элемент записывается в результирующий массив.

Вывод результирующего массива на экран.