//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OwinSignalR.Data.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Application
    {
        public Application()
        {
            this.ApplicationReferralUrls = new HashSet<ApplicationReferralUrl>();
        }
    
        public int ApplicationId { get; set; }
        public string ApplicationName { get; set; }
        public string ApiToken { get; set; }
        public string ApplicationSecret { get; set; }
    
        public virtual ICollection<ApplicationReferralUrl> ApplicationReferralUrls { get; set; }
    }
}
