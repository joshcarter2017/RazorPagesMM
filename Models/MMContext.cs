using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RazorPagesMM.Models
{
    public class MMContext : DbContext
    {
        public MMContext(DbContextOptions<MMContext> options)
            : base(options)
        {
        }

        public DbSet<Club> Clubs { get; set; }
        public DbSet<ClubShow> ClubShows { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<Placement> Placements { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<YearShow> YearShows { get; set; }
    }
}
