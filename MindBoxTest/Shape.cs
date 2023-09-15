using System;

namespace MindBoxTest
{
    //Для добавления новой фигуры наследуемся от Shape
    public abstract class Shape : IHaveSquare 
    {
        public abstract double CalculateSquare();
    }
}
