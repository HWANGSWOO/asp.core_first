using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Models;

namespace App.Data.Repositories
{
    public class NoteRepository : INoteRepository
    {
        private readonly AppContext _context;
        public NoteRepository(AppContext context)
        {
            _context = context;
        }
        public void AddNote(Note note)
        {
            _context.Notes.Add(note);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
        public IEnumerable<Note> GetAllNotes()
        {
            var result = _context.Notes.ToList();
            return result;
        }
        public Note GetNotes(int NoteNo)
        {
            var result = _context.Notes.Find(NoteNo);
            return result;
        }
    }
}
