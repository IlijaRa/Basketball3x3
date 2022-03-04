using BasketLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basketball3x3
{
    public interface IPrizeRequester
    {
        void PrizeComplete(PrizeModel model);
    }
}
