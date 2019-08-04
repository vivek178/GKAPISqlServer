using System;
using System.Collections.Generic;
using System.Text;

namespace GKBusinessLayer.CustomExceptions
{
    public class LabelNotFoundExeception : ApplicationException
    {
        public LabelNotFoundExeception() { }
        public LabelNotFoundExeception(string Message) : base(Message) { }
    }
}
