using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Hometown_Application.Areas.Identity.Data;

public class ApplicationUser : IdentityUser
{
    [PersonalData]
    [Column(TypeName = "nvarchar(100)")]
    public string FirstName { get; set; }

    [PersonalData]
    [Column(TypeName = "nvarchar(100)")]
    public string LastName { get; set; }

    public byte[]? ProfilePicture { get; set; }

    [PersonalData]
    [Column(TypeName = "nvarchar(50)")]
    public string? BlockNumber { get; set; }

    [PersonalData]
    public int? LotNumber { get; set; }

    [PersonalData]
    [Column(TypeName = "nvarchar(150)")]
    public string? StreetName { get; set; }

    
}

