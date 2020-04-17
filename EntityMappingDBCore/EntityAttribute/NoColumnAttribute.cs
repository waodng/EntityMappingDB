﻿using System;

namespace EntityMappingDBCore
{

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    /// <summary>
    /// 忽略，没有对应的列
    /// </summary>
    public class NoColumnAttribute : Attribute
    {
    }
}
