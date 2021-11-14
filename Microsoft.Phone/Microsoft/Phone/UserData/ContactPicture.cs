// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.UserData.ContactPicture
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.IO;
using System.Security;

namespace Microsoft.Phone.UserData
{
  [SecuritySafeCritical]
  internal class ContactPicture : Stream
  {
    private IntPtr _StreamHandle;
    private PoomDataServiceInteropContext _Interop = new PoomDataServiceInteropContext();

    [SecuritySafeCritical]
    internal ContactPicture(PoomDataServiceInteropContext interop, IntPtr streamHandle)
    {
      this._StreamHandle = streamHandle;
      this._Interop = interop;
    }

    internal static bool TryGetContactPicture(uint contactId, out ContactPicture picture)
    {
      PoomDataServiceInteropContext interop = new PoomDataServiceInteropContext();
      IntPtr streamHandle;
      if (interop.TryGetContactPictureStream(contactId, out streamHandle))
      {
        picture = new ContactPicture(interop, streamHandle);
        return true;
      }
      picture = (ContactPicture) null;
      return false;
    }

    public override long Position
    {
      get => this.Seek(0L, SeekOrigin.Current);
      set => this.Seek(value, SeekOrigin.Begin);
    }

    public override long Length
    {
      [SecuritySafeCritical] get => this._Interop.GetStreamLength(this._StreamHandle);
    }

    public override bool CanSeek => true;

    [SecuritySafeCritical]
    public override long Seek(long offset, SeekOrigin origin) => this._Interop.SeekStream(this._StreamHandle, offset, origin);

    public override bool CanRead => true;

    [SecuritySafeCritical]
    public override int Read(byte[] buffer, int offset, int count) => this._Interop.ReadStream(this._StreamHandle, buffer, offset, count);

    [SecuritySafeCritical]
    protected override void Dispose(bool disposing) => this._Interop.FreeStream(this._StreamHandle);

    public override bool CanWrite => false;

    public override void Write(byte[] buffer, int offset, int count) => throw new NotSupportedException();

    public override void Flush() => throw new NotSupportedException();

    public override void SetLength(long value) => throw new NotSupportedException();
  }
}
