using kpz4.Builders;
using kpz4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kpz4.Directors
{
    public class Director
    {
        public Notebook ConstructGamingNotebook(NotebookBuilder builder)
        {
            return builder
                .SetCPU(null)
                .SetRAM(null)
                .SetStorage(null)
                .SetGPU(null)
                .SetDisplay(null)
                .GetNotebook();
        }

        public Notebook ConstructOfficeNotebook(NotebookBuilder builder)
        {
            return builder
                .SetCPU(null)
                .SetRAM(null)
                .SetStorage(null)
                .SetGPU(null)
                .SetDisplay(null)
                .GetNotebook();
        }
    }
}
