using ClassList;

Console.Clear();
int lengthArray = 6; // длина строчного массива
string[] ArrayOriginal = ArrayMaster.CreateFromKeyboard(lengthArray);
Console.WriteLine();
ArrayMaster.PrintArray(ArrayOriginal, "Строчный массив: ");
int lengthString = 3; // ограничение длины слова
string[] ArrayNew = ArrayMaster.CreateNewArray(ArrayOriginal, lengthString);
ArrayMaster.PrintArray(ArrayNew, $"Новый массив со словами ограниченными длиной в {lengthString} символа: ");