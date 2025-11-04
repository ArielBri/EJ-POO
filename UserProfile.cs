namespace POO_1
{
    using System;

    public class UserProfile
    {
        #region PRIVATE
        private string username;
        private string email;
        private string password;

        #endregion

        #region CTOR
        public UserProfile(string username, string email, string password)
        {
            this.username = username;
            SetEmail(email);
            SetPassword(password);
        }

        #endregion

        #region GETTERS Y SETTERS
        /// <summary>
        ///GETTER Y SETTER PARA USERNAME
        /// </summary>
        /// <returns></returns>
        public string GetUsername()
        {
            return username;
        }

        public void SetUsername(string username)
        {
            this.username = username;
        }

        /// <summary>
        /// GETTER Y SETTER PARA EMAIL
        /// </summary>
        /// <returns></returns>
        public string GetEmail()
        {
            return email;
        }

        public void SetEmail(string email)
        {
            if (string.IsNullOrEmpty(email) || !email.Contains("@"))
            {
                throw new ArgumentException("El email debe contener un '@'");
            }
            this.email = email;
        }

        /// <summary>
        /// GETTER Y SETTER PARA PASSWORD
        /// </summary>
        /// <returns></returns>
        public string GetPassword()
        {
            return password;
        }

        public void SetPassword(string password)
        {
            if (string.IsNullOrEmpty(password) || password.Length <= 8)
            {
                throw new ArgumentException("La contraseña debe tener más de 8 caracteres");
            }
            this.password = password;
        }

        #endregion

        
        public void DisplayProfile()
        {
            Console.WriteLine($"Username: {username}");
            Console.WriteLine($"Email: {email}");
        }
    }
  }
