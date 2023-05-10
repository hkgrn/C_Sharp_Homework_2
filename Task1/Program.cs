// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите число: ");
string letter = Convert.ToString(Console.ReadLine());
int lenght = letter.Length;
int a = 0;

if (lenght == 5) {
 for (int i=0; i<2; i++) {
    if (letter[i] == letter [4-i]) {
    a = a + 1;
    };
 }
    if (a == 2) {
        Console.WriteLine ("Число - палиндром.");
    }
    else Console.WriteLine ("Число - не палиндром.");
}
else {
 Console.WriteLine("Вы ввели некорректное значение. Требуется пятизначное число.");
}