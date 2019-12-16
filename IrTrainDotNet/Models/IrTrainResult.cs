﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IrTrainDotNet.Models
{
   public class IrTrainResult<T>
    {
        public int ExceptionId { get; set; }
        public string ExceptionMessage { get; set; }
        public T Result { get; set; }
         
    }
}