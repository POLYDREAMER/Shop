using System;
using System.Linq;
using System.Collections.Generic;
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public double Price { get; set; }
}
class Program
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>
{
new Product { Id = 1, Name = "Ноутбук", Category = "Електронiка", Price = 1200 },
new Product { Id = 2, Name = "Футболка", Category = "Одяг", Price = 20 },
new Product { Id = 3, Name = "Шоколадка", Category = "Їжа", Price = 2.5 },
new Product { Id = 4, Name = "Смартфон", Category = "Електронiка", Price = 800 },
new Product { Id = 5, Name = "Джинси", Category = "Одяг", Price = 50 },
new Product { Id = 6, Name = "Морозиво", Category = "Їжа", Price = 3 },
new Product { Id = 7, Name = "Телевiзор", Category = "Електронiка", Price = 1500 },
new Product { Id = 8, Name = "Кросiвки", Category = "Взуття", Price = 80 },
new Product { Id = 9, Name = "Пiча", Category = "Їжа", Price = 10 },
new Product { Id = 10, Name = "Монiтор", Category = "Електронiка", Price = 300 },
new Product { Id = 11, Name = "Свiтшот", Category = "Одяг", Price = 35 },
new Product { Id = 12, Name = "Книга", Category = "Книги", Price = 15 },
new Product { Id = 13, Name = "Браслет", Category = "Прикраси", Price = 25 },
new Product { Id = 14, Name = "Чайник", Category = "Побутова технiка", Price = 40 },
new Product { Id = 15, Name = "Батонцик", Category = "Їжа", Price = 1.5 },
new Product { Id = 16, Name = "Мишка", Category = "Електронiка", Price = 10 },
new Product { Id = 17, Name = "Портфель", Category = "Аксесуари", Price = 70 },
new Product { Id = 18, Name = "Спортивний костюм", Category = "Спорт", Price = 100 },
new Product { Id = 19, Name = "Кавоварка", Category = "Побутова технiка", Price = 60 },
new Product { Id = 20, Name = "Годинник", Category = "Прикраси", Price = 120 }
};
        //Вивід усього списку
        foreach (var product in products)
        {
            Console.WriteLine($"ID: {product.Id}, Назва: {product.Name}, Категорiя: {product.Category}, Цiна: {product.Price}");
        }



        //Завдання 1
        var electronics = products.Where(p => p.Category == "Електронiка").ToList();
        Console.WriteLine("");
        Console.WriteLine("Завдання 1: вибрати товари категорiї 'єлектронiка'");
        foreach (var product in electronics)

        {
            Console.WriteLine($"ID: {product.Id}, Назва: {product.Name}, Категорiя: {product.Category}, Цiна: {product.Price}");
        }


        //Завдання 2
        var mostExpensiveProduct = products.OrderByDescending(p => p.Price).First();
        Console.WriteLine("");
        Console.WriteLine("Завдання 2: обрати найдорожчий товар");
        Console.WriteLine($"Найдорожчий товар: ID: {mostExpensiveProduct.Id}, Назва: {mostExpensiveProduct.Name}, Категорiя: {mostExpensiveProduct.Category}, Цiна: {mostExpensiveProduct.Price}");


        //Завдання 3
        double totalCost = products.Sum(p => p.Price);
        Console.WriteLine("");
        Console.WriteLine("Завдання 3: сума усiх товарiв");
        Console.WriteLine($"{totalCost}");


        //Завдання 4
        var sortedProducts = products.OrderBy(p => p.Price).ToList();
        Console.WriteLine("");
        Console.WriteLine("Завдання 4: вiдсортувати товари за цiною у порядку зростання");
        foreach (var product in sortedProducts)
        {
            Console.WriteLine($"ID: {product.Id}, Назва: {product.Name}, Категорiя: {product.Category}, Цiна: {product.Price}");
        }

        //Завдання 5
        var uniqueCategories = products.Select(p => p.Category).Distinct().ToList();
        Console.WriteLine("");
        Console.WriteLine("Завдання 5: вибрати унiкальнi категорiї товару");
        foreach (var category in uniqueCategories)
        {
            Console.WriteLine(category);
        }

        //Завдання 6
        var productCountByCategory = products.GroupBy(p => p.Category)
                                             .Select(g => new { Category = g.Key, Count = g.Count() })
                                             .ToList();
        Console.WriteLine("");
        Console.WriteLine("Завдання 6: Знайти кiлькiсть товарiв у кожнiй категорiї");
        foreach (var item in productCountByCategory)
        {
            Console.WriteLine($"Категорiя: {item.Category}, Кiлькiсть товарiв: {item.Count}");
        }

        //Завдання 7
        var productsStartingWithS = products.Where(p => p.Name.StartsWith("С")).ToList();
        Console.WriteLine("");
        Console.WriteLine("Завдання 7: Вибрати товари з назвами, якi починаються на букву 'С'");
        foreach (var product in productsStartingWithS)
        {
            Console.WriteLine($"ID: {product.Id}, Назва: {product.Name}, Категорiя: {product.Category}, Цiна: {product.Price}");
        }


        //Завдання 8
        double averagePrice = products.Average(p => p.Price);
        Console.WriteLine("");
        Console.WriteLine("Завдання 8: знайти середню цiну товарiв");
        Console.WriteLine($"Середня цiна товарiв: {averagePrice}");


        //Завдання 9
        var cheapProducts = products.Where(p => p.Price < 50).ToList();
        Console.WriteLine("");
        Console.WriteLine("Завдання 9: Вибрати товари, цiна яких менше 50");
        foreach (var product in cheapProducts)
        {
            Console.WriteLine($"ID: {product.Id}, Назва: {product.Name}, Категорiя: {product.Category}, Цiна: {product.Price}");
        }


        //Завдання 10
        int expensiveProductCount = products.Count(p => p.Price > 100);
        Console.WriteLine("");
        Console.WriteLine("Завдання 10: Вибрати товари, цiна яких бiльше 100");
        Console.WriteLine($"{expensiveProductCount}");


        //Завдання 11
        var firstFiveProducts = products.Take(5).ToList();
        Console.WriteLine("");
        Console.WriteLine("Завдання 11: Вибрати товари перщi 5 товарiв");
        foreach (var product in firstFiveProducts)
        {
            Console.WriteLine($"ID: {product.Id}, Назва: {product.Name}, Категорiя: {product.Category}, Цiна: {product.Price}");
        }


        //Завдання 12
        var lastProduct = products.Last();
        Console.WriteLine("");
        Console.WriteLine("Завдання 12: Повернути останнiй тиовар");
        Console.WriteLine($"ID: {lastProduct.Id}, Назва: {lastProduct.Name}, Категорiя: {lastProduct.Category}, Цiна: {lastProduct.Price}");


        //Завдання 13
        var foodProducts = products.Where(p => p.Category == "Їжа").OrderBy(p => p.Price).ToList();
        Console.WriteLine("");
        Console.WriteLine("Завдання 13: Обрати їжу та вiдсортувати за цiною у зростаннi");
        foreach (var product in foodProducts)
        {
            Console.WriteLine($"ID: {product.Id}, Назва: {product.Name}, Категорiя: {product.Category}, Цiна: {product.Price}");
        }


        //Завдання 14
        var productNamesInUpperCase = products.Select(p => p.Name.ToUpper()).ToList();
        Console.WriteLine("");
        Console.WriteLine("Завдання 14: Повернути iмена товарiв в верхньому регiстрi");
        foreach (var name in productNamesInUpperCase)
        {
            Console.WriteLine(name);
        }


        //Завдання 15
        var productsInRange = products.Where(p => p.Price >= 10 && p.Price <= 100).ToList();
        Console.WriteLine("");
        Console.WriteLine("Завдання 15: Повернути товари цiна яких бiльше 10 та менше 100");
        foreach (var product in productsInRange)
        {
            Console.WriteLine($"ID: {product.Id}, Назва: {product.Name}, Категорiя: {product.Category}, Цiна: {product.Price}");
        }


        //Завдання 16
        var cheapestProduct = products.OrderBy(p => p.Price).First();
        Console.WriteLine("");
        Console.WriteLine("Завдання 16: Знайти найменшу цiну серед товарiв");
        Console.WriteLine($"ID: {cheapestProduct.Id}, Назва: {cheapestProduct.Name}, Категорiя: {cheapestProduct.Category}, Цiна: {cheapestProduct.Price}");


        //Завдання 17
        var coffeeProducts = products.Where(p => p.Name.Contains("Кава")).ToList();
        Console.WriteLine("");
        Console.WriteLine("Завдання 17: Вибрати товари, що мiстять слово 'Кава' в назвi.");
        Console.WriteLine("(Такого товару немає)");
        foreach (var product in coffeeProducts)
        {
            Console.WriteLine($"ID: {product.Id}, Назва: {product.Name}, Категорiя: {product.Category}, Цiна: {product.Price}");

        }


        //Завдання 18
        int totalProductCount = products.Count();
        Console.WriteLine("");
        Console.WriteLine("Завдання 18: Загальна кiлькiсть товарiв");
        Console.WriteLine($"{totalProductCount}");


        //Завдання 19
        var productWithSmallestId = products.OrderBy(p => p.Id).First();
        Console.WriteLine("");
        Console.WriteLine("Завдання 19: Товар з найменшим ID");
        Console.WriteLine($"ID: {productWithSmallestId.Id}, Назва: {productWithSmallestId.Name}, Категорiя: {productWithSmallestId.Category}, Цiна: {productWithSmallestId.Price}");


        //Завдання 20
        var singleWordProducts = products.Where(p => !p.Name.Contains(" ")).ToList();
        Console.WriteLine("");
        Console.WriteLine("Завдання 20: Вибрати товари, назви яких мiстять лише одне слово.");
        foreach (var product in singleWordProducts)
        {
            Console.WriteLine($"ID: {product.Id}, Назва: {product.Name}, Категорiя: {product.Category}, Цiна: {product.Price}");
        }

    }
}

