using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bagirova_A
{
    static class Pages
    {
        private static Catalog_1 _catalog1 = new Catalog_1();
        private static Catalog_2 _catalog2 = new Catalog_2();

        public static Catalog_1 Catalog_1
        {
            get
            {
                return _catalog1;
            }
        }

        public static Catalog_2 Catalog_2
        {
            get
            {
                return _catalog2;
            }
        }
    }

}
