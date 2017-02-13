// <copyright file="AlbumDto.cs" company="">
// PSL. All rights reserved.
// </copyright>
// <author>PSL.</author>
// <summary>This is the DTO from Album</summary>
namespace WinAmp2.COMMON.DTOs.PlayListsProject
{
    using Newtonsoft.Json;
	using System;
    using System.Collections.Generic;
	/// <summary>
	/// Gets or sets the column of the application.
	/// </summary>
	/// <value>The Album.</value>
	/// <author>PSL.</author>
	public class AlbumDto : BaseDto
	{
		/// <summary>
		/// Gets or sets the column of the application.
		/// </summary>
		/// <value>The IdAlbum.</value>
		/// <author>PSL.</author>
		public int? IdAlbum { get; set; }
		
		/// <summary>
		/// Gets or sets the column of the application.
		/// </summary>
		/// <value>The Name.</value>
		/// <author>PSL.</author>
		public string Name { get; set; }
		
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