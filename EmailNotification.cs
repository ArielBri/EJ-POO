namespace POO_1
{
    public class EmailNotification : Notification
    {
        #region PRIVATE
        private string subject;
        #endregion

        public EmailNotification(string recipient, string message, string subject = "Notificación")
            : base(recipient, message)
        {
            this.subject = subject;
        }

        public override void Send()
        {
            Console.WriteLine("📧 Sending Email to " + recipient);
            Console.WriteLine("   Subject: " + subject);
            Console.WriteLine("   Message: " + message);
            Console.WriteLine();
        }
    }
}
