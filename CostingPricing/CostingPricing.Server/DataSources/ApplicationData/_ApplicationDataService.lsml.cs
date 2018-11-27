using Microsoft.LightSwitch.Security.Server;
using Microsoft.LightSwitch;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;

namespace LightSwitchApplication
{
    public partial class ApplicationDataService
    {
        partial void cp_lm_excipient_costs_Inserting(cp_lm_excipient_cost entity)
        {
            entity.saveCalulatedFieldsToDB();
        }
    }
}