using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.Model
{
    public class Product
    {
        #region Public Properties

        public int Id { get; set; }


        public virtual Manufacturer Manufacturer { get; set; }


        public int ManufacturerId { get; set; }


        public string Name { get; set; }

        #endregion

        #region Public Constructors

        public Product()
        { }

        #endregion
    }
}
