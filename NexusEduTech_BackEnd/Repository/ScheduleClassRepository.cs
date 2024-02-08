using AutoMapper;
using NexusEduTech_BackEnd.DTOs;
using NexusEduTech_BackEnd.Models;


namespace NexusEduTech_BackEnd.Repository
{
    public class ScheduleClassRepository : IScheduleClass
    {
        private readonly MyContext _context;
        private readonly IMapper _mapper;

        public ScheduleClassRepository(MyContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void AssignTeacher(ScheduleClassDTO data)
        {
            try
            {
                var _class=_mapper.Map<ScheduleClass>(data);
                _context.scheduleClass.Add(_class);
                _context.SaveChanges();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<ScheduleClassDTO> ViewSchedules()
        {
            try
            {
                var items = _context.scheduleClass.ToList();
                var _class= _mapper.Map<List<ScheduleClassDTO>>(items);
                return _class;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<ScheduleClassWithTeacherNameSubjectName> GetWithTeacherNameSubjectName(string teacherName,string subName)
        {
            try
            {
                var item = (from s in _context.scheduleClass
                            join sub in _context.Subject
                            on s.subjectId equals sub.subjectId
                            join t in _context.Teachers
                            on s.TeacherId equals t.TeacherId
                            where t.Name == teacherName && sub.subjectName == subName
                            select new ScheduleClassWithTeacherNameSubjectName
                            {
                                ClassId = s.ClassId,
                                SessionTime = s.SessionTime,
                                SessionDate = s.SessionDate,
                                subjectName = sub.subjectName,
                                Name = t.Name
                            }).ToList();
                return item;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
    }

