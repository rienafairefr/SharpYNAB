// ReSharper disable InconsistentNaming

using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using SharpYNAB.Schema.Types;

namespace SharpYNAB.Schema
{
    public interface IEntity:INotifyPropertyChanged
    {
        Guid id { get; set; }
        bool is_tombstone { get; set; }
    }

    public class Entity:IEntity
    {
        public Guid id { get; set; }
        public bool is_tombstone { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}