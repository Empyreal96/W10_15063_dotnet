// Decompiled with JetBrains decompiler
// Type: Microsoft.Devices.PhotoStream
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.IO;
using System.Security;

namespace Microsoft.Devices
{
  [SecuritySafeCritical]
  internal class PhotoStream : FileStream
  {
    private PhotoHandle mPhotoHandle;

    public PhotoStream(string localFileName)
      : base(localFileName, FileMode.Open, FileAccess.Read, FileShare.Read)
    {
      this.mPhotoHandle = NativePhotoStreamMethods.CreateFile(localFileName, 2147483648U, 1U, IntPtr.Zero, 4U, 67108992U, IntPtr.Zero);
    }

    [SecuritySafeCritical]
    protected override void Dispose(bool disposing)
    {
      base.Dispose(disposing);
      if (this.mPhotoHandle == null || this.mPhotoHandle.IsClosed)
        return;
      this.mPhotoHandle.Dispose();
    }
  }
}
