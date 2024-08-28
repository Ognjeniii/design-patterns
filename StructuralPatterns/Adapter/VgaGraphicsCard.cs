using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Adapter
{
    public class VgaGraphicsCard
    {
        public VgaStream GetVgaStream()
        { 
            VgaStream vgaStream = new VgaStream();
            vgaStream.SetData(new byte[] { });
            return vgaStream;
        }
    }
}
