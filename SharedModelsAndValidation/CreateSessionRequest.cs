using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedModelsAndValidation
{
    public class CreateSessionRequest
    {
        required public string Password { get; set; }

        required public string Email { get; set; }

    }
}
