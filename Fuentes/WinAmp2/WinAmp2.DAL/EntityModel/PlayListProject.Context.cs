﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinAmp2.DAL.EntityModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PlayListsProjectEntities : DbContext
    {
        public PlayListsProjectEntities()
            : base("name=PlayListsProjectEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Album> Album { get; set; }
        public virtual DbSet<AlbumSongArtist> AlbumSongArtist { get; set; }
        public virtual DbSet<Artist> Artist { get; set; }
        public virtual DbSet<Genre> Genre { get; set; }
        public virtual DbSet<PlayList> PlayList { get; set; }
        public virtual DbSet<PlayListDetail> PlayListDetail { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Song> Song { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserPlayList> UserPlayList { get; set; }
    }
}