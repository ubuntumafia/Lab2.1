using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Введите значения для базового класса:");

        bool field1 = ReadBoolean("Введите значение для Field1 (true/false): ");
        bool field2 = ReadBoolean("Введите значение для Field2 (true/false): ");

        // Создание объекта базового класса
        BaseClass baseObj = new BaseClass(field1, field2);
        Console.WriteLine(baseObj);

        // Вычисление и вывод отрицания дизъюнкции
        bool negationDisjunctionResult = baseObj.NegationDisjunction();
        Console.WriteLine("Отрицание дизъюнкции: " + negationDisjunctionResult);

        Console.WriteLine("\nДочерний класс:\n");

        // Создание объекта дочернего класса
        DerivedClass derivedObj = new DerivedClass(field1, field2);
        var (conjunction, disjunction, implication) = derivedObj.PerformOperations();

        Console.WriteLine("Результаты операций:");
        Console.WriteLine("Конъюнкция: " + string.Join("", conjunction));
        Console.WriteLine("Дизъюнкция: " + string.Join("", disjunction));
        Console.WriteLine("Следование: " + string.Join("", implication));
    }

    // Метод для безопасного чтения логического значения
    private static bool ReadBoolean(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            if (bool.TryParse(input, out bool result))
            {
                return result;
            }
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите true или false.");
        }
    }
}
