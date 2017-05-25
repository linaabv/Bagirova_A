using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bagirova_A
{
    public class NewUser
    {
        private int _budget;
        public int Budget
        {
            get { return _budget; }
            set { _budget = value; }
        }
        public NewUser(int budget)
        {
            _budget = budget;
        }
    }
}
