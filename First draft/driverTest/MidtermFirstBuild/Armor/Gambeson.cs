﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermFirstBuild
{
    class Gambeson : Item, IArmor
    {
        private int _defenseValue;
        private bool _isNatural;
        private string _name;
        private double _weight;
        private InventorySlotId _slot;

        public Gambeson(Random randAttack) : base()
        {
            _defenseValue = randAttack.Next(1, 5);
            _isNatural = false;
            _name = "Gambeson";
            _slot = InventorySlotId.CHESTPIECE;

        }

        public int DefenseValue
        {
            get { return _defenseValue; }
        }
        public override bool IsNatural
        {
            get { return _isNatural; }
        }

        public override string Name
        {
            get { return _name; }
        }

        public override double Weight
        {
            get { return _weight; }
        }

        public override InventorySlotId Slot
        {
            get { return _slot; }
        }

        public override string ToString()
        {
            return (base.ToString() + " Defense: " + DefenseValue);
        }
    }
}
