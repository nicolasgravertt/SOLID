using System;
namespace InterfaceSegregation;
interface CloudHostingProvider
{
    string createServer(string host, string port);
    string listServers();
}
