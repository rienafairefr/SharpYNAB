using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using SharpnYNAB.Annotations;

namespace SharpnYNAB.Schema.Roots
{
    public interface IRootObj
    {
        Knowledge knowledge { get; set; }
        int Size { get; }
    }

    public abstract class RootObj : IRootObj, INotifyPropertyChanged
    {
        public Knowledge knowledge { get; set; } = new Knowledge();
        public abstract int Size { get; }
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}