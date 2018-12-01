using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BAL;
using Entities;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Cors;

namespace RvCellApi.Controllers
{
    [EnableCors("ApiPolicy")]
    public class PropertyAPIController : ControllerBase
    {
        
        [Route("api/PropertyAPI/GettAllPropertiesWithSearch/{BrandID}/{SkipRows}/{TakeRows}")]
        public string GetAllPropertys(int BrandID, int SkipRows, int TakeRows)
        {
            Propertys Model = new Propertys();
            Model.BrandID = BrandID;
            Model.SkipRows = SkipRows;
            Model.TakeRows = TakeRows;
            List<Propertys> lstPropertys = new List<Propertys>();
            lstPropertys = new BAL.PropertysBAL().GettAllPropertiesWithSearch(Model);
            return Newtonsoft.Json.JsonConvert.SerializeObject(lstPropertys);
        }

        [Route("api/PropertyAPI/GetAllPropertyUnits/{PropertyID}")]
        public string GetAllPropertyUnits(int PropertyID)
        {
            List<PropertyUnits> lstPropertyUnits = new List<PropertyUnits>();
            lstPropertyUnits = new BAL.PropertyUnitsBAL().GetAllPropertyUnits(PropertyID);
            return Newtonsoft.Json.JsonConvert.SerializeObject(lstPropertyUnits);
        }

        //[Route("api/PropertyAPI/GettAllPropertiesByBrands")]
        //public string GettAllPropertiesByBrands(Brands brand)
        //{
        //    List<PropertyUnits> lstPropertys = new List<PropertyUnits>();
        //    lstPropertys = new BAL.PropertysBAL().GetAllPropertyUnitByBrands(brand);
        //    return Newtonsoft.Json.JsonConvert.SerializeObject(lstPropertys);
        //}


        //[Route("api/PropertyAPI/GetAllPropertyUnitByBrands")]
        //public string GetAllPropertyUnitByBrands(Brands brand)
        //{
        //    List<PropertyUnits> lstPropertyUnits = new List<PropertyUnits>();
        //    lstPropertyUnits = new BAL.PropertysBAL().GetAllPropertyUnitByBrands(brand);
        //    return Newtonsoft.Json.JsonConvert.SerializeObject(lstPropertyUnits);
        //}

        //[Route("api/PropertyAPI/GetPropertyAmenities")]
        //public string GetPropertyAmenities(Propertys prop)
        //{
        //    string temp = string.Empty;
        //    temp = new BAL.PropertysBAL().GetPropertyAmenities(prop);
        //    return temp;
        //}

        //[Route("api/PropertyAPI/GetPropertyBrands")]
        //public string GetPropertyBrands()
        //{
        //    List<Propertys> lstPropertyUnits = new List<Propertys>();
        //    lstPropertyUnits = new BAL.BrandsBAL().GetBrandsPropertyByQuery();
        //    return Newtonsoft.Json.JsonConvert.SerializeObject(lstPropertyUnits);
        //}
        [HttpGet]
        [Route("api/PropertyAPI/GettAllPropertiesByBrands/{brandId}")]
        public string GettAllPropertiesByBrands(int brandId)
        {
           List<PropertyUnits> prop = new List<PropertyUnits>();
            prop = new BAL.PropertysBAL().GettAllPropertiesByBrands(brandId);
            return Newtonsoft.Json.JsonConvert.SerializeObject(prop);
        }


        [HttpGet]
        [Route("api/PropertyAPI/GetPropertyBrands/{brandId}")]
        public string GetPropertyBrands(int brandId)
        {
            Brands brand = new Brands();

            brand = new BAL.BrandsBAL().GetAllBrandById(brandId);
            return Newtonsoft.Json.JsonConvert.SerializeObject(brand);
        }
        [HttpPost]
        [Route("api/PropertyAPI/GetAllPropertiesWithSearchText")]
        public string GetAllPropertiesWithSearchText([FromBody]Propertys Model)
        {
            List<Propertys> lstPropertys = new List<Propertys>();
            lstPropertys = new BAL.PropertysBAL().GetAllPropertiesWithSearchText(Model);
            return Newtonsoft.Json.JsonConvert.SerializeObject(lstPropertys);
        }
        [HttpGet]
        [Route("api/PropertyAPI/DestinationDropList")]
        public string DestinationDropList()
        {
            try
            {
         
                List<DestinationTypes> lstPropertys = new List<DestinationTypes>();
                lstPropertys = new BAL.PropertysBAL().DestinationDropList();
                return Newtonsoft.Json.JsonConvert.SerializeObject(lstPropertys);
            }
            catch (Exception ex)
            {


                //return Request.CreateResponse(HttpStatusCode.NotFound, err);
                  return Newtonsoft.Json.JsonConvert.SerializeObject(ex.ToString());

            }
        
        }

        [HttpGet]
        [Route("api/PropertyAPI/StateDropList")]
        public string StateDropdownList()
        {
            List<StateModel> lstPropertys = new List<StateModel>();
            lstPropertys = new BAL.PropertysBAL().StateDropdownList();
            return Newtonsoft.Json.JsonConvert.SerializeObject(lstPropertys);
        }

        [HttpGet]
        [Route("api/PropertyAPI/GetCallingScript/{BrandID}")]
        public string GetCallingScript(int BrandID)
        {
            List<CallingScriptModel> ObjCallingscript = new List<CallingScriptModel>();

            ObjCallingscript = new BAL.PropertysBAL().GetCallingScript(BrandID);
            return Newtonsoft.Json.JsonConvert.SerializeObject(ObjCallingscript);

        }


    }
}
