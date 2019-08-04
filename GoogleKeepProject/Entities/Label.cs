using Newtonsoft.Json;

namespace Entities
{
    public class Label
    {
        // properties for label.
        public int LabelID { get; set; }
        public string Description { get; set; }
        public int NoteID { get; set; }


        // for one to many relationship.
        [JsonIgnore]
        public virtual Notes note { get; set; }
    }
}
