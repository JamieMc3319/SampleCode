using System;

namespace ZohoClients.Core.Attributes
{
    public class QueryStringParameterNameAttribute : Attribute
    {
        public string ParameterName { get; private set; }

        public QueryStringParameterNameAttribute(string parameterName)
        {
            this.ParameterName = parameterName;
        }
    }
}