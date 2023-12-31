﻿using DevFramework.Core.CrossCuttingConcers.Caching;
using PostSharp.Aspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DevFramework.Core.Aspects.Postsharp.CacheAspects
{
    [Serializable]
    public class CacheRemoveAspects : OnMethodBoundaryAspect
    {
        private string _pattern;
        private Type _cacheType;
        private ICacheManager _cacheManager;
        public CacheRemoveAspects(Type cacheType)
        {
            this._cacheType = cacheType;
        }
        public CacheRemoveAspects(string pattern, Type cacheType)
        {
            _pattern = pattern;
            _cacheType = cacheType;
        }
        public override void RuntimeInitialize(MethodBase method)
        {
            if (typeof(ICacheManager).IsAssignableFrom(_cacheType) == false)
            {
                throw new Exception("Wrong cache Manager");
            }
            _cacheManager = (ICacheManager)Activator.CreateInstance(_cacheType);


            base.RuntimeInitialize(method);
        }
        public override void OnSuccess(MethodExecutionArgs args)
        {
            _cacheManager.RemoveByPattern(string.IsNullOrEmpty(_pattern)
                ? string.Format($"{0}.{1}.*", args.Method.ReflectedType.Namespace, args.Method.ReflectedType.Name) :
                _pattern);
            base.OnSuccess(args);
        }

    }
}
