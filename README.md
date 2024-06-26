# Описание

## Решаемая задача
> Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Примеры:
> [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]

> [“1234”, “1567”, “-2”, “computer science”] → [“-2”]

> [“Russia”, “Denmark”, “Kazan”] → []

## Разбор кода

Код представляет собой набор методов для работы с массивами строк:

IngresarСadenasAMatriz: Этот метод позволяет пользователю ввести определенное количество строк через консоль и сохранить их в массиве.

CrearCadenasDeMatrizDeMenosDe3: Этот метод принимает массив строк и создает новый массив, содержащий только те строки, длина которых меньше или равна 3 символам.

ImprimirMatriz: Этот метод принимает массив строк и возвращает его строковое представление.

## Как использовать

1. Вызовите метод IngresarСadenasAMatriz, чтобы ввести строки через консоль и сохранить их в массиве.
Вызовите метод 
2. CrearCadenasDeMatrizDeMenosDe3, чтобы получить новый массив, содержащий строки с длиной менее или равной 3 символам.
3. Для получения строкового представления массивов вызовите метод ImprimirMatriz.

## Пример использования кода:

```
string[] MatrizDeTrabajo = IngresarСadenasAMatriz();
string[] result = CrearCadenasDeMatrizDeMenosDe3(MatrizDeTrabajo);
string firstArray = ImprimirMatriz(MatrizDeTrabajo);
string secondArray = ImprimirMatriz(result);

Console.WriteLine(firstArray + " -> " + secondArray);


```
