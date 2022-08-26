using Nop.Data.Mapping;
using System;
using System.Collections.Generic;

namespace Nop.Plugin.BS23.ShowSomethingBeforeNews.Mapping
{
    public partial class NameCompatibility : INameCompatibility
    {
        public Dictionary<Type, string> TableNames => new Dictionary<Type, string>();

        public Dictionary<(Type, string), string> ColumnName => new Dictionary<(Type, string), string>();
    }
}