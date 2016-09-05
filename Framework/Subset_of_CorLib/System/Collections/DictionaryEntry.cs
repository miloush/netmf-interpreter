﻿////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Copyright (c) Microsoft Corporation.  All rights reserved.
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
using System;


namespace System.Collections
{
    public class DictionaryEntry
    {
        public Object Key;
        public Object Value;

        public DictionaryEntry(Object key, Object value)
        {
            Key = key;
            Value = value;
        }
    }
}