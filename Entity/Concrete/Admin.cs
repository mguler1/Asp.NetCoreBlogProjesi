using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
  public  class Admin
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string Role { get; set; }
    }
}
