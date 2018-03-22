﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TibiaHeleper.Modules.WalkerModule
{
    public static class StatementType
    {
        public static Hashtable getType;

        static StatementType()
        {
            getType = new Hashtable();
            getType.Add("waypoint", 0);
            getType.Add("label", 1);
            getType.Add("check", 2);
            getType.Add("action", 3);

            getType.Add("Go To Label", 4);
            getType.Add("Mouse Click", 5);
            getType.Add("Say", 6);
            getType.Add("Stand", 7);
            getType.Add("Hotkey", 9);
            getType.Add("Use On Field", 10);

        }
    }
}