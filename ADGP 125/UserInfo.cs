using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADGP_125
{
    [Serializable()]
    public class UserInfo
    {
        private string m_Name; // Name of player

        // calls from other class, to grab info/value in m_Name
        public string Name { get { return m_Name; } } 

        // Constructor use to create/instance of player object
        // takes values in parameters and assign them to var's in class
        public UserInfo(string name)
        {
            m_Name = name;
        }

        // default constructor
        public UserInfo()
        {
            m_Name = "Pandalord";
        }
    }
}
