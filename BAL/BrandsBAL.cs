using System;
using System.Collections;
using System.Collections.Generic;
using Entities;
using DAL;

namespace BAL
{
    public class BrandsBAL
    {
        public List<Brands> GetAllBrands()
        {
            return new DAL.BrandsDAL().GetAllBrands();
        }

        public Brands GetAllBrandById(int brandId)
        {
            return new DAL.BrandsDAL().GetAllBrandById(brandId);
        }

        public bool AddBrands(Brands brand)
        {
            return new DAL.BrandsDAL().AddBrands(brand);
        }

        public bool UpdateBrands(Brands brand)
        {
            return new DAL.BrandsDAL().UpdateBrands(brand);
        }

        public bool DeleteBrands(Brands brand)
        {
            return new DAL.BrandsDAL().DeleteBrands(brand);
        }

        public string GetBrandBenefits(Brands brand)
        {
            return new DAL.BrandsDAL().GetBrandBenefits(brand);
        }

        public List<Propertys> GetBrandsPropertyByQuery()
        {
            return new DAL.BrandsDAL().GetBrandsPropertyByQuery();
        }
    }
}
