using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPocketMoney
{
    public class RegModel
    {
        public Guid UserId { get; set; }
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
        public string ConfirmPassword { get; set; }
    }
}
