using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GKBusinessLayer
{
    public interface IKeepNoteService
    {
        int CreateNote(Notes notes);

        int RemoveNote(int NoteID);

        int UpdateNote(Notes notes);

        Notes GetNotesByID(int NoteID);

        List<Notes> GetAllNotes();
    }
}
