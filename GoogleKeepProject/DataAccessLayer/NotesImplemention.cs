using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entities;

namespace DataAccessLayer
{
    public class NotesImplemention : IKeepNotes
    {

        // create a refrence of noteDBContext class and instantiate inside constructor.
        private readonly NotesDBConText noteDbcontext;

        public NotesImplemention(NotesDBConText text)
        {
            noteDbcontext = text;
        }


        // this is implementation of all the methods of IkeepNotes.
        // Create a new Note.
        public int CreateNote(Notes notes)
        {
            noteDbcontext.notes.Add(notes);
            return noteDbcontext.SaveChanges();
        }


        // Get all the notes.
        public List<Notes> GetAllNotes()
        {
            return noteDbcontext.notes.ToList();
        }


        // Get the note by specific ID.
        public Notes GetNotesByID(int NoteID)
        {
            return noteDbcontext.notes.Find(NoteID);
        }


        // Remove the note by spesific ID.
        public int RemoveNote(int NoteID)
        {
            var selectnote = noteDbcontext.notes.Find(NoteID);
            noteDbcontext.Remove(selectnote);
            return noteDbcontext.SaveChanges();
        }

         
        // Update the pre existing note.
        public int UpdateNote(Notes notes)
        {
            noteDbcontext.Entry(notes).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return noteDbcontext.SaveChanges();
        }
    }
}