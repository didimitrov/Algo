using System;

namespace _03.InvalidRangeException
{
    class InvalidRangeException<T> :ApplicationException
    {
        public T Start { get;private set; }
        public T End { get; private set; }

        public InvalidRangeException(string message, T end, T start) : base(message)
        {
            Start = start;
            End = end;
        }
    }
}
