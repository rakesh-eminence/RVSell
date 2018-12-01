using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using Entities;
using System.Data.Common;
using System.Data.SqlClient;

namespace DAL
{
    public class PropertyUnitsDAL
    {
        //public List<PropertyUnits> GetPropertyUnitsList(int propertyId)
        //{
        //    List<PropertyUnits> lstPropertyUnits = new List<PropertyUnits>();
        //    SqlDataAdapter adpt = new SqlDataAdapter("Select * from PropertyUnits where BrandId=" + propertyId, new DataConn().GetConn());
        //    DataSet ds = new DataSet();
        //    adpt.Fill(ds);
        //    if (ds.Tables[0].Rows.Count > 0)
        //    {
        //        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        //        {
        //            PropertyUnits prop = new PropertyUnits();
        //            prop.PropertyUnitID = Convert.ToInt32(ds.Tables[0].Rows[i]["PropertyUnitID"].ToString());
        //            prop.AccountID = Convert.ToInt32(ds.Tables[0].Rows[i]["AccountID"].ToString());
        //            prop.Name = Convert.ToString(ds.Tables[0].Rows[i]["Name"].ToString());
        //            prop.Installation = Convert.ToString(ds.Tables[0].Rows[i]["Installation"].ToString());
        //            prop.PageName = Convert.ToString(ds.Tables[0].Rows[i]["PageName"].ToString());
        //            //prop.timeStamp = Convert.ToDateTime(ds.Tables[0].Rows[i]["timeStamp"].ToString());
        //            //prop.CreateDate = Convert.ToDateTime(ds.Tables[0].Rows[i]["CreateDate"].ToString());
        //            //prop.LastUpdateDate = Convert.ToDateTime(ds.Tables[0].Rows[i]["LastUpdateDate"].ToString());
        //            prop.Description = Convert.ToString(ds.Tables[0].Rows[i]["Description"].ToString());
        //            prop.AdditionalInformation = Convert.ToString(ds.Tables[0].Rows[i]["AdditionalInformation"].ToString());
        //            prop.LastModifiedByAccountID = Convert.ToInt32(ds.Tables[0].Rows[i]["LastModifiedByAccountID"].ToString());
        //            prop.BrandID = Convert.ToInt32(ds.Tables[0].Rows[i]["BrandID"].ToString());
        //            prop.ChildrenAllowed = (ds.Tables[0].Rows[i]["ChildrenAllowed"].ToString() == "1" ? true : false);
        //            prop.AgeRequirement = Convert.ToInt32(ds.Tables[0].Rows[i]["AgeRequirement"].ToString());
        //            prop.PetsAllowed = (ds.Tables[0].Rows[i]["PetsAllowed"].ToString() == "1" ? true : false);
        //            prop.PetSizeMaxWeight = Convert.ToInt32(ds.Tables[0].Rows[i]["PetSizeMaxWeight"].ToString());
        //            prop.PropertyCode = Convert.ToString(ds.Tables[0].Rows[i]["PropertyCode"].ToString());
        //            prop.BookingAvailabilityMessage = Convert.ToString(ds.Tables[0].Rows[i]["BookingAvailabilityMessage"].ToString());
        //            prop.PropertyTitle = Convert.ToString(ds.Tables[0].Rows[i]["PropertyTitle"].ToString());
        //            prop.SquareFootage = Convert.ToString(ds.Tables[0].Rows[i]["SquareFootage"].ToString());
        //            prop.RollawaysAllowed = (ds.Tables[0].Rows[i]["RollawaysAllowed"].ToString() == "1" ? true : false);
        //            prop.PetDeposit = Convert.ToString(ds.Tables[0].Rows[i]["PetDeposit"].ToString());
        //            prop.PropertyID = Convert.ToInt32(ds.Tables[0].Rows[i]["PropertyID"].ToString());
        //            prop.MaxOccupancy = Convert.ToInt32(ds.Tables[0].Rows[i]["MaxOccupancy"].ToString());
        //            prop.NumberOfBedrooms = Convert.ToInt32(ds.Tables[0].Rows[i]["NumberOfBedrooms"].ToString());
        //            prop.NumberOfBathrooms = Convert.ToInt32(ds.Tables[0].Rows[i]["NumberOfBathrooms"].ToString());
        //            lstPropertyUnits.Add(prop);
        //        }
        //    }
        //    return lstPropertyUnits;
        //}

        //public bool AddPropertyUnits(PropertyUnits propUnits)
        //{
        //    SqlConnection cn = new DataConn().GetConn();
        //    SqlCommand cmd = new SqlCommand();
        //    try
        //    {
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.CommandText = "spAddPropertyUnits";
        //        cmd.Connection = cn;
        //        cn.Open();
        //        cmd.Parameters.AddWithValue("@AccountID", propUnits.AccountID);
        //        cmd.Parameters.AddWithValue("@Name", propUnits.Name);
        //        cmd.Parameters.AddWithValue("@Installation", propUnits.Installation);
        //        cmd.Parameters.AddWithValue("@PageName", propUnits.PageName);
        //        cmd.Parameters.AddWithValue("@timeStamp", propUnits.Timestamp);
        //        cmd.Parameters.AddWithValue("@CreateDate", propUnits.CreateDate);
        //        cmd.Parameters.AddWithValue("@LastUpdateDate", propUnits.LastUpdateDate);
        //        cmd.Parameters.AddWithValue("@Description", propUnits.Description);
        //        cmd.Parameters.AddWithValue("@AdditionalInformation", propUnits.AdditionalInformation);
        //        cmd.Parameters.AddWithValue("@LastModifiedByAccountID", propUnits.LastModifiedByAccountID);
        //        cmd.Parameters.AddWithValue("@BrandID", propUnits.BrandID);
        //        cmd.Parameters.AddWithValue("@ChildrenAllowed", propUnits.ChildrenAllowed);
        //        cmd.Parameters.AddWithValue("@AgeRequirement", propUnits.AgeRequirement);
        //        cmd.Parameters.AddWithValue("@PetsAllowed", propUnits.PetsAllowed);
        //        cmd.Parameters.AddWithValue("@PetSizeMaxWeight", propUnits.PetSizeMaxWeight);
        //        cmd.Parameters.AddWithValue("@PropertyCode", propUnits.PropertyCode);
        //        cmd.Parameters.AddWithValue("@BookingAvailabilityMessage", propUnits.BookingAvailabilityMessage);
        //        cmd.Parameters.AddWithValue("@PropertyTitle", propUnits.PropertyTitle);
        //        cmd.Parameters.AddWithValue("@SquareFootage", propUnits.SquareFootage);
        //        cmd.Parameters.AddWithValue("@RollawaysAllowed", propUnits.RollawaysAllowed);
        //        cmd.Parameters.AddWithValue("@PetDeposit", propUnits.PetDeposit);
        //        cmd.Parameters.AddWithValue("@PropertyID", propUnits.PropertyID);
        //        cmd.Parameters.AddWithValue("@MaxOccupancy", propUnits.MaxOccupancy);
        //        cmd.Parameters.AddWithValue("@NumberOfBedrooms", propUnits.NumberOfBedrooms);
        //        cmd.Parameters.AddWithValue("@NumberOfBathrooms", propUnits.NumberOfBathrooms);
        //        cmd.ExecuteNonQuery();
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //    finally
        //    {
        //        if (cn.State == ConnectionState.Open)
        //        {
        //            cn.Close();
        //        }
        //        cmd.Dispose();
        //        cn.Dispose();
        //    }
        //}

        //public bool UpdatePropertyUnits(PropertyUnits propUnits)
        //{
        //    SqlConnection cn = new DataConn().GetConn();
        //    SqlCommand cmd = new SqlCommand();
        //    try
        //    {
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.CommandText = "spUpdatePropertyUnits";
        //        cmd.Connection = cn;
        //        cn.Open();
        //        cmd.Parameters.AddWithValue("@AccountID", propUnits.AccountID);
        //        cmd.Parameters.AddWithValue("@Name", propUnits.Name);
        //        cmd.Parameters.AddWithValue("@Installation", propUnits.Installation);
        //        cmd.Parameters.AddWithValue("@PageName", propUnits.PageName);
        //        cmd.Parameters.AddWithValue("@timeStamp", propUnits.Timestamp);
        //        cmd.Parameters.AddWithValue("@CreateDate", propUnits.CreateDate);
        //        cmd.Parameters.AddWithValue("@LastUpdateDate", propUnits.LastUpdateDate);
        //        cmd.Parameters.AddWithValue("@Description", propUnits.Description);
        //        cmd.Parameters.AddWithValue("@AdditionalInformation", propUnits.AdditionalInformation);
        //        cmd.Parameters.AddWithValue("@LastModifiedByAccountID", propUnits.LastModifiedByAccountID);
        //        cmd.Parameters.AddWithValue("@BrandID", propUnits.BrandID);
        //        cmd.Parameters.AddWithValue("@ChildrenAllowed", propUnits.ChildrenAllowed);
        //        cmd.Parameters.AddWithValue("@AgeRequirement", propUnits.AgeRequirement);
        //        cmd.Parameters.AddWithValue("@PetsAllowed", propUnits.PetsAllowed);
        //        cmd.Parameters.AddWithValue("@PetSizeMaxWeight", propUnits.PetSizeMaxWeight);
        //        cmd.Parameters.AddWithValue("@PropertyCode", propUnits.PropertyCode);
        //        cmd.Parameters.AddWithValue("@BookingAvailabilityMessage", propUnits.BookingAvailabilityMessage);
        //        cmd.Parameters.AddWithValue("@PropertyTitle", propUnits.PropertyTitle);
        //        cmd.Parameters.AddWithValue("@SquareFootage", propUnits.SquareFootage);
        //        cmd.Parameters.AddWithValue("@RollawaysAllowed", propUnits.RollawaysAllowed);
        //        cmd.Parameters.AddWithValue("@PetDeposit", propUnits.PetDeposit);
        //        cmd.Parameters.AddWithValue("@PropertyID", propUnits.PropertyID);
        //        cmd.Parameters.AddWithValue("@MaxOccupancy", propUnits.MaxOccupancy);
        //        cmd.Parameters.AddWithValue("@NumberOfBedrooms", propUnits.NumberOfBedrooms);
        //        cmd.Parameters.AddWithValue("@NumberOfBathrooms", propUnits.NumberOfBathrooms);
        //        cmd.ExecuteNonQuery();
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //    finally
        //    {
        //        if (cn.State == ConnectionState.Open)
        //        {
        //            cn.Close();
        //        }
        //        cmd.Dispose();
        //        cn.Dispose();
        //    }
        //}
    }
}
