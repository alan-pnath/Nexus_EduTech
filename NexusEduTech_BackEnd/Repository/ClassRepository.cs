using AutoMapper;
using NexusEduTech_BackEnd.DTOs;
using NexusEduTech_BackEnd.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NexusEduTech_BackEnd.Repository
{
    public class ClassRepository : IClass
    {
        private readonly MyContext _context;
        private readonly IMapper _mapper;

        public ClassRepository(MyContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void AddClass(ClassDTO data)
        {
            try
            {
                var _class=_mapper.Map<Classess>(data);

                _context.Classesses.Add(_class);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteClass(int id)
        {
            try
            {
                Classess cl = _context.Classesses.Find(id);
                _context.Classesses.Remove(cl);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<ClassDTO> GetAllClasses()
        {
            try
            {
                var item= _context.Classesses.ToList();
                var _class = _mapper.Map<List<ClassDTO>>(item);
                return _class;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void UpdateClass(ClassDTO data)
        {
            try
            {
                var _class = _mapper.Map<Classess>(data);
                _context.Classesses.Update(_class);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
