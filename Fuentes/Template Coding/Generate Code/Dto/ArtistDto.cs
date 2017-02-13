// <copyright file="ArtistDto.cs" company="">
// PSL. All rights reserved.
// </copyright>
// <author>PSL.</author>
// <summary>This is the DTO from Artist</summary>
namespace WinAmp2.COMMON.DTOs.PlayListsProject
{
    using Newtonsoft.Json;
	using System;
    using System.Collections.Generic;
	/// <summary>
	/// Gets or sets the column of the application.
	/// </summary>
	/// <value>The Artist.</value>
	/// <author>PSL.</author>
	public class ArtistDto : BaseDto
	{
		/// <summary>
		/// Gets or sets the column of the application.
		/// </summary>
		/// <value>The IdArtist.</value>
		/// <author>PSL.</author>
		public int? IdArtist { get; set; }
		
		/// <summary>
		/// Gets or sets the column of the application.
		/// </summary>
		/// <value>The Name.</value>
		/// <author>PSL.</author>
		public string Name { get; set; }
		
		/// <summary>
		/// Gets or sets the column of the application.
		/// </summary>
		/// <value>The LastName.</value>
		/// <author>PSL.</author>
		public string LastName { get; set; }
		
		/// <summary>
		/// Gets or sets the column of the application.
		/// </summary>
		/// <value>The Nationality.</value>
		/// <author>PSL.</author>
		public string Nationality { get; set; }
		
		/// <summary>
		/// This is the list DTO from AlbumSongArtist.
		/// </summary>
		/// <value>The list AlbumSongArtist.</value>
		/// <author>PSL.</author>
	    public List<AlbumSongArtistDto> AlbumSongArtist { get; set; }
	
	    [JsonIgnore]
		public bool? ReferenceTableAlbumSongArtist { get; set; }
		
	}
}