using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelWork.Domain.Entities
{
    /// <summary>
    /// Contains common properties for all models.
    /// </summary>
    public class BaseModel
    {
      /// <summary>
      /// Creating Hospital code
      /// </summary>
        public string?  HospitalCode { get; set; }
        /// <summary>
        /// Creation Date of the row.
        /// </summary>
        [Column(TypeName = "smalldatetime")]
        public DateTime DateCreated { get; set; }
        /// <summary>
        /// Entry the Created by
        /// </summary>
        public Guid CreatedBy { get; set; }
        /// <summary>
        /// Modified Date of the row.
        /// </summary>
        [Column(TypeName = "smalldatetime")]
        public DateTime DateModified { get; set; }
        /// <summary>
        /// Entry the Modified by
        /// </summary>
        public Guid ModifiedBy { get; set; }
        /// <summary>
        /// Indicates the row is deleted or not.
        /// </summary>
        public bool IsRowDeleted { get; set; }
    }
}
