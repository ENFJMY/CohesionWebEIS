using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CohesionWebEIS.Models.DTO
{
    public class PageInfoDTO
    {
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages 
        {
            get { return Convert.ToInt32(Math.Ceiling((double)TotalItems / ItemsPerPage)); }
        }
    }
}