using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumFirst
{
    class EAPageObject
    {
        public EAPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }
        [FindsBy(How =How.Id, Using = "TitleId")]
        public IWebElement ddlTitleId { get; set; }

        [FindsBy(How =How.Name, Using = "Initial")]
        public IWebElement txtInitial { get; set; }

        [FindsBy(How =How.Name, Using = "FirstName")]
        public IWebElement txtFirstName { get; set; }

        [FindsBy(How =How.Name, Using = "MiddleName")]
        public IWebElement txtMiddleName { get; set; }

        [FindsBy(How =How.Name, Using = "Female")]
        public IWebElement btnFemale { get; set; }

        [FindsBy(How =How.Name, Using = "Hindi")]
        public IWebElement btnHindi { get; set; }

        [FindsBy(How =How.Name, Using = "Save")]
        public IWebElement btnSave { get; set; }

        public void FillUserForm(string titleId, string initial, string firstName, string middleName)
        {

            SeleniumSetMethods.EnterText(txtInitial, initial);
            SeleniumSetMethods.EnterText(txtFirstName, firstName);
            SeleniumSetMethods.EnterText(txtMiddleName, middleName);
            SeleniumSetMethods.Click(btnSave);
            SeleniumSetMethods.Click(btnFemale);
            SeleniumSetMethods.Click(btnHindi);


            //ddlTitleId.SendKeys(titleId);
            //txtInitial.SendKeys(initial);
            //txtFirstName.SendKeys(firstName);
            //txtMiddleName.SendKeys(middleName);

            //btnFemale.Click();
            //btnHindi.Click();
            //btnSave.Click();
        }


    }
}
