using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrincipal
{

    ////
    ///// factory pattern
    ///using it in the main class


    public class IstudentRepositoryFactory{

        public static IStudentRepository GetStudentRepository() {
            return new StudentRepository();
        }


}





    /// <summary>
    /// first step intefrace for each dependency I OUT DB File
    /// passed by constructor
    /// 
    /// </summary>

    public interface IStudentRepository {

        void AddStudent();
        void DeleteStudent();
        void EditStudent();
        void GetAll();

    }

    public class StudentRepository : IStudentRepository
    {
        public void AddStudent()
        {
            throw new NotImplementedException();
        }

        public void DeleteStudent()
        {
            throw new NotImplementedException();
        }

        public void EditStudent()
        {
            throw new NotImplementedException();
        }

        public void GetAll()
        {
            throw new NotImplementedException();
        }
    }



    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DoB { get; set; }

        //tight coupling
        private IStudentRepository _stdRepo ;

        public Student(IStudentRepository studentRepository)
        {
            this._stdRepo= studentRepository; 
        }

        public void Save()
        {
            // _stdRepo.AddStudent(this);
            _stdRepo.AddStudent();
        }
    }

    //public class StudentRepository
    //{
    //    public void AddStudent(Student std)
    //    {
    //        //EF code removed for clarity
    //    }

    //    public void DeleteStudent(Student std)
    //    {
    //        //EF code removed for clarity
    //    }

    //    public void EditStudent(Student std)
    //    {
    //        //EF code removed for clarity
    //    }

    //    public IList<Student> GetAllStudents()
    //    {
    //        return new List<Student>();        
    //        //EF code removed for clarity
    //    }
    //}
}
