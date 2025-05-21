using System;

namespace DependencyInversion;
interface Database
{
    string insert();
    string update();
    string delete();
}
