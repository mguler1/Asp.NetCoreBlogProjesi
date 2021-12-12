using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity.Concrete
{
   public class Subsucribe
    {
        [Key]
        public int MailId { get; set; }
        public string Mail { get; set; }
        public bool MailStatus { get; set; }
    }
}
