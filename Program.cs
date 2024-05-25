// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] IngresarСadenasAMatriz()
{
    Console.WriteLine("Введите количество строк: ");
    int count = int.Parse( Console.ReadLine());

    string[] MatrizDeTrabajo = new string[count];

    Console.WriteLine($"Введите {count} строк(у) (после ввода каждой нажмите ENTER):");
    for (int i = 0; i < count; i++)
    {
        MatrizDeTrabajo[i] = Console.ReadLine();

    }

    return MatrizDeTrabajo;
}

string[] CrearCadenasDeMatrizDeMenosDe3(string[] MatrizDeTrabajo)
{
    int count = 0;
    foreach (string item in MatrizDeTrabajo)
    {
        if (item.Length <= 3)
        {
            count++;
        }
    }
    string[] result = new string[count];
    int i = 0;
    foreach (string item in MatrizDeTrabajo)
    {
        if (item.Length <= 3)
        {
            result[i] = item;
            i++;
        }
    }

    return result;
}

string ImprimirMatriz(string[] MatrizDeTrabajo)
{
    string arString = "[";
    for (int i = 0; i < MatrizDeTrabajo.Length; i++)
    {   
        arString += $"\"{MatrizDeTrabajo[i]}\"";
        if (i < MatrizDeTrabajo.Length - 1)
        {
            arString += ", ";
        }
    }
    arString += "]";
    return arString;
}

string[] MatrizDeTrabajo = IngresarСadenasAMatriz();
string[] result = CrearCadenasDeMatrizDeMenosDe3(MatrizDeTrabajo);
string firstArray = ImprimirMatriz(MatrizDeTrabajo);
string secondArray = ImprimirMatriz(result);

Console.WriteLine(firstArray + " -> " + secondArray);
