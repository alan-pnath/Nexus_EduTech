using Microsoft.EntityFrameworkCore;
using NexusEduTech_BackEnd.DTOs;
using NexusEduTech_BackEnd.Models;
using AutoMapper;
namespace NexusEduTech_BackEnd.Repository
{
    public class TeacherAttendenceRepository : ITeacherAttendence
    {
        private readonly MyContext _context;
        private readonly IMapper _mapper;

        public TeacherAttendenceRepository(MyContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void AddTeacherAttendence(TeacherAttendenceDTO data)
        {
            try
            {
                var item = _mapper.Map<TeacherAttendence>(data);
                item.AttendanceDate = DateTime.Now;
                _context.TeacherAttendences.Add(item);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public AttendenceResult GetTeacherAttendenceById(int tid)
        {
            try
            {
                AttendenceResult r = new AttendenceResult();
                var item = _context.TeacherAttendences.Where(t => t.TeacherId == tid).ToList();
                var NoOfPresent = 0;
                /*var dates = item.Count();*/
                int TotalWorkingDays = item.Count();
                foreach (var i in item)
                {
                   
                        if(i.Status.Equals("Present"))
                        {
                            NoOfPresent++;
                        }
                    
                }
                int NoOfAbsent = TotalWorkingDays - NoOfPresent;


                r.TotalWorkingDays = TotalWorkingDays;
                r.NoOfPresent = NoOfPresent;
                r.NoOfAbsent = NoOfAbsent;
                return r;


            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<TeacherAttendenceDTO> GetTeacherAttendencebyMonth(int month)
        {
            try
            {
                var studattendences = _context.TeacherAttendences.Where(
                      x => x.AttendanceDate.Month == month).ToList();
                var item = _mapper.Map<List<TeacherAttendenceDTO>>(studattendences);
                return item;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(TeacherAttendenceDTO data)
        {
            try
            {
                var _item = _mapper.Map<TeacherAttendence>(data);
                _context.TeacherAttendences.Update(_item);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
