// <copyright file="UserPlayListDto.cs" company="">
// PSL. All rights reserved.
// </copyright>
// <author>PSL.</author>
// <summary>This is the DTO from UserPlayList</summary>
namespace WinAmp2.COMMON.DTOs.PlayListsProject
{
    using Newtonsoft.Json;
	using System;
    
	/// <summary>
	/// Gets or sets the column of the application.
	/// </summary>
	/// <value>The UserPlayList.</value>
	/// <author>PSL.</author>
	public class UserPlayListDto : BaseDto
	{
		/// <summary>
		/// Gets or sets the column of the application.
		/// </summary>
		/// <value>The IdUserPlayList.</value>
		/// <author>PSL.</author>
		public int? IdUserPlayList { get; set; }
		
		/// <summary>
		/// Gets or sets the column of the application.
		/// </summary>
		/// <value>The IdUser.</value>
		/// <author>PSL.</author>
		public int? IdUser { get; set; }
		
		/// <summary>
		/// Gets or sets the column of the application.
		/// </summary>
		/// <value>The IdPlayList.</value>
		/// <author>PSL.</author>
		public int? IdPlayList { get; set; }
		
		/// <summary>
		/// This is the DTO from PlayList.
		/// </summary>
		/// <value>The PlayList.</value>
		/// <author>PSL.</author>
	    public PlayListDto PlayList { get; set; }
	
	    [JsonIgnore]
		public bool? ReferenceTablePlayList { get; set; }
		
		/// <summary>
		/// This is the DTO from User.
		/// </summary>
		/// <value>The User.</value>
		/// <author>PSL.</author>
	    public UserDto User { get; set; }
	
	    [JsonIgnore]
		public bool? ReferenceTableUser { get; set; }
		
	}
}