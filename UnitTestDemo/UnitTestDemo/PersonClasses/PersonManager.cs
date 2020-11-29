using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestDemo.PersonClasses
{
    public class PersonManager
  {
    public Person CreatePerson(string first,
                                string last,
                                bool isSupervisor) {
      Person ret = null;

      if (!string.IsNullOrEmpty(first)) {
        if (isSupervisor) {
          ret = new Supervisor();
        }
        else {
          ret = new Employee();
        }

        // Assign variables
        ret.FirstName = first;
        ret.LastName = last;
      }

      return ret;
    }

    /// <summary>
    /// This method simulates retrieving a list of Person objects from a database or other data store
    /// </summary>
    /// <returns>A collection of Person objects</returns>
    public List<Person> GetPeople() {
      List<Person> people = new List<Person>();


      people.Add(new Person() { FirstName = "John", LastName = "Doe" });
      people.Add(new Person() { FirstName = "Jane", LastName = "Smith" });
      people.Add(new Person() { FirstName = "Jim", LastName = "Adams" });

            return people;
    }

    /// <summary>
    /// This method simulates retrieving a list of Supervisor objects from a database or other data store
    /// </summary>
    /// <returns>A collection of Supervisor objects</returns>
    public List<Person> GetSupervisors() {
      List<Person> people = new List<Person>();

      people.Add(CreatePerson("Paul", "Sheriff", true));
      people.Add(CreatePerson("Michael", "Krasowski", true));

      return people;
    }

    /// <summary>
    /// This method simulates retrieving a list of Employee objects from a database or other data store
    /// </summary>
    /// <returns>A collection of Person objects</returns>
    public List<Person> GetEmployees() {
      List<Person> people = new List<Person>();

      people.Add(CreatePerson("Steve", "Nystrom", false));
      people.Add(CreatePerson("John", "Kuhn", false));
      people.Add(CreatePerson("Jim", "Ruhl", false));

      return people;
    }

    /// <summary>
    /// This method simulates retrieving a list of Supervisor and Employee objects from a database or other data store
    /// </summary>
    /// <returns>A collection of Supervisor and Employee objects</returns>
    public List<Person> GetSupervisorsAndEmployees() {
      List<Person> people = new List<Person>();

      people.AddRange(GetEmployees());
      people.AddRange(GetSupervisors());

      return people;
    }
  }
}
