using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerSaleSYS
{
    public class Dropdown
    {
        public Panel Container {  get; set; }
        public bool IsExpanded { get; set; }
        public Timer Timer { get; set; }
    }
}
