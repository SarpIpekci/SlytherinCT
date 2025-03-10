﻿using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T> where T : class
    {
        public T Data { get; }

        public DataResult(T data,bool isSuccess,string message):base(isSuccess,message)
        {
            Data = data;
        }

        public DataResult(T data,bool isSuccess):base(isSuccess)
        {
            Data = data;
        }
    }
}
