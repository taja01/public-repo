using System;

namespace SeleniumWebDriverDemo
{
    public class TestDataException : Exception
    {
        public TestDataException(string message) : base(message)
        {
        }

        public TestDataException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}