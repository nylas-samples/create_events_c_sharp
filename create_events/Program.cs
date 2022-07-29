// Import packages
using RestSharp;
using System;

// Load .env file
DotNetEnv.Env.Load();
DotNetEnv.Env.TraversePath().Load();

// Create a new Rest Client and call the Nylas API endpoint
var client = new RestSharp.RestClient("https://api.nylas.com/events");
// Wait until the connection is done
client.Timeout = -1;
// We want a POST method
var request = new RestSharp.RestRequest(Method.POST);
// Adding header and authorization
request.AddHeader("Content-Type", "application/json");
request.AddHeader("Authorization", "Bearer " + System.Environment.GetEnvironmentVariable("ACCESS_TOKEN"));

// Set date and time for the event
DateTime now = DateTime.Now;
DateTimeOffset start_time = new DateTimeOffset(now.Year, now.Month, now.Day, 17, 0, 0, TimeSpan.Zero);
start_time = start_time.ToLocalTime();
DateTimeOffset end_time = new DateTimeOffset(now.Year, now.Month, now.Day, 17, 30, 0, TimeSpan.Zero);
end_time = end_time.ToLocalTime();

var body = @"{" + "\n" +
@"    ""title"":""Let's learn some Nylas API with C#""," + "\n" +
@"    ""when"" : {" + "\n" +
$@"        ""start_time"": ""{start_time.ToUnixTimeSeconds()}""," + "\n" +
$@"        ""end_time"": ""{end_time.ToUnixTimeSeconds()}""" + "\n" +
@"    }," + "\n" +
@"    ""location"": ""Blag's Den""," + "\n" +
$@"    ""calendar_id"": ""{System.Environment.GetEnvironmentVariable("CALENDAR_ID")}""," + "\n" +
@"    ""participants"": [" + "\n" +
@"        {" + "\n" +
@"            ""email"": ""alvaro.t@nylas.com""," + "\n" +
@"            ""name"": ""Blag""" + "\n" +
@"        }" + "\n" +
@"    ]" + "\n" +
@"}";

Console.WriteLine(body);

// Adding the body as a parameter
//request.AddParameter("application/json", body, ParameterType.RequestBody);
// We send the request
//IRestResponse response = client.Execute(request);
// Print the response
//Console.WriteLine(response.Content);
// Wait for user input before closing the terminal
Console.Read();
