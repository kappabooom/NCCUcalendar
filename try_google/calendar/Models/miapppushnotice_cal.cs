//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace calendar.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class miapppushnotice_cal
    {
        public int id { get; set; }
        public string ldap_id { get; set; }
        public string role_cod { get; set; }
        public string title { get; set; }
        public string body { get; set; }
        public System.DateTime inserted_date { get; set; }
        public Nullable<System.DateTime> set_pushdate { get; set; }
        public bool istran { get; set; }
        public Nullable<System.DateTime> tran_date { get; set; }
    }
}
