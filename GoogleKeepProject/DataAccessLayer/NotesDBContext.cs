using Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccessLayer
{
    public class NotesDBConText : DbContext
    {
        public NotesDBConText() { }

        public NotesDBConText(DbContextOptions<NotesDBConText> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // defining primary key to NoteId.
            modelBuilder.Entity<Notes>().HasKey( n => new { n.NoteID});

            // defining primary key to LableID.
            modelBuilder.Entity<Label>().HasKey( l => new { l.LabelID});
        }

        public DbSet<Notes> notes { get; set; }
        public DbSet<Label> labels { get; set; }
    }
}
