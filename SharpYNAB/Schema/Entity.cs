using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace SharpYNAB.Schema
{
    public interface IEntity:INotifyPropertyChanged
    {
        Guid Id { get; set; }
        bool IsTombstone { get; set; }
    }

    public class Entity:IEntity
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }
        [JsonProperty("is_tombstone")]
        public bool IsTombstone { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}