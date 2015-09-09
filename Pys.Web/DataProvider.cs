using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Pys.Data;

public static class DataProvider
{
    public static IDataProvider Instance = new PysDataProvider();
}