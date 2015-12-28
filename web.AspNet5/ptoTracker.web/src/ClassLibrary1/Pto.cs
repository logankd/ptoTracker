using System;
using System.ComponentModel.DataAnnotations;

namespace PtoTracker.Models
{
    public class Pto
    {
		[Key]
	    public int Id { get; set; }
	    public int UserId { get; set; }
	    public DateTime Start { get; set; }
	    public DateTime End { get; set; }
	    public User ApprovedBy { get; set; }	
    }
}
