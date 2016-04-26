using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_Code_First
{
    public class NEWCreditCards
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public int EmployeeId { get; set; }

        public virtual Employees Employee{ get; set; }
    }
}
