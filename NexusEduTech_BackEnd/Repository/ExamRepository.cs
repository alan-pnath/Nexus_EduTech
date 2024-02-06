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

        public List<ExamDTO> GetByName(string name)
        {
            try
            {
               var item= _context.Exams.Where(e => e.ExamName == name).ToList();
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
    }
}
