// ReSharper disable InconsistentNaming

using System;
using SharpnYNAB.Schema.Types;

namespace SharpnYNAB.Schema
{
    public class Entity
    {
        public Guid id { get; set; }
        public bool is_tombstone { get; set; }
    }
}