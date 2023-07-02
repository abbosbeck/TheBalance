//--------------------------------------------------
// Copyright (c) Coalition of Good-Hearted Engineers
// Developed by TheBalance Team
//--------------------------------------------------

namespace TheBalance.Service.Exceptions
{
    public class TheBalanceException : Exception
    {
        public int Code { get; set; }

        public TheBalanceException(int code, string message) 
            : base(message) 
        {
            this.Code = code;
        }
    }
}
