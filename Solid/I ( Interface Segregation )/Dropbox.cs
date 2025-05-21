using System;
namespace InterfaceSegregation;
internal class Dropbox : CloudStorageProvider
{
    public string getFile(string path)
    {
        throw new NotImplementedException();
    }

    public string storeFile(string path)
    {
        throw new NotImplementedException();
    }
}
