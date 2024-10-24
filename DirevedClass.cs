using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DerivedClass : BaseClass
{
    // Значения по умолчанию
    private string[] defaultValues1 = { "0", "0", "1", "1" };
    private string[] defaultValues2 = { "0", "1", "0", "1" };

    public DerivedClass(bool f1, bool f2) : base(f1, f2) { }

    // Метод для выполнения логических операций
    public (string[], string[], string[]) PerformOperations()
    {
        var (field1, field2) = GetFields();

        // Инверсия значений, если поле равно false
        if (!field1) InvertValues(ref defaultValues1);
        if (!field2) InvertValues(ref defaultValues2);

        // Выполнение операций
        var conjunction = new string[4];
        var disjunction = new string[4];
        var implication = new string[4];

        for (int i = 0; i < 4; i++)
        {
            bool val1 = defaultValues1[i] == "1";
            bool val2 = defaultValues2[i] == "1";

            conjunction[i] = (val1 && val2) ? "1" : "0";
            disjunction[i] = (val1 || val2) ? "1" : "0";
            implication[i] = (!val1 || val2) ? "1" : "0";
        }

        return (conjunction, disjunction, implication);
    }

    // Метод для инверсии значений
    private void InvertValues(ref string[] values)
    {
        for (int i = 0; i < values.Length; i++)
        {
            values[i] = values[i] == "1" ? "0" : "1";
        }
    }
}