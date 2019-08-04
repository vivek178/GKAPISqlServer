using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public interface IKeepNotes
    {
        int CreateNote(Notes notes);

        int RemoveNote(int NoteID);

        int UpdateNote(Notes notes);

        Notes GetNotesByID(int NoteID);

        List<Notes> GetAllNotes();
    }
}
