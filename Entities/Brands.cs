using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("Brands")]
    public class Brands
    {
        [Key]
        [Column("BrandID")]
        public int BrandID { get; set; }

        [Column("BrandName")]
        public string BrandName { get; set; }

        [Timestamp]
        [Column("Timestamp")]
        public byte[] Timestamp { get; set; }

        [Column("RoomCount")]
        public int RoomCount { get; set; }

        [Column("HoursOfOperation")]
        public string HoursOfOperation { get; set; }

        [Column("PmsCmsLinks")]
        public string PmsCmsLinks { get; set; }

        [Column("Poc")]
        public string Poc { get; set; }

        [Column("MarketsServed")]
        public string MarketsServed { get; set; }

        [Column("GroupsAllowed")]
        public bool GroupsAllowed { get; set; }

        [Column("GiftCertificates")]
        public string GiftCertificates { get; set; }

        [Column("CallScript")]
        public string CallScript { get; set; }

        [Column("LogoFileID")]
        public Int64 LogoFileID { get; set; }

        [Column("Faq")]
        public string Faq { get; set; }

        [Column("Policy")]
        public string Policy { get; set; }

        [Column("SocialFacebook")]
        public string SocialFacebook { get; set; }

        [Column("SocialTwitter")]
        public string SocialTwitter { get; set; }

        [Column("SocialYouTube")]
        public string SocialYouTube { get; set; }

        [Column("SocialLinkedIn")]
        public string SocialLinkedIn { get; set; }

        [Column("SalesCallerID")]
        public string SalesCallerID { get; set; }

        [Column("Website")]
        public string Website { get; set; }

        [Column("MaintenanceEmail")]
        public string MaintenanceEmail { get; set; }

        [Column("SalesEmail")]
        public string SalesEmail { get; set; }

        [Column("GuestUseEmail")]
        public string GuestUseEmail { get; set; }

        [Column("PhoneMainLocal")]
        public string PhoneMainLocal { get; set; }

        [Column("Fax")]
        public string Fax { get; set; }

        [Column("PhoneTollFree")]
        public string PhoneTollFree { get; set; }

        [Column("EmergencyContact")]
        public string EmergencyContact { get; set; }

        [Column("MaintenanceContact")]
        public string MaintenanceContact { get; set; }

        [Column("Avatar")]
        public byte[] Avatar { get; set; }

        [Column("AvatarMimeType")]
        public string AvatarMimeType { get; set; }

        public string Benefits { get; set; }

        public virtual ICollection<Brands> lstBrands { get; set; }
    }
}
