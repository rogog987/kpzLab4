using kpz4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kpz4.Builders
{
    public abstract class NotebookBuilder
    {
        protected Notebook notebook;

        public NotebookBuilder()
        {
            notebook = new Notebook();
        }

        public abstract NotebookBuilder SetCPU(string cpu);
        public abstract NotebookBuilder SetRAM(string ram);
        public abstract NotebookBuilder SetStorage(string storage);
        public abstract NotebookBuilder SetGPU(string gpu);
        public abstract NotebookBuilder SetDisplay(string display);

        public Notebook GetNotebook()
        {
            return notebook;
        }
    }
}
