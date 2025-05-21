using System;
namespace InterfaceSegregation;
interface CloudStorageProvider
{
    string storeFile(string path);
    string getFile(string path);
}
