using AutoMapper;
using NexusEduTech_BackEnd.DTOs;
using NexusEduTech_BackEnd.Models;

namespace NexusEduTech_BackEnd.Repository
{
    public class MarkRepository : IMarks
    {
        private readonly MyContext _context;
        private readonly IMapper _mapper;

        public MarkRepository(MyContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public string AddMark(MarksDTO data)
        {
            try
            {
                var _mark = _mapper.Map<Marks>(data);
                _context.Marks.Add(_mark);
                _context.SaveChanges();
                return ("Mark Added");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string UpdateMark(MarksDTO data)
        {
            try
            {
                var _mark = _mapper.Map<Marks>(data);
                _context.Marks.Update(_mark);
                _context.SaveChanges();
                return ("Mark Updated");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
