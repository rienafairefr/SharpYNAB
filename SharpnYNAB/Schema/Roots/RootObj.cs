using System.Collections.Generic;

namespace SharpnYNAB.Schema.Roots
{
    public interface IRootObj
    {
        Knowledge knowledge { get; set; }
    }

    public abstract class RootObj : IRootObj
    {
        public Knowledge knowledge { get; set; } = new Knowledge();
    }
}