
namespace S3Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var operation = new S3BucketOprations();
            operation.UploadFile();
            operation.DownloadFileAsync().Wait();
            operation.PresSignedUrl();
            operation.GetObjectTagging();
            operation.UpdateObjectTagging();

        }
    }
}
