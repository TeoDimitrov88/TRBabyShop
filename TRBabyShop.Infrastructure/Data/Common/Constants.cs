using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRBabyShop.Infrastructure.Data.Common
{
    public class Constants
    {
        public const int MaxUsernameLength = 30;

        public const int MinUsernameLength = 6;

        public const int MaxPasswordLength = 30;
        public const int MinPasswordLength = 5;

        public const int MinEmailLength = 10;
        public const int MaxEmailLength = 60;

        public static class Status
        {
            public const string RoleUser = "User";
            public const string RoleAdmin = "Admin";


            public const string PendingStatus = "Pending";
            public const string ApprovedStatus = "Approved";
            public const string StatusInProcess = "Processing";
            public const string ShippedStatus = "Shipped";
            public const string CancelledStatus = "Cancelled";


            public const string PaymentStatusPending = "Pending";
            public const string PaymentStatusApproved = "Approved";
            public const string PaymentStatusDelayedPayment = "ApprovedForDelayedPayment";
            public const string PaymentStatusRejected = "Rejected";


            public const string SessionCart = "SessionShoppingCart";
        }
    }
}
