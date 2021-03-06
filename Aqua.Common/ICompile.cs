﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aqua.Common.IR;

namespace Aqua.Common
{
    public interface ICompile
    {
        string LanguageName { get; }

        string[] FileExtensions { get; }

        Module Compile(string fileName);
    }
}
