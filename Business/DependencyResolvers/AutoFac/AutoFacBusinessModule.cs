using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.AutoFac
{
    public class AutoFacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<SchoolManager>().As<ISchoolService>().SingleInstance();
            builder.RegisterType<EfSchoolDal>().As<ISchoolDal>().SingleInstance();

            builder.RegisterType<CityManager>().As<ICityService>().SingleInstance();
            builder.RegisterType<EfCityDal>().As<ICityDal>().SingleInstance();

            builder.RegisterType<DistrictManager>().As<IDistrictService>().SingleInstance();
            builder.RegisterType<EfDistrictDal>().As<IDistrictDal>().SingleInstance();

            builder.RegisterType<FamilyInformationManager>().As<IFamilyInformationService>().SingleInstance();
            builder.RegisterType<EfFamilyInformationDal>().As<IFamilyInformationDal>().SingleInstance();

            builder.RegisterType<CancelReasonManager>().As<ICancelReasonService>().SingleInstance();
            builder.RegisterType<EfCancelReasonDal>().As<ICancelReasonDal>().SingleInstance();

            builder.RegisterType<ForeignLanguageManager>().As<IForeignLanguageService>().SingleInstance();
            builder.RegisterType<EfForeignLanguageDal>().As<IForeignLanguageDal>().SingleInstance();

            builder.RegisterType<IncentiveManager>().As<IIncentiveService>().SingleInstance();
            builder.RegisterType<EfIncentiveDal>().As<IIncentiveDal>().SingleInstance();

            builder.RegisterType<QuotaManager>().As<IQuotaService>().SingleInstance();
            builder.RegisterType<EfQuotaDal>().As<IQuotaDal>().SingleInstance();

            builder.RegisterType<GuidanceCounselorManager>().As<IGuidanceCounselorService>().SingleInstance();
            builder.RegisterType<EfGuidanceCounselorDal>().As<IGuidanceCounselorDal>().SingleInstance();

            builder.RegisterType<ClassGroupManager>().As<IClassGroupService>().SingleInstance();
            builder.RegisterType<EfClassGroupDal>().As<IClassGroupDal>().SingleInstance();

            builder.RegisterType<OccupationManager>().As<IOccupationService>().SingleInstance();
            builder.RegisterType<EfOccupationDal>().As<IOccupationDal>().SingleInstance();

            builder.RegisterType<FamilyIntimacyManager>().As<IFamilyIntimacyService>().SingleInstance();
            builder.RegisterType<EfFamilyIntimacyDal>().As<IFamilyIntimacyDal>().SingleInstance();

            builder.RegisterType<WorkplaceManager>().As<IWorkplaceService>().SingleInstance();
            builder.RegisterType<EfWorkplaceDal>().As<IWorkplaceDal>().SingleInstance();

            builder.RegisterType<DutyManager>().As<IDutyService>().SingleInstance();
            builder.RegisterType<EfDutyDal>().As<IDutyDal>().SingleInstance();

            builder.RegisterType<DiscountTypeManager>().As<IDiscountTypeService>().SingleInstance();
            builder.RegisterType<EfDiscountTypeDal>().As<IDiscountTypeDal>().SingleInstance();

            builder.RegisterType<DocumentManager>().As<IDocumentService>().SingleInstance();
            builder.RegisterType<EfDocumentDal>().As<IDocumentDal>().SingleInstance();

            builder.RegisterType<PromotionManager>().As<IPromotionService>().SingleInstance();
            builder.RegisterType<EfPromotionDal>().As<IPromotionDal>().SingleInstance();

            builder.RegisterType<SchoolServiceManager>().As<ISchoolServiceService>().SingleInstance();
            builder.RegisterType<EfSchoolServiceDal>().As<ISchoolServiceDal>().SingleInstance();

            builder.RegisterType<ClassManager>().As<IClassService>().SingleInstance();
            builder.RegisterType<EfClassDal>().As<IClassDal>().SingleInstance();

            builder.RegisterType<ServiceTypeManager>().As<IServiceTypeService>().SingleInstance();
            builder.RegisterType<EfServiceTypeDal>().As<IServiceTypeDal>().SingleInstance();

        }
    }
}
