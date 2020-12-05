namespace Midterm_Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CourseAndCourseStatusData : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Courses(CourseName,CourseDescription,TutorName,CourseRating) values('Accounting', 'Beginning Accounting', 'Andrea F', 9)");
            Sql("Insert into Courses(CourseName,CourseDescription,TutorName,CourseRating) values('Finance', 'Intermediate Accounting', 'Andrea F', 9)");
            Sql("Insert into Courses(CourseName,CourseDescription,TutorName,CourseRating) values('Microeconomics', 'Beginning Micro', 'Andrea F', 8)");
            Sql("Insert into Courses(CourseName,CourseDescription,TutorName,CourseRating) values('Macroeconomics', 'Beginning Macro', 'Andrea F', 8)");
            Sql("Insert into Courses(CourseName,CourseDescription,TutorName,CourseRating) values('Entreprenuership', 'Freshman Seminar', 'Andrea F', 10)");

            Sql("Insert into CourseStatus(Status) values(1,2)");
            Sql("Insert into CourseStatus(Status) values(1,2)");

        }


        
        public override void Down()
        {
        }
    }
}
