using System;
using System.Collections.Generic;
using System.Text;

namespace GKBusinessLayer.CustomExceptions
{
    public class NoteAlreadyExistException : ApplicationException
    {
        public NoteAlreadyExistException() { }
        public NoteAlreadyExistException(string Message) : base(Message) { }
    }
}
