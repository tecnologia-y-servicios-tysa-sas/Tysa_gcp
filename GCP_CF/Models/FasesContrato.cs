﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GCP_CF.Models
{
    public class FasesContrato
    {
        [Key]
        public int FaseContrato_Id { get; set; }
        public string Descripcion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ActividadesFases> ActividadesFases { get; set; }
    }
}