using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Uygulama1.Models;

namespace Uygulama1
{
    public class StudentBusinessCode
    {
        private readonly AppContext _context;
        public StudentBusinessCode( AppContext context)
        {
               _context = context;

        }
        public bool AddStudent(Student student )
        {
            _context.Students.Add( student );
            _context.SaveChanges();
            return true;
        }
        public bool DeleteStudent(string fullName)
        {
            var isStudent = _context.Students.FirstOrDefault( s => s.FirstName == fullName );

            if (isStudent != null)
            {
                _context.Students.Remove(isStudent);
                _context.SaveChanges();
                return true;
            }

            return false;
        }
        public bool UpdateStudent( Student student )
        {
            _context.Students.Update( student );
            _context.SaveChanges();
            return true;
        }
        public Student GetStudent(string firstName)
        {
           return _context.Students.FirstOrDefault(s => s.FirstName ==firstName);

        }



    }
}
