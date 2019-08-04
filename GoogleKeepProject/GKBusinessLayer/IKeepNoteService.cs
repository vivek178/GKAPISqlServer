using Entities;
using System.Collections.Generic;

namespace GKBusinessLayer
{
    /// <summary>
    /// Interface for Accessing the properties of Notes Class.
    /// </summary>
    public interface IKeepNoteService
    {
        int CreateNote(Notes notes);

        int RemoveNote(int NoteID);

        int UpdateNote(Notes notes);

        Notes GetNotesByID(int NoteID);

        List<Notes> GetAllNotes();
    }
}
