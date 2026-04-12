using DomainLayer.Entities;

namespace ServiceLayer.Services.Implementations
{
    public interface ICourseGroupService
    {
        
        CourseGroup CreateGroup(CourseGroup courseGroup);
        CourseGroup UpdateGroup(int id, CourseGroup courseGroup);
        void DeleteGroup(int id);
        CourseGroup GetByGroupId(int id);
        CourseGroup GetGroupsByTeacher(string name);
        CourseGroup  GetGroupsByRoom(string room);

        List<CourseGroup> GetAllGroups();

        List<CourseGroup> SearchGroupsByName(string text);

    }
}
