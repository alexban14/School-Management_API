namespace lab4_solid.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Course",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Semester = c.Int(nullable: false),
                        Year = c.Int(nullable: false),
                        TeacherID = c.Int(nullable: false),
                        Grade_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Grade", t => t.Grade_ID)
                .ForeignKey("dbo.Teacher", t => t.TeacherID, cascadeDelete: true)
                .Index(t => t.TeacherID)
                .Index(t => t.Grade_ID);
            
            CreateTable(
                "dbo.StudentCourse",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        StudentID = c.Int(nullable: false),
                        CourseID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Course", t => t.CourseID, cascadeDelete: true)
                .ForeignKey("dbo.Student", t => t.StudentID, cascadeDelete: true)
                .Index(t => t.StudentID)
                .Index(t => t.CourseID);
            
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        Email = c.String(),
                        RegistrationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Grade",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        GradeNotation = c.Int(nullable: false),
                        StudentID = c.Int(nullable: false),
                        CourseID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Teacher",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        Email = c.String(),
                        RegistrationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Director",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        BirthDate = c.DateTime(nullable: false),
                        Email = c.String(),
                        RegistrationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.GradeStudent",
                c => new
                    {
                        Grade_ID = c.Int(nullable: false),
                        Student_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Grade_ID, t.Student_ID })
                .ForeignKey("dbo.Grade", t => t.Grade_ID, cascadeDelete: true)
                .ForeignKey("dbo.Student", t => t.Student_ID, cascadeDelete: true)
                .Index(t => t.Grade_ID)
                .Index(t => t.Student_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Course", "TeacherID", "dbo.Teacher");
            DropForeignKey("dbo.StudentCourse", "StudentID", "dbo.Student");
            DropForeignKey("dbo.GradeStudent", "Student_ID", "dbo.Student");
            DropForeignKey("dbo.GradeStudent", "Grade_ID", "dbo.Grade");
            DropForeignKey("dbo.Course", "Grade_ID", "dbo.Grade");
            DropForeignKey("dbo.StudentCourse", "CourseID", "dbo.Course");
            DropIndex("dbo.GradeStudent", new[] { "Student_ID" });
            DropIndex("dbo.GradeStudent", new[] { "Grade_ID" });
            DropIndex("dbo.StudentCourse", new[] { "CourseID" });
            DropIndex("dbo.StudentCourse", new[] { "StudentID" });
            DropIndex("dbo.Course", new[] { "Grade_ID" });
            DropIndex("dbo.Course", new[] { "TeacherID" });
            DropTable("dbo.GradeStudent");
            DropTable("dbo.Director");
            DropTable("dbo.Teacher");
            DropTable("dbo.Grade");
            DropTable("dbo.Student");
            DropTable("dbo.StudentCourse");
            DropTable("dbo.Course");
        }
    }
}
