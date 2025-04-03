﻿/*
 * Tencent is pleased to support the open source community by making xLua available.
 * Copyright (C) 2016 THL A29 Limited, a Tencent company. All rights reserved.
 * Licensed under the MIT License (the "License"); you may not use this file except in compliance with the License. You may obtain a copy of the License at
 * http://opensource.org/licenses/MIT
 * Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the specific language governing permissions and limitations under the License.
*/

using System;

namespace XLua
{
    [Serializable]
    public class LuaException : Exception
    {
        public LuaException(string message) : base(GetCorrectMessage(message))
        {
            
        }
        
        static string GetCorrectMessage(string message)
        {
            if(LuaVM.instanceValid)
            {
                return LuaVM.instance.env.Traceback(message);
            }
            return message;
        }
    }
}
