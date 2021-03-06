using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace WebTasksProject.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the WebTasksProjectUser class
    public class WebTasksProjectUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string Nome { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string Sobrenome { get; set; }
    }
}
