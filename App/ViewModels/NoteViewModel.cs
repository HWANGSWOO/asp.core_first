using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Models;

namespace App.ViewModels
{
    public class NoteViewModel
    {
        public Note Note { get; set; }
        public IEnumerable<Note> Notes { get; set; }
    
    }
}
