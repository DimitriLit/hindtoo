using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hindtoo
{
    public class PeopleList
    {
        public static readonly List<People> people = new List<People> 
        {
            new People()
            {
                Id = 1,
                Name = "Foo",
                Age = 20,
            },

            new People()
            {
                Id = 2,
                Name = "Bar",
                Age = 20
            },

            new People()
            {
                Id = 3,
                Name = "Jhoen",
                Age = 26
            },

            new People()
            {
                Id = 4,
                Name = "Marija",
                Age = 26
            },

            new People()
            {
                Id = 5,
                Name = "Poeter",
                Age = 17
            },



        };
    }
}
