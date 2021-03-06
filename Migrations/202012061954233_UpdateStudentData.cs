namespace Midterm_Demo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateStudentData : DbMigration
    {
        public override void Up()
        {
            Sql("Delete from Students");
            Sql("Insert into Students(FirstName,LastName,Age,CourseId,CourseEnrolledDate,CourseStatus,Grade) values ('Fred', 'Jackson', 19, 1001, '8/31/2020', 1, 'A')");
            Sql("Insert into Students(FirstName,LastName,Age,CourseId,CourseEnrolledDate,CourseStatus,Grade) values ('Mary', 'Smith', 20, 1010, '1/7/2020', 2, 'A')");
            Sql("Insert into Students(FirstName,LastName,Age,CourseId,CourseEnrolledDate,CourseStatus,Grade) values ('Thomas', 'Jones', 19, 1020, '8/31/2020', 1, 'A')");
            Sql("Insert into Students(FirstName,LastName,Age,CourseId,CourseEnrolledDate,CourseStatus,Grade) values ('Reese', 'Gregory', 21, 1010, '1/7/2020', 2, 'A')");
            Sql("Insert into Students(FirstName,LastName,Age,CourseId,CourseEnrolledDate,CourseStatus,Grade) values ('James', 'Ward', 20, 1001, '8/31/2020', 1, 'A')");

            Sql("Delete from CourseStatus");
            Sql("Insert into CourseStatus(Status) values ('In-Progress')");
            Sql("Insert into CourseStatus(Status) values ('Completed')");
        }
        
        public override void Down()
        {
        }
    }
}
