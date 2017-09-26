using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DataModel;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.DynamoDBv2.Model;
using Amazon.Runtime;

namespace Alexamorse_code
{
    public class ApplicationDBContext
    {
        var credentials = new BasicAWSCredentials(accessKey, secretKey);
        var client = new AmazonDynamoDBClient(credentials, RegionEndpoint.EUCentral1);
    }
}
