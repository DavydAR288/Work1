using ClassList;

Console.Clear();
int lengthArray = 3;
string[] ArrayOriginal = ArrayMaster.CreateFromKeyboard(lengthArray);
ArrayMaster.PrintArray(ArrayOriginal, "Строчный массив: ");
Console.WriteLine();
int lengthString = 3;
string[] ArrayNew = ArrayMaster.CreateNewArray(ArrayOriginal, lengthString);
ArrayMaster.PrintArray(ArrayNew, $"Новый массив со словами ограниченными длинной в {lengthString} символа: ");