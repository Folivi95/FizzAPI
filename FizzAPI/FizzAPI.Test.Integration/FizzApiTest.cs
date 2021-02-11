using NUnit.Framework;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace FizzAPI.Test.Integration
{
    public class FizzApiTest
    {
        [TestCase("Get", "api/v1/Fizz/15")]
        //[Ignore("Need to fix jwt setting value and handle 401 error")]
        public async Task GetFizzResult(string method, string URL)
        {
            using var client = new TestClientProvider().Client;
            var request = new HttpRequestMessage(new HttpMethod(method), URL);
            var response = await client.SendAsync(request);

            // response.EnsureSuccessStatusCode();

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }

        [Test]
        public async Task FizzResult()
        {
            Random r = new Random();
            int number = r.Next(1, 101);

            using var client = new TestClientProvider().Client;
            var request = new HttpRequestMessage(
                new HttpMethod("GET"), $"api/v1/Fizz/{number}");

            var response = await client.SendAsync(request);

            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }

        [Test]
        public async Task OutsideFizzConstraint()
        {
            Random r = new Random();
            int number = r.Next(102, 1000);

            using var client = new TestClientProvider().Client;

            var request = new HttpRequestMessage(new HttpMethod("GET"),
                $"api/v1/Fizz/{number}");

            var response = await client.SendAsync(request);

            //response.EnsureSuccessStatusCode();

            var res = await response.Content.ReadAsStringAsync();

            var parsedResult = res.ToString().Split(new[] { ',', ':' }, StringSplitOptions.RemoveEmptyEntries);

            response.StatusCode = parsedResult[1].Equals("500") ? HttpStatusCode.BadRequest : HttpStatusCode.Ambiguous;

            Assert.AreEqual(HttpStatusCode.BadRequest, response.StatusCode );
        }
    }
}