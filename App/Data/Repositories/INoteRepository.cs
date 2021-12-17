using System.Collections.Generic;
using App.Models;

namespace App.Data.Repositories
{
    public interface INoteRepository
    {
        void AddNote(Note note);
        IEnumerable<Note> GetAllNotes();
        Note GetNotes(int NoteNo);
        void Save();
    }
}