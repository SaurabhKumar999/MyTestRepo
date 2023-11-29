using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Models
{
    public class Teachers
    {
        [Key]
        public int TeacherId
        {
            get;
            set;
        }
        public string? FirstName
        {
            get;
            set;
        }
        public string? LastName
        {
            get;
            set;
        }
        public string? Emial
        {
            get;
            set;
        }
        public long? Phone_No
        {
            get;
            set;
        }
        public string? Gender
        {
            get;
            set;
        }
        public string? City
        {
            get;
            set;
        }
        public string? State
        {
            get;
            set;
        }
        public string? Country
        {
            get;
            set;
        }
        public DateTime? Date_of_Birth
        {
            get;
            set;
        }
        public long? Salary
        {
            get;
            set;
        }
        public DateTime? Date_of_Joining
        {
            get;
            set;
        }
    }
}
