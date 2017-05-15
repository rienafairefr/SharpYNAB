using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;
using SharpYNAB.Annotations;

namespace SharpYNAB.Schema.Roots
{
    public interface IRootObj
    {
        Knowledge Knowledge { get; set; }
        int Size { get; }
    }

    public abstract class RootObj : IRootObj, INotifyPropertyChanged
    {
        [JsonIgnore]
        public int Id { get; set; }
        [JsonIgnore]
        public Knowledge Knowledge { get; set; } = new Knowledge();
        [JsonIgnore]
        public abstract int Size { get; }
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}