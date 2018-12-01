using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using Entities;
using System.Data.SqlClient;

namespace DAL
{
    public class BrandsDAL
    {
        #region "List All Brands"
        public List<Brands> GetAllBrands()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adpt = new SqlDataAdapter("SELECT * from Brands order by BrandName", new DataConn().GetConn());
            adpt.Fill(ds);
            List<Brands> lstBrands = new List<Brands>();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                Brands brand = new Brands();
                DataRow dr = ds.Tables[0].Rows[i];
                brand.BrandID = Convert.ToInt32(dr[0].ToString());
                brand.BrandName = Convert.ToString(dr[1].ToString());
                //brand.timeStamp = Convert.ToDateTime(dr[2].ToString());
                brand.RoomCount = Convert.ToInt32(dr[3].ToString());
                brand.HoursOfOperation = Convert.ToString(dr[4].ToString());
                brand.PmsCmsLinks = Convert.ToString(dr[5].ToString());
                brand.Poc = Convert.ToString(dr[6].ToString());
                brand.MarketsServed = Convert.ToString(dr[7].ToString());
                brand.GroupsAllowed = (Convert.ToString(dr[8].ToString()) == "True" ? true : false);
                brand.GiftCertificates = (Convert.ToBoolean(dr[9])  ? true : false).ToString();
                brand.CallScript = Convert.ToString(dr[10].ToString());
                if (String.IsNullOrEmpty(dr[11].ToString()))
                {
                    dr[11] = "-1";
                }
                brand.LogoFileID = Convert.ToInt64(dr[11].ToString());
                brand.Faq = Convert.ToString(dr[12].ToString());
                brand.Policy = Convert.ToString(dr[13].ToString());
                brand.SocialFacebook = Convert.ToString(dr[14].ToString());
                brand.SocialTwitter = Convert.ToString(dr[15].ToString());
                brand.SocialYouTube = Convert.ToString(dr[16].ToString());
                brand.SocialLinkedIn = Convert.ToString(dr[17].ToString());
                brand.SalesCallerID = Convert.ToString(dr[18].ToString());
                brand.Website = Convert.ToString(dr[19].ToString());
                brand.MaintenanceEmail = Convert.ToString(dr[20].ToString());
                brand.SalesEmail = Convert.ToString(dr[21].ToString());
                brand.GuestUseEmail = Convert.ToString(dr[22].ToString());
                brand.PhoneMainLocal = Convert.ToString(dr[23].ToString());
                brand.Fax = Convert.ToString(dr[24].ToString());
                string str = new BrandsDAL().GetBrandBenefits(brand);

                brand.Benefits = str;
                //if (str.Length > 0)
                //{
                //    if (str.EndsWith(","))
                //    {
                //        str = str.Substring(0, str.Length - 1);
                //        brand.Benefits = str;
                //    }
                //}
                //if (str.Length > 0)
                //{
                //    brand.Benefits = str.TrimEnd(',');
                //}

                //brand.PhoneTollFree = Convert.ToString(dr[25].ToString());
                //brand.EmergencyContact = Convert.ToString(dr[26].ToString());
                //brand.MaintenanceContact = Convert.ToString(dr[27].ToString());
                //brand.AvatarMimeType = Convert.ToString(dr[30].ToString());
                lstBrands.Add(brand);
            }
            return lstBrands;
        }
        #endregion

        #region "Get All Brands by ID"
        public Brands GetAllBrandById(int brandId)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adpt = new SqlDataAdapter("SELECT * from Brands where brandId=" + brandId, new DataConn().GetConn());
            adpt.Fill(ds);
            Brands brand = new Brands();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                DataRow dr = ds.Tables[0].Rows[i];
                brand.BrandID = Convert.ToInt32(dr[0].ToString());
                brand.BrandName = Convert.ToString(dr[1].ToString());
                //brand.timeStamp = Convert.ToDateTime(dr[2].ToString());
                brand.RoomCount = Convert.ToInt32(dr[3].ToString());
                brand.HoursOfOperation = Convert.ToString(dr[4].ToString());
                brand.PmsCmsLinks = Convert.ToString(dr[5].ToString());
                brand.Poc = Convert.ToString(dr[6].ToString());
                brand.MarketsServed = Convert.ToString(dr[7].ToString());
                brand.GroupsAllowed = (Convert.ToString(dr[8].ToString()) == "True" ? true : false);
                brand.GiftCertificates = ((Convert.ToBoolean(dr[9]) ? "Yes" : "No")).ToString();
                brand.CallScript = Convert.ToString(dr[10].ToString());
                if (String.IsNullOrEmpty(dr[11].ToString()))
                {
                    dr[11] = "-1";
                }
                brand.LogoFileID = Convert.ToInt64(dr[11].ToString());
                brand.Faq = Convert.ToString(dr[12].ToString());
                brand.Policy = Convert.ToString(dr[13].ToString());
                brand.SocialFacebook = Convert.ToString(dr[14].ToString());
                brand.SocialTwitter = Convert.ToString(dr[15].ToString());
                brand.SocialYouTube = Convert.ToString(dr[16].ToString());
                brand.SocialLinkedIn = Convert.ToString(dr[17].ToString());
                brand.SalesCallerID = Convert.ToString(dr[18].ToString());
                brand.Website = Convert.ToString(dr[19].ToString());
                brand.MaintenanceEmail = Convert.ToString(dr[20].ToString());
                brand.SalesEmail = Convert.ToString(dr[21].ToString());
                brand.GuestUseEmail = Convert.ToString(dr[22].ToString());
                brand.PhoneMainLocal = Convert.ToString(dr[23].ToString());
                brand.Fax = Convert.ToString(dr[24].ToString());
                brand.PhoneTollFree = Convert.ToString(dr[25].ToString());
                brand.EmergencyContact = Convert.ToString(dr[26].ToString());
                brand.MaintenanceContact = Convert.ToString(dr[27].ToString());
                //brand.AvatarMimeType = Convert.ToString(dr[30].ToString());

            }
            return brand;
        }
        #endregion

        #region "Add New Brand"
        public bool AddBrands(Brands brand)
        {
            SqlConnection cn = new DataConn().GetConn();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spAddBrands";
                cmd.Connection = cn;
                cn.Open();
                cmd.Parameters.AddWithValue("@BrandName", brand.BrandName);
                cmd.Parameters.AddWithValue("@RoomCount", brand.RoomCount);
                cmd.Parameters.AddWithValue("@HoursOfOperation", brand.HoursOfOperation);
                cmd.Parameters.AddWithValue("@PmsCmsLinks", brand.PmsCmsLinks);
                cmd.Parameters.AddWithValue("@Poc", brand.Poc);
                cmd.Parameters.AddWithValue("@MarketsServed", brand.MarketsServed);
                cmd.Parameters.AddWithValue("@GroupsAllowed", brand.GroupsAllowed);
                cmd.Parameters.AddWithValue("@GiftCertificates", brand.GiftCertificates);
                cmd.Parameters.AddWithValue("@CallScript", brand.CallScript);
                cmd.Parameters.AddWithValue("@LogoFileID", brand.LogoFileID);
                cmd.Parameters.AddWithValue("@Faq", brand.Faq);
                cmd.Parameters.AddWithValue("@Policy", brand.Policy);
                cmd.Parameters.AddWithValue("@SocialFacebook", brand.SocialFacebook);
                cmd.Parameters.AddWithValue("@SocialTwitter", brand.SocialTwitter);
                cmd.Parameters.AddWithValue("@SocialYouTube", brand.SocialYouTube);
                cmd.Parameters.AddWithValue("@SocialLinkedIn", brand.SocialLinkedIn);
                cmd.Parameters.AddWithValue("@SalesCallerID", brand.SalesCallerID);
                cmd.Parameters.AddWithValue("@Website", brand.Website);
                cmd.Parameters.AddWithValue("@MaintenanceEmail", brand.MaintenanceEmail);
                cmd.Parameters.AddWithValue("@SalesEmail", brand.SalesEmail);
                cmd.Parameters.AddWithValue("@GuestUseEmail", brand.GuestUseEmail);
                cmd.Parameters.AddWithValue("@PhoneMainLocal", brand.PhoneMainLocal);
                cmd.Parameters.AddWithValue("@Fax", brand.Fax);
                cmd.Parameters.AddWithValue("@PhoneTollFree", brand.PhoneTollFree);
                cmd.Parameters.AddWithValue("@EmergencyContact", brand.EmergencyContact);
                cmd.Parameters.AddWithValue("@MaintenanceContact", brand.MaintenanceContact);
                cmd.Parameters.AddWithValue("@Avatar", brand.Avatar);
                cmd.Parameters.AddWithValue("@AvatarMimeType", brand.AvatarMimeType);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                cmd.Dispose();
                cn.Dispose();
            }
        }
        #endregion

        #region "Update Brands"
        public bool UpdateBrands(Brands brand)
        {
            SqlConnection cn = new DataConn().GetConn();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spUpdateBrands";
                cmd.Connection = cn;
                cn.Open();
                cmd.Parameters.AddWithValue("@BrandId", brand.BrandID);
                cmd.Parameters.AddWithValue("@BrandName", brand.BrandName);
                cmd.Parameters.AddWithValue("@RoomCount", brand.RoomCount);
                cmd.Parameters.AddWithValue("@HoursOfOperation", brand.HoursOfOperation);
                cmd.Parameters.AddWithValue("@PmsCmsLinks", brand.PmsCmsLinks);
                cmd.Parameters.AddWithValue("@Poc", brand.Poc);
                cmd.Parameters.AddWithValue("@MarketsServed", brand.MarketsServed);
                cmd.Parameters.AddWithValue("@GroupsAllowed", brand.GroupsAllowed);
                cmd.Parameters.AddWithValue("@GiftCertificates", brand.GiftCertificates);
                cmd.Parameters.AddWithValue("@CallScript", brand.CallScript);
                cmd.Parameters.AddWithValue("@LogoFileID", brand.LogoFileID);
                cmd.Parameters.AddWithValue("@Faq", brand.Faq);
                cmd.Parameters.AddWithValue("@Policy", brand.Policy);
                cmd.Parameters.AddWithValue("@SocialFacebook", brand.SocialFacebook);
                cmd.Parameters.AddWithValue("@SocialTwitter", brand.SocialTwitter);
                cmd.Parameters.AddWithValue("@SocialYouTube", brand.SocialYouTube);
                cmd.Parameters.AddWithValue("@SocialLinkedIn", brand.SocialLinkedIn);
                cmd.Parameters.AddWithValue("@SalesCallerID", brand.SalesCallerID);
                cmd.Parameters.AddWithValue("@Website", brand.Website);
                cmd.Parameters.AddWithValue("@MaintenanceEmail", brand.MaintenanceEmail);
                cmd.Parameters.AddWithValue("@SalesEmail", brand.SalesEmail);
                cmd.Parameters.AddWithValue("@GuestUseEmail", brand.GuestUseEmail);
                cmd.Parameters.AddWithValue("@PhoneMainLocal", brand.PhoneMainLocal);
                cmd.Parameters.AddWithValue("@Fax", brand.Fax);
                cmd.Parameters.AddWithValue("@PhoneTollFree", brand.PhoneTollFree);
                cmd.Parameters.AddWithValue("@EmergencyContact", brand.EmergencyContact);
                cmd.Parameters.AddWithValue("@MaintenanceContact", brand.MaintenanceContact);
                cmd.Parameters.AddWithValue("@Avatar", brand.Avatar);
                cmd.Parameters.AddWithValue("@AvatarMimeType", brand.AvatarMimeType);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception )
            {
                return false;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                cmd.Dispose();
                cn.Dispose();
            }
        }
        #endregion

        #region "Delete Brands"
        public bool DeleteBrands(Brands brand)
        {
            SqlConnection cn = new DataConn().GetConn();
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "spDeleteBrands";
                cmd.Connection = cn;
                cn.Open();
                cmd.Parameters.AddWithValue("@BrandId", brand.BrandID);

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
                cmd.Dispose();
                cn.Dispose();
            }
        }
        #endregion

        #region "Get Brands Benefits"
        public string GetBrandBenefits(Brands brand)
        {
            string strBenefits = string.Empty;
            string strQry = string.Empty;
            strQry += "SELECT distinct Benefits.BenefitName FROM Brands INNER JOIN ";
            strQry += " Propertys ON Brands.BrandID = Propertys.BrandID INNER JOIN PropertyUnits ON Propertys.PropertyID = PropertyUnits.PropertyID INNER JOIN ";
            strQry += " PropertyAmenitys ON Propertys.PropertyID = PropertyAmenitys.PropertyID INNER JOIN ";
            strQry += " PropertyUnitBenefits ON PropertyUnits.PropertyUnitID = PropertyUnitBenefits.PropertyUnitID INNER JOIN ";
            strQry += " Benefits ON PropertyUnitBenefits.BenefitID = Benefits.BenefitID  where Brands.BrandID = " + brand.BrandID;
            DataSet ds = new DataSet();
            SqlDataAdapter adpt = new SqlDataAdapter(strQry, new DataConn().GetConn());
            adpt.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    strBenefits += ds.Tables[0].Rows[i]["BenefitName"].ToString() + ", ";
                }
            }
            return strBenefits;
        }
        #endregion

        #region "Get Brands By Query"
        public List<Propertys> GetBrandsPropertyByQuery()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter adpt = new SqlDataAdapter("select Propertys.BrandId,Propertys.PropertyId,Parking,AdditionalInformation,Faq,Policy  from Propertys inner join Brands on Propertys.BrandId = Brands.BrandId", new DataConn().GetConn());
            adpt.Fill(ds);
            List<Propertys> lstPropertys = new List<Propertys>();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                DataRow dr = ds.Tables[0].Rows[i];
                Propertys prop = new Propertys();
                prop.BrandID = Convert.ToInt32(dr[0].ToString());
                prop.PropertyID = Convert.ToInt32(dr[1].ToString());
                prop.Parking = Convert.ToString(dr[2].ToString());
                prop.AdditionalInformation = Convert.ToString(dr[3].ToString()) == null ? "" : Convert.ToString(dr[3].ToString());
                lstPropertys.Add(prop);
                //brand.BrandID = Convert.ToInt32(dr[0].ToString());
                //brand.BrandName = Convert.ToString(dr[1].ToString());
                ////brand.timeStamp = Convert.ToDateTime(dr[2].ToString());
                //brand.RoomCount = Convert.ToInt32(dr[3].ToString());
                //brand.HoursOfOperation = Convert.ToString(dr[4].ToString());
                //brand.PmsCmsLinks = Convert.ToString(dr[5].ToString());
                //brand.Poc = Convert.ToString(dr[6].ToString());
                //brand.MarketsServed = Convert.ToString(dr[7].ToString());
                //brand.GroupsAllowed = (Convert.ToString(dr[8].ToString()) == "True" ? true : false);
                //brand.GiftCertificates = (Convert.ToString(dr[9].ToString()) == "True" ? true : false);
                //brand.CallScript = Convert.ToString(dr[10].ToString());
                //if (String.IsNullOrEmpty(dr[11].ToString()))
                //{
                //    dr[11] = "-1";
                //}
                //brand.LogoFileID = Convert.ToInt64(dr[11].ToString());
                //brand.Faq = Convert.ToString(dr[12].ToString());
                //brand.Policy = Convert.ToString(dr[13].ToString());
                //brand.SocialFacebook = Convert.ToString(dr[14].ToString());
                //brand.SocialTwitter = Convert.ToString(dr[15].ToString());
                //brand.SocialYouTube = Convert.ToString(dr[16].ToString());
                //brand.SocialLinkedIn = Convert.ToString(dr[17].ToString());
                //brand.SalesCallerID = Convert.ToString(dr[18].ToString());
                //brand.Website = Convert.ToString(dr[19].ToString());
                //brand.MaintenanceEmail = Convert.ToString(dr[20].ToString());
                //brand.SalesEmail = Convert.ToString(dr[21].ToString());
                //brand.GuestUseEmail = Convert.ToString(dr[22].ToString());
                //brand.PhoneMainLocal = Convert.ToString(dr[23].ToString());
                //brand.Fax = Convert.ToString(dr[24].ToString());
                ////brand.PhoneTollFree = Convert.ToString(dr[25].ToString());
                ////brand.EmergencyContact = Convert.ToString(dr[26].ToString());
                ////brand.MaintenanceContact = Convert.ToString(dr[27].ToString());
                ////brand.AvatarMimeType = Convert.ToString(dr[30].ToString());

            }
            return lstPropertys;
        }
        #endregion
    }
}
