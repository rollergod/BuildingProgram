using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingProgram.Models
{
    public class BuildingObject
    {
        public int Id { get; set; }
        public int ObjectNumber { get; set; }
        public string ObjectName { get; set; }
        public string Address { get; set; }
        public bool IsChecked { get; set; } = false;
        public bool IsBuildingEnded { get; set; } = false;
        public bool IsBuildPermit { get; set; }
        public DateOnly StartPlanned { get; set; }
        public DateOnly StartActual { get; set; }
        public DateOnly EndDate { get; set; }
        public int BuildingStatus { get; set; } // TODO : придумать статусы (может быть ENUM?)
         
        public string? ImageName { get; set; }
        // TODO : добавить связи выполнения контроля и строительной компании
    }
}
