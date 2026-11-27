using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLDDataAccess;

namespace DVLDBusinessLayer
{
    public class clsCountry
    {

        enum enMode { AddNew, Update };

        private enMode Mode;

        public int CountryID { get; set; }
        public string CountryName { get; set; }

        public clsCountry()
        {
            CountryID = -1;
            CountryName = "";

            Mode = enMode.AddNew;
        }

        private clsCountry(int CountryID, string CountryName)
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;

            Mode = enMode.Update;
        }

        public static clsCountry Find(string CountryName)
        {
            int CountryID = -1;

            if (clsCountryDataAccess.GetCountryByName(ref CountryID, ref CountryName))
            {
                return new clsCountry(CountryID, CountryName);
            }
            else
            {
                return null;
            }
        }

        public static clsCountry Find(int CountryID)
        {
            string CountryName = "";

            if (clsCountryDataAccess.GetCountryByID(CountryID, ref CountryName))
            {
                return new clsCountry(CountryID, CountryName);
            }
            else
            {
                return null;
            }
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewCountry())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateCountry();
            }

            return false;
        }

        private bool _UpdateCountry()
        {
            return clsCountryDataAccess.UpdateCountry(this.CountryID, this.CountryName);
        }

        private bool _AddNewCountry()
        {
            this.CountryID = clsCountryDataAccess.AddNewCountry(this.CountryName);

            return (this.CountryID != -1);
        }

        public static bool DeleteCountry(int CountryID)
        {
            return clsCountryDataAccess.DeleteCountry(CountryID);
        }

        public static DataTable GetAllCountries()
        {
            return clsCountryDataAccess.GetAllCountries();
        }

        public static bool IsCountryExists(int CountryID)
        {
            return clsCountryDataAccess.IsCountryExists(CountryID);
        }

        public static bool IsCountryExists(string CountryName)
        {
            return clsCountryDataAccess.IsCountryExists(CountryName);
        }

    }
}
