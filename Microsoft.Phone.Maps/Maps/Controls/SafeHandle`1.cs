// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Controls.SafeHandle`1
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using Microsoft.Win32.SafeHandles;
using System;
using System.Globalization;
using System.Security;

namespace Microsoft.Phone.Maps.Controls
{
  [SecurityCritical]
  internal class SafeHandle<T> : SafeHandleZeroOrMinusOneIsInvalid
  {
    private readonly InteropDestroyFunctions.DestroyObject destroyObjectHandler;

    [SecurityCritical]
    protected SafeHandle()
      : base(true)
    {
      if (!InteropDestroyFunctions.Table.TryGetValue(typeof (T), out this.destroyObjectHandler))
        throw new InvalidOperationException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, Resources.DestroyObjectFunctionExceptionFormat, (object) typeof (T).ToString()));
    }

    [SecurityCritical]
    protected override bool ReleaseHandle()
    {
      this.destroyObjectHandler(this.handle);
      return true;
    }
  }
}
