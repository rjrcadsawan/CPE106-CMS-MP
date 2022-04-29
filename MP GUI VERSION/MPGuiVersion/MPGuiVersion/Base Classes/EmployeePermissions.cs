using System;
using System.Collections.Generic;
using System.Text;

namespace MPGuiVersion
{
    public class EmployeePermissions
    {
        private int employeeID;

        public bool accessInventory { get; set; }
        public bool accessBookkeeping { get; set; }
        public bool accessTasks { get; set; }
        public bool accessEmployees { get; set; }
        public bool accessSettings { get; set; }
        public bool accessPermissions { get; set; }
    }
}
