﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoGo.PokeMobBot.Logic.Event
{
    public class PlayerStatsEvent : IEvent

    {
        public List<POGOProtos.Data.Player.PlayerStats> PlayerStats { get; set; }
    }
}
