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
        //
        #region API/Excipients Costs
        partial void cp_lm_excipient_costs_Inserting(cp_lm_excipient_cost entity)
        {
            entity.saveCalulatedFieldsToDB();                                       // Save Calculated Values to DB
        }

        partial void cp_lm_excipient_costs_Updating(cp_lm_excipient_cost entity)
        {
            entity.saveCalulatedFieldsToDB();                                       // Save Calculated Values to DB
            AuditHelper.CreateAuditTrailForUpdate(entity, this); 
        }

        partial void cp_lm_excipient_costs_Deleting(cp_lm_excipient_cost entity)
        {
            AuditHelper.CreateAuditTrailForDelete(entity, this);
        }

        partial void cp_lm_api_costs_Inserting(cp_lm_api_cost entity)
        {
            entity.saveCalulatedFieldsToDB();                                       // Save Calculated Values to DB
        }

        partial void cp_lm_api_costs_Updating(cp_lm_api_cost entity)
        {
            entity.saveCalulatedFieldsToDB();                                       // Save Calculated Values to DB
            AuditHelper.CreateAuditTrailForUpdate(entity, this);
        }
        partial void cp_lm_api_costs_Deleting(cp_lm_api_cost entity)
        {
            AuditHelper.CreateAuditTrailForDelete(entity, this);
        }

        #endregion
        
        #region DB Audit Trail Functions (ForRest)

        partial void cp_lu_countries_Updating(cp_lu_country entity)
        {
            AuditHelper.CreateAuditTrailForUpdate(entity, this);
        }
        partial void cp_lm_applications_Updating(cp_lm_application entity)
        {
            AuditHelper.CreateAuditTrailForUpdate(entity, this);
        }
        partial void cp_lm_pm_eye_ear_nasal_drops_Updating(cp_lm_pm_eye_ear_nasal_drop entity)
        {
            AuditHelper.CreateAuditTrailForUpdate(entity, this);
        }
        partial void cp_lu_suppliers_Updating(cp_lu_supplier entity)
        {
            AuditHelper.CreateAuditTrailForUpdate(entity, this);
        }
        partial void cp_lm_pm_patches_Updating(cp_lm_pm_patch entity)
        {
            AuditHelper.CreateAuditTrailForUpdate(entity, this);
        }
        partial void cp_lm_pm_sachets_Updating(cp_lm_pm_sachet entity)
        {
            AuditHelper.CreateAuditTrailForUpdate(entity, this);
        }
        partial void cp_lu_drugs_Updating(cp_lu_drug entity)
        {
            AuditHelper.CreateAuditTrailForUpdate(entity, this);
        }
        partial void cp_lm_pm_spray_inhalers_Updating(cp_lm_pm_spray_inhaler entity)
        {
            AuditHelper.CreateAuditTrailForUpdate(entity, this);
        }
        partial void cp_lu_applicants_Updating(cp_lu_applicant entity)
        {
            AuditHelper.CreateAuditTrailForUpdate(entity, this);
        }
        partial void cp_lm_pm_capsule_blister_packs_hgs_Updating(cp_lm_pm_capsule_blister_packs_hg entity)
        {
            AuditHelper.CreateAuditTrailForUpdate(entity, this);
        }
        partial void cp_lu_source_manufacturers_Updating(cp_lu_source_manufacturer entity)
        {
            AuditHelper.CreateAuditTrailForUpdate(entity, this);
        }
        partial void cp_lm_pm_capsule_blister_packs_sgs_Updating(cp_lm_pm_capsule_blister_packs_sg entity)
        {
            AuditHelper.CreateAuditTrailForUpdate(entity, this);
        }
        partial void cp_lm_pm_capsule_bottle_pack_hgs_Updating(cp_lm_pm_capsule_bottle_pack_hg entity)
        {
            AuditHelper.CreateAuditTrailForUpdate(entity, this);
        }
        partial void cp_lm_pm_capsule_bottle_pack_sgs_Updating(cp_lm_pm_capsule_bottle_pack_sg entity)
        {
            AuditHelper.CreateAuditTrailForUpdate(entity, this);
        }
        partial void cp_lu_currencies_Updating(cp_lu_currency entity)
        {
            AuditHelper.CreateAuditTrailForUpdate(entity, this);
        }
        partial void cp_lm_pm_syrups_Updating(cp_lm_pm_syrup entity)
        {
            AuditHelper.CreateAuditTrailForUpdate(entity, this);
        }
        partial void cp_lm_pm_tablets_blister_packs_Updating(cp_lm_pm_tablets_blister_pack entity)
        {
            AuditHelper.CreateAuditTrailForUpdate(entity, this);
        }
        partial void cp_lm_pm_tablets_bottle_packs_Updating(cp_lm_pm_tablets_bottle_pack entity)
        {
            AuditHelper.CreateAuditTrailForUpdate(entity, this);
        }
        partial void cp_lu_apis_Updating(cp_lu_api entity)
        {
            AuditHelper.CreateAuditTrailForUpdate(entity, this);
        }
        partial void cp_lu_excipients_Updating(cp_lu_excipient entity)
        {
            AuditHelper.CreateAuditTrailForUpdate(entity, this);
        }
        partial void cp_lm_pm_infusions_Updating(cp_lm_pm_infusion entity)
        {
            AuditHelper.CreateAuditTrailForUpdate(entity, this);
        }
        partial void cp_lm_pm_injections_Updating(cp_lm_pm_injection entity)
        {
            AuditHelper.CreateAuditTrailForUpdate(entity, this);
        }
        partial void cp_lm_pm_ointment_gel_creams_Updating(cp_lm_pm_ointment_gel_cream entity)
        {
            AuditHelper.CreateAuditTrailForUpdate(entity, this);
        }

        partial void cp_lu_countries_Deleting(cp_lu_country entity)
        {
            AuditHelper.CreateAuditTrailForDelete(entity, this);
        }
        partial void cp_lm_applications_Deleting(cp_lm_application entity)
        {
            AuditHelper.CreateAuditTrailForDelete(entity, this);
        }
        partial void cp_lm_pm_eye_ear_nasal_drops_Deleting(cp_lm_pm_eye_ear_nasal_drop entity)
        {
            AuditHelper.CreateAuditTrailForDelete(entity, this);
        }
        partial void cp_lu_suppliers_Deleting(cp_lu_supplier entity)
        {
            AuditHelper.CreateAuditTrailForDelete(entity, this);
        }
        partial void cp_lm_pm_patches_Deleting(cp_lm_pm_patch entity)
        {
            AuditHelper.CreateAuditTrailForDelete(entity, this);
        }
        partial void cp_lm_pm_sachets_Deleting(cp_lm_pm_sachet entity)
        {
            AuditHelper.CreateAuditTrailForDelete(entity, this);
        }
        partial void cp_lu_drugs_Deleting(cp_lu_drug entity)
        {
            AuditHelper.CreateAuditTrailForDelete(entity, this);
        }
        partial void cp_lm_pm_spray_inhalers_Deleting(cp_lm_pm_spray_inhaler entity)
        {
            AuditHelper.CreateAuditTrailForDelete(entity, this);
        }
        partial void cp_lu_applicants_Deleting(cp_lu_applicant entity)
        {
            AuditHelper.CreateAuditTrailForDelete(entity, this);
        }
        partial void cp_lm_pm_capsule_blister_packs_hgs_Deleting(cp_lm_pm_capsule_blister_packs_hg entity)
        {
            AuditHelper.CreateAuditTrailForDelete(entity, this);
        }
        partial void cp_lu_source_manufacturers_Deleting(cp_lu_source_manufacturer entity)
        {
            AuditHelper.CreateAuditTrailForDelete(entity, this);
        }
        partial void cp_lm_pm_capsule_blister_packs_sgs_Deleting(cp_lm_pm_capsule_blister_packs_sg entity)
        {
            AuditHelper.CreateAuditTrailForDelete(entity, this);
        }
        partial void cp_lm_pm_capsule_bottle_pack_hgs_Deleting(cp_lm_pm_capsule_bottle_pack_hg entity)
        {
            AuditHelper.CreateAuditTrailForDelete(entity, this);
        }
        partial void cp_lm_pm_capsule_bottle_pack_sgs_Deleting(cp_lm_pm_capsule_bottle_pack_sg entity)
        {
            AuditHelper.CreateAuditTrailForDelete(entity, this);
        }
        partial void cp_lu_currencies_Deleting(cp_lu_currency entity)
        {
            AuditHelper.CreateAuditTrailForDelete(entity, this);
        }
        partial void cp_lm_pm_syrups_Deleting(cp_lm_pm_syrup entity)
        {
            AuditHelper.CreateAuditTrailForDelete(entity, this);
        }
        partial void cp_lm_pm_tablets_blister_packs_Deleting(cp_lm_pm_tablets_blister_pack entity)
        {
            AuditHelper.CreateAuditTrailForDelete(entity, this);
        }
        partial void cp_lm_pm_tablets_bottle_packs_Deleting(cp_lm_pm_tablets_bottle_pack entity)
        {
            AuditHelper.CreateAuditTrailForDelete(entity, this);
        }
        partial void cp_lu_apis_Deleting(cp_lu_api entity)
        {
            AuditHelper.CreateAuditTrailForDelete(entity, this);
        }
        partial void cp_lu_excipients_Deleting(cp_lu_excipient entity)
        {
            AuditHelper.CreateAuditTrailForDelete(entity, this);
        }
        partial void cp_lm_pm_infusions_Deleting(cp_lm_pm_infusion entity)
        {
            AuditHelper.CreateAuditTrailForDelete(entity, this);
        }
        partial void cp_lm_pm_injections_Deleting(cp_lm_pm_injection entity)
        {
            AuditHelper.CreateAuditTrailForDelete(entity, this);
        }
        partial void cp_lm_pm_ointment_gel_creams_Deleting(cp_lm_pm_ointment_gel_cream entity)
        {
            AuditHelper.CreateAuditTrailForDelete(entity, this);
        }







        #endregion

        #region Access Controls
        partial void cp_lm_api_costs_CanDelete(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.DeleteApplication);
        }
        partial void cp_lm_api_costs_CanInsert(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.AddApplication);
        }
        partial void cp_lm_api_costs_CanUpdate(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.EditApplication);
        }
        partial void cp_lm_applications_CanDelete(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.DeleteApplication);
        }
        partial void cp_lm_applications_CanInsert(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.AddApplication);
        }
        partial void cp_lm_applications_CanUpdate(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.EditApplication);
        }
        partial void cp_lm_excipient_costs_CanDelete(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.DeleteApplication);
        }
        partial void cp_lm_excipient_costs_CanInsert(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.AddApplication);
        }
        partial void cp_lm_excipient_costs_CanUpdate(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.EditApplication);
        }
        partial void cp_lm_pm_capsule_blister_packs_hgs_CanDelete(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.DeleteApplication);
        }
        partial void cp_lm_pm_capsule_blister_packs_hgs_CanInsert(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.AddApplication);
        }
        partial void cp_lm_pm_capsule_blister_packs_hgs_CanUpdate(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.EditApplication);
        }
        partial void cp_lm_pm_capsule_blister_packs_sgs_CanDelete(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.DeleteApplication);
        }
        partial void cp_lm_pm_capsule_blister_packs_sgs_CanInsert(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.AddApplication);
        }
        partial void cp_lm_pm_capsule_blister_packs_sgs_CanUpdate(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.EditApplication);
        }
        partial void cp_lm_pm_capsule_bottle_pack_hgs_CanDelete(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.DeleteApplication);
        }
        partial void cp_lm_pm_capsule_bottle_pack_hgs_CanInsert(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.AddApplication);
        }
        partial void cp_lm_pm_capsule_bottle_pack_hgs_CanUpdate(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.EditApplication);
        }
        partial void cp_lm_pm_capsule_bottle_pack_sgs_CanDelete(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.DeleteApplication);
        }
        partial void cp_lm_pm_capsule_bottle_pack_sgs_CanInsert(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.AddApplication);
        }
        partial void cp_lm_pm_capsule_bottle_pack_sgs_CanUpdate(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.EditApplication);
        }
        partial void cp_lm_pm_eye_ear_nasal_drops_CanDelete(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.DeleteApplication);
        }
        partial void cp_lm_pm_eye_ear_nasal_drops_CanInsert(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.AddApplication);
        }
        partial void cp_lm_pm_eye_ear_nasal_drops_CanUpdate(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.EditApplication);
        }
        partial void cp_lm_pm_infusions_CanDelete(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.DeleteApplication);
        }
        partial void cp_lm_pm_infusions_CanInsert(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.AddApplication);
        }
        partial void cp_lm_pm_infusions_CanUpdate(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.EditApplication);
        }
        partial void cp_lm_pm_injections_CanDelete(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.DeleteApplication);
        }
        partial void cp_lm_pm_injections_CanInsert(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.AddApplication);
        }
        partial void cp_lm_pm_injections_CanUpdate(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.EditApplication);
        }
        partial void cp_lm_pm_ointment_gel_creams_CanDelete(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.DeleteApplication);
        }
        partial void cp_lm_pm_ointment_gel_creams_CanInsert(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.AddApplication);
        }
        partial void cp_lm_pm_ointment_gel_creams_CanUpdate(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.EditApplication);
        }
        partial void cp_lm_pm_patches_CanDelete(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.DeleteApplication);
        }
        partial void cp_lm_pm_patches_CanInsert(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.AddApplication);
        }
        partial void cp_lm_pm_patches_CanUpdate(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.EditApplication);
        }
        partial void cp_lm_pm_sachets_CanDelete(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.DeleteApplication);
        }
        partial void cp_lm_pm_sachets_CanInsert(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.AddApplication);
        }
        partial void cp_lm_pm_sachets_CanUpdate(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.EditApplication);
        }
        partial void cp_lm_pm_spray_inhalers_CanDelete(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.DeleteApplication);
        }
        partial void cp_lm_pm_spray_inhalers_CanInsert(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.AddApplication);
        }
        partial void cp_lm_pm_spray_inhalers_CanUpdate(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.EditApplication);
        }
        partial void cp_lm_pm_syrups_CanDelete(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.DeleteApplication);
        }
        partial void cp_lm_pm_syrups_CanInsert(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.AddApplication);
        }
        partial void cp_lm_pm_syrups_CanUpdate(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.EditApplication);
        }
        partial void cp_lm_pm_tablets_blister_packs_CanDelete(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.DeleteApplication);
        }
        partial void cp_lm_pm_tablets_blister_packs_CanInsert(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.AddApplication);
        }
        partial void cp_lm_pm_tablets_blister_packs_CanUpdate(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.EditApplication);
        }
        partial void cp_lm_pm_tablets_bottle_packs_CanDelete(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.DeleteApplication);
        }
        partial void cp_lm_pm_tablets_bottle_packs_CanInsert(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.AddApplication);
        }
        partial void cp_lm_pm_tablets_bottle_packs_CanUpdate(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.EditApplication);
        }
        partial void cp_lu_apis_CanDelete(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.DeleteCommon);
        }
        partial void cp_lu_apis_CanInsert(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.AddCommon);
        }
        partial void cp_lu_apis_CanUpdate(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.EditCommon);
        }
        partial void cp_lu_applicants_CanDelete(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.DeleteCommon);
        }
        partial void cp_lu_applicants_CanInsert(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.AddCommon);
        }
        partial void cp_lu_applicants_CanUpdate(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.EditCommon);
        }
        partial void cp_lu_countries_CanDelete(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.DeleteCommon);
        }
        partial void cp_lu_countries_CanInsert(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.AddCommon);
        }
        partial void cp_lu_countries_CanUpdate(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.EditCommon);
        }
        partial void cp_lu_currencies_CanDelete(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.DeleteCommon);
        }
        partial void cp_lu_currencies_CanInsert(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.AddCommon);
        }
        partial void cp_lu_currencies_CanUpdate(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.EditCommon);
        }
        partial void cp_lu_drugs_CanDelete(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.DeleteCommon);
        }
        partial void cp_lu_drugs_CanInsert(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.AddCommon);
        }
        partial void cp_lu_drugs_CanUpdate(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.EditCommon);
        }
        partial void cp_lu_excipients_CanDelete(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.DeleteCommon);
        }
        partial void cp_lu_excipients_CanInsert(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.AddCommon);
        }
        partial void cp_lu_excipients_CanUpdate(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.EditCommon);
        }
        partial void cp_lu_source_manufacturers_CanDelete(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.DeleteCommon);
        }
        partial void cp_lu_source_manufacturers_CanInsert(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.AddCommon);
        }
        partial void cp_lu_source_manufacturers_CanUpdate(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.EditCommon);
        }
        partial void cp_lu_suppliers_CanDelete(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.DeleteCommon);
        }
        partial void cp_lu_suppliers_CanInsert(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.AddCommon);
        }
        partial void cp_lu_suppliers_CanUpdate(ref bool result)
        {
            result = this.Application.User.HasPermission(Permissions.AccessLM) && this.Application.User.HasPermission(Permissions.EditCommon);
        }
        
        partial void AuditTrails_CanUpdate(ref bool result)
        {
            result = false;
        }

        partial void AuditTrails_CanDelete(ref bool result)
        {
            result = false;
        }
        #endregion
    }
}