using Amazon.Runtime;
using Amazon.S3;
using System;
using System.Configuration;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            //aws hesabına bağlanılacak
            var credentials = new BasicAWSCredentials(
                ConfigurationManager.AppSettings["accessId"],
                ConfigurationManager.AppSettings["secretKey"]);

            using (AmazonS3Client client = new AmazonS3Client
                (credentials, Amazon.RegionEndpoint.EUWest1))
            {
                foreach (var item in client.ListBuckets().Buckets)
                {
                    Console.WriteLine(item.BucketName + " " +
                        item.CreationDate.ToShortDateString());
                }
            }
            Console.ReadLine();
        }
    }
}
