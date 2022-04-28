using System;

namespace Core.Entity
{
    public class Roles
    {
        public Roles()
        {
            createDate = DateTime.Now;
                
        }
        public int id { get; set; }
        public string name { get; set; }

        public DateTime createDate { get; set; }
        public string value_logic { get; set; }
    }
}