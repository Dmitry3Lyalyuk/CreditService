using CredirService.Domain.Common;
using CredirService.Domain.Enums;
using System.Data;

namespace CreditService.Application.Credits.Queries
{
    public class CreditDTO : BaseAuditableEntity
    {
        public string Number { get; set; }
        public decimal Amount { get; set; }
        public int TermValue { get; set; }
        public decimal InterestValue { get; set; }
        public Status Status { get; set; }
        public DataSetDateTime CreatedAt { get; set; }
        public DataSetDateTime LastModifiedAt { get; set; }
    }
}
