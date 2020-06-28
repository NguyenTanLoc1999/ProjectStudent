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
    
    public partial class Student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student()
        {
            this.ProjectManagements = new HashSet<ProjectManagement>();
        }
    
        public string S_ID { get; set; }
        public string S_name { get; set; }
        public string S_fullname { get; set; }
        public string S_major { get; set; }
        public Nullable<System.DateTime> S_birthday { get; set; }
        public string S_phone { get; set; }
        public string S_email { get; set; }
        public string S_gender { get; set; }
        [System.ComponentModel.Browsable(false)]
        public string IDLogin { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [System.ComponentModel.Browsable(false)]
        public virtual ICollection<ProjectManagement> ProjectManagements { get; set; }
        [System.ComponentModel.Browsable(false)]
        public virtual UserLogin UserLogin { get; set; }

        public override string ToString()
        {
            return this.S_fullname;
        }
    }
}
