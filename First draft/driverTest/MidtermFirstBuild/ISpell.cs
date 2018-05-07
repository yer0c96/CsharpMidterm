using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermFirstBuild
{
    public interface ISpell
    {
        int CurrentCharges { get; set; }
        int MaxCharges { get; }
        int ChargesPerUse { get; }

        int CastSpell();
    }
}
