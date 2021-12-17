using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Data;
using App.Data.Repositories;
using App.Models;
using App.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class NoteController : Controller
    {
        private readonly INoteRepository _noteRepository;

        public NoteController(INoteRepository noteRepository)
        {
            _noteRepository = noteRepository;
        }

        /// <summary>
        /// 게시판 리스트
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            var notes = _noteRepository.GetAllNotes();

            var viewModel = new NoteViewModel()
            {
                Note = new Note(),
                

            };
            return View(viewModel);
        }
        
        /// <summary>
        /// 게시물 추가
        /// </summary>
        /// <returns></returns>
        public  IActionResult Add()
        {

            /*
              
                    var viewModel = new NoteViewModel()
            {
                Note = new Note(),
                Notes = notes

            };   
             */

            return View();
        }
        [HttpPost]
        public IActionResult Add(NoteViewModel model)
        {
            if (ModelState.IsValid)
            {
                // model 데이터를  테이블에 저장
                _noteRepository.AddNote(model.Note);
                _noteRepository.Save();

                ModelState.Clear();
            }
            else
            {
                //에러를 보여준다
            }

            var notes = _noteRepository.GetAllNotes();
            var viewModel = new NoteViewModel()
            {
                Note = new Note(),
                Notes = notes
            };

            return View(viewModel);
        }




        /// <summary>
        /// 게시물 수정
        /// </summary>
        /// <returns></returns>
        public IActionResult Edit()
        {
            return View();
        }
        /// <summary>
        /// 게시물 삭제
        /// </summary>
        /// <returns></returns>
        public IActionResult Delete()
        {
            return View();
        }
    }
}
