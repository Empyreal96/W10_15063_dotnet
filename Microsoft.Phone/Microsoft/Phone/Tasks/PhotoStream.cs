// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Tasks.PhotoStream
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.IO;
using System.Security;

namespace Microsoft.Phone.Tasks
{
  [SecuritySafeCritical]
  internal class PhotoStream : FileStream
  {
    private PhotoHandle mPhotoHandle;

    public PhotoStream(string localFileName)
      : base(localFileName, FileMode.Open, FileAccess.Read, QuirksMode.ShouldPhotoStreamOpenWithDeleteOnCloseFlag() ? FileShare.Read | FileShare.Delete : FileShare.Read)
    {
      this.mPhotoHandle = NativeMethods.CreateFile(localFileName, 2147483648U, 1U, IntPtr.Zero, 4U, QuirksMode.ShouldPhotoStreamOpenWithDeleteOnCloseFlag() ? 67108992U : 128U, IntPtr.Zero);
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
