using System;
using System.Collections;
using System.Collections.Generic;
using Entities;
using DAL;

namespace BAL
{
    public class PropertysBAL
    {
   

        public List<PropertyUnits> GettAllPropertiesByBrands(int brandId)
        {
            return new DAL.PropertysDAL().GettAllPropertiesByBrands(brandId);
        }

        public List<Propertys> GettAllPropertiesWithSearch(Propertys Model)
        {
            return new DAL.PropertysDAL().GettAllPropertiesWithSearch(Model);
        }

        public List<PropertyUnits> GetAllPropertyUnitByBrands(Brands brand)
        {
            return new DAL.PropertysDAL().GetAllPropertyUnitByBrands(brand);
        }

        public string GetPropertyAmenities(Propertys prop)
        {
            return new DAL.PropertysDAL().GetPropertyAmenities(prop);
        }

        public List<Propertys> GetAllPropertiesWithSearchText(Propertys Model)
        {
            return new DAL.PropertysDAL().GetAllPropertiesWithSearchText(Model);
        }

        public List<PropertyUnits> GetAllPropertyUnits(int PropertyID)
        {
            return new DAL.PropertysDAL().GetAllPropertyUnits(PropertyID);
        }

        public List<DestinationTypes> DestinationDropList()
        {
            return new DAL.PropertysDAL().DestinationDropList();
        }

        public List<StateModel> StateDropdownList()
        {
            return new DAL.PropertysDAL().StateDropdownList();
        }

        public List<CallingScriptModel> GetCallingScript(int BrandID)
        {

            return new DAL.PropertysDAL().GetCallingScript(BrandID);

        }




    }
}
