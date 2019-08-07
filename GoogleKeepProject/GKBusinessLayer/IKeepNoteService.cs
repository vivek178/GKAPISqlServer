using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GKBusinessLayer
{
    public interface IKeepNoteService
    {
        int CreateNote(Notes notes);

        List<Notes> GetAllNotes();

        Notes GetNotesByID(int NoteID);

        int RemoveNote(int NoteID);

        int UpdateNote(Notes notes);
    }
}
