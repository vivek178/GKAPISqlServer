using Entities;
using System.Collections.Generic;

namespace DataAccessLayer
{
    /// <summary>
    /// Inteface for Accessing properties of Notes class.
    /// </summary>
    public interface IKeepNotes
    {
        int CreateNote(Notes notes);

        int RemoveNote(int NoteID);

        int UpdateNote(Notes notes);

        Notes GetNotesByID(int NoteID);

        List<Notes> GetAllNotes();
    }
}
