//
// CouchbaseSqliteCollationFunction.cs
//
// Author:
//     Zachary Gramana  <zack@xamarin.com>
//
// Copyright (c) 2014 Xamarin Inc
// Copyright (c) 2014 .NET Foundation
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
//
// Copyright (c) 2014 Couchbase, Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file
// except in compliance with the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the
// License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND,
// either express or implied. See the License for the specific language governing permissions
// and limitations under the License.
//


using System;
using SQLitePCL;

namespace Couchbase.Lite.Storage
{

    internal static class CouchbaseSqliteJsonUnicodeCollationFunction
    {
        public static Int32 Compare (object userData, String param1, String param2)
        {
            return JsonCollator.Compare(JsonCollationMode.Unicode, param1, param2, Int32.MaxValue);
        }
    }
        
    internal static class CouchbaseSqliteJsonAsciiCollationFunction
    {
        //Woefully incomplete ?
        public static Int32 Compare (object userData, String param1, String param2)
        {
            return JsonCollator.Compare(JsonCollationMode.Ascii, param1, param2, Int32.MaxValue);
        }
    }
        
    internal static class CouchbaseSqliteJsonRawCollationFunction
    {
        //Woefully incomplete ?
        public static Int32 Compare (object userData, String param1, String param2)
        {
            return JsonCollator.Compare(JsonCollationMode.Raw, param1, param2, Int32.MaxValue);
        }
    }
        
    internal static class CouchbaseSqliteRevIdCollationFunction
    {
        //Woefully incomplete ?
        public static Int32 Compare (object userData, String param1, String param2)
        {
            return RevIdCollator.Compare(param1, param2);
        }
    }

    internal static class CouchbaseSqliteFtsRankFunction
    {
        public static void Execute(sqlite3_context ctx, object user_data, sqlite3_value[] args)
        {
            
        }
    }
}
