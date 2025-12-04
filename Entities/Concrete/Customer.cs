using Core.Entities;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Entities.Concrete
{
    public class Customer: BaseEntity, IEntity
    {
        public string CustomerName { get; set; }
        public string CustomerCode { get; set; }

        public static string GenerateRandomCode()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var buffer = new byte[11];
            RandomNumberGenerator.Fill(buffer);
            var result = new char[buffer.Length];

            for (int i = 0; i < buffer.Length; i++)
            {
                result[i] = chars[buffer[i] % chars.Length];
            }

            return new string(result);
        }

        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

    }
}
