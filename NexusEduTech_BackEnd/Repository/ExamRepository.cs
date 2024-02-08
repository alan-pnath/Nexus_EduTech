using NexusEduTech_BackEnd.Models;
using AutoMapper;
using NexusEduTech_BackEnd.DTOs;
using Microsoft.AspNetCore.Http.HttpResults;
namespace NexusEduTech_BackEnd.Repository
{
    public class ExamRepository:IExam
    {
        private readonly MyContext _context;
        private readonly IMapper _mapper;

        public ExamRepository(MyContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }       

        public string AddExam(ExamDTO data)
        {
            try
            {
                var _exam = _mapper.Map<Examination>(data);

                    _context.Exams.Add(_exam);
                    _context.SaveChanges();
                    return ("Exam Added");
        
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string DeleteExam(int id)
        {
            try
            {
                Examination ex = _context.Exams.Find(id);
                _context.Exams.Remove(ex);
                _context.SaveChanges();
                return ("Exam Deleted");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<ExamDTO> GetAll()
        {

            try
            {
                var items= _context.Exams.ToList();
                var _exam = _mapper.Map<List<ExamDTO>>(items);
                return _exam;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<ExamDTO> GetById(int id)
        {
            try
            {
               var item= _context.Exams.Where(e => e.ExamId == id).ToList();
                var _exam = _mapper.Map<List<ExamDTO>>(item);
                return _exam;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string UpdateExam(ExamDTO data)
        {
            try
            {
                var _exam = _mapper.Map<Examination>(data);
                _context.Exams.Update(_exam);
                _context.SaveChanges();
                return ("exam Updated");
            }
            catch (Exception)
            {

                throw;
            }
        }
       /* public List <WithSubjectNameAndStd> GetExamWithSubjectNameAndStd(string subName,string std)
        {
            try
            {
               *//* var result = (from e in _context.Exams
                              join s in _context.Subject
                              on e.subjectId equals s.subjectId
                              join c in _context.Class
                              on e.ClassId equals c.ClassId
                              join m in _context.Marks
                              on e.ExamId equals m.ExamId
                              where s.subjectName == subName && c.Standard == std
                              select new WithSubjectNameAndStd
                              {
                                  ExamName = e.ExamName,
                                  Max_Mark = e.Max_Mark,
                                  subjectName = s.subjectName,
                                  mark = m.mark
                              }
                            ).ToList();*//*

                var subId = (from s in _context.Subject where s.subjectName ==  subName select s.subjectId).FirstOrDefault();
                var result 
                return result;

            }
            catch (Exception)
            {

                throw;
            }
        }*/
    }
}
