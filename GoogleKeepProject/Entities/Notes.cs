using Newtonsoft.Json;
using System.Collections.Generic;

namespace Entities
{
    public class Notes
    {
        // defining properties for Notes.
        public int NoteID { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }

        // for one to many relationship.
        [JsonIgnore]
        public virtual ICollection<Label> labels  { get; set; }
    }
}
