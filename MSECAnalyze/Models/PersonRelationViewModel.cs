using Domain.Entities;
namespace MSECAnalyze.Models
{
    public class PersonRelationViewModel
    {
        public PersonRelation PersonRelation { get; set; }
        public Person Person { get; set; }
        public Relationship Relationship { get; set; }
    }
}