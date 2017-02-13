using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.Model
{
    public class Manufacturer
    {
        #region Public Properties

        public int Id { get; set; }


        public string Name { get; set; }


        public virtual ICollection<Product> Products { get; set; }

        #endregion

        #region Public Constructors

        public Manufacturer()
        { }

        #endregion
    }
}
