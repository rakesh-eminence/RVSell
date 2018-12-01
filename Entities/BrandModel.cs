using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
   public class BrandModel
    {
        [Key]
        [Column("BrandID")]
        public int BrandID { get; set; }

        [Column("GeneralInformation")]
        public string GeneralInformation { get; set; }

        [Column("Faq")]
        public string Faq { get; set; }

        [Column("PoliciesAndProcedures")]
        public string PoliciesAndProcedures { get; set; }

        [Column("parking")]
        public string parking { get; set; }

        [Column("AdditionalInformation")]
        public string AdditionalInformation { get; set; }
    }
}
