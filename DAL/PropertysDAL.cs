using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using Entities;
using System.Data.Common;
using System.Data.SqlClient;

namespace DAL
{
    public class PropertysDAL
    {


        public List<PropertyUnits> GettAllPropertiesByBrands(int BrandID)
        {
            List<PropertyUnits> lstProperty = new List<PropertyUnits>();
            SqlDataAdapter adpt = new SqlDataAdapter("Select * from Propertys where BrandId=" + BrandID, new DataConn().GetConn());
            DataSet ds = new DataSet();
            adpt.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    PropertyUnits prop = new PropertyUnits();
                    prop.PropertyUnitID = Convert.ToInt32(ds.Tables[0].Rows[i]["PropertyUnitID"].ToString());
                    prop.AccountID = Convert.ToInt32(ds.Tables[0].Rows[i]["AccountID"].ToString());
                    prop.Name = Convert.ToString(ds.Tables[0].Rows[i]["Name"].ToString());
                    prop.Installation = Convert.ToString(ds.Tables[0].Rows[i]["Installation"].ToString());
                    prop.PageName = Convert.ToString(ds.Tables[0].Rows[i]["PageName"].ToString());
                    //prop.timeStamp = Convert.ToDateTime(ds.Tables[0].Rows[i]["timeStamp"].ToString());
                    //prop.CreateDate = Convert.ToDateTime(ds.Tables[0].Rows[i]["CreateDate"].ToString());
                    //prop.LastUpdateDate = Convert.ToDateTime(ds.Tables[0].Rows[i]["LastUpdateDate"].ToString());
                    prop.Description = Convert.ToString(ds.Tables[0].Rows[i]["Description"].ToString());
                    prop.AdditionalInformation = Convert.ToString(ds.Tables[0].Rows[i]["AdditionalInformation"].ToString());
                    prop.LastModifiedByAccountID = Convert.ToInt32(ds.Tables[0].Rows[i]["LastModifiedByAccountID"].ToString());
                    prop.BrandID = Convert.ToInt32(ds.Tables[0].Rows[i]["BrandID"].ToString());
                    prop.ChildrenAllowed = (ds.Tables[0].Rows[i]["ChildrenAllowed"].ToString() == "1" ? true : false);
                    prop.AgeRequirement = Convert.ToInt32(ds.Tables[0].Rows[i]["AgeRequirement"].ToString());
                    prop.PetsAllowed = (ds.Tables[0].Rows[i]["PetsAllowed"].ToString() == "1" ? true : false);
                    prop.PetSizeMaxWeight = Convert.ToInt32(ds.Tables[0].Rows[i]["PetSizeMaxWeight"].ToString());
                    prop.PropertyCode = Convert.ToString(ds.Tables[0].Rows[i]["PropertyCode"].ToString());
                    prop.BookingAvailabilityMessage = Convert.ToString(ds.Tables[0].Rows[i]["BookingAvailabilityMessage"].ToString());
                    prop.PropertyTitle = Convert.ToString(ds.Tables[0].Rows[i]["PropertyTitle"].ToString());
                    prop.SquareFootage = Convert.ToString(ds.Tables[0].Rows[i]["SquareFootage"].ToString());
                    prop.RollawaysAllowed = (ds.Tables[0].Rows[i]["RollawaysAllowed"].ToString() == "1" ? true : false);
                    prop.PetDeposit = Convert.ToString(ds.Tables[0].Rows[i]["PetDeposit"].ToString());
                    prop.PropertyID = Convert.ToInt32(ds.Tables[0].Rows[i]["PropertyID"].ToString());
                    prop.MaxOccupancy = Convert.ToInt32(ds.Tables[0].Rows[i]["MaxOccupancy"].ToString());
                    prop.NumberOfBedrooms = Convert.ToInt32(ds.Tables[0].Rows[i]["NumberOfBedrooms"].ToString());
                    prop.NumberOfBathrooms = Convert.ToInt32(ds.Tables[0].Rows[i]["NumberOfBathrooms"].ToString());
                    lstProperty.Add(prop);
                }
            }
            return lstProperty;
        }

        public List<PropertyUnits> GetAllPropertyUnits(int PropertyID)
        {
            List<PropertyUnits> lstPropUnits = new List<PropertyUnits>();
            SqlDataAdapter adpt = new SqlDataAdapter("select * from PropertyUnits where PropertyID =" + PropertyID, new DataConn().GetConn());
            DataSet ds = new DataSet();
            adpt.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    PropertyUnits punits = new PropertyUnits();
                    punits.PropertyUnitID = Convert.ToInt32(ds.Tables[0].Rows[i][0].ToString());
                    //punits.AccountID = Convert.ToInt32(ds.Tables[0].Rows[i][1].ToString());
                    punits.Name = Convert.ToString(ds.Tables[0].Rows[i][2].ToString());
                    //punits.Installation = Convert.ToString(ds.Tables[0].Rows[i][3].ToString());
                    //punits.PageName = Convert.ToString(ds.Tables[0].Rows[i][4].ToString());
                    //punits.Timestamp = (byte[])(ds.Tables[0].Rows[i][5]);
                    //punits.CreateDate = Convert.ToDateTime(ds.Tables[0].Rows[i][6].ToString());
                    //punits.LastUpdateDate = Convert.ToDateTime(ds.Tables[0].Rows[i][7].ToString());
                    punits.Description = Convert.ToString(ds.Tables[0].Rows[i][8].ToString());
                    punits.AdditionalInformation = Convert.ToString(ds.Tables[0].Rows[i][9].ToString());
                    //punits.LastModifiedByAccountID = Convert.ToInt32(ds.Tables[0].Rows[i][10].ToString());
                    //punits.BrandID = Convert.ToInt32(ds.Tables[0].Rows[i][11].ToString());
                    punits.ChildrenAllowed = (bool)(ds.Tables[0].Rows[i][12]);
                    //punits.AgeRequirement = Convert.ToInt32(ds.Tables[0].Rows[i][13].ToString());
                    punits.PetsAllowed = (bool)(ds.Tables[0].Rows[i][14]);
                    //punits.PetSizeMaxWeight = Convert.ToInt32(ds.Tables[0].Rows[i][15].ToString());
                    //punits.PropertyCode = Convert.ToString(ds.Tables[0].Rows[i][16].ToString());
                    punits.BookingAvailabilityMessage = Convert.ToString(ds.Tables[0].Rows[i][17].ToString());
                    // punits.PropertyTitle = Convert.ToString(ds.Tables[0].Rows[i][18].ToString());
                    //  punits.SquareFootage = Convert.ToString(ds.Tables[0].Rows[i][19].ToString());
                    punits.RollawaysAllowed = (bool)(ds.Tables[0].Rows[i][20]);
                    punits.PetDeposit = Convert.ToString(ds.Tables[0].Rows[i][21].ToString());
                    //punits.PropertyID = Convert.ToInt32(ds.Tables[0].Rows[i][22].ToString());
                    punits.MaxOccupancy = Convert.ToInt32(ds.Tables[0].Rows[i][23].ToString());
                    punits.NumberOfBedrooms = Convert.ToInt32(ds.Tables[0].Rows[i][24].ToString());
                    punits.NumberOfBathrooms = Convert.ToInt32(ds.Tables[0].Rows[i][25].ToString());
                    lstPropUnits.Add(punits);
                }
            }
            return lstPropUnits;
        }

        public List<PropertyUnits> GetAllPropertyUnitByBrands(Brands brand)
        {
            List<PropertyUnits> lstPropUnits = new List<PropertyUnits>();
            SqlDataAdapter adpt = new SqlDataAdapter("select * from PropertyUnits where brandId=" + brand.BrandID, new DataConn().GetConn());
            DataSet ds = new DataSet();
            adpt.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    PropertyUnits punits = new PropertyUnits();
                    punits.PropertyUnitID = Convert.ToInt32(ds.Tables[0].Rows[i][0].ToString());
                    punits.AccountID = Convert.ToInt32(ds.Tables[0].Rows[i][1].ToString());
                    punits.Name = Convert.ToString(ds.Tables[0].Rows[i][2].ToString());
                    punits.Installation = Convert.ToString(ds.Tables[0].Rows[i][3].ToString());
                    punits.PageName = Convert.ToString(ds.Tables[0].Rows[i][4].ToString());
                    punits.Timestamp = (byte[])(ds.Tables[0].Rows[i][5]);
                    punits.CreateDate = Convert.ToDateTime(ds.Tables[0].Rows[i][6].ToString());
                    punits.LastUpdateDate = Convert.ToDateTime(ds.Tables[0].Rows[i][7].ToString());
                    punits.Description = Convert.ToString(ds.Tables[0].Rows[i][3].ToString());
                    punits.AdditionalInformation = Convert.ToString(ds.Tables[0].Rows[i][3].ToString());
                    punits.LastModifiedByAccountID = Convert.ToInt32(ds.Tables[0].Rows[i][14].ToString());
                    punits.BrandID = Convert.ToInt32(ds.Tables[0].Rows[i][15].ToString());
                    punits.ChildrenAllowed = ((Convert.ToInt32(ds.Tables[0].Rows[i][16].ToString()) == 1 ? true : false));
                    punits.AgeRequirement = Convert.ToInt32(ds.Tables[0].Rows[i][17].ToString());
                    punits.PetsAllowed = ((Convert.ToInt32(ds.Tables[0].Rows[i][18].ToString()) == 1 ? true : false));
                    punits.PetSizeMaxWeight = Convert.ToInt32(ds.Tables[0].Rows[i][19].ToString());
                    punits.PropertyCode = Convert.ToString(ds.Tables[0].Rows[i][20].ToString());
                    punits.BookingAvailabilityMessage = Convert.ToString(ds.Tables[0].Rows[i][21].ToString());
                    punits.PropertyTitle = Convert.ToString(ds.Tables[0].Rows[i][22].ToString());
                    punits.SquareFootage = Convert.ToString(ds.Tables[0].Rows[i][23].ToString());
                    punits.RollawaysAllowed = ((Convert.ToInt32(ds.Tables[0].Rows[i][24].ToString()) == 1 ? true : false));
                    punits.PetDeposit = Convert.ToString(ds.Tables[0].Rows[i][25].ToString());
                    punits.PropertyID = Convert.ToInt32(ds.Tables[0].Rows[i][26].ToString());
                    punits.MaxOccupancy = Convert.ToInt32(ds.Tables[0].Rows[i][27].ToString());
                    punits.NumberOfBedrooms = Convert.ToInt32(ds.Tables[0].Rows[i][28].ToString());
                    punits.NumberOfBathrooms = Convert.ToInt32(ds.Tables[0].Rows[i][29].ToString());
                    lstPropUnits.Add(punits);
                }
            }
            return lstPropUnits;
        }

        public string GetPropertyAmenities(Propertys prop)
        {
            String str = String.Empty;
            SqlDataAdapter adpt = new SqlDataAdapter("select * from Amenitys where AmenityID in (select AmenityID from PropertyAmenitys where PropertyID=" + prop.PropertyID + ")", new DataConn().GetConn());
            DataSet ds = new DataSet();
            adpt.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    str += ds.Tables[0].Rows[i]["AmenityName"].ToString() + ",";
                }
            }
            return str;
        }


        #region "Get List of All Propertys"
        public List<Propertys> GettAllPropertiesWithSearch(Propertys Model)
        {
            string exception = "";
             List<Propertys> lstProperty = new List<Propertys>();


            //string query = @"declare @skipRows int = " +  +",@takeRows int ="+ 30 + ",@BrandID int = " + 35 + ", @TotalRecords  int =" + 0;
            //       query += "select @TotalRecords = COUNT(*) from Brands b1 inner join Propertys p1 on b1.BrandID = p1.BrandID where b1.BrandID = @BrandID "; 
            //        query += "Select @TotalRecords TotalRecords, STUFF((select distinct ' , ' +  BenefitName from PropertyUnitBenefits Pub inner join  Benefits b on Pub.BenefitID = b.BenefitID inner join ";
            //query += "PropertyUnits pu on Pub.PropertyUnitID = pu.PropertyUnitID  where pu.PropertyID = p.PropertyID FOR XML PATH(''), TYPE ).value('.', 'NVARCHAR(MAX)') ,1,2,'') BenefitName,* ";
            //query += " from Propertys p inner join Brands b on p.BrandID = b.BrandID where b.BrandID = @BrandID ";
            //query += " ORDER BY b.BrandID OFFSET @skipRows ROWS FETCH NEXT @takeRows ROWS ONLY ";


            string query = " declare @skipRows int =" + Model.SkipRows + ", @takeRows int =" + Model.TakeRows + ", @BrandID int =" + Model.BrandID + ", @TotalRecordsCount  int = " + 0;
            query += " select @TotalRecordsCount = COUNT(*) from Brands b1 inner join Propertys p1 on b1.BrandID = p1.BrandID where b1.BrandID = @BrandID ";
            query += " Select @TotalRecordsCount TotalRecordsCount, STUFF((select distinct ' , ' + BenefitName from PropertyUnitBenefits Pub inner ";
            query += " join Benefits b on Pub.BenefitID = b.BenefitID inner join PropertyUnits pu on Pub.PropertyUnitID = pu.PropertyUnitID  ";
            query += " where pu.PropertyID = p.PropertyID FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)') ,1,2,'') BenefitName,* ";
            query += " from Propertys p inner join Brands b on p.BrandID = b.BrandID where b.BrandID = @BrandID";
            query += " ORDER BY b.BrandID OFFSET @skipRows ROWS FETCH NEXT @takeRows ROWS ONLY";




            DataSet ds = new DataSet();
            SqlDataAdapter adpt = new SqlDataAdapter(query, new DataConn().GetConn());
            //adpt.TableMappings.Add("y", "y");
            //adpt.TableMappings.Add("x", "x");

            adpt.Fill(ds);
            List<Benefits> benefit = new List<Benefits>();
            try
            {


                if (ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)

                    {
                        Propertys prop = new Propertys();
                        prop.PropertyID = Convert.ToInt32(ds.Tables[0].Rows[i]["PropertyID"].ToString());
                        prop.AccountID = Convert.ToInt32(ds.Tables[0].Rows[i]["AccountID"].ToString());
                        prop.Name = Convert.ToString(ds.Tables[0].Rows[i]["Name"].ToString());
                        prop.Installation = Convert.ToString(ds.Tables[0].Rows[i]["Installation"].ToString());
                        prop.Address = Convert.ToString(ds.Tables[0].Rows[i]["Address"].ToString());
                        prop.WebsiteUrl = Convert.ToString(ds.Tables[0].Rows[i]["WebsiteUrl"].ToString());
                        prop.EmailAddress = Convert.ToString(ds.Tables[0].Rows[i]["EmailAddress"].ToString());
                        if (!String.IsNullOrEmpty(ds.Tables[0].Rows[i]["LocaleID"].ToString()))
                        {
                            prop.LocaleID = Convert.ToInt32(ds.Tables[0].Rows[i]["LocaleID"].ToString());
                        }
                        else
                        {
                            prop.LocaleID = 0;
                        }
                        if (!String.IsNullOrEmpty(ds.Tables[0].Rows[i]["CityID"].ToString()))
                        {
                            prop.CityID = Convert.ToInt32(ds.Tables[0].Rows[i]["CityID"].ToString());
                        }
                        else
                        {
                            prop.CityID = 0;
                        }
                        if (!String.IsNullOrEmpty(ds.Tables[0].Rows[i]["StateID"].ToString()))
                        {
                            prop.StateID = Convert.ToInt32(ds.Tables[0].Rows[i]["StateID"].ToString());
                        }
                        else
                        {
                            prop.StateID = 0;
                        }
                        prop.PageName = Convert.ToString(ds.Tables[0].Rows[i]["PageName"].ToString());
                        //prop.timeStamp = Convert.ToDateTime(ds.Tables[0].Rows[i]["timeStamp"].ToString());
                        try
                        {
                            prop.LastUpdateDate = Convert.ToDateTime(ds.Tables[0].Rows[i]["LastUpdateDate"].ToString());
                        }
                        catch (Exception) { }
                        prop.CityName = Convert.ToString(ds.Tables[0].Rows[i]["CityName"].ToString());
                        prop.Description = Convert.ToString(ds.Tables[0].Rows[i]["Description"].ToString());
                        prop.Zipcode = Convert.ToString(ds.Tables[0].Rows[i]["Zipcode"].ToString());
                        if (!String.IsNullOrEmpty(ds.Tables[0].Rows[i]["RegionID"].ToString()))
                        {
                            prop.RegionID = Convert.ToInt32(ds.Tables[0].Rows[i]["RegionID"].ToString());
                        }
                        else
                        {
                            prop.RegionID = 0;
                        }
                        prop.AdditionalInformation = Convert.ToString(ds.Tables[0].Rows[i]["AdditionalInformation"].ToString());
                        if (!String.IsNullOrEmpty(ds.Tables[0].Rows[i]["LastModifiedByAccountID"].ToString()))
                        {
                            prop.LastModifiedByAccountID = Convert.ToInt32(ds.Tables[0].Rows[i]["LastModifiedByAccountID"].ToString());
                        }
                        else
                        {
                            prop.LastModifiedByAccountID = 0;
                        }
                        if (!String.IsNullOrEmpty(ds.Tables[0].Rows[i]["BranchOfServiceID"].ToString()))
                        {
                            prop.BranchOfServiceID = Convert.ToInt32(ds.Tables[0].Rows[i]["BranchOfServiceID"].ToString());
                        }
                        else
                        {
                            prop.BranchOfServiceID = 0;
                        }
                        if (!String.IsNullOrEmpty(ds.Tables[0].Rows[i]["BrandID"].ToString()))
                        {
                            prop.BrandID = Convert.ToInt32(ds.Tables[0].Rows[i]["BrandID"].ToString());
                        }
                        else
                        {
                            prop.BrandID = 0;
                        }
                        prop.ChildrenAllowed = (ds.Tables[0].Rows[i]["ChildrenAllowed"].ToString() == "True" ? true : false);
                        if (!String.IsNullOrEmpty(ds.Tables[0].Rows[i]["AgeRequirement"].ToString()))
                        {
                            prop.AgeRequirement = Convert.ToInt32(ds.Tables[0].Rows[i]["AgeRequirement"].ToString());
                        }
                        else
                        {
                            prop.AgeRequirement = 0;
                        }
                        prop.PetsAllowed = (ds.Tables[0].Rows[i]["PetsAllowed"].ToString() == "True" ? true : false);
                        prop.PetSizeMaxWeight = Convert.ToInt32(ds.Tables[0].Rows[i]["PetSizeMaxWeight"].ToString());
                        prop.InteriorCorridors = (ds.Tables[0].Rows[i]["InteriorCorridors"].ToString() == "True" ? 1 : 0);
                        prop.ExteriorCorridors = (ds.Tables[0].Rows[i]["ExteriorCorridors"].ToString() == "True" ? 1 : 0);
                        prop.PropertyCode = Convert.ToString(ds.Tables[0].Rows[i]["PropertyCode"].ToString());
                        prop.PropertyTitle = Convert.ToString(ds.Tables[0].Rows[i]["PropertyTitle"].ToString());
                        prop.MaintenanceEmailAddress = Convert.ToString(ds.Tables[0].Rows[i]["MaintenanceEmailAddress"].ToString());
                        prop.SalesEmailAddress = Convert.ToString(ds.Tables[0].Rows[i]["SalesEmailAddress"].ToString());
                        prop.SquareFootage = Convert.ToString(ds.Tables[0].Rows[i]["SquareFootage"].ToString());
                        prop.PetDeposit = Convert.ToString(ds.Tables[0].Rows[i]["PetDeposit"].ToString());
                        prop.LocalTransportation = Convert.ToString(ds.Tables[0].Rows[i]["LocalTransportation"].ToString());
                        prop.Parking = Convert.ToString(ds.Tables[0].Rows[i]["Parking"].ToString());
                        prop.BenefitName = ds.Tables[0].Rows[i]["BenefitName"].ToString();
                        prop.RoomCount = Convert.ToInt32(ds.Tables[0].Rows[i]["RoomCount"]);
                        prop.TotalRecordsCount = Convert.ToInt32(ds.Tables[0].Rows[i]["TotalRecordsCount"]);
                        DataRow dr = ds.Tables[0].Rows[i];
                        lstProperty.Add(prop);
                    }

                }
            }
            catch (Exception ex)
            {
                exception =  ex.ToString();
                throw;
            }
            return lstProperty;

        }
        #endregion

        #region "Get List of All Propertys"
        public List<Propertys> GetAllPropertiesWithSearchText(Propertys Model)
        {
            List<Propertys> lstProperty = new List<Propertys>();

            string query = "";
            //query = " declare @skipRows int =" + Model.SkipRows + ", @takeRows int =" + Model.TakeRows + ", @BrandID int =" + Model.BrandID + ", @PropertyName  varchar(500) = " + "'%" + Model.PropertyName + "%'" + ",@TotalRecordsCount  int = " + 0;
            //query += " select @TotalRecordsCount = COUNT(*) from Brands b1 inner join Propertys p1 on b1.BrandID = p1.BrandID where b1.BrandID = @BrandID ";
            //query += " Select @TotalRecordsCount TotalRecordsCount, STUFF((select distinct ' , ' + BenefitName from PropertyUnitBenefits Pub inner ";
            //query += " join Benefits b on Pub.BenefitID = b.BenefitID inner join PropertyUnits pu on Pub.PropertyUnitID = pu.PropertyUnitID  ";
            //query += " where pu.PropertyID = p.PropertyID FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)') ,1,2,'') BenefitName,* ";
            //query += " from Propertys p inner join Brands b on p.BrandID = b.BrandID  where b.BrandID = @BrandID and p.Name LIke @PropertyName";
            //query += " ORDER BY b.BrandID OFFSET @skipRows ROWS FETCH NEXT @takeRows ROWS ONLY";

            string bedRoomCountString = "";
            string bathRoomCountString = "";
            string StateFilterString = "";
            if (Model.RoomMinimum > 0)
            {
                bedRoomCountString = " and A.BedroomCount  >= " + Model.RoomMinimum;
            }
      
            if (Model.BathRoomMinimum > 0)
            {
                bathRoomCountString = " and A.BathroomCount  >= " + Model.BathRoomMinimum;
            }
          
            if (Model.StateID > 0)
            {
                StateFilterString = " and P.StateID = " + Model.StateID;
            }
            if (Model.DestinationTypeID == 0)
            {
               query = " declare @skipRows int =" + Model.SkipRows + ", @takeRows int =" + Model.TakeRows + ", @BrandID int =" + Model.BrandID + ", @PropertyName  varchar(500) = " + "'%" + Model.PropertyName + "%'" + ",@TotalRecordsCount  int = " + 0;

                query += " select @TotalRecordsCount = COUNT(*)   from Propertys p inner join Brands b on p.BrandID = b.BrandID left join Accomodations A on A.PropertyID = p.PropertyID where b.BrandID = @BrandID and p.Name LIke @PropertyName " + bedRoomCountString + bathRoomCountString + StateFilterString;
                query += " Select @TotalRecordsCount  TotalRecordsCount , STUFF((select distinct ' , ' + BenefitName from PropertyUnitBenefits Pub inner ";
                query += " join Benefits b on Pub.BenefitID = b.BenefitID inner join PropertyUnits pu on Pub.PropertyUnitID = pu.PropertyUnitID  ";
                query += " where pu.PropertyID = p.PropertyID FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)') ,1,2,'') BenefitName,* ";
                query += " from Propertys p inner join Brands b on p.BrandID = b.BrandID left join Accomodations A on A.PropertyID = p.PropertyID where b.BrandID = @BrandID and p.Name LIke @PropertyName ";
                query += bedRoomCountString + bathRoomCountString + StateFilterString;
                query += " ORDER BY b.BrandID OFFSET @skipRows ROWS FETCH NEXT @takeRows ROWS ONLY";
            }
            else
            {
                string DestinationTypeString = " and PD.DestinationTypeID = " + Model.DestinationTypeID;
                query = " declare @skipRows int =" + Model.SkipRows + ", @takeRows int =" + Model.TakeRows + ", @BrandID int =" + Model.BrandID + ", @PropertyName  varchar(500) = " + "'%" + Model.PropertyName + "%'" + ",@TotalRecordsCount  int = " + 0;
                query += " select @TotalRecordsCount = COUNT(*)   from Propertys p inner join Brands b on p.BrandID = b.BrandID left join Accomodations A on A.PropertyID = p.PropertyID left join PropertyDestinations PD on  PD.PropertyID = p.PropertyID  where b.BrandID = @BrandID and p.Name LIke @PropertyName " + bedRoomCountString + bathRoomCountString + StateFilterString + DestinationTypeString;
                query += " Select @TotalRecordsCount  TotalRecordsCount , STUFF((select distinct ' , ' + BenefitName from PropertyUnitBenefits Pub inner ";
                query += " join Benefits b on Pub.BenefitID = b.BenefitID inner join PropertyUnits pu on Pub.PropertyUnitID = pu.PropertyUnitID  ";
                query += " where pu.PropertyID = p.PropertyID FOR XML PATH(''), TYPE).value('.', 'NVARCHAR(MAX)') ,1,2,'') BenefitName,* ";
                query += " from Propertys p inner join Brands b on p.BrandID = b.BrandID left join Accomodations A on A.PropertyID = p.PropertyID left join PropertyDestinations PD on  PD.PropertyID = p.PropertyID where b.BrandID = @BrandID and p.Name LIke @PropertyName ";
                query += bedRoomCountString + bathRoomCountString + StateFilterString + DestinationTypeString;
                query += " ORDER BY b.BrandID OFFSET @skipRows ROWS FETCH NEXT @takeRows ROWS ONLY";
            }
            DataSet ds = new DataSet();
            SqlDataAdapter adpt = new SqlDataAdapter(query, new DataConn().GetConn());
            //adpt.TableMappings.Add("y", "y");
            //adpt.TableMappings.Add("x", "x");

            adpt.Fill(ds);
            List<Benefits> benefit = new List<Benefits>();
            try
            {


                if (ds.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < ds.Tables[0].Rows.Count; i++)

                    {
                        Propertys prop = new Propertys();
                        prop.PropertyID = Convert.ToInt32(ds.Tables[0].Rows[i]["PropertyID"].ToString());
                        prop.AccountID = Convert.ToInt32(ds.Tables[0].Rows[i]["AccountID"].ToString());
                        prop.Name = Convert.ToString(ds.Tables[0].Rows[i]["Name"].ToString());
                        prop.Installation = Convert.ToString(ds.Tables[0].Rows[i]["Installation"].ToString());
                        prop.Address = Convert.ToString(ds.Tables[0].Rows[i]["Address"].ToString());
                        prop.WebsiteUrl = Convert.ToString(ds.Tables[0].Rows[i]["WebsiteUrl"].ToString());
                        prop.EmailAddress = Convert.ToString(ds.Tables[0].Rows[i]["EmailAddress"].ToString());
                        if (!String.IsNullOrEmpty(ds.Tables[0].Rows[i]["LocaleID"].ToString()))
                        {
                            prop.LocaleID = Convert.ToInt32(ds.Tables[0].Rows[i]["LocaleID"].ToString());
                        }
                        else
                        {
                            prop.LocaleID = 0;
                        }
                        if (!String.IsNullOrEmpty(ds.Tables[0].Rows[i]["CityID"].ToString()))
                        {
                            prop.CityID = Convert.ToInt32(ds.Tables[0].Rows[i]["CityID"].ToString());
                        }
                        else
                        {
                            prop.CityID = 0;
                        }
                        if (!String.IsNullOrEmpty(ds.Tables[0].Rows[i]["StateID"].ToString()))
                        {
                            prop.StateID = Convert.ToInt32(ds.Tables[0].Rows[i]["StateID"].ToString());
                        }
                        else
                        {
                            prop.StateID = 0;
                        }
                        prop.PageName = Convert.ToString(ds.Tables[0].Rows[i]["PageName"].ToString());
                        //prop.timeStamp = Convert.ToDateTime(ds.Tables[0].Rows[i]["timeStamp"].ToString());
                        try
                        {
                            prop.LastUpdateDate = Convert.ToDateTime(ds.Tables[0].Rows[i]["LastUpdateDate"].ToString());
                        }
                        catch (Exception) { }
                        prop.CityName = Convert.ToString(ds.Tables[0].Rows[i]["CityName"].ToString());
                        prop.Description = Convert.ToString(ds.Tables[0].Rows[i]["Description"].ToString());
                        prop.Zipcode = Convert.ToString(ds.Tables[0].Rows[i]["Zipcode"].ToString());
                        if (!String.IsNullOrEmpty(ds.Tables[0].Rows[i]["RegionID"].ToString()))
                        {
                            prop.RegionID = Convert.ToInt32(ds.Tables[0].Rows[i]["RegionID"].ToString());
                        }
                        else
                        {
                            prop.RegionID = 0;
                        }
                        prop.AdditionalInformation = Convert.ToString(ds.Tables[0].Rows[i]["AdditionalInformation"].ToString());
                        if (!String.IsNullOrEmpty(ds.Tables[0].Rows[i]["LastModifiedByAccountID"].ToString()))
                        {
                            prop.LastModifiedByAccountID = Convert.ToInt32(ds.Tables[0].Rows[i]["LastModifiedByAccountID"].ToString());
                        }
                        else
                        {
                            prop.LastModifiedByAccountID = 0;
                        }
                        if (!String.IsNullOrEmpty(ds.Tables[0].Rows[i]["BranchOfServiceID"].ToString()))
                        {
                            prop.BranchOfServiceID = Convert.ToInt32(ds.Tables[0].Rows[i]["BranchOfServiceID"].ToString());
                        }
                        else
                        {
                            prop.BranchOfServiceID = 0;
                        }
                        if (!String.IsNullOrEmpty(ds.Tables[0].Rows[i]["BrandID"].ToString()))
                        {
                            prop.BrandID = Convert.ToInt32(ds.Tables[0].Rows[i]["BrandID"].ToString());
                        }
                        else
                        {
                            prop.BrandID = 0;
                        }
                        prop.ChildrenAllowed = (ds.Tables[0].Rows[i]["ChildrenAllowed"].ToString() == "True" ? true : false);
                        if (!String.IsNullOrEmpty(ds.Tables[0].Rows[i]["AgeRequirement"].ToString()))
                        {
                            prop.AgeRequirement = Convert.ToInt32(ds.Tables[0].Rows[i]["AgeRequirement"].ToString());
                        }
                        else
                        {
                            prop.AgeRequirement = 0;
                        }
                        prop.PetsAllowed = (ds.Tables[0].Rows[i]["PetsAllowed"].ToString() == "True" ? true : false);
                        prop.PetSizeMaxWeight = Convert.ToInt32(ds.Tables[0].Rows[i]["PetSizeMaxWeight"].ToString());
                        prop.InteriorCorridors = (ds.Tables[0].Rows[i]["InteriorCorridors"].ToString() == "True" ? 1 : 0);
                        prop.ExteriorCorridors = (ds.Tables[0].Rows[i]["ExteriorCorridors"].ToString() == "True" ? 1 : 0);
                        prop.PropertyCode = Convert.ToString(ds.Tables[0].Rows[i]["PropertyCode"].ToString());
                        prop.PropertyTitle = Convert.ToString(ds.Tables[0].Rows[i]["PropertyTitle"].ToString());
                        prop.MaintenanceEmailAddress = Convert.ToString(ds.Tables[0].Rows[i]["MaintenanceEmailAddress"].ToString());
                        prop.SalesEmailAddress = Convert.ToString(ds.Tables[0].Rows[i]["SalesEmailAddress"].ToString());
                        prop.SquareFootage = Convert.ToString(ds.Tables[0].Rows[i]["SquareFootage"].ToString());
                        prop.PetDeposit = Convert.ToString(ds.Tables[0].Rows[i]["PetDeposit"].ToString());
                        prop.LocalTransportation = Convert.ToString(ds.Tables[0].Rows[i]["LocalTransportation"].ToString());
                        prop.Parking = Convert.ToString(ds.Tables[0].Rows[i]["Parking"].ToString());
                        prop.BenefitName = ds.Tables[0].Rows[i]["BenefitName"].ToString();
                        prop.TotalRecordsCount = Convert.ToInt32(ds.Tables[0].Rows[i]["TotalRecordsCount"]);
                        prop.RoomCount = Convert.ToInt32(ds.Tables[0].Rows[i]["RoomCount"]);

                        //   prop.FilterRecordCount = Convert.ToInt32(ds.Tables[0].Rows[i]["FilterRecordCount"]);

                        DataRow dr = ds.Tables[0].Rows[i];
                        lstProperty.Add(prop);
                    }

                }
            }
            catch (Exception)
            {

            
            }
            return lstProperty;

        }
        #endregion


        public List<DestinationTypes> DestinationDropList()
        {

            List<DestinationTypes> ObjDestinationTypes = new List<DestinationTypes>();
            string str = "select * from DestinationTypes";
            DataSet ds = new DataSet();
            SqlDataAdapter adpt = new SqlDataAdapter(str, new DataConn().GetConn());
            adpt.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DestinationTypes Dest = new DestinationTypes();
                    Dest.DestinationTypeID = Convert.ToInt32(ds.Tables[0].Rows[i]["DestinationTypeID"]);
                    Dest.DestinationTypeName = (ds.Tables[0].Rows[i]["DestinationTypeName"]).ToString();
                    ObjDestinationTypes.Add(Dest);
                }
            }
            return ObjDestinationTypes;
        }


        public List<StateModel> StateDropdownList()
        {

            List<StateModel> ObjDestinationTypes = new List<StateModel>();
            string str = "select FullName,StateID,CountryID from States";
            DataSet ds = new DataSet();
            SqlDataAdapter adpt = new SqlDataAdapter(str, new DataConn().GetConn());
            adpt.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {

                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    StateModel ObjState = new StateModel();
                    ObjState.StateID = Convert.ToInt32(ds.Tables[0].Rows[i]["StateID"]);
                    ObjState.Name = (ds.Tables[0].Rows[i]["FullName"]).ToString();
                    ObjDestinationTypes.Add(ObjState);
                }
            }
            return ObjDestinationTypes;
        }

        public List<CallingScriptModel> GetCallingScript(int BrandID)
        {
            List<CallingScriptModel> ObjCallingScript = new List<CallingScriptModel>();
            string str = "select BrandID, CallScript from Brands where BrandID = " + BrandID;
            DataSet ds = new DataSet();
            SqlDataAdapter adpt = new SqlDataAdapter(str, new DataConn().GetConn());
            adpt.Fill(ds);
            string CallingScript = "";
            string[] scriptArray;
            if(ds.Tables[0].Rows.Count > 0)
            {
                for(int i = 0;i < ds.Tables[0].Rows.Count; i++)
                {
                    CallingScript = (ds.Tables[0].Rows[i]["CallScript"]).ToString();
                }

                CallingScript = CallingScript.Replace("[agent]", "<div class=\"clearfix agentclass\"><div class=\"chat-body clearfix\"><p>").Replace("[action]", "<div class=\"clearfix\"><div class=\"chat-body clearfix\"><p class=\"text-info\">").Replace("[important]", "<span class=\"text-danger\">").Replace("[endimportant]", "</span>").Replace("[end]", "</p></div></div>[agentend]");
            }

            scriptArray = CallingScript.Split("[agentend]");

            foreach(string item in scriptArray)
            {
                CallingScriptModel objItem = new CallingScriptModel();
                if (item.IndexOf("agentclass") != -1)
                {
                    objItem.Agent = item;
                    objItem.BrandId = BrandID;
                }
                else
                {
                    objItem.Action = item;
                    objItem.BrandId = BrandID;
                }
                ObjCallingScript.Add(objItem);
            }

            return ObjCallingScript;
        }


        //http://qa.realvoicecm.com/propertys/brandlanding.aspx?BrandID=11

        public string GetBrandBenefitsList(List<Benefits> benefit, int PropertyID)
        {
            string benefitList = string.Empty;

            for (int i = 0; i < benefit.Count; i++)
            {
                if (benefit[i].PropertyID == PropertyID)
                {
                    benefitList += benefit[i].BenefitName + " ,";
                }
            }
            if (benefitList.Length > 0)
            {
                benefitList = benefitList.Remove(benefitList.Length - 1, 1);
            }
            return benefitList;
        }


    }
}




