using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Helpers
{
    public enum  Menus
    {
        CreateGroup=1,
UpdateGroup = 2,
DeleteGroup = 3,
GetGroupById = 4,
GetAllGroupsByTeacher = 5,
GetAllGroupsByRoom = 6,
GetAllGroups = 7,
CreateStudent = 8,
UpdateStudent = 9,
GetStudentsById = 10,
DeleteStudent =11,
GetStudentsByAge = 12,
GetStudentsByGroupId = 13,
SearchGroupsByName =14,
SearchStudentsByNameOrSurname = 15
       ,
    }
}
