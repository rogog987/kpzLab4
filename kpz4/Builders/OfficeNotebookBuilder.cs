using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kpz4.Builders
{
    public class OfficeNotebookBuilder : NotebookBuilder
    {
        public override NotebookBuilder SetCPU(string cpu)
        {
            notebook.CPU = cpu ?? "Intel Core i5";
            return this;
        }

        public override NotebookBuilder SetRAM(string ram)
        {
            notebook.RAM = ram ?? "8GB";
            return this;
        }

        public override NotebookBuilder SetStorage(string storage)
        {
            notebook.Storage = storage ?? "512GB SSD";
            return this;
        }

        public override NotebookBuilder SetGPU(string gpu)
        {
            notebook.GPU = gpu ?? "Integrated Graphics";
            return this;
        }

        public override NotebookBuilder SetDisplay(string display)
        {
            notebook.Display = display ?? "15.6-inch Full HD";
            return this;
        }
    }
}
