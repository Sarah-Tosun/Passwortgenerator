using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passwortgenerator.source.password
{
    interface Password
    {
        string GeneratePassword(Setting setting);
    }
}
