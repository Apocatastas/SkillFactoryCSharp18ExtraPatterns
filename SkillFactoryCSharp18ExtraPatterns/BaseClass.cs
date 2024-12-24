using System;
namespace BuilderTask
{
    /// <summary>
    /// Базовый класс прототип
    /// </summary>
    abstract class BaseClass
    {
        public int Id { get; }
        public BaseClass(int id)
        {
            Id = id;
        }

        //  Метод для получения свойства объекта
        public void GetId()
        {
            Console.WriteLine($"Создан объект с Id {Id}");
        }

        // метод для клонирования
        public abstract BaseClass Clone();
    }
}

