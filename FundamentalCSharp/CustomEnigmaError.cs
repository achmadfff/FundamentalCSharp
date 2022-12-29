namespace FundamentalCSharp
{
    internal class CustomEnigmaError : Exception
    {
        public CustomEnigmaError()
        {

        }

        public CustomEnigmaError(string message) : base(message)
        {

        }

        public CustomEnigmaError(string message, Exception inner) : base(message, inner)
        {

        }
        //public override string Message
        //{
        //    get
        //    {
        //        return "Telah terjadi error";
        //    }

        //}
        public override string HelpLink
        {
            get
            {
                return "Hubungi Fadhil jika error";
            }
        }
    }

}