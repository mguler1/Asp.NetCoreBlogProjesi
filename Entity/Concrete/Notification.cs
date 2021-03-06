using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
  public  class Notification
    {
        public int NotificationId { get; set; }
        public string NotificationType { get; set; }
        public string NotificationTypeSymbol { get; set; }
        public string NotificationDescription { get; set; }
        public DateTime NotificationDate { get; set; }
        public bool NotificationStatus { get; set; }
    }
}
