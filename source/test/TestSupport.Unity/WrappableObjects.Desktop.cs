﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
#if !DOTNET
namespace Microsoft.Practices.Unity.TestSupport
{
    public partial class Wrappable : MarshalByRefObject
    {
    }

    public partial class WrappableWithProperty : MarshalByRefObject
    {
    }
}
#endif