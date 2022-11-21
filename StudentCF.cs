using System;
using System.Data.Entity;
using System.Linq;

namespace KPZ_Lab03CF
{
    public class StudentCF : DbContext
    {
        // Your context has been configured to use a 'StudentCF' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'KPZ_Lab03CF.StudentCF' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'StudentCF' 
        // connection string in the application configuration file.
        public StudentCF()
            : base("name=StudentCF")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Student> Students { get; set; }
    }

    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Nullable<double> AverageMath { get; set; }
        public Nullable<double> AverageEnglish { get; set; }
        public Nullable<double> AveragePhilosophy { get; set; }
        public Nullable<double> AverageProgramming { get; set; }
    }
}