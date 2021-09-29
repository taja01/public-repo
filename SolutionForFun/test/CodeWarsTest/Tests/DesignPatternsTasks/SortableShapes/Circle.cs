using System;

namespace CodeWarsTests.DesignPatternsTasks.SortableShapes
{
    class Circle : Shape
    {
        public Circle(double radius)
        {
            Area = Math.PI * radius * radius;
        }
    }
}
