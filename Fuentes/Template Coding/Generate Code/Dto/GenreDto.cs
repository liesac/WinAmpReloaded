// <copyright file="GenreDto.cs" company="">
// PSL. All rights reserved.
// </copyright>
// <author>PSL.</author>
// <summary>This is the DTO from Genre</summary>
namespace WinAmp2.COMMON.DTOs.PlayListsProject
{
    using Newtonsoft.Json;
	using System;
    using System.Collections.Generic;
	/// <summary>
	/// Gets or sets the column of the application.
	/// </summary>
	/// <value>The Genre.</value>
	/// <author>PSL.</author>
	public class GenreDto : BaseDto
	{
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
		/// This is the list DTO from Song.
		/// </summary>
		/// <value>The list Song.</value>
		/// <author>PSL.</author>
	    public List<SongDto> Song { get; set; }
	
	    [JsonIgnore]
		public bool? ReferenceTableSong { get; set; }
		
	}
}