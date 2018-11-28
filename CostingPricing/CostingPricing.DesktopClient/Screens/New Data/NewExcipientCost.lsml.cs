using Microsoft.LightSwitch.Presentation.Extensions;
using Microsoft.LightSwitch.Presentation;
using Microsoft.LightSwitch.Framework.Client;
using Microsoft.LightSwitch;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.IO;
using System.Linq;
using System;
using System.Windows.Controls;
using System.Windows;

namespace LightSwitchApplication
{
    public partial class NewExcipientCost
    {
        partial void NewExcipientCost_InitializeDataWorkspace(global::System.Collections.Generic.List<global::Microsoft.LightSwitch.IDataService> saveChangesTo)
        {
            // Write your code here.
            this.cp_lm_excipient_costProperty = new cp_lm_excipient_cost();
        }

        partial void NewExcipientCost_Saved()
        {
            // Write your code here.
            this.Close(false);
            Application.Current.ShowDefaultScreen(this.cp_lm_excipient_costProperty);
        }
        partial void currencySelect_Changed()
        {
            this.cp_lm_excipient_costProperty.import_price_currency = currencySelect;
            if (this.currencySelect.currency_code == "PKR")
            {
                this.FindControl("pkr_conversion_rate").IsEnabled = false;
            }
            else
                this.FindControl("pkr_conversion_rate").IsEnabled = true;
        }
    }
}