using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core
{
    public abstract class BaseEntity
        /*
         Abstract yapılmasının sebebi Base Entityden Nesne Örneğinin Alınmaması Özelliği
         Abstract Classlar ortak propların tanımlandığı yerlerde kullanılır.
        */
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
