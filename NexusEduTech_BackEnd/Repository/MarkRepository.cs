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
                /*_mark.MarkId = new Random().Next(1000,9999);*/
                _context.Marks.Add(_mark);
                _context.SaveChanges();
                return ("Mark Added");
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string UpdateMark(MarksDTO data,int id)
        {
            try
            {
                var _mark = _mapper.Map<Marks>(data);
                _mark.MarkId = id;
                _context.Marks.Update(_mark);
                _context.SaveChanges();
                return ("Mark Updated");
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<MarksDTO> GetMarks()
        {
            try
            {
                var items=_context.Marks.ToList();
                var _marks=_mapper.Map<List<MarksDTO>>(items);
                return _marks;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
