using System;
using System.Data;
using System.Configuration;

/// <summary>
/// MyOleParameter 的摘要说明
/// </summary>
namespace Pys.Data
{
    public class PysDatabaseParameter
    {
        public PysDatabaseParameter(string name, object value)
        {
            m_name = name;
            m_value = value;
        }

        private string m_name;
        public string Name
        {
            set
            {
                m_name = value;
            }
            get
            {
                return m_name;
            }
        }

        private object m_value;
        public object Value
        {
            set
            {
                m_value = value;
            }
            get
            {
                return m_value;
            }
        }
    }

    public class PsyDatabaseParameterCollection
    {
        private System.Collections.Generic.List<PysDatabaseParameter> m_istParameters = new System.Collections.Generic.List<PysDatabaseParameter>();
        public System.Collections.Generic.List<PysDatabaseParameter> ListParameters
        {
            set
            {
                m_istParameters = value;
            }
            get
            {
                return m_istParameters;
            }
        }
        public void Add(string name, object value)
        {
            m_istParameters.Add(new PysDatabaseParameter(name, value));
        }
    }
}