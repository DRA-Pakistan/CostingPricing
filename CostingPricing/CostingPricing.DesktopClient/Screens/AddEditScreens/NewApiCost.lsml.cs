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

namespace LightSwitchApplication
{
    public partial class NewApiCost
    {
        partial void NewApiCost_InitializeDataWorkspace(global::System.Collections.Generic.List<global::Microsoft.LightSwitch.IDataService> saveChangesTo)
        {
            // Write your code here.
            this.cp_lm_api_costProperty = new cp_lm_api_cost();
        }

        partial void NewApiCost_Saved()
        {
            // Write your code here.
            this.Close(false);
            Application.Current.ShowDefaultScreen(this.cp_lm_api_costProperty);
        }
        partial void currencySelect_Changed()
        {
            this.cp_lm_api_costProperty.import_price_currency = currencySelect;
            if (currencySelect.currency_code == "PKR")
            {
                this.FindControl("pkr_conversion_rate").IsEnabled = false;
            }
            else 
            {
                this.FindControl("pkr_conversion_rate").IsEnabled = true;
            }
        }


    }
}