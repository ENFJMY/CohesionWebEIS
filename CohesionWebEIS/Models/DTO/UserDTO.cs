using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CohesionWebEIS.Models.DTO
{
    public class UserDTO
    {
        public string USER_ID         { get; set; }
        public string USER_NAME       { get; set; }
        public string USER_GROUP_CODE { get; set; }
        public string USER_PASSWORD   { get; set; }
        public string USER_DEPARTMENT { get; set; }
    }
}