﻿namespace BashSoft.Exceptions
{
    using System;

    public class DataNotInitializedException : Exception
    {
        private const string DataNotInitializedExceptionMessage =
            "The data structure must be initialised first in order to make any operations with it.";

        public DataNotInitializedException()
            : base(DataNotInitializedExceptionMessage)
        {
        }

        public DataNotInitializedException(string message)
            : base(message)
        {
        }
    }
}
