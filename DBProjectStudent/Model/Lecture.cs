//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBProjectStudent.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Lecture
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lecture()
        {
            this.Projects = new HashSet<Project>();
        }
    
        public string L_ID { get; set; }
        public string L_name { get; set; }
        public string L_fullname { get; set; }
        public string L_department { get; set; }
        public string L_gender { get; set; }
        public Nullable<System.DateTime> L_birthday { get; set; }
        public string L_phone { get; set; }
        public string L_email { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Project> Projects { get; set; }

        public override string ToString()
        {
            return this.L_fullname;
        }
    }
}
