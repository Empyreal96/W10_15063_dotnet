// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Input.Touch.FilterSession
// Assembly: Microsoft.Xna.Framework.Input.Touch, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 8E9BEFFA-058F-469C-A733-2CE9128BE180
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI3BB0~1.DLL

using System;

namespace Microsoft.Xna.Framework.Input.Touch
{
  internal class FilterSession
  {
    private IntPtr _handle;

    internal FilterSession() => Helpers.ThrowExceptionFromResult(SafeTouchNativeMethods.CreateFilterSession(out this._handle));

    internal void Dispose() => Helpers.ThrowExceptionFromResult(SafeTouchNativeMethods.FilterSessionRelease(this._handle));

    internal void Filter(ref TouchInfoBuffer touch)
    {
      if (this._handle == IntPtr.Zero)
        return;
      Helpers.ThrowExceptionFromResult(SafeTouchNativeMethods.FilterSessionFilter(this._handle, ref touch));
    }
  }
}
