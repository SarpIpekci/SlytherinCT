﻿using Castle.DynamicProxy;
using System;

namespace Core.Utilities.Interceptors
{
    //Metot çalışmadan önce belli validasyonlarımız var ise interceptor ile araya girip çalıştırıp devam edebiliriz.
    //Castle kütüphanesiyle metot çalışmadan önce metodu yakaladığımız kısım
    public class MethodInterception : MethodInterceptionBaseAttribute
    {
        protected virtual void OnBefore(IInvocation invocation) { }
        protected virtual void OnAfter(IInvocation invocation) { }
        protected virtual void OnException(IInvocation invocation, System.Exception e) { }
        protected virtual void OnSuccess(IInvocation invocation) { }

        public override void Intercept(IInvocation invocation)
        {
            var isSuccess = true;
            OnBefore(invocation);
            try
            {
                invocation.Proceed();
            }
            catch (Exception e)
            {
                isSuccess = false;
                OnException(invocation, e);
                throw;
            }
            finally
            {
                if (isSuccess)
                {
                    OnSuccess(invocation);
                }
            }
            OnAfter(invocation);
        }
    }
}
