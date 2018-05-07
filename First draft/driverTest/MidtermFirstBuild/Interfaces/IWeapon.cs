using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermFirstBuild
{
    public interface IWeapon 
    {
        int AttackValue { get; }
        bool IsNatural { get; }
        
    }
}
