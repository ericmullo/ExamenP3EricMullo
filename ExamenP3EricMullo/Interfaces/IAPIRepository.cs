using ExamenP3EricMullo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenP3EricMullo.Interfaces
{
    internal interface IAPIRepository
    {
        public Task<AeropuertoModel> GetResponseFromAPi(string name);
    }
}
