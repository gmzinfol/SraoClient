﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SraoClient
{
    public struct Option<T>
    {
        public static Option<T> None => default;
        public static Option<T> Some(T value) => new Option<T>(value);
        readonly bool isSome;
        readonly T value;

        Option(T value)
        {
            this.value = value;
            isSome = this.value is object;
        }

        public bool IsSome(out T value)
        {
            value = this.value;
            return isSome;
        }
    }
}
