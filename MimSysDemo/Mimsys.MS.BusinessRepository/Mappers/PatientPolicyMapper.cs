// Copyright (c) 2024 Mimsys  All rights reserved.

#region Namespace

using System;
using Sage.CA.SBS.ERP.Sage300.Common.Models;
using Sage.CA.SBS.ERP.Sage300.Common.BusinessRepository;
using Sage.CA.SBS.ERP.Sage300.Common.Interfaces.Entity;
using Mimsys.MS.Models;
using Mimsys.MS.Models.Enums; // For common enumerations

#endregion

namespace Mimsys.MS.BusinessRepository.Mappers
{
    /// <summary>
    /// Class for PatientPolicy mapping
    /// </summary>
    /// <typeparam name="T">PatientPolicy</typeparam>
    public class PatientPolicyMapper<T> : ModelMapper<T> where T : PatientPolicy, new ()
    {
        #region Constructor

        /// <summary>
        /// Constructor to set the Context
        /// </summary>
        /// <param name="context">Context</param>
        public PatientPolicyMapper(Context context)
            : base(context)
        {
        }

        #endregion

        #region ModelMapper methods

        /// <summary>
        /// Map entity to model
        /// </summary>
        /// <param name="entity">Business Entity</param>
        /// <returns>Mapped Model</returns>
        public override T Map(IBusinessEntity entity)
        {
            var model = base.Map(entity);

            model.PatientCode = entity.GetValue<string>(PatientPolicy.Index.PatientCode);
            model.MedicalAidCompany = entity.GetValue<string>(PatientPolicy.Index.MedicalAidCompany);
            model.PlanCode = entity.GetValue<string>(PatientPolicy.Index.PlanCode);
            model.PolicyNumber = entity.GetValue<string>(PatientPolicy.Index.PolicyNumber);
            model.StartDate = entity.GetValue<DateTime>(PatientPolicy.Index.StartDate);
            model.ExpiryDate = entity.GetValue<DateTime>(PatientPolicy.Index.ExpiryDate);
            model.DeductibleBalance = entity.GetValue<decimal>(PatientPolicy.Index.DeductibleBalance);
            model.CoPaymentAmount = entity.GetValue<decimal>(PatientPolicy.Index.CoPaymentAmount);
			model.CurrentPrimaryInsurance = (Mimsys.MS.Models.Enums.CurrentPrimaryInsurance)(entity.GetValue<int>(PatientPolicy.Index.CurrentPrimaryInsurance));
            model.AnnualDeductible = entity.GetValue<decimal>(PatientPolicy.Index.AnnualDeductible);
			model.PrincipleType = (Mimsys.MS.Models.Enums.PrincipleType)(entity.GetValue<int>(PatientPolicy.Index.PrincipleType));
            model.InsuranceReferral = entity.GetValue<string>(PatientPolicy.Index.InsuranceReferral);
            model.CreatedBy = entity.GetValue<string>(PatientPolicy.Index.CreatedBy);
            model.CreatedDate = entity.GetValue<DateTime>(PatientPolicy.Index.CreatedDate);
            model.ModifiedBy = entity.GetValue<string>(PatientPolicy.Index.ModifiedBy);
            model.ModifiedDate = entity.GetValue<DateTime>(PatientPolicy.Index.ModifiedDate);
			model.CustomerType = (Mimsys.MS.Models.Enums.CustomerType)(entity.GetValue<int>(PatientPolicy.Index.CustomerType));
			model.SponsoredBy = (Mimsys.MS.Models.Enums.SponsoredBy)(entity.GetValue<int>(PatientPolicy.Index.SponsoredBy));
            model.SponsorCode = entity.GetValue<string>(PatientPolicy.Index.SponsorCode);
            model.PlanType = entity.GetValue<string>(PatientPolicy.Index.PlanType);
            model.InsuranceIDPath = entity.GetValue<string>(PatientPolicy.Index.InsuranceIDPath);
            model.PrincipalEmployeeNumber = entity.GetValue<string>(PatientPolicy.Index.PrincipalEmployeeNumber);
            model.EmployeeID = entity.GetValue<string>(PatientPolicy.Index.EmployeeID);
            model.EmployeeMRNNumber = entity.GetValue<string>(PatientPolicy.Index.EmployeeMRNNumber);
			model.InsApplicationRequired = (Mimsys.MS.Models.Enums.InsApplicationRequired)(entity.GetValue<int>(PatientPolicy.Index.InsApplicationRequired));
            model.InsApplicationNumber = entity.GetValue<string>(PatientPolicy.Index.InsApplicationNumber);
            model.EmployerName = entity.GetValue<string>(PatientPolicy.Index.EmployerName);
            model.OldExpiryDate = entity.GetValue<DateTime>(PatientPolicy.Index.OldExpiryDate);
            model.BasicSalary = entity.GetValue<decimal>(PatientPolicy.Index.BasicSalary);
			model.NetworkYN = (Mimsys.MS.Models.Enums.NetworkYN)(entity.GetValue<int>(PatientPolicy.Index.NetworkYN));
            model.Network = entity.GetValue<string>(PatientPolicy.Index.Network);
			model.SecondaryPlanApplicable = (Mimsys.MS.Models.Enums.SecondaryPlanApplicable)(entity.GetValue<int>(PatientPolicy.Index.SecondaryPlanApplicable));
            model.SecInsuranceCompany = entity.GetValue<string>(PatientPolicy.Index.SecInsuranceCompany);
            model.SecPolicyGroupCode = entity.GetValue<string>(PatientPolicy.Index.SecPolicyGroupCode);
            model.SecInsurancePolicy = entity.GetValue<string>(PatientPolicy.Index.SecInsurancePolicy);
            model.SecPolicyNumber = entity.GetValue<string>(PatientPolicy.Index.SecPolicyNumber);
			model.SecCustomerType = (Mimsys.MS.Models.Enums.SecCustomerType)(entity.GetValue<int>(PatientPolicy.Index.SecCustomerType));
            model.SecStartDate = entity.GetValue<DateTime>(PatientPolicy.Index.SecStartDate);
            model.SecExpiryDate = entity.GetValue<DateTime>(PatientPolicy.Index.SecExpiryDate);
            model.PrimaryInsuranceCardNumber = entity.GetValue<string>(PatientPolicy.Index.PrimaryInsuranceCardNumber);
            model.DependentNumber = entity.GetValue<string>(PatientPolicy.Index.DependentNumber);
            model.SecPlanCardNumber = entity.GetValue<string>(PatientPolicy.Index.SecPlanCardNumber);
            model.SecPlanDependentNumber = entity.GetValue<string>(PatientPolicy.Index.SecPlanDependentNumber);
			model.SecondarySponsoredBy = (Mimsys.MS.Models.Enums.SecondarySponsoredBy)(entity.GetValue<int>(PatientPolicy.Index.SecondarySponsoredBy));
            model.SecondarySponsorCode = entity.GetValue<string>(PatientPolicy.Index.SecondarySponsorCode);
            model.SecondarySponsorName = entity.GetValue<string>(PatientPolicy.Index.SecondarySponsorName);
            model.FundBrandID = entity.GetValue<string>(PatientPolicy.Index.FundBrandID);
            model.UniversalPatientIdentifierUPI = entity.GetValue<string>(PatientPolicy.Index.UniversalPatientIdentifierUPI);
			model.VideoConsultationEligiblity = (Mimsys.MS.Models.Enums.VideoConsultationEligiblity)(entity.GetValue<int>(PatientPolicy.Index.VideoConsultationEligiblity));
            model.CompanyName = entity.GetValue<string>(PatientPolicy.Index.CompanyName);
            model.PolicyName = entity.GetValue<string>(PatientPolicy.Index.PolicyName);
            model.PolicyDescription = entity.GetValue<string>(PatientPolicy.Index.PolicyDescription);
			model.Command = (Mimsys.MS.Models.Enums.Command)(entity.GetValue<int>(PatientPolicy.Index.Command));
            model.VISITID = entity.GetValue<string>(PatientPolicy.Index.VISITID);
            model.PRPOLEXPDT = entity.GetValue<DateTime>(PatientPolicy.Index.PRPOLEXPDT);
            model.SEPOLEXPDT = entity.GetValue<DateTime>(PatientPolicy.Index.SEPOLEXPDT);
            return model;
        }

        /// <summary>
        /// Map model to entity
        /// </summary>
        /// <param name="model">Model</param>
        /// <param name="entity">Business Entity</param>
        public override void Map(T model, IBusinessEntity entity)
        {
            if (model == null)
            {
                return;
            }
            entity.SetValue(PatientPolicy.Index.PatientCode, model.PatientCode);
            entity.SetValue(PatientPolicy.Index.MedicalAidCompany, model.MedicalAidCompany);
            entity.SetValue(PatientPolicy.Index.PlanCode, model.PlanCode);
            entity.SetValue(PatientPolicy.Index.PolicyNumber, model.PolicyNumber);
            entity.SetValue(PatientPolicy.Index.StartDate, model.StartDate);
            entity.SetValue(PatientPolicy.Index.ExpiryDate, model.ExpiryDate);
            entity.SetValue(PatientPolicy.Index.DeductibleBalance, model.DeductibleBalance);
            entity.SetValue(PatientPolicy.Index.CoPaymentAmount, model.CoPaymentAmount);
            entity.SetValue(PatientPolicy.Index.CurrentPrimaryInsurance, model.CurrentPrimaryInsurance);
            entity.SetValue(PatientPolicy.Index.AnnualDeductible, model.AnnualDeductible);
            entity.SetValue(PatientPolicy.Index.PrincipleType, model.PrincipleType);
            entity.SetValue(PatientPolicy.Index.InsuranceReferral, model.InsuranceReferral);
            entity.SetValue(PatientPolicy.Index.CreatedBy, model.CreatedBy);
            entity.SetValue(PatientPolicy.Index.CreatedDate, model.CreatedDate);
            entity.SetValue(PatientPolicy.Index.ModifiedBy, model.ModifiedBy);
            entity.SetValue(PatientPolicy.Index.ModifiedDate, model.ModifiedDate);
            entity.SetValue(PatientPolicy.Index.CustomerType, model.CustomerType);
            entity.SetValue(PatientPolicy.Index.SponsoredBy, model.SponsoredBy);
            entity.SetValue(PatientPolicy.Index.SponsorCode, model.SponsorCode);
            entity.SetValue(PatientPolicy.Index.PlanType, model.PlanType);
            entity.SetValue(PatientPolicy.Index.InsuranceIDPath, model.InsuranceIDPath);
            entity.SetValue(PatientPolicy.Index.PrincipalEmployeeNumber, model.PrincipalEmployeeNumber);
            entity.SetValue(PatientPolicy.Index.EmployeeID, model.EmployeeID);
            entity.SetValue(PatientPolicy.Index.EmployeeMRNNumber, model.EmployeeMRNNumber);
            entity.SetValue(PatientPolicy.Index.InsApplicationRequired, model.InsApplicationRequired);
            entity.SetValue(PatientPolicy.Index.InsApplicationNumber, model.InsApplicationNumber);
            // entity.SetValue(PatientPolicy.Index.EmployerName, model.EmployerName);
            entity.SetValue(PatientPolicy.Index.OldExpiryDate, model.OldExpiryDate);
            entity.SetValue(PatientPolicy.Index.BasicSalary, model.BasicSalary);
            entity.SetValue(PatientPolicy.Index.NetworkYN, model.NetworkYN);
            entity.SetValue(PatientPolicy.Index.Network, model.Network);
            entity.SetValue(PatientPolicy.Index.SecondaryPlanApplicable, model.SecondaryPlanApplicable);
            entity.SetValue(PatientPolicy.Index.SecInsuranceCompany, model.SecInsuranceCompany);
            entity.SetValue(PatientPolicy.Index.SecPolicyGroupCode, model.SecPolicyGroupCode);
            entity.SetValue(PatientPolicy.Index.SecInsurancePolicy, model.SecInsurancePolicy);
            entity.SetValue(PatientPolicy.Index.SecPolicyNumber, model.SecPolicyNumber);
            entity.SetValue(PatientPolicy.Index.SecCustomerType, model.SecCustomerType);
            entity.SetValue(PatientPolicy.Index.SecStartDate, model.SecStartDate);
            entity.SetValue(PatientPolicy.Index.SecExpiryDate, model.SecExpiryDate);
            entity.SetValue(PatientPolicy.Index.PrimaryInsuranceCardNumber, model.PrimaryInsuranceCardNumber);
            entity.SetValue(PatientPolicy.Index.DependentNumber, model.DependentNumber);
            entity.SetValue(PatientPolicy.Index.SecPlanCardNumber, model.SecPlanCardNumber);
            entity.SetValue(PatientPolicy.Index.SecPlanDependentNumber, model.SecPlanDependentNumber);
            entity.SetValue(PatientPolicy.Index.SecondarySponsoredBy, model.SecondarySponsoredBy);
            entity.SetValue(PatientPolicy.Index.SecondarySponsorCode, model.SecondarySponsorCode);
            // entity.SetValue(PatientPolicy.Index.SecondarySponsorName, model.SecondarySponsorName);
            entity.SetValue(PatientPolicy.Index.FundBrandID, model.FundBrandID);
            entity.SetValue(PatientPolicy.Index.UniversalPatientIdentifierUPI, model.UniversalPatientIdentifierUPI);
            entity.SetValue(PatientPolicy.Index.VideoConsultationEligiblity, model.VideoConsultationEligiblity);
            entity.SetValue(PatientPolicy.Index.CompanyName, model.CompanyName);
            entity.SetValue(PatientPolicy.Index.PolicyName, model.PolicyName);
            entity.SetValue(PatientPolicy.Index.PolicyDescription, model.PolicyDescription);
            // entity.SetValue(PatientPolicy.Index.Command, model.Command);
            entity.SetValue(PatientPolicy.Index.VISITID, model.VISITID);
            entity.SetValue(PatientPolicy.Index.PRPOLEXPDT, model.PRPOLEXPDT);
            entity.SetValue(PatientPolicy.Index.SEPOLEXPDT, model.SEPOLEXPDT);
        }

        /// <summary>
        /// Map Key
        /// </summary>
        /// <param name="model">Model</param>
        /// <param name="entity">Business Entity</param>
        public override void MapKey(T model, IBusinessEntity entity)
        {
            entity.SetValue(PatientPolicy.Index.PatientCode, model.PatientCode);
        }

        #endregion
    }
}