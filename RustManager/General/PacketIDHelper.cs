﻿using System;
using System.Collections.Generic;

namespace RustManager.General
{
    class PacketIDHelper
    {
        // TODO: Implement properly?

        private static Random Random = new Random();
        private static List<int> CurrentPackets = new List<int>();

        public static int GeneratePacketID()
        {
            //int num = 0;
            //while (num == 0 || CurrentPackets.Contains(num))
            //{
            //    num = Random.Next(10, 1000);
            //}

            //CurrentPackets.Add(num);
            //return num;

            return 69;
        }

        //public static bool IsMyPacket(int id) => CurrentPackets.Contains(id);
        public static bool IsMyPacket(int id) => id == 69;

        public static void UsedPacket(int id)
        {
            if (CurrentPackets.Contains(id))
            {
                CurrentPackets.Remove(id);
            }
        }
    }
}
