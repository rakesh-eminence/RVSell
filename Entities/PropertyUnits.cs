using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class PropertyUnits
    {
        [Key]
        [Column("PropertyUnitID")]
        public int PropertyUnitID { get; set; }

        [Column("AccountID")]
        public int AccountID { get; set; }

        [Column("Name")]
        public string Name { get; set; }

        [Column("Installation")]
        public string Installation { get; set; }

        [Column("PageName")]
        public string PageName { get; set; }

        [Timestamp]
        [Column("Timestamp")]
        public byte[] Timestamp { get; set; }

        [Column("CreateDate")]
        public DateTime CreateDate { get; set; }

        [Column("LastUpdateDate")]
        public DateTime LastUpdateDate { get; set; }

        [Column("Description")]
        public string Description { get; set; }

        [Column("AdditionalInformation")]
        public string AdditionalInformation { get; set; }

        [Column("LastModifiedByAccountID")]
        public int LastModifiedByAccountID { get; set; }

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

        [Column("PropertyCode")]
        public string PropertyCode { get; set; }

        [Column("BookingAvailabilityMessage")]
        public string BookingAvailabilityMessage { get; set; }

        [Column("PropertyTitle")]
        public string PropertyTitle { get; set; }

        [Column("SquareFootage")]
        public string SquareFootage { get; set; }

        [Column("RollawaysAllowed")]
        public bool RollawaysAllowed { get; set; }

        [Column("PetDeposit")]
        public string PetDeposit { get; set; }

        [Column("PropertyID")]
        public int PropertyID { get; set; }

        [Column("MaxOccupancy")]
        public int MaxOccupancy { get; set; }

        [Column("NumberOfBedrooms")]
        public int NumberOfBedrooms { get; set; }

        [Column("NumberOfBathrooms")]
        public int NumberOfBathrooms { get; set; }


        [Column("Name")]
        public string PropertyName { get; set; }
    }
}
