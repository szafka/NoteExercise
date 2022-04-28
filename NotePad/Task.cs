using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotePad
{
    public class Task
    {
        public String name;
        public Boolean active;
        public Task(String name, Boolean active)
        {
            this.name = name;
            this.active = active;
        }
        public Boolean isActive()
        {
            return active;
        }
        public void ChangeActiveFlag(Boolean active)
        {
            this.active = active;
        }
        public override string ToString()
        {
            return name + ": " + (active ? "is active:" : "not active:");
        }
    }
}
