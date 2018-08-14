using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecflowIntro
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int numbers)
        {
            Console.WriteLine(numbers);
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            Console.WriteLine("Pressed Add Button");
        }

        [When(@"I press subtract")]
        public void WhenIPressSubtract()
        {
            Console.WriteLine("Pressed Subtract Button");
        }


        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int result)
        {
            if (result == 121)
                Console.WriteLine("Test Passed");
            else
            { 
                Console.WriteLine("Test Failed");
                throw new Exception("The Value is different");
            }


        }
        [Then(@"I view result")]
        public void ThenIViewResult()
        {
            Console.WriteLine("Viewed Result");
        }

        [When(@"I fill all the mandatory details in form")]
        public void WhenIFillAllTheMandatoryDetailsInForm(Table table)
        {
           Employeedetails details = table.CreateInstance<Employeedetails>();
            Console.WriteLine(details.Name);
            Console.WriteLine(details.Age);
            Console.WriteLine(details.Phone);
            Console.WriteLine(details.Email);
        }

        [When(@"I fill all the mandatory details in form for four")]
        public void WhenIFillAllTheMandatoryDetailsInFormForFour(Table table)
        {
            var details = table.CreateSet<Employeedetails>();
            foreach (Employeedetails emp in details)
            {
                Console.WriteLine("Details of Employee" + emp.Name);
                Console.WriteLine("________________________________________");
                Console.WriteLine(emp.Name);
                Console.WriteLine(emp.Age);
                Console.WriteLine(emp.Phone);
                Console.WriteLine(emp.Email);
            }
        }


        [When(@"I fill all the mandatory details in form (.*), (.*) , (.*) and (.*)")]
        public void WhenIFillAllTheMandatoryDetailsInFormMynameAndAbcdXyz_Com(string name,int age, Int64 phone, string email)
        {
            Console.WriteLine("Name:" + name);
            Console.WriteLine("Age:" + age);
            Console.WriteLine("Phone:" + phone);
            Console.WriteLine("Email:" + email);
        }


    }
}
