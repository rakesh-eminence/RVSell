using System;
using System.Collections;
using System.Collections.Generic;
using Entities;
using DAL;

namespace BAL
{
    public class PropertyUnitsBAL
    {
        //public List<PropertyUnits> GetPropertyUnitsList(int propertyId)
        //{
        //    return new DAL.PropertyUnitsDAL().GetPropertyUnitsList(propertyId);
        //}

        //public bool AddPropertyUnits(PropertyUnits propUnits)
        //{
        //    return new DAL.PropertyUnitsDAL().AddPropertyUnits(propUnits);
        //}

        //public bool UpdatePropertyUnits(PropertyUnits propUnits)
        //{
        //    //return new DAL.PropertyUnitsDAL().UpdatePropertyUnits(propUnits);
        //}

        public List<PropertyUnits> GetAllPropertyUnits(int PropertyID)
        {
            return new DAL.PropertysDAL().GetAllPropertyUnits(PropertyID);
        }
    }
}
