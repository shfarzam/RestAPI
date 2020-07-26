using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace RestAPI.Models
{
    [DataContract]
    public class Person
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string zipcode { get; set; }

        [DataMember]
        public string city { get; set; }

        [DataMember]
        public string color { get; set; }

        public string[] Colors = new string[] {"","blau","grün","violett","rot","gelb","türkis","weiß"};
        public string[] lines = System.IO.File.ReadAllLines(@"c:\sample-input.csv");

        public List<Person> GetPerson()
        {            
            string[] error = { "Error to find Fiile." };
            List<Person> persons = new List<Person>();

            try
            {
                //string[] lines = System.IO.File.ReadAllLines(@"c:\sample-input.csv");
                

                for (int i = 0; i < lines.Length; i++)
                {
                    string[] fields = lines[i].Split(',');
                    try
                    {
                        persons.Add(new Person { Id = i + 1, FirstName = fields[0], LastName = fields[1], zipcode = fields[2].Substring(1, 6), city = fields[2].Substring(7, fields[2].Length - 7), color = Colors[Int16.Parse(fields[3])] });
                    } catch (Exception ex)
                    {

                    }
                    
                }
                return persons;
            }
            catch (Exception ex)
            {
                
                return persons;
            }
        }

        public List<Person> GetPersonById(int id)
        {
            string[] error = { "Error to find Fiile." };
            List<Person> persons = new List<Person>();

            try
            {
                //string[] lines = System.IO.File.ReadAllLines(@"c:\sample-input.csv");


                for (int i = 0; i < lines.Length; i++)
                {
                    string[] fields = lines[i].Split(',');
                    if (id == i + 1)
                    {
                        try
                        {
                            persons.Add(new Person { Id = i + 1, FirstName = fields[0], LastName = fields[1], zipcode = fields[2].Substring(1, 6), city = fields[2].Substring(7, fields[2].Length - 7), color = Colors[Int16.Parse(fields[3])] });
                            return persons;
                        }
                        catch (Exception ex)
                        {

                        }
                    }

                }
                persons.Add(new Person { Id = 0, FirstName = "N/A", LastName = "N/A", zipcode = "N/A", city = "N/A", color = "N/A" });
                return persons;
            }
            catch (Exception ex)
            {
                persons.Add(new Person { Id = 0, FirstName = "N/A", LastName = "N/A", zipcode = "N/A", city = "N/A", color = "N/A" });
                return persons;
            }
        }

        public List<Person> GetPersonByColor(string color)
        {
            string[] error = { "Error to find Fiile." };
            List<Person> persons = new List<Person>();

            try
            {
                //string[] lines = System.IO.File.ReadAllLines(@"c:\sample-input.csv");

                int index = Array.IndexOf(Colors, color);

                for (int i = 0; i < lines.Length; i++)
                {
                    string[] fields = lines[i].Split(',');
                    if ( fields.Length > 3 && index == Int16.Parse(fields[3]))
                    {
                        try
                        {
                            persons.Add(new Person { Id = i + 1, FirstName = fields[0], LastName = fields[1], zipcode = fields[2].Substring(1, 6), city = fields[2].Substring(7, fields[2].Length - 7), color = Colors[Int16.Parse(fields[3])] });                            
                        }
                        catch (Exception ex)
                        {

                        }
                    }

                }

                if(persons.Count > 0)
                {
                    return persons;
                }

                persons.Add(new Person { Id = 0, FirstName = "N/A", LastName = "N/A", zipcode = "N/A", city = "N/A", color = "N/A" });
                return persons;

            }
            catch (Exception ex)
            {
                persons.Add(new Person { Id = 0, FirstName = "N/A", LastName = "N/A", zipcode = "N/A", city = "N/A", color = "N/A" });
                return persons;
            }
        }

    }
}