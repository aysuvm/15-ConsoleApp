using CourseApplication.Controllers;
using ServiceLayer.Helpers;
using System.Diagnostics;

internal class Program
{
   public static void Main(string[] args)
    {
        CourseGroupController courseGroupController = new CourseGroupController();

        Helper.PrintConsole(ConsoleColor.Blue, "Select one option:");
        Helper.PrintConsole(ConsoleColor.Yellow,
            "1-Create Group\n" +
            "2-Update Group\n" +
            "3-Delete Group\n" +
            "4-Get Group by Id\n" +
            "5-Get All Groups by Teacher\n" +
            "6-Get All Groups by Room\n" +
            "7-Get All Groups\n" +
            "8-Create Student\n" +
            "9-Update Student\n" +
            "10-Get Student by Id\n" +
            "11-Delete Student\n" +
            "12-Get Students by Age\n" +
            "13-Get Students by Group Id\n" +
            "14-Search Groups by Name\n" +
            "15-Search Students by Name or Surname");

        while (true)
        {
            string selectOption = Console.ReadLine();
            int selectNumber;

            if (int.TryParse(selectOption, out selectNumber))
            {
                switch (selectNumber)
                {
                    case(int) Menus.CreateGroup:
                        courseGroupController.CreateGroup();
                        break;

                    case(int)Menus.UpdateGroup :
                        courseGroupController.UpdateGroup();
                        break;

                    case (int)Menus.DeleteGroup:
                        courseGroupController.DeleteGroup();
                        break;

                    case (int)Menus.GetGroupById:
                        courseGroupController.GetGroupById();
                        break;

                    case (int)Menus.GetAllGroupsByTeacher:
                        courseGroupController.GetAllGroupsByTeacher();
                        break;

                    case (int)Menus.GetAllGroupsByRoom:
                        courseGroupController.GetAllGroupsByRoom();
                        break;

                    case(int)Menus.GetAllGroups:
                        courseGroupController.GetAllGroups();
                        break;

                    case (int)Menus.CreateStudent:
                        courseGroupController.CreateStudent();
                        break;

                    case (int)Menus.UpdateStudent:
                        courseGroupController.UpdateStudent();
                        break;

                    case (int)Menus.GetStudentsById:
                        courseGroupController.GetStudentById();
                        break;

                    case (int)Menus.DeleteStudent:
                        courseGroupController.DeleteStudent();
                        break;

                    case (int)Menus.GetStudentsByAge:
                        courseGroupController.GetStudentsByAge();
                        break;

                    case (int)Menus.GetStudentsByGroupId:
                        courseGroupController.GetStudentsByGroupId();
                        break;

                    case (int)Menus.SearchGroupsByName:
                        courseGroupController.SearchGroupByName();
                        break;

                    case (int)Menus.SearchStudentsByNameOrSurname:
                        courseGroupController.SearchStudentByNameOrSurname();
                        break;

                    default:
                        Helper.PrintConsole(ConsoleColor.Red, "Wrong option!");
                        break;
                }
            }
            else
            {
                Helper.PrintConsole(ConsoleColor.Red, "Add correct option type!");
               
            }
        }

    }
    private static void GetMenus()
    {
        Helper.PrintConsole(ConsoleColor.Yellow,
           "1-Create Group\n" +
           "2-Update Group\n" +
           "3-Delete Group\n" +
           "4-Get Group by Id\n" +
           "5-Get All Groups by Teacher\n" +
           "6-Get All Groups by Room\n" +
           "7-Get All Groups\n" +
           "8-Create Student\n" +
           "9-Update Student\n" +
           "10-Get Student by Id\n" +
           "11-Delete Student\n" +
           "12-Get Students by Age\n" +
           "13-Get Students by Group Id\n" +
           "14-Search Groups by Name\n" +
           "15-Search Students by Name or Surname");
    }
}


