using System;
namespace InterfaceSegregation;
internal class Amazon : CloudHostingProvider, CloudStorageProvider, CDNProvider
{
    public string createServer(string host, string port)
    {
        throw new NotImplementedException();
    }

    public string getCDNAAdress()
    {
        throw new NotImplementedException();
    }

    public string getFile(string path)
    {
        throw new NotImplementedException();
    }

    public string listServers()
    {
        throw new NotImplementedException();
    }

    public string storeFile(string path)
    {
        throw new NotImplementedException();
    }
}
