using System;
using System.Diagnostics.CodeAnalysis;

namespace CodeWarsTests.DesignPatternsTasks.SortableShapes
{
    abstract class Shape : IComparable<Shape>
    {

        public int CompareTo([AllowNull] Shape other)
        {
            if (other == null) return 1;

            return this.Area.CompareTo(other.Area);
        }

        public double Area { get; protected set; }
    }
}
