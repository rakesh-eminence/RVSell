using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("Propertys")]
    public class Propertys
    {
        [Key]
        [Column("PropertyID")]
        public int PropertyID { get; set; }

        [Column("AccountID")]
        public int AccountID { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("Installation")]
        public string Installation { get; set; }

        [Column("Address")]
        public string Address { get; set; }

        [Column("WebsiteUrl")]
        public string WebsiteUrl { get; set; }

        [Column("EmailAddress")]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", ErrorMessage = "Invalid Email Id")]
        public string EmailAddress { get; set; }

        [Column("LocaleID")]
        public int LocaleID { get; set; }

        [Column("CityID")]
        public int CityID { get; set; }

        [Column("StateID")]
        public int StateID { get; set; }

        [Column("PageName")]
        public string PageName { get; set; }

        [Timestamp]
        [Column("Timestamp")]
        public byte[]  timestamp { get; set; }

        [Column("CreateDate")]
        public DateTime CreateDate { get; set; }

        [Column("LastUpdateDate")]
        public DateTime LastUpdateDate { get; set; }

        [Column("CityName")]
        public string CityName { get; set; }

        [Column("Description")]
        public string Description { get; set; }

        [Column("Zipcode")]
        public string Zipcode { get; set; }

        [Column("RegionID")]
        public int RegionID { get; set; }

        [Column("AdditionalInformation")]
        public string AdditionalInformation { get; set; }

        [Column("LastModifiedByAccountID")]
        public int LastModifiedByAccountID { get; set; }

        [Column("BranchOfServiceID")]
        public int BranchOfServiceID { get; set; }

        [Column("BrandID")]
        public int BrandID { get; set; }

        [Column("ChildrenAllowed")]
        public bool ChildrenAllowed { get; set; }

        [Column("AgeRequirement")]
        public int AgeRequirement { get; set; }

        [Column("PetsAllowed")]
        public bool PetsAllowed { get; set; }

        [Column("PetSizeMaxWeight")]
        public int PetSizeMaxWeight { get; set; }

        [Column("InteriorCorridors")]
        public int InteriorCorridors { get; set; }

        [Column("ExteriorCorridors")]
        public int ExteriorCorridors { get; set; }

        [Column("PropertyCode")]
        public string PropertyCode { get; set; }

        [Column("PropertyTitle")]
        public string PropertyTitle { get; set; }

        [Column("MaintenanceEmailAddress")]
        public string MaintenanceEmailAddress { get; set; }

        [Column("SalesEmailAddress")]
        public string SalesEmailAddress { get; set; }

        [Column("SquareFootage")]
        public string SquareFootage { get; set; }

        [Column("PetDeposit")]
        public string PetDeposit { get; set; }

        [Column("LocalTransportation")]
        public string LocalTransportation { get; set; }

        [Column("Parking")]
        public string Parking { get; set; }


        [Column("Faq")]
        public string Faq { get; set; }

        [Column("Policy")]
        public string Policy { get; set; }


        [Column("BenefitName")]
        public string BenefitName { get; set; }

        public int RoomCount { get; set; }

        public int SkipRows { get; set; }

        public int TakeRows { get; set; }

        public int TotalRecordsCount { get; set; }

        public string PropertyName { get; set; }

        public int RoomMinimum { get; set; }


        public int RoomMaximum { get; set; }


        public int BathRoomMinimum { get; set; }

        public int BathRoomMaximum { get; set; }

        public int DestinationTypeID { get; set; }

     
        public int FilterRecordCount { get; set; }
    }
}