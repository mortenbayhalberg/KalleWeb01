﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KalleWebSite.Models
{
    public class tblSpiller
    {

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public tblSpiller()
        // {
        //    this.tblSpil = new HashSet<tblSpil>();
        // }

        public int CN_SpillerPK { get; set; }
        public string CN_SpillerForNavn { get; set; }
        public string CN_SpillerEfterNavn { get; set; }
        public string CN_SpillerInit { get; set; }
        public Nullable<System.DateTime> CN_SpillerOptDato { get; set; }
        public Nullable<System.DateTime> CN_SpillerUdMeldDato { get; set; }
        public Nullable<bool> CN_SpillerFormand { get; set; }
        public Nullable<bool> CN_SpillerNastFormand { get; set; }
        public Nullable<bool> CN_SpillerKasser { get; set; }
        public Nullable<bool> CN_SpillerRevisor { get; set; }
        public Nullable<bool> CN_SpillerSkemaAnsv { get; set; }
        public Nullable<bool> CN_SpillerWebAnsv { get; set; }
        public string CN_EMail { get; set; }
        public Nullable<bool> CN_AktivMedl { get; set; }
        public Nullable<bool> CN_PassivMedl { get; set; }
        public Nullable<bool> CN_ProveMedl { get; set; }

        // [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        // public virtual ICollection<tblSpil> tblSpil { get; set; }
    }
}