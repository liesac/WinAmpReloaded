// <copyright file="UserDto.cs" company="">
// PSL. All rights reserved.
// </copyright>
// <author>PSL.</author>
// <summary>This is the DTO from User</summary>
namespace WinAmp2.COMMON.DTOs.PlayListsProject
{
    using Newtonsoft.Json;
	using System;
    using System.Collections.Generic;
	/// <summary>
	/// Gets or sets the column of the application.
	/// </summary>
	/// <value>The User.</value>
	/// <author>PSL.</author>
	public class UserDto : BaseDto
	{
		/// <summary>
		/// Gets or sets the column of the application.
		/// </summary>
		/// <value>The IdUser.</value>
		/// <author>PSL.</author>
		public int? IdUser { get; set; }
		
		/// <summary>
		/// Gets or sets the column of the application.
		/// </summary>
		/// <value>The IdRole.</value>
		/// <author>PSL.</author>
		public int? IdRole { get; set; }
		
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
		/// <value>The UserName.</value>
		/// <author>PSL.</author>
		public string UserName { get; set; }
		
		/// <summary>
		/// Gets or sets the column of the application.
		/// </summary>
		/// <value>The Email.</value>
		/// <author>PSL.</author>
		public string Email { get; set; }
		
		/// <summary>
		/// Gets or sets the column of the application.
		/// </summary>
		/// <value>The Password.</value>
		/// <author>PSL.</author>
		public string Password { get; set; }
		
		/// <summary>
		/// This is the list DTO from UserPlayList.
		/// </summary>
		/// <value>The list UserPlayList.</value>
		/// <author>PSL.</author>
	    public List<UserPlayListDto> UserPlayList { get; set; }
	
	    [JsonIgnore]
		public bool? ReferenceTableUserPlayList { get; set; }
		
		/// <summary>
		/// This is the DTO from Role.
		/// </summary>
		/// <value>The Role.</value>
		/// <author>PSL.</author>
	    public RoleDto Role { get; set; }
	
	    [JsonIgnore]
		public bool? ReferenceTableRole { get; set; }
		
	}
}