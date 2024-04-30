// Copyright (c) 2024 Mimsys  All rights reserved.

#region Namespace

using System;
using Sage.CA.SBS.ERP.Sage300.Common.Models;
using Sage.CA.SBS.ERP.Sage300.Common.BusinessRepository;
using Sage.CA.SBS.ERP.Sage300.Common.Interfaces.Entity;
using Mimsys.MS.Models;
using Mimsys.MS.Models.Enums; // For common enumerations
using Sage.CA.SBS.ERP.Sage300.Common.Utilities;

#endregion

namespace Mimsys.MS.BusinessRepository.Mappers
{
    /// <summary>
    /// Class for MRDVisit mapping
    /// </summary>
    /// <typeparam name="T">MRDVisit</typeparam>
    public class MRDVisitMapper<T> : ModelMapper<T> where T : MRDVisit, new ()
    {
        #region Constructor

        /// <summary>
        /// Constructor to set the Context
        /// </summary>
        /// <param name="context">Context</param>
        public MRDVisitMapper(Context context)
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

            model.VisitCode = entity.GetValue<string>(MRDVisit.Index.VisitCode);
            model.VisitDate = entity.GetValue<DateTime>(MRDVisit.Index.VisitDate);
            model.VisitTime = entity.GetValue<DateTime>(MRDVisit.Index.VisitTime).TimeOfDay;
            model.ProviderCode = entity.GetValue<string>(MRDVisit.Index.ProviderCode);
            model.DepartmentCode = entity.GetValue<string>(MRDVisit.Index.DepartmentCode);
            model.DepartmentName = entity.GetValue<string>(MRDVisit.Index.DepartmentName);
            model.PatientCode = entity.GetValue<string>(MRDVisit.Index.PatientCode);
            model.PatientName = entity.GetValue<string>(MRDVisit.Index.PatientName);
            model.ProviderName = entity.GetValue<string>(MRDVisit.Index.ProviderName);
			model.CaseType = (Mimsys.MS.Models.Enums.CaseType)(entity.GetValue<int>(MRDVisit.Index.CaseType));
			model.VisitStatus = (Mimsys.MS.Models.Enums.VisitStatus)(entity.GetValue<int>(MRDVisit.Index.VisitStatus));
			model.Inactive = (Mimsys.MS.Models.Enums.Inactive)(entity.GetValue<int>(MRDVisit.Index.Inactive));
			model.IsConsultation = (Mimsys.MS.Models.Enums.IsConsultation)(entity.GetValue<int>(MRDVisit.Index.IsConsultation));
            model.CreatedBy = entity.GetValue<string>(MRDVisit.Index.CreatedBy);
            model.CreatedDate = entity.GetValue<DateTime>(MRDVisit.Index.CreatedDate);
            model.ModifyBy = entity.GetValue<string>(MRDVisit.Index.ModifyBy);
            model.ModifyDate = entity.GetValue<DateTime>(MRDVisit.Index.ModifyDate);
            model.LastMaintained = entity.GetValue<DateTime>(MRDVisit.Index.LastMaintained);
            model.BillingCode = entity.GetValue<string>(MRDVisit.Index.BillingCode);
			model.VisitType = (Mimsys.MS.Models.Enums.VisitType)(entity.GetValue<int>(MRDVisit.Index.VisitType));
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

            entity.SetValue(MRDVisit.Index.VisitCode, model.VisitCode);
            entity.SetValue(MRDVisit.Index.VisitDate, model.VisitDate);
            entity.SetValue(MRDVisit.Index.VisitTime, DateUtil.GetMinDate().Add(model.VisitTime));
            entity.SetValue(MRDVisit.Index.ProviderCode, model.ProviderCode);
            entity.SetValue(MRDVisit.Index.DepartmentCode, model.DepartmentCode);
            entity.SetValue(MRDVisit.Index.DepartmentName, model.DepartmentName);
            entity.SetValue(MRDVisit.Index.PatientCode, model.PatientCode);
            entity.SetValue(MRDVisit.Index.PatientName, model.PatientName);
            entity.SetValue(MRDVisit.Index.ProviderName, model.ProviderName);
            entity.SetValue(MRDVisit.Index.CaseType, model.CaseType);
            entity.SetValue(MRDVisit.Index.VisitStatus, model.VisitStatus);
            entity.SetValue(MRDVisit.Index.Inactive, model.Inactive);
            entity.SetValue(MRDVisit.Index.IsConsultation, model.IsConsultation);
            // entity.SetValue(MRDVisit.Index.CreatedBy, model.CreatedBy);
            entity.SetValue(MRDVisit.Index.CreatedDate, model.CreatedDate);
            // entity.SetValue(MRDVisit.Index.ModifyBy, model.ModifyBy);
            entity.SetValue(MRDVisit.Index.ModifyDate, model.ModifyDate);
            entity.SetValue(MRDVisit.Index.LastMaintained, model.LastMaintained);
            entity.SetValue(MRDVisit.Index.BillingCode, model.BillingCode);
            entity.SetValue(MRDVisit.Index.VisitType, model.VisitType);
        }

        /// <summary>
        /// Map Key
        /// </summary>
        /// <param name="model">Model</param>
        /// <param name="entity">Business Entity</param>
        public override void MapKey(T model, IBusinessEntity entity)
        {
            entity.SetValue(MRDVisit.Index.VisitCode, model.VisitCode);
        }

        #endregion
    }
}