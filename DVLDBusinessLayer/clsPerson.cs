using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DVLDDataAccess;

namespace DVLDBusinessLayer
{

    public class clsPerson
    {
        enum enMode { AddNew, Update };

        private enMode _Mode;

        public int PersonID { get; set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public sbyte Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int NationalityCountryID { get; set; }
        public string Address { get; set; }
        public string ImagePath { get; set; }
        public clsCountry CountryInfo;

        public clsPerson()
        {
            PersonID = -1;
            NationalNo = "";
            FirstName = "";
            SecondName = "";
            ThirdName = "";
            LastName = "";
            Gender = -1;
            Email = "";
            Phone = "";
            DateOfBirth = DateTime.Today;
            NationalityCountryID = -1;
            Address = "";
            ImagePath = "";
        }


        private clsPerson(int PersonID, string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName,
            sbyte Gender, string Email, string Phone, DateTime DateOfBirth, int NationalityCountryID, string Address, string ImagePath)
        {
            this.PersonID = PersonID;
            this.NationalNo = NationalNo;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.Gender = Gender;
            this.Email = Email;
            this.Phone = Phone;
            this.DateOfBirth = DateOfBirth;
            this.NationalityCountryID = NationalityCountryID;
            this.Address = Address;
            this.ImagePath = ImagePath;
            this.CountryInfo = clsCountry.Find(NationalityCountryID);
            this._Mode = enMode.Update;
        }

        private bool _AddNewPerson()
        {
            this.PersonID = clsPeopleDataAccess.AddNewPerson(this.NationalNo, this.FirstName, this.SecondName, this.ThirdName, this.LastName,
                this.Gender, this.Email, this.Phone, this.DateOfBirth, this.NationalityCountryID, this.Address, this.ImagePath);

            return (this.PersonID != -1);
        }

        private bool _UpdatePerson()
        {
            return clsPeopleDataAccess.UpdatePerson(this.PersonID, this.NationalNo, this.FirstName, this.SecondName, this.ThirdName, this.LastName,
                this.Gender, this.Email, this.Phone, this.DateOfBirth, this.NationalityCountryID, this.Address, this.ImagePath);
        }

        public static bool DeletePerson(int PersonID)
        {
            string ImagePath = clsPerson.Find(PersonID).ImagePath;
            if(clsPeopleDataAccess.DeletePerson(PersonID))
            {
                if (!string.IsNullOrEmpty(ImagePath))
                {
                    try
                    {
                        if (File.Exists(ImagePath))
                            File.Delete(ImagePath);
                    }
                    catch (Exception ex)
                    {
                        // handle exception here
                    }

                }
                return true;
            }
            return false;
        }

        public bool Save()
        {
            switch(_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return _UpdatePerson();
            }

            return false;
        }

        public static clsPerson Find(int PersonID)
        {
            string NationalNo = "", FirstName = "", SecondName = "", ThirdName = "", LastName = "", Email = "", Phone = "", Address = "", ImagePath = "";
            sbyte Gender = -1;
            DateTime DateOfBirth = DateTime.Today;
            int NationalityCountryID = -1;

            if (clsPeopleDataAccess.GetPersonInfoByID(PersonID, ref NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName,
                ref Gender, ref Email, ref Phone, ref DateOfBirth, ref NationalityCountryID, ref Address, ref ImagePath))
            {
                return new clsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName,
                    Gender, Email, Phone, DateOfBirth, NationalityCountryID, Address, ImagePath);
            }
            else
            {
                return null;
            }
        }

        public static clsPerson Find(string NationalNo)
        {
            int PersonID = -1;
            string FirstName = "", SecondName = "", ThirdName = "", LastName = "", Email = "", Phone = "", Address = "", ImagePath = "";
            sbyte Gender = -1;
            DateTime DateOfBirth = DateTime.Today;
            int NationalityCountryID = -1;

            if (clsPeopleDataAccess.GetPersonInfoByNationalNo(ref PersonID, NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName,
                ref Gender, ref Email, ref Phone, ref DateOfBirth, ref NationalityCountryID, ref Address, ref ImagePath))
            {
                return new clsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName,
                    Gender, Email, Phone, DateOfBirth, NationalityCountryID, Address, ImagePath);
            }
            else
            {
                return null;
            }
        }

        public static DataTable GetAllPeople()
        {
            return clsPeopleDataAccess.GetAllPeople();
        }

        public static bool IsPersonExists(int PersonID)
        {
            return clsPeopleDataAccess.IsPersonExists(PersonID);
        }

        public static bool IsPersonExists(string NationalNo)
        {
            return clsPeopleDataAccess.IsPersonExists(NationalNo);
        }

        public string FullName()
        {
            return ($"{FirstName} {SecondName} {ThirdName} {LastName}");
        }
    }
}

