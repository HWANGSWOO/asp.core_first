using System.Collections.Generic;
using App.Views.Home;

namespace App.Data.Repositories
{
    public interface ITeacherRepository
    {
        IEnumerable<Teacher> GetAllTeachers();
        Teacher GetTeacher(int id);
    }
}