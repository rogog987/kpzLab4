using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kpz4.Builders
{
    public class GamingNotebookBuilder : NotebookBuilder
    {
        public override NotebookBuilder SetCPU(string cpu)
        {
            notebook.CPU = cpu ?? "Intel Core i9";
            return this;
        }

        public override NotebookBuilder SetRAM(string ram)
        {
            notebook.RAM = ram ?? "32GB";
            return this;
        }

        public override NotebookBuilder SetStorage(string storage)
        {
            notebook.Storage = storage ?? "1TB SSD";
            return this;
        }

        public override NotebookBuilder SetGPU(string gpu)
        {
            notebook.GPU = gpu ?? "NVIDIA RTX 4080";
            return this;
        }

        public override NotebookBuilder SetDisplay(string display)
        {
            notebook.Display = display ?? "17-inch 4K";
            return this;
        }
    }
}
