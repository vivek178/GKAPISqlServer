using Entities;
using System.Collections.Generic;
using System.Linq;

namespace DataAccessLayer
{
    public class LabelImplementation : IKeepLabel
    {


        // create a refrence of noteDBContext class and instantiate inside constructor.
        private readonly NotesDBConText noteDbcontext;

        public LabelImplementation(NotesDBConText text)
        {
            noteDbcontext = text;
        }


        // this is implementation of all the methods of IkeepNotes.
        // Create a new Label.
        public int CreateLabel(Label label)
        {
            noteDbcontext.labels.Add(label);
            return noteDbcontext.SaveChanges();
        }


        // Get all List of Label.
        public List<Label> GetLabels()
        {
            return noteDbcontext.labels.ToList();
        }


        // Remove a specific Label.
        public int RemoveLabel(int LabelID)
        {
            var selectnote = noteDbcontext.labels.Find(LabelID);
            noteDbcontext.Remove(selectnote);
            return noteDbcontext.SaveChanges();
        }


        // Update a specific label.
        public int UpdateLabel(Label label)
        {
            noteDbcontext.Entry(label).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return noteDbcontext.SaveChanges();
        }
    }
}
