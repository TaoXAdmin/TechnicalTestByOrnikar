using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Authenticators.OAuth2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicalTestByOrnikar.drivers;
using TechnicalTestByOrnikar.Utils.DummyAPI;
using TechTalk.SpecFlow;

namespace TechnicalTestByOrnikar.Steps.APIsSteps
{
    [Binding]
     class APIsSteps
    {
        APIDeal deal = new APIDeal(); 

        [Given(@"I perform a GET request ""([^""]*)"" on the api to retrieve all employees")]
        public void GivenIPerformAGETRequestOnTheApi(string request)
        {
            deal.NewAPIDealGet(request);
        }

        [Given(@"status code is ""([^""]*)""")]
        public void GivenStatusCodeIs(string oK)
        {
            Assert.That(deal.Response.StatusCode.ToString().Equals(oK));
        }

        [Given(@"the statut is success")]
        public void GivenTheStatutIsSuccess()
        {
            Assert.That(JObject.Parse(deal.Response.Content).SelectToken("status").ToString().Equals("success"));
        }

        [Given(@"In the response's JSON body I have all employee")]
        public void GivenInTheResponsesJSONBodyIHaveAllEmployee()
        {
            Assert.That(JObject.Parse(deal.Response.Content).SelectToken("data").Count(), Is.EqualTo(24));
        }

        [Given(@"I perform a GET request ""([^""]*)"" on the api to retrieve an employee")]
        public void WhenIPerformAGETRequestOnTheApi(string request)
        {
            deal.NewAPIDealGet(request);
        }

        [Given(@"In the response's JSON body I have the employee data")]
        public void WhenInTheResponsesJSONBodyIHaveTheEmployeeData()
        {
            Assert.That(int.Parse(JObject.Parse(deal.Response.Content).SelectToken("data").SelectToken("id").ToString()), Is.EqualTo(1));
            Assert.That(JObject.Parse(deal.Response.Content).SelectToken("data").SelectToken("employee_name").ToString().Equals("Tiger Nixon"));
            Assert.That(int.Parse(JObject.Parse(deal.Response.Content).SelectToken("data").SelectToken("employee_salary").ToString()), Is.EqualTo(320800));
            Assert.That(int.Parse(JObject.Parse(deal.Response.Content).SelectToken("data").SelectToken("employee_age").ToString()), Is.EqualTo(61));
        }

        [Given(@"I perform a POST request ""([^""]*)"" on the api")]
        public void WhenIPerformAPOSTRequestOnTheApi(string request)
        {
            var employee = new Employee();
            employee.name = "John Tester";
            employee.salary = "40000";
            employee.age = "29";
            deal.NewAPIDealPost(request, employee);
        }

        [Given(@"In the response's JSON body I have the new employee information")]
        public void WhenInTheResponsesJSONBodyIHaveTheNewEmployeeInformation()
        {
            deal.NewAPIDealGet("https://dummy.restapiexample.com/api/v1/employee/" + "idOfNewEmployee");
            Assert.That(JObject.Parse(deal.Response.Content).SelectToken("data").SelectToken("employee_name").ToString().Equals("John Tester"));
            Assert.That(int.Parse(JObject.Parse(deal.Response.Content).SelectToken("data").SelectToken("employee_salary").ToString()), Is.EqualTo(40000));
            Assert.That(int.Parse(JObject.Parse(deal.Response.Content).SelectToken("data").SelectToken("employee_age").ToString()), Is.EqualTo(29));
        }

        [Given(@"I perform a PUT request ""([^""]*)"" on the api")]
        public void WhenIPerformAPUTRequestOnTheApi(string request)
        {
            var employee = new Employee();
            employee.name = "John Tester";
            employee.salary = "40001";
            employee.age = "29";
            var json = JsonConvert.SerializeObject(employee);
            deal.NewAPIDealPut(request, json);
        }

        [Given(@"In the response's JSON body I have updated infos")]
        public void WhenInTheResponsesJSONBodyIHaveUpdatedInfos()
        {
            deal.NewAPIDealGet("https://dummy.restapiexample.com/api/v1/employee/" + "idOfNewEmployee");
            Assert.That(int.Parse(JObject.Parse(deal.Response.Content).SelectToken("data").SelectToken("employee_salary").ToString()), Is.EqualTo(40001));
        }

        [Given(@"I perform a DELETE request ""([^""]*)"" on the api")]
        public void WhenIPerformADELETERequestOnTheApi(string request)
        {
            deal.NewAPIDealDelete(request);
        }

        [Given(@"I can not perform a GET on this user")]
        public void WhenICanNotPerformAGETOnThisUser()
        {
            deal.NewAPIDealGet("https://dummy.restapiexample.com/api/v1/employee/2");
            Assert.That(!deal.Response.StatusCode.ToString().Equals("OK"));
        }


        [AfterTestRun]
        public static void CleanUp()
        {
            Thread.Sleep(1000);
        }
    }
}
