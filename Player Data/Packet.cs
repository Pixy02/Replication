using System;
using System.Collections.Generic;
using System.Text;

namespace Player_Data
{
    public enum Packet
    {
        Spawn = 1,
        Move,
        Attack,
    }

    class PacketData
    {
        private List<byte> buffer;
        private byte[] readableBuffer;
        private int readPos;
    }
}