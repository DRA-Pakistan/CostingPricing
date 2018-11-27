using Microsoft.LightSwitch;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;

namespace LightSwitchApplication
{
    public partial class cp_lm_excipient_cost
    {
        partial void total_import_price_comp_auto_Compute(ref decimal result)
        {
            if (import_price_per_unit > 0 && imported_quantity > 0)
                result = this.import_price_per_unit * imported_quantity;
            else result = 0;
            //total_import_price_comp_db = result;
        }

        partial void total_import_levies_pkr_comp_auto_Compute(ref decimal result)
        {
            result = custom_duty_amount_pkr + income_tax_amount_pkr + other_import_charges_pkr;
            //total_import_levies_pkr_comp_db = result;
        }

        partial void landed_cost_pkr_comp_auto_Compute(ref decimal result)
        {
            if (total_import_price_comp_auto > 0 && pkConversionRate() > 0)
                result = (total_import_price_comp_auto * pkConversionRate()) + total_import_levies_pkr_comp_auto;

        }

        decimal pkConversionRate()
        {
            if (import_price_currency == "PKR")
                return 1;
            else return pkr_conversion_rate;
        }

        partial void landed_cost_per_unit_pkr_comp_auto_Compute(ref decimal result)
        {
            if (landed_cost_pkr_comp_auto > 0 && imported_quantity > 0)
                result = landed_cost_pkr_comp_auto / imported_quantity;
            else result = 0;

        }

        public void saveCalulatedFieldsToDB()
        {
            total_import_price_comp_db = total_import_price_comp_auto;
            total_import_levies_pkr_comp_db = total_import_levies_pkr_comp_auto;
            landed_cost_pkr_comp_db = landed_cost_pkr_comp_auto;
            landed_cost_per_unit_pkr_comp_db = landed_cost_per_unit_pkr_comp_auto;
            custom_duty_amount_pkr = custom_duty_amount_pkr_comp;
            income_tax_amount_pkr = income_tax_amount_pkr_comp;
            total_import_price_pkr = total_import_price_pkr_comp;
        }

        partial void custom_duty_amount_pkr_comp_Compute(ref decimal result)
        {
            if (custom_duty_rate_pkr > 0 && imported_quantity > 0)
                result = custom_duty_rate_pkr * imported_quantity;
            else result = 0;

        }

        partial void income_tax_amount_pkr_comp_Compute(ref decimal result)
        {
            if (income_tax_rate_pkr > 0 && imported_quantity > 0)
                result = income_tax_rate_pkr * imported_quantity;
            else result = 0;

        }

        partial void total_import_price_pkr_comp_Compute(ref decimal result)
        {
            result = total_import_price_comp_auto * pkConversionRate();

        }
    }
}