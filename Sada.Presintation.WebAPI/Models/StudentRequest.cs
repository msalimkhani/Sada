using Sada.Core.Domain.Models;

namespace Sada.Presintation.WebAPI.Models
{
    public class StudentRegisterRequest : Person
    {
        public StudentRegisterRequest() : base() { }
    }
    public class StudentModifyRequest : Person
    {
        public StudentModifyRequest() : base() { }
        public int StudentId { get; set; }
    }
}
