using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using VirtualPocketMoney.Services;
using Xamarin.Forms;

namespace VirtualPocketMoney.Tables
{
    public class RegUserTable
    {



        public RegUserTable()
        {
            // Contact = new Contacts();
        }


        public Guid UserId { get; set; }
        public string Name { get; set; }
        // public virtual Contacts Contact { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Salutation { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public string APPID { get; set; }
        public string BVN { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        // public string UniqueNo { get; set; }



        //private string GenerateApplicationUser()
        //{
        //    return User.Name = $"{LName}{FName}";

        //}


        //public string GenerateUniqueNumber(IUnitOfWork unitOfWork)
        //{
        //    _unitofwork = unitOfWork;

        //    var TotalPersons = (_unitofwork.Customers.Getall().Count());



        //    UniqueNum = $"{Acr}{(++TotalPersons).ToString().PadLeft(7, '0')}";


        //    return UniqueNum;
        //}


       

    }
}

