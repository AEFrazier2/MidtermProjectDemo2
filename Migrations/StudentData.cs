namespace Midterm_Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class StudentData : DbMigration
    {
        public override void Up()
        {
            Sql("Delete from Students");
            Sql("Insert into Students(StudentId,FirstName,LastName,Age,CourseId,CourseEnrolledDate,CourseStatus,Grade) values ('Fred', 'Jackson', 19, 1, 8/31/2020, 1, 'A')");
            Sql("Insert into Students(StudentId,FirstName,LastName,Age,CourseId,CourseEnrolledDate,CourseStatus,Grade) values ('Mary', 'Smith', 20, 2, 1/7/2020, 2, 'A')");
            Sql("Insert into Students(StudentId,FirstName,LastName,Age,CourseId,CourseEnrolledDate,CourseStatus,Grade) values ('Thomas', 'Jones', 19, 3, 8/31/2020, 1, 'A')");
            Sql("Insert into Students(StudentId,FirstName,LastName,Age,CourseId,CourseEnrolledDate,CourseStatus,Grade) values ('Reese', 'Gregory', 21, 4, 1/7/2020, 2, 'A')");
            Sql("Insert into Students(StudentId,FirstName,LastName,Age,CourseId,CourseEnrolledDate,CourseStatus,Grade) values ('James', 'Ward', 20, 1, 8/31/2020, 1, 'A')");

            //Sql("Insert into CourseStatus(Status) values (In-Progress)");
            //Sql("Insert into CourseStatus(Status) values (Complete)");
        }

        public override void Down()
        {
        }
    }
}
