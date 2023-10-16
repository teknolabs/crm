﻿using TeknoLabs.Crm.Domain.Abstract;

namespace TeknoLabs.Crm.Domain.ClientEntities
{
    public sealed class UniformChartOfAccount : Entity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public char Type { get; set; }
        public string CompanyId { get; set; }
    }
}
