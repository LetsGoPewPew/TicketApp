namespace Library.Verification
{
    public class BankId : IVerificationMethod
    {
        public bool Verify()
        {
            return true;
        }

        public override string ToString()
        {
            return "BankID";
        }
    }
}
