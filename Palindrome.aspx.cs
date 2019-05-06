using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Palindrom.Web
{
    public partial class Palindrome : System.Web.UI.Page
    {
        private TextBox inputBox;
        private TextBox resultBox;

        protected void Page_Init(object sender, EventArgs e)
        {
            inputBox = this.FindControl("input") as TextBox;
            resultBox = this.FindControl("result") as TextBox;
        }

        protected bool IsPalindrome(string input)
        {
            bool isPalindrome = true;

            try
            {
                if(input.ToLower() == "exit")
                {
                    Response.Redirect("ExitPage.aspx");
                }

                char[] userInput = input.ToCharArray();

                if (userInput.Length == 0)
                {
                    throw new Exception("Cannot check a blank string. Please try again.");
                }

                for (int i = 0; i < userInput.Length; i++)
                {
                    if ((userInput[i] < 65) || (userInput[i] > 90 && userInput[i] < 97) || (userInput[i] > 123))
                    {
                        throw new Exception("Restricted character detected. Please try again.");
                    }
                    else
                    {
                        userInput[i] = Char.ToLower(userInput[i]);
                    }
                }

                for (int index = 0; index < userInput.Length / 2; index++)
                {

                    if (userInput[index] != userInput[userInput.Length - 1 - index])
                    {
                        isPalindrome = false;
                    }

                }
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return isPalindrome;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            try
            {
                bool result = IsPalindrome(inputBox.Text);
                resultBox.Text = result.ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    } 
}