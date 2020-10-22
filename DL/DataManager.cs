using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    internal class DataManager
    {
        public void Serialize(List<Person> personList)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(personList.GetType());

            using (FileStream outFile = new FileStream("Persons.xml", FileMode.Create, FileAccess.Write))
            {
                xmlSerializer.Serialize(outFile, personList);
            }
        }

        public List<Person> Deserialize()
        {
            List<Person> listOfPersonsToBeReturned;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Person>));

            using (FileStream inFile = new FileStream("Persons.xml", FileMode.Open, FileAccess.Read))
            {
                listOfPersonsToBeReturned = (List<Person>)xmlSerializer.Deserialize(inFile);
            }

            return listOfPersonsToBeReturned; 
        }
    }
}
