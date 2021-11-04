using CustomerManager_1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManager_1.DataAccess
{
    public class DataContext : DbContext
    {
        public virtual DbSet<Exercise> Exercises { get; set; }

        public virtual DbSet<TrainingProgram> TrainingPrograms { get; set; }

        public virtual DbSet<Food> Foods { get; set; }

        public virtual DbSet<Menu> Menus { get; set; }

        public virtual DbSet<Customer> Customers { get; set; }

        public DataContext() : base ("ProgramDB")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<DataContext>(null);
            base.OnModelCreating(modelBuilder);
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Exercise>()
        //        .HasMany<TrainingProgram>(t => t.TrainingPrograms)
        //        .WithMany(t => t.Exercises)
        //        .Map(et =>
        //        {
        //            et.MapLeftKey("ExerciseRefId");
        //            et.MapRightKey("TrainingProgramRefId");
        //            et.ToTable("ExerciseTrainingProgram");
        //        });

        //    modelBuilder.Entity<Food>()
        //        .HasMany<Menu>(t => t.Menus)
        //        .WithMany(t => t.Foods)
        //        .Map(fm =>
        //        {
        //            fm.MapLeftKey("FoodRefId");
        //            fm.MapRightKey("MenuRefId");
        //            fm.ToTable("FoodMenu");
        //        });

        //    modelBuilder.Entity<TrainingProgram>()
        //        .HasMany<Customer>(t => t.Customerss)
        //        .WithMany(t => t.TrainingPrograms)
        //        .Map(tc =>
        //        {
        //            tc.MapLeftKey("TrainingProgramRefId");
        //            tc.MapRightKey("CustomerRefId");
        //            tc.ToTable("TrainingProgramCustomer");
        //        });

        //    modelBuilder.Entity<Menu>()
        //        .HasMany<Customer>(t => t.Customers)
        //        .WithMany(t => t.Menus)
        //        .Map(fm =>
        //        {
        //            fm.MapLeftKey("MenuRefId");
        //            fm.MapRightKey("CustomerRefId");
        //            fm.ToTable("MenuCustomer");
        //        });

        //    base.OnModelCreating(modelBuilder);
        //}

    }
}
