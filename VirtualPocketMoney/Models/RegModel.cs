using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace VirtualPocketMoney.Models
{
    public class RegModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Salutation { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public string APPID { get; set; }
        public string BVN { get; set; }
        public string Password { get; set; }
        public string UniqueNo => GenerateUniqueNumber();
        //public string ConfirmPassword { get; set; }



        private string GenerateUniqueNumber()
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "VPMDataBase.db");
            var db = new SQLiteConnection(dbpath);
            var total = db.Table<RegModel>().Count();
            return $"VPM{(++total).ToString().PadLeft(7, '0')}";
        }
    }
}
