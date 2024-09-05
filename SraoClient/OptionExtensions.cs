using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SraoClient
{
    public static class OptionExtensions
    {
        public static U Match<T, U>(this Option<T> option,
            Func<T, U> onIsSome,
            Func<U> onIsNone) => option.IsSome(out var value) ? onIsSome(value) : onIsNone();
    }
}
