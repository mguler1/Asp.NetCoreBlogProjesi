using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity.Concrete
{
    public  class About
    {
        [Key]
        public int AboutId { get; set; }
        public string AboutDetails1 { get; set; }
        public string AboutDetails2 { get; set; }
        public string AboutImage1 { get; set; }
        public string AboutImage2 { get; set; }
        public string AboutImageMapLocation { get; set; }
        public bool AboutStatus { get; set; }
    }
}
