// <copyright file="PlayListDto.cs" company="">
// PSL. All rights reserved.
// </copyright>
// <author>PSL.</author>
// <summary>This is the DTO from PlayList</summary>
namespace WinAmp2.COMMON.DTOs.PlayListsProject
{
    using Newtonsoft.Json;
	using System;
    using System.Collections.Generic;
	/// <summary>
	/// Gets or sets the column of the application.
	/// </summary>
	/// <value>The PlayList.</value>
	/// <author>PSL.</author>
	public class PlayListDto : BaseDto
	{
		/// <summary>
		/// Gets or sets the column of the application.
		/// </summary>
		/// <value>The IdPlayList.</value>
		/// <author>PSL.</author>
		public int? IdPlayList { get; set; }
		
		/// <summary>
		/// Gets or sets the column of the application.
		/// </summary>
		/// <value>The IdPlayListType.</value>
		/// <author>PSL.</author>
		public int? IdPlayListType { get; set; }
		
		/// <summary>
		/// Gets or sets the column of the application.
		/// </summary>
		/// <value>The Name.</value>
		/// <author>PSL.</author>
		public string Name { get; set; }
		
		/// <summary>
		/// Gets or sets the column of the application.
		/// </summary>
		/// <value>The Score.</value>
		/// <author>PSL.</author>
		public int? Score { get; set; }
		
		/// <summary>
		/// Gets or sets the column of the application.
		/// </summary>
		/// <value>The Visibility.</value>
		/// <author>PSL.</author>
		public string Visibility { get; set; }
		
		/// <summary>
		/// This is the list DTO from PlayListDetail.
		/// </summary>
		/// <value>The list PlayListDetail.</value>
		/// <author>PSL.</author>
	    public List<PlayListDetailDto> PlayListDetail { get; set; }
	
	    [JsonIgnore]
		public bool? ReferenceTablePlayListDetail { get; set; }
		
		/// <summary>
		/// This is the list DTO from UserPlayList.
		/// </summary>
		/// <value>The list UserPlayList.</value>
		/// <author>PSL.</author>
	    public List<UserPlayListDto> UserPlayList { get; set; }
	
	    [JsonIgnore]
		public bool? ReferenceTableUserPlayList { get; set; }
		
	}
}