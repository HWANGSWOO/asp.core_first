using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models
{
    public class Note
    {
        [Key]
        /// <summary>
        /// 게시물 번호
        /// </summary>
        public int NoteNo { get; set; }

        /// <summary>
        /// 게시물 제목
        /// </summary>
     
        public string NoteTitle { get; set; }

        /// <summary>
        /// 게시물 내용
        /// </summary>
     
        public string NoteContents { get; set; }
      
        /// <summary>
        /// 작성자 아이디
        /// </summary>
      
        public int ID { get; set; }
        
        [ForeignKey("ID")]
        public virtual Student Student { get; set; }
    }

}
