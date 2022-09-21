// Задача: написать программу, которая из имеющегося массива строк формирует массив из строк, длина который меньше либо равно 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] arr = new string[4] {"hello", "2", "world", ":-)"};
string[] new_arr = new string[0];

// выводим что было до
Console.WriteLine("[{0}]", string.Join(", ", arr));

// выводим что стало после
Console.WriteLine("[{0}]", string.Join(", ", FillArray(arr, new_arr)));

string[] FillArray(string[] arrFrom, string[] arrTo) 
{
    for (int i = 0; i < arrFrom.Length; i++) {
        if (arrFrom[i].Length <= 3) {
            arrTo = arrTo.Append(arrFrom[i]).ToArray();
        }
    }

    return arrTo;
}