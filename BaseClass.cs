using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BaseClass
{
    private bool field1;
    private bool field2;

    public BaseClass(bool f1, bool f2)
    {
        field1 = f1;
        field2 = f2;
    }

    // Конструктор копирования
    public BaseClass(BaseClass other)
    {
        field1 = other.field1;
        field2 = other.field2;
    }

    // Метод для получения значений полей
    public (bool, bool) GetFields()
    {
        return (field1, field2);
    }

    // Метод для инверсии полей
    public void InvertFields()
    {
        field1 = !field1;
        field2 = !field2;
    }

    // Метод для вычисления отрицания дизъюнкции
    public bool NegationDisjunction()
    {
        return !(field1 || field2);
    }

    // Перегрузка метода ToString()
    public override string ToString()
    {
        return $"Field1: {field1}, Field2: {field2}";
    }
}
