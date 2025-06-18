using System;
using System.Net.Mail;
using UnityEngine;

public class CheckInput : MonoBehaviour
{
    public static string CheckInputData(string firstName, string lastName, string email){
        if(firstName == "" || lastName == "" || email == ""){
            return "empty";
        }

        try
        {
            MailAddress m = new MailAddress(email);
            return "worked";
        }
        catch (FormatException)
        {
            return "email";
        }
    }
}
