using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace OOPLabs
{
    class BaseCustomException : Exception
    {
        public BaseCustomException()
        {
        }
    }

    class WrongNeighbourhoodException : BaseCustomException
    {
        public WrongNeighbourhoodException()
        {
            int[] aa = null;
            Debug.Assert(aa != null, "Values array cannot be null");
        }
    }

    class EmptyStringException : WrongNeighbourhoodException
    {
        public EmptyStringException()
        {
        }
    }

    class InvalidIndexException : Exception
    {
        public InvalidIndexException()
        {
        }
    }
}
