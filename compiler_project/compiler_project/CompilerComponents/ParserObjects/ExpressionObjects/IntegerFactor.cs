﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compiler6083Project.ParserClasses.ExpressionObjects
{
    class IntegerFactor : NumberFactor
    {
        public int Value { get; set; }
    }
}