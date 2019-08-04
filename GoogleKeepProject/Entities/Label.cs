using Newtonsoft.Json;

namespace Entities
{
    public class Label
    {
        public int LabelID { get; set; }
        public string Description { get; set; }
        public int NoteID { get; set; }

        [JsonIgnore]
        public virtual Notes note { get; set; }
    }
}
