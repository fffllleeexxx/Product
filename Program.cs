using Newtonsoft.Json;
using Test.Product;


List<Products> list = new List<Products>();

while (true)
{
    Console.WriteLine("Напишите команду");
    string command = Console.ReadLine();

    if (command == "Добавить товар")
    {
        Console.WriteLine("Напиши тип продукта");
        string type = Console.ReadLine();

        if (type == "Еда" || type == "Food")
        {
            Console.WriteLine("Напишите название товара, его цену, вес, является ли он хрупким, объём");
            string name = Console.ReadLine();
            int count = Convert.ToInt32(Console.ReadLine());
            int weight = Convert.ToInt32(Console.ReadLine());
            bool fragility = Convert.ToBoolean(Console.ReadLine());
            int volume = Convert.ToInt32(Console.ReadLine());
            Food a = new Food(name, count, weight, fragility, volume);
            list.Add(a);
        }
        else if (type == "Одежда" || type == "Clothes")
        {
            Console.WriteLine("Напишите название товара, его цену");
            string name = Console.ReadLine();
            int count = Convert.ToInt32(Console.ReadLine());
            Clothes a = new Clothes(name, count);
            list.Add(a);
        }
        else
        {
            Console.WriteLine("Нет такого типа");
        }

    }
    else if (command == "Перезаписать")
    {
        foreach (Products p in list)
        {
            string json = JsonConvert.SerializeObject(list);
            Console.WriteLine(json);
        }
    }
    else if (command == "Сортировать")
    {
        Console.WriteLine("Как вы хотите сортировать:по типу или по цене?");
        string sort = Console.ReadLine();
        if (sort == "по цене")
        {
            BubbleSort(list);
        }
        else if (sort == "по типу")
        {
            TypeSort(list);
        }
        else
        {
            Console.WriteLine("Нет такого сортировки");
        }
    }
    else
    {
        Console.WriteLine("Нет такой команды");
    }
}

static void Swap(Products e1, Products e2)
{
    var temp = e1;
    e1 = e2;
    e2 = temp;
}

static void BubbleSort(List<Products> _list)
{
    int len = _list.Count;
    for (int i = 1; i < len; i++)
    {
        for (int j = 0; j < len - i; j++)
        {
            if (_list[j].count > _list[j + 1].count)
            {
                Swap(_list[j], _list[j + 1]);
            }
        }
    }

    foreach (Products p in _list)
    {
        Console.WriteLine(p);
    }
}

static void TypeSort(List<Products> _list)
{
    for (int i = 1; i < _list.Count; i++)
    {
        for (int j = 0; j < _list.Count; j++)
        {
            if (_list[j].GetType() == typeof(Food) && _list[j + 1].GetType() == typeof(Clothes))
            {
                Swap(_list[j], _list[j + 1]);
            }
        }
    }

    foreach (Products p in _list)
    {
        Console.WriteLine(p);
    }
}
