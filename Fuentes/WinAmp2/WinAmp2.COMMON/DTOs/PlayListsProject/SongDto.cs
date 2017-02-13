// <copyright file="SongDto.cs" company="">
// PSL. All rights reserved.
// </copyright>
// <author>PSL.</author>
// <summary>This is the DTO from Song</summary>
namespace WinAmp2.COMMON.DTOs.PlayListsProject
{
    using Newtonsoft.Json;
	using System;
    using System.Collections.Generic;
	/// <summary>
	/// Gets or sets the column of the application.
	/// </summary>
	/// <value>The Song.</value>
	/// <author>PSL.</author>
	public class SongDto : BaseDto
	{
		/// <summary>
		/// Gets or sets the column of the application.
		/// </summary>
		/// <value>The IdSong.</value>
		/// <author>PSL.</author>
		public int? IdSong { get; set; }
		
		/// <summary>
		/// Gets or sets the column of the application.
		/// </summary>
		/// <value>The IdGenre.</value>
		/// <author>PSL.</author>
		public int? IdGenre { get; set; }
		
		/// <summary>
		/// Gets or sets the column of the application.
		/// </summary>
		/// <value>The Name.</value>
		/// <author>PSL.</author>
		public string Name { get; set; }
		
		/// <summary>
		/// Gets or sets the column of the application.
		/// </summary>
		/// <value>The Length.</value>
		/// <author>PSL.</author>
		public TimeSpan? Length { get; set; }
		
		/// <summary>
		/// This is the list DTO from AlbumSongArtist.
		/// </summary>
		/// <value>The list AlbumSongArtist.</value>
		/// <author>PSL.</author>
	    public List<AlbumSongArtistDto> AlbumSongArtist { get; set; }
	
	    [JsonIgnore]
		public bool? ReferenceTableAlbumSongArtist { get; set; }
		
		/// <summary>
		/// This is the list DTO from PlayListDetail.
		/// </summary>
		/// <value>The list PlayListDetail.</value>
		/// <author>PSL.</author>
	    public List<PlayListDetailDto> PlayListDetail { get; set; }
	
	    [JsonIgnore]
		public bool? ReferenceTablePlayListDetail { get; set; }
		
		/// <summary>
		/// This is the DTO from Genre.
		/// </summary>
		/// <value>The Genre.</value>
		/// <author>PSL.</author>
	    public GenreDto Genre { get; set; }
	
	    [JsonIgnore]
		public bool? ReferenceTableGenre { get; set; }
		
	}
}