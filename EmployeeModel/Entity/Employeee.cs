using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeModel.Entity
{
    public class Employeee: BaseEntity
    {
        public User User { get; set; }

        public Guid UserId { get; set; }
       
        public string EmployeeIdentity { get; set; }

        public string OfficialMail { get; set; }

        public string OfficialPhoneNumber { get; set; }
       
      
    }
}
