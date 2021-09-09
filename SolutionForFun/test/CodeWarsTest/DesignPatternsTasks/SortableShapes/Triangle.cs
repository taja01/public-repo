namespace CodeWarsTests.DesignPatternsTasks.SortableShapes
{
    class Triangle : Shape
    {
        public Triangle(double triangleBase, double height)
        {
            Area = (triangleBase * height) / 2;
        }
    }
}
