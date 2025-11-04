namespace POO_1.Notifications
{
    public class PushNotification : Notification
    {
        #region PRIVATE
        private string deviceId;
        #endregion

        public PushNotification(string recipient, string message, string deviceId)
            : base(recipient, message)
        {
            this.deviceId = deviceId;
        }

        public override void Send()
        {
            Console.WriteLine("   Sending Push Notification to " + recipient);
            Console.WriteLine("   Device ID: " + deviceId);
            Console.WriteLine("   Message: " + message);
            Console.WriteLine();
        }
    }
}
