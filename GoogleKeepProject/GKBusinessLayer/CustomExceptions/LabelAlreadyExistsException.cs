using System;
using System.Collections.Generic;
using System.Text;

namespace GKBusinessLayer.CustomExceptions
{
    public class LabelAlreadyExistsException : ApplicationException
    {
        public LabelAlreadyExistsException() { }
        public LabelAlreadyExistsException(string Message) : base(Message) { }
    }
}
