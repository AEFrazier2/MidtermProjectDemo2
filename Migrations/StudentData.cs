namespace Midterm_Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class StudentData : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Students(StudentId,FirstName,LastName,Age,CourseId,CourseEnrolledDate,CourseStatus,Grade) values ('Fred', 'Jackson', 19, 1001, 8/31/2020, 1, 'A')");
            Sql("Insert into Students(StudentId,FirstName,LastName,Age,CourseId,CourseEnrolledDate,CourseStatus,Grade) values ('Mary', 'Smith', 20, 1010, 1/7/2020, 2, 'A')");
            Sql("Insert into Students(StudentId,FirstName,LastName,Age,CourseId,CourseEnrolledDate,CourseStatus,Grade) values ('Thomas', 'Jones', 19, 1020, 8/31/2020, 1, 'A')");
            Sql("Insert into Students(StudentId,FirstName,LastName,Age,CourseId,CourseEnrolledDate,CourseStatus,Grade) values ('Reese', 'Gregory', 21, 1010, 1/7/2020, 2, 'A')");
            Sql("Insert into Students(StudentId,FirstName,LastName,Age,CourseId,CourseEnrolledDate,CourseStatus,Grade) values ('James', 'Ward', 20, 1001, 8/31/2020, 1, 'A')");

            Sql("Insert into CourseStatus(Status) values (1,10)");
            Sql("Insert into CourseStatus(Status) values (1,10)");
        }

        public override void Down()
        {
        }
    }
}
