using TeknoLabs.Crm.Domain.Abstract;

namespace TeknoLabs.Crm.Domain.AppEntities
{
    public sealed class Client : Entity
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string TaxDepartmant { get; set; }
        public string TaxNo { get; set; }

        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }

    }
}
