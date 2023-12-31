# Mindbox Библиотека AreaCalculator для вычисления площади фигур

 
Библиотека для вычисления площади фигур на C# предоставляет функциональность для расчета площади различных геометрических фигур с раширенными возможностями для треугольника. 

## Возможности

- Вычисление площади круга по заданному радиусу. [тут](./AreaCalculator/Implementations/Circle/Circle.cs)
- Вычисление площади треугольника по трем заданным сторонам. [тут](./AreaCalculator/Implementations/Triangle/Triangle.cs)
- Юнит-тесты для обеспечения точности вычислений. [тут](./AreaCalculatorUnitTests/Tests)
- Проверка, является ли заданный треугольник прямоугольным. [тут](./AreaCalculator/Implementations/Triangle/TriangleUtils.cs)
- Проверка, является ли заданный треугольник равносторонним. [тут](./AreaCalculator/Implementations/Triangle/TriangleUtils.cs)
- Простое расширение функциональности библиотеки путем добавления новых классов.

## Установка

Вы можете использовать эту библиотеку в своих проектах на C#, следуя этим шагам:

1. Клонируйте или загрузите этот репозиторий на свой компьютер.
2. Соберите проект с помощью вашей любимой среды разработки или командной строки.
3. Добавьте ссылку на сгенерированную сборку (`AreaCalculator.dll`) в ваш проект.

## Использование

Пример использования библиотеки для вычисления площади в вашем коде на C#:

```csharp
using System;
using AreaCalculator;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5.0);
            double circleArea = circle.CalculateArea();

            Triangle triangle = new Triangle(3.0, 4.0, 5.0);
            double triangleArea = triangle.CalculateArea();

            // TriangleUtils наследуется от Triangle и имеет расширенный фунционал
            TriangleUtils triangle1 = new TriangleUtils(3.0, 4.0, 5.0);
            double triangleArea1 = triangle1.CalculateArea();
            bool isRightTriangle = triangle1.IsRightTriangle();
            bool isIsoscelesTriangle = triangle1.IsIsoscelesTriangle();

        }
    }
}
```
# SQL Задача
```sql
CREATE TABLE Products (
	Id INT PRIMARY KEY,
	"Name" TEXT
);

INSERT INTO Products
VALUES
	(1, 'Les Enfants du capitaine Grant'),
	(2, 'Sukhoi Superjet 100 '),
	(3, 'Xiaomi');

CREATE TABLE Categories (
	Id INT PRIMARY KEY,
	"Name" TEXT
);

INSERT INTO Categories
VALUES
	(1, 'Book'),
	(2, 'Plane'),
	(3, 'Gift');

CREATE TABLE ProductCategories (
	ProductId INT FOREIGN KEY REFERENCES Products(Id),
	CategoryId INT FOREIGN KEY REFERENCES Categories(Id),
	PRIMARY KEY (ProductId, CategoryId)
);

INSERT INTO ProductCategories
VALUES
	(1, 1),
	(1, 3),
	(2, 2);

SELECT P."Name", C."Name"
FROM Products P
LEFT JOIN ProductCategories PC
	ON P.Id = PC.ProductId
LEFT JOIN Categories C
	ON PC.CategoryId = C.Id;
```
