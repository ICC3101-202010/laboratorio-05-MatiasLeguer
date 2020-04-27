using System;
using System.Collections.Generic;
using System.Text;

namespace Solucion_Lab_21_abril
{
    public class User
    { 
        public User()
        {

        }


        public delegate void VerifyEmailEventHandler(object source, EventArgs args);
        public event VerifyEmailEventHandler EmailVerified;

        protected virtual void OnEmailVerified()
        {
            if(EmailVerified != null)
            {
                EmailVerified(this, new EventArgs());
            }
        }

        public void OnEmailSent(object source, EventArgs args)
        {
            string confirm;
            Console.Write("Quieres verificar tu correo? (Y/N): ");
            confirm = Console.ReadLine();
            if(confirm  == "Y")
            {
                OnEmailVerified();
            }
            else
            {
                Console.WriteLine("Correo no verificado");
            }
        }



    }
}
