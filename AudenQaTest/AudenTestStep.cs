using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace AudenQaTest
{

    [Binding]

    class AudenTestStep
    {
        IWebDriver driver;

        [Given(@"i am on Auden Homepage and select loan Amount and Repayment day")]
        public void GivenIAmOnAudenHomepageAndSelectLoanAmountAndRepaymentDay()
        {
            AudenHomepage AdHmpage = new AudenHomepage();
            AdHmpage.ClickandMoveSelectedSliders();
            AdHmpage.SelectRepaymentDate();
        }

        [Given(@"i should see the first repayment date text as '(.*)'")]
        public void GivenIShouldSeeTheFirstRepaymentDateTextAs(string text)
        {
            AudenHomepage AdHmpage = new AudenHomepage();
            AdHmpage.Check_Repayment_Date(text);
        }


        [Given(@"i should see the Min as (.*) and Max (.*)")]
        public void GivenIShouldSeeTheMinAsAndMax(int p0, int p1)
        {

            {
                //AudenHomepage AdHmpage = new AudenHomepage();
               // AdHmpage.CheckMinandMaxAmount("200, 500");
            }


        }

        [Given(@"the selected slider amount is the loan Amount")]
        public void GivenTheSelectedSliderAmountIsTheLoanAmount()
        {
            //AudenHomepage AdHmpage = new AudenHomepage();//
            //AdHmpage.CheckSliderAmountasLoanAmount("£450");//
        }

    }
}
