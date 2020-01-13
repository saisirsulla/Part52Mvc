using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Part52Mvc_.Models
{
    [MetadataType(typeof(EmployeeMetadata))]
    public partial class Employee
    {

    }
    public class EmployeeMetadata
    {
        [DisplayFormat(NullDisplayText = "Gender not specified")]
        public string Gender { get; set; }
    }
}