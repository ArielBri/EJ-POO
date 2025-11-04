namespace POO_1
{
    public abstract class Notification
    {
        #region PROTECTED
        protected string recipient;
        protected string message;
        #endregion

        #region CTOR
        public Notification(string recipient, string message)
        {
            this.recipient = recipient;
            this.message = message;
        }
        #endregion

        #region GETTERTS
        public string GetRecipient()
        {
            return recipient;
        }

        public string GetMessage()
        {
            return message;
        }
        #endregion

        /// <summary>
        /// METODO ABSTRACTO ENVIAR
        /// </summary>
        public abstract void Send();
    }
}
