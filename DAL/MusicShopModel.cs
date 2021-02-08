namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    public class MusicShopModel : DbContext
    {
        
        public MusicShopModel()
            : base("name=MusicShopModel")
        {
        }

        public virtual DbSet<Plate> Plates { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Publisher> Publishers { get; set; }
        public virtual DbSet<Group> Groups { get; set; }

    }

    public class Plate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PublishYear { get; set; }
        public int TrackCount { get; set; }
        public decimal SalePrice { get; set; }
        public decimal CostPrice { get; set; }

        // nav props
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
        public Publisher Publisher { get; set; }
        public int PublisherId { get; set; }
        public Group Group { get; set; }
        public int GroupId { get; set; }
    }
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // nav props
        public ICollection<Plate> Plates { get; set; }
    }
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adrese { get; set; }
        // nav props
        public ICollection<Plate> Plates { get; set; }
    }
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // nav props
        public ICollection<Plate> Plates { get; set; }
    }
}