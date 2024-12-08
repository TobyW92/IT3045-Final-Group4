using System;
using Microsoft.EntityFrameworkCore;
using IT3045_Final_Group4.Models;


namespace IT3045_Final_Group4.Data
{
    public class TeamMemberContext : DbContext
    {
        public TeamMemberContext(DbContextOptions<TeamMemberContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<TeamMember>().HasData(
                new TeamMember { Id = 1, FullName = "Toby Wright", Birthdate = new DateTime(1992, 7, 31), CollegeProgram = "Associate of Applied Business in Information Technology", YearInProgram = "Freshman"},
                new TeamMember { Id = 2, FullName = "John Penn", Birthdate = new DateTime(1995, 11, 08), CollegeProgram = "Associate of Applied Business in Information Technology", YearInProgram = "Sophomore" },
                new TeamMember { Id = 3, FullName = "Matt Glazier", Birthdate = new DateTime(1998, 9, 30), CollegeProgram = "Clermont Certificate in Information Technology", YearInProgram = "Sophomore" },
                new TeamMember { Id = 4, FullName = "Leslie Alonge", Birthdate = new DateTime(2005, 8, 27), CollegeProgram = "Bachelor of Science in Cybersecurity", YearInProgram = "Sophomore" },
                new TeamMember { Id = 5, FullName = "Kellen Hubbard", Birthdate = new DateTime(1998, 9, 30), CollegeProgram = "Associate of Applied Business in Information Technology", YearInProgram = "Sophomore"}
            );
        }

        public DbSet<TeamMember> TeamMembers {  get; set; }
    }
}
