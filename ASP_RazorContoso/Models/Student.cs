﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_RazorContoso.Models
{
        public class Student
        {
            public int StudentID { get; set; }
            
            [DisplayName("Last Name"), Required, StringLength(20)]
            public string LastName { get; set; }

            [DisplayName("First Name"), Required, StringLength(20)]
            public string FirstName { get; set; }

            [DisplayName("Enrol Date"), DataType(DataType.Date)]
            [DisplayFormat(DataFormatString ="YYYY/MM/DD")]
            public DateTime EnrollmentDate { get; set; }

            //Relationships or navigation properties
            public virtual ICollection<Enrollment> Enrollments { get; set; }
        }
}
