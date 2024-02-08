using Microsoft.EntityFrameworkCore;
using NexusEduTech_BackEnd.Models;
using AutoMapper;
using NexusEduTech_BackEnd.DTOs;

namespace NexusEduTech_BackEnd.Repository
{
    public class TeacherRepository : ITeacher
    {
        private readonly MyContext context;
        private readonly IMapper _mapper;

        public TeacherRepository(MyContext context,IMapper mapper)
        {
            this.context = context;
            _mapper = mapper;
        }   

        public void AddTeacher(TeacherDTO data)
        {
            try
            {
                var _teacher= _mapper.Map<Teacher>(data);
                context.Teachers.Add(_teacher);
                context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteTeacher(int  teacherId)
        {
            try
            {

                Teacher teacher = context.Teachers.SingleOrDefault(s => s.TeacherId == teacherId);
                context.Teachers.Remove(teacher);
                context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<TeacherDTO> GetAll()
        {
            try
            {
                var items = context.Teachers.ToList();
                var _teacher = _mapper.Map<List<TeacherDTO>>(items);
                return _teacher;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public TeacherDTO GetTeacherById(int teacherId)
        {
            try
            {
                var item= context.Teachers.SingleOrDefault(s => s.TeacherId == teacherId);
               var _teacher= _mapper.Map<TeacherDTO>(item);
                return _teacher;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<TeacherDTO> GetTeacherByClass(int classid)
        {
            try
            {
                var item = context.Teachers.Where(x => x.ClassId == classid).ToList();
                var _teacher = _mapper.Map<List<TeacherDTO>>(item);
                return _teacher;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void UpdateTeacher(TeacherDTO data)
        {
            try
            {
                var _teacher = _mapper.Map<Teacher>(data);
                context.Teachers.Update(_teacher);
                context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
