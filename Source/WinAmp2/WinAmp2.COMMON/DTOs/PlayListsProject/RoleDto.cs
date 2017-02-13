// <copyright file="RoleDto.cs" company="">
// PSL. All rights reserved.
// </copyright>
// <author>PSL.</author>
// <summary>This is the DTO from Role</summary>
namespace WinAmp2.COMMON.DTOs.PlayListsProject
{
    using Newtonsoft.Json;
	using System;
    using System.Collections.Generic;
	/// <summary>
	/// Gets or sets the column of the application.
	/// </summary>
	/// <value>The Role.</value>
	/// <author>PSL.</author>
	public class RoleDto : BaseDto
	{
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
		/// This is the list DTO from User.
		/// </summary>
		/// <value>The list User.</value>
		/// <author>PSL.</author>
	    public List<UserDto> User { get; set; }
	
	    [JsonIgnore]
		public bool? ReferenceTableUser { get; set; }
		
	}
}