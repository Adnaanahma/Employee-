﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeModel.Entity
{
    public class BaseEntity
    {
        public Guid Id { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }
    }
}
