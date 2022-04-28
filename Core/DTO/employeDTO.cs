using System;
using System.Collections.Generic;
using System.Text;

namespace Core.DTO
{
    public class employeDTO
    {
        public string name { get; set; }

        public string lastName { get; set; }
        public string nameComplete { get { return name + lastName; } }
        public int identification { get; set; }

        public string email { get; set; }
    }
}
