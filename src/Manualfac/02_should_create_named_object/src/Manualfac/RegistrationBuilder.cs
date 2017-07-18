﻿using System;
using Manualfac.Services;

namespace Manualfac
{
    class RegistrationBuilder : IRegistrationBuilder
    {
        public Service Service { get; set; }
        public Func<IComponentContext, object> Activator { get; set; }

        public IRegistrationBuilder As<TService>()
        {
            Service = new TypedService(typeof(TService));
            return this;
        }

        public IRegistrationBuilder Named<TService>(string name)
        {
            throw new NotImplementedException();
        }

        public ComponentRegistration Build()
        {
            return new ComponentRegistration(Service, Activator);
        }
    }
}