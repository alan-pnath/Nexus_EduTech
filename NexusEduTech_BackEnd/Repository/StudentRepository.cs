using NexusEduTech_BackEnd.DTOs;
using NexusEduTech_BackEnd.Models;
using AutoMapper;
namespace NexusEduTech_BackEnd.Repository
{
    public class StudentRepository : IStudent
    {
        private readonly MyContext _context;
        private readonly IMapper _mapper;

        public StudentRepository(MyContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public string Add(StudentDTO data)
        {
            try
            {
                var _student = _mapper.Map<Student>(data);
                _context.Students.Add(_student);
                _context.SaveChanges();
                return ("Student Added");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string Delete(int id)
        {
            try
            {
                Student st = _context.Students.Find(id); //studentID
                _context.Students.Remove(st);
                _context.SaveChanges();
                return ("Student Deleted");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<StudentDTO> GetAll()
        {
            try
            {
                var items= _context.Students.ToList();
                var _student = _mapper.Map<List<StudentDTO>>(items);
                return _student;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public StudentDTO GetByRollNo(string rollno)
        {
            try
            {
                var item = _context.Students.SingleOrDefault(s => s.RegistrationNumber == rollno);
                var _student = _mapper.Map<StudentDTO>(item);
                return _student;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<StudentDTO> GetByStd(string std)
        {
            try
            {
                var item= _context.Students.Where(s => s.Std == std).ToList();
                var _student= _mapper.Map<List<StudentDTO>>(item);
                return _student;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<StudentDTO> GetByStdSec(string std, string sec)
        {
            try
            {
                var item= _context.Students.Where(s => s.Std == std && s.Section == sec).ToList();
                var _student=_mapper.Map<List<StudentDTO>>(item);
                return _student;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string Update(StudentDTO data)
        {
            try
            {
                var _student = _mapper.Map<Student>(data);
                _context.Students.Update(_student);
                _context.SaveChanges();
                return ("Student Updated");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
