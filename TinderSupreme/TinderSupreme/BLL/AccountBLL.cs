using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TinderSupreme.DAL;


namespace TinderSupreme.BLL
{
    public class AccountBLL
    {
        public static String NewUser(Account newUser, String verifiedPassWord)
        {
            String s = "";
            //Check if username already exists
            if(newUser.Password == verifiedPassWord)
            {
                //Username don't exists, check if the password verfication is correct
                if (!AccountDAL.IsUsernameInDB(newUser.UserName))               
                {
                    //Store username in database
                    AccountDAL.Store(newUser);
                    s += "Username succesfully created and stored in database";

                }
                else
                {
                    s += "Username already exists";
                }

            }
            else
            {
                s += "Password verification failed";
            }
            return s;
        }
        
    }
}