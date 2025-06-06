﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTracker.Shared.Exceptions
{
    public class EntityNotFoundException : Exception
    {
        public EntityNotFoundException() :base(){}
        public EntityNotFoundException(string message) : base(message) {}
        public EntityNotFoundException(string message, Exception innerException) : base(message, innerException){ }
    }
}
