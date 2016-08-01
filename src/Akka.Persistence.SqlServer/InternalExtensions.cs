﻿//-----------------------------------------------------------------------
// <copyright file="InternalExtensions.cs" company="Akka.NET Project">
//     Copyright (C) 2009-2016 Lightbend Inc. <http://www.lightbend.com>
//     Copyright (C) 2013-2016 Akka.NET project <https://github.com/akkadotnet/akka.net>
// </copyright>
//-----------------------------------------------------------------------

using System.Data.SqlClient;

namespace Akka.Persistence.SqlServer
{
    internal static class InternalExtensions
    {
        public static string QuoteSchemaAndTable(this string sqlQuery, string schemaName, string tableName)
        {
            var cb = new SqlCommandBuilder();
            return string.Format(sqlQuery, cb.QuoteIdentifier(schemaName), cb.QuoteIdentifier(tableName));
        }
    }
}