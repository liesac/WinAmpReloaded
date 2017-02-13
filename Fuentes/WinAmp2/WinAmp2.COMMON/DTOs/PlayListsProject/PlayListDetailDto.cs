// <copyright file="PlayListDetailDto.cs" company="">
// PSL. All rights reserved.
// </copyright>
// <author>PSL.</author>
// <summary>This is the DTO from PlayListDetail</summary>
namespace WinAmp2.COMMON.DTOs.PlayListsProject
{
    using Newtonsoft.Json;
	using System;
    
	/// <summary>
	/// Gets or sets the column of the application.
	/// </summary>
	/// <value>The PlayListDetail.</value>
	/// <author>PSL.</author>
	public class PlayListDetailDto : BaseDto
	{
		/// <summary>
		/// Gets or sets the column of the application.
		/// </summary>
		/// <value>The IdPlayListDetail.</value>
		/// <author>PSL.</author>
		public int? IdPlayListDetail { get; set; }
		
		/// <summary>
		/// Gets or sets the column of the application.
		/// </summary>
		/// <value>The IdPlayList.</value>
		/// <author>PSL.</author>
		public int? IdPlayList { get; set; }
		
		/// <summary>
		/// Gets or sets the column of the application.
		/// </summary>
		/// <value>The IdSong.</value>
		/// <author>PSL.</author>
		public int? IdSong { get; set; }
		
		/// <summary>
		/// This is the DTO from PlayList.
		/// </summary>
		/// <value>The PlayList.</value>
		/// <author>PSL.</author>
	    public PlayListDto PlayList { get; set; }
	
	    [JsonIgnore]
		public bool? ReferenceTablePlayList { get; set; }
		
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