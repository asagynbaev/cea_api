using System;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class Shifts
    {
        [Key]
        public int Id { get; set; }
        public int positionId { get; set; }
        public DateTime ShiftDate { get; set; }
        public int? EmployeeId { get; set; }
        public int? OrganizationId { get; set; }
        public int? SortOrder { get; set; }
        public bool IsCanceled { get; set; }
        public DateTime? CanceledAt { get; set; }
        public int CanceledBy { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}