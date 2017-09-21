using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Amazon.Lambda.Core;
using Alexa.NET.Response;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace Alexa_morse_code
{
    public class Function
    {

        /// <summary>
        /// A simple function that takes a string and does a ToUpper
        /// </summary>
        /// <param name="input"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public /*string*/ SkillResponse FunctionHandler(string input, ILambdaContext context)
        {
            SkillResponse response = new SkillResponse();
            response.Response.ShouldEndSession = false;
            IOutputSpeech innerResponse = null;
            var log = context.Logger;

            var allResources = GetResources();
            var resource = allResources.FirstOrDefault();
            return input?.ToUpper();
        }

        public char[] toArray(string input)
        {
            char[] characters = input.ToCharArray();
            return characters;
        }

        public void output(char[] input)
        {
            //TODO
        }
    }
}
