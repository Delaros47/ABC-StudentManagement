﻿using Autofac;
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

        }
    }
}
