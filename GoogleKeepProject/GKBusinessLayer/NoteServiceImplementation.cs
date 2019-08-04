using DataAccessLayer;
using Entities;
using GKBusinessLayer.CustomExceptions;
using System.Collections.Generic;

namespace GKBusinessLayer
{
    public class NoteServiceImplementation : IKeepNoteService
    {

        // Create a refrence of DataAccessLayer and intialize it.
        private readonly IKeepNotes keepNotes;

        // Initilaize IKeepNote.
        public NoteServiceImplementation(IKeepNotes keep)
        {
            keepNotes = keep;
        }


        // create a Note in service.
        public int CreateNote(Notes notes)
        {
            var result = keepNotes.GetNotesByID(notes.NoteID);
            if (result == null)
            {
                return keepNotes.CreateNote(notes);
            }
            else
            {
                throw new NoteAlreadyExistException("The user is already Exists in database");
            }
        }


        // get all the Notes in Service.
        public List<Notes> GetAllNotes()
        {
            return keepNotes.GetAllNotes();
        }


        // Get the Notes by Specific ID.
        public Notes GetNotesByID(int NoteID)
        {
            var result = keepNotes.GetNotesByID(NoteID);
            if (result == null)
            {
                throw new NotesNotFoundException("Notes Not found");
            }
            else
            {
                return result;
            }
        }


        // Remove a  Specific Note.
        public int RemoveNote(int NoteID)
        {
            var result = keepNotes.GetNotesByID(NoteID);
            if (result == null)
            {
                throw new NotesNotFoundException("Notes Not found");
            }
            else
            {
                return keepNotes.RemoveNote(NoteID);
            }
        }


        // Update a specific notes.
        public int UpdateNote(Notes notes)
        {
            var result = keepNotes.GetNotesByID(notes.NoteID);
            if (result == null)
            {
                throw new NotesNotFoundException("Notes Not found");
            }
            else
            {
                result.Title = notes.Title;
                result.Text = notes.Text;
                return keepNotes.UpdateNote(result);
            }
        }
    }
}
