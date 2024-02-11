using NexusEduTech_BackEnd.DTOs;
using NexusEduTech_BackEnd.Models;
using AutoMapper;
using ActiveUp.Net.Groupware.vCard;
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

        public List<ByStd> GetAll()
        {
            try
            {
                var item = (from s in _context.Students
                            join c in _context.Class
                            on s.ClassId equals c.ClassId
                            select new ByStd()
                            {
                                StudentId = s.StudentId,
                                Name = s.Name,
                                RegistrationNumber = s.RegistrationNumber,
                                Standard = c.Standard,
                                Section = c.Section,
                                DOB = s.DOB,
                                Address =s.Address,
                                Email = s.Email
                            }).ToList();
                return item;
                /* var items= _context.Students.ToList();
                 var _student = _mapper.Map<List<StudentDTO>>(items);
                 return _student;*/
            }
            catch (Exception)
            {

                throw;
            }
        }

        public GetByRollNo GetByStudentId(int id)
        {
            try
            {

                var item = (from s in _context.Students
                            join c in _context.Class
                            on s.ClassId equals c.ClassId
                            where s.StudentId == id
                            select new GetByRollNo()
                            {
                                StudentId = s.StudentId,
                                Name = s.Name,
                                Gender = s.Gender,
                                DOB = s.DOB,
                                Email = s.Email,
                                Address = s.Address,
                                RegistrationNumber = s.RegistrationNumber,
                                Standard = c.Standard,
                                Section = c.Section
                            }).FirstOrDefault();
                return item;
                /* var item = _context.Students.SingleOrDefault(s => s.RegistrationNumber == rollno);
                 var _student = _mapper.Map<StudentDTO>(item);
                 return _student;*/
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<ByStd> GetByStd(string std)
        {
            try
            {

                var item = (from s in _context.Students
                            join c in _context.Class
                            on s.ClassId equals c.ClassId
                            where c.Standard == std 
                            select new ByStd()
                            {
                                StudentId = s.StudentId,
                                Name = s.Name,
                                RegistrationNumber = s.RegistrationNumber,
                                Standard = c.Standard,
                                Section = c.Section
                            }).ToList();
                return item;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<ByStd> GetByStdSec(string std, string sec)
        {
            try
            {
                var item= ( from s in _context.Students
                                                   join c in _context.Class
                                                   on s.ClassId equals c.ClassId
                            where c.Standard == std && c.Section == sec
                                                   select new ByStd()
                                                   {
                                                       StudentId=s.StudentId,
                                                       Name=s.Name,
                                                       RegistrationNumber=s.RegistrationNumber,
                                                       Standard=c.Standard,
                                                       Section=c.Section
                                                   }).ToList();
                return item;
            
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
        public List<Result> Results()
        {
            try
            {
                var result = (from s in _context.Students
                              join m in _context.Marks
                              on s.StudentId equals m.StudentId
                              join e in _context.Exams
                              on m.ExamId equals e.ExamId
                              join sub in _context.Subject
                              on e.subjectId equals sub.subjectId
                              select new Result()
                              {
                                  subjectName = sub.subjectName,
                                  mark = m.mark,
                                  ExamName = e.ExamName,
                                  Max_Mark = e.Max_Mark,
                              }).ToList();
                return result;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Result> ResultsById(int id)
        {
            try
            {
                var result = (from s in _context.Students
                              join m in _context.Marks
                              on s.StudentId equals m.StudentId
                              join e in _context.Exams
                              on m.ExamId equals e.ExamId
                              join sub in _context.Subject
                              on e.subjectId equals sub.subjectId
                              where s.StudentId == id
                              select new Result()
                              {
                                  subjectName = sub.subjectName,
                                  mark = m.mark,
                                  ExamName = e.ExamName,
                                  Max_Mark = e.Max_Mark,
                              }).ToList();
                return result;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<StudentDTO> GetStudentsByClassId(int classId)
        {
            try
            {
                var result = (from s in _context.Students
                              where s.ClassId == classId
                              select new StudentDTO()
                              { StudentId = s.StudentId,
                                  Name = s.Name,
                              RegistrationNumber = s.RegistrationNumber,
                              Gender = s.Gender,
                              DOB = s.DOB,
                              Address = s.Address,
                              Email = s.Email
                              }).ToList();

                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
