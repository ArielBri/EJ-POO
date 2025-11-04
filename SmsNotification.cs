namespace POO_1
{
    public class SmsNotification : Notification
    {
        #region PRIVATE
        private string phoneNumber;
        #endregion

        public SmsNotification(string recipient, string message, string phoneNumber)
            : base(recipient, message)
        {
            this.phoneNumber = phoneNumber;
        }

        public override void Send()
        {
            Console.WriteLine("📱 Sending SMS to " + recipient);
            Console.WriteLine("   Phone: " + phoneNumber);
            Console.WriteLine("   Message: " + message);
            Console.WriteLine();
        }
    }
}
