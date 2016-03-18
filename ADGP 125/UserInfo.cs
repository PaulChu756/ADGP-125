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
        private string m_AnimalType; // Type of animal

        // calls from other class, to grab info/value in m_Name
        public string Name { get { return m_Name; } } 
        public string Animal { get { return m_AnimalType; } }

        // Constructor use to create/instance of player object
        // takes values in parameters and assign them to var's in class
        public UserInfo(string name, string animal)
        {
            m_Name = name;
            m_AnimalType = animal;
        }

        // default constructor
        public UserInfo()
        {
            m_Name = "Pandalord";
            m_AnimalType = "Panda";
        }
    }
}
