// <copyright file="AlbumSongArtistDto.cs" company="">
// PSL. All rights reserved.
// </copyright>
// <author>PSL.</author>
// <summary>This is the DTO from AlbumSongArtist</summary>
namespace WinAmp2.COMMON.DTOs.PlayListsProject
{
    using Newtonsoft.Json;
	using System;
    
	/// <summary>
	/// Gets or sets the column of the application.
	/// </summary>
	/// <value>The AlbumSongArtist.</value>
	/// <author>PSL.</author>
	public class AlbumSongArtistDto : BaseDto
	{
		/// <summary>
		/// Gets or sets the column of the application.
		/// </summary>
		/// <value>The IdAlbumSong.</value>
		/// <author>PSL.</author>
		public int? IdAlbumSong { get; set; }
		
		/// <summary>
		/// Gets or sets the column of the application.
		/// </summary>
		/// <value>The IdAlbum.</value>
		/// <author>PSL.</author>
		public int? IdAlbum { get; set; }
		
		/// <summary>
		/// Gets or sets the column of the application.
		/// </summary>
		/// <value>The IdSong.</value>
		/// <author>PSL.</author>
		public int? IdSong { get; set; }
		
		/// <summary>
		/// Gets or sets the column of the application.
		/// </summary>
		/// <value>The IdArtist.</value>
		/// <author>PSL.</author>
		public int? IdArtist { get; set; }
		
		/// <summary>
		/// This is the DTO from Album.
		/// </summary>
		/// <value>The Album.</value>
		/// <author>PSL.</author>
	    public AlbumDto Album { get; set; }
	
	    [JsonIgnore]
		public bool? ReferenceTableAlbum { get; set; }
		
		/// <summary>
		/// This is the DTO from Artist.
		/// </summary>
		/// <value>The Artist.</value>
		/// <author>PSL.</author>
	    public ArtistDto Artist { get; set; }
	
	    [JsonIgnore]
		public bool? ReferenceTableArtist { get; set; }
		
		/// <summary>
		/// This is the DTO from Song.
		/// </summary>
		/// <value>The Song.</value>
		/// <author>PSL.</author>
	    public SongDto Song { get; set; }
	
	    [JsonIgnore]
		public bool? ReferenceTableSong { get; set; }
		
	}
}