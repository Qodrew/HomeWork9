Console.Write("Введите число: ");
int num64 = int.Parse(Console.ReadLine());

void PrintNto1 (int inputNum) {
    if (inputNum < 0) System.Console.WriteLine("Введено не натуральное число");
    if (inputNum == 0) return;
    Console.Write($"{inputNum} ");
    PrintNto1(inputNum - 1); 
}
PrintNto1(num64);
