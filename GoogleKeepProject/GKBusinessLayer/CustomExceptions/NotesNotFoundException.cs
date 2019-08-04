using System;
using System.Collections.Generic;
using System.Text;

namespace GKBusinessLayer.CustomExceptions
{
    public class NotesNotFoundException : ApplicationException
    {
        public NotesNotFoundException() { }
        public NotesNotFoundException( string message) : base(message) { }
    }
}
