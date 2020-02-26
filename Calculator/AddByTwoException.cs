using System;

namespace Calculator
{
    class AddByTwoException : Exception
    {
        public AddByTwoException()
            : base("Je ne veux pas de deux !")
        { }

        public AddByTwoException(string message)
            : base("Je ne veux pas de deux, voici pourquoi : " + message)
        { }

        public AddByTwoException(string message, Exception inner)
            : base("Je ne veux pas de deux, voici pourquoi : " + message + inner.Message, inner)
        { }
    }
}
