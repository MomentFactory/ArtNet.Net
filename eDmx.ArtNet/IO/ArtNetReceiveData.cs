﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtNet.IO
{
    public class ArtNetReceiveData
    {
        public byte[] buffer = new byte[1500];
        public int bufferSize = 1500;
        public int DataLength = 0;

        public bool Valid
        {
            get { return DataLength > 12; }
        }

        public int OpCode
        {
            get
            {
                return buffer[9] + (buffer[8] << 8);
            }
        }

    }
}
