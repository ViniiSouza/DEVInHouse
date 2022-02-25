using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymAdministration.Core
{
    public class Equipment
    {
        public int Id { get; private set; }

        public string Name { get; private set; }

        public string Description { get; private set; }

        public DateTime AcquiredDate { get; private set; }

        public Equipment(int id, string name, string description, DateTime acquiredDate)
        {
            Id = id;
            Name = name;
            Description = description;
            AcquiredDate = acquiredDate;
        }
    }
}
