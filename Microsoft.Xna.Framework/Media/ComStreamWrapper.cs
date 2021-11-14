// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Media.ComStreamWrapper
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using Microsoft.Phone;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security;

namespace Microsoft.Xna.Framework.Media
{
  internal class ComStreamWrapper
  {
    private Stream source;
    private long cachedPosition;
    private ComStreamWrapper.ReadDelegate readDelegate;
    private ComStreamWrapper.WriteDelegate writeDelegate;
    private ComStreamWrapper.SeekDelegate seekDelegate;
    private ComStreamWrapper.StatDelegate statDelegate;

    internal IntPtr ReadFuntionPtr => ComStreamWrapper.GetFunctionPointerForDelegate((Delegate) this.readDelegate);

    internal IntPtr WriteFuntionPtr => ComStreamWrapper.GetFunctionPointerForDelegate((Delegate) this.writeDelegate);

    internal IntPtr SeekFuntionPtr => ComStreamWrapper.GetFunctionPointerForDelegate((Delegate) this.seekDelegate);

    internal IntPtr LengthFuntionPtr => ComStreamWrapper.GetFunctionPointerForDelegate((Delegate) this.statDelegate);

    [SecuritySafeCritical]
    public static IntPtr GetFunctionPointerForDelegate(Delegate d) => Marshal.GetFunctionPointerForDelegate(d);

    public ComStreamWrapper(Stream stream)
    {
      this.source = stream != null ? stream : throw new ArgumentNullException(nameof (stream));
      this.cachedPosition = this.source.Position;
      this.readDelegate = new ComStreamWrapper.ReadDelegate(this.Read);
      this.writeDelegate = new ComStreamWrapper.WriteDelegate(this.Write);
      this.seekDelegate = new ComStreamWrapper.SeekDelegate(this.Seek);
      this.statDelegate = new ComStreamWrapper.StatDelegate(this.GetLength);
    }

    private void ValidateStream()
    {
      if (this.source.CanRead || !QuirksMode.ShouldXnaUnDisposeStream())
        return;
      if (!(this.source is MemoryStream source))
        return;
      try
      {
        this.source = (Stream) new MemoryStream(source.GetBuffer());
        this.source.Position = this.cachedPosition;
      }
      catch
      {
      }
    }

    [AllowReversePInvokeCalls]
    [SecuritySafeCritical]
    public void Read(byte[] pv, int cb, IntPtr pcbRead)
    {
      this.ValidateStream();
      if (!this.source.CanRead)
        return;
      int val = this.source.Read(pv, 0, cb);
      this.cachedPosition = this.source.Position;
      if (!(pcbRead != IntPtr.Zero))
        return;
      Marshal.WriteInt32(pcbRead, val);
    }

    [SecuritySafeCritical]
    [AllowReversePInvokeCalls]
    public void Write(byte[] pv, int cb, IntPtr pcbWritten)
    {
      this.ValidateStream();
      if (!this.source.CanWrite)
        return;
      this.source.Write(pv, 0, cb);
      this.cachedPosition = this.source.Position;
      if (!(pcbWritten != IntPtr.Zero))
        return;
      Marshal.WriteInt32(pcbWritten, cb);
    }

    [AllowReversePInvokeCalls]
    [SecuritySafeCritical]
    public void Seek(long dlibMove, int dwOrigin, IntPtr plibNewPosition)
    {
      this.ValidateStream();
      if (!this.source.CanSeek)
        return;
      long val = this.source.Seek(dlibMove, (SeekOrigin) dwOrigin);
      this.cachedPosition = val;
      if (!(plibNewPosition != IntPtr.Zero))
        return;
      Marshal.WriteInt64(plibNewPosition, val);
    }

    [AllowReversePInvokeCalls]
    [SecuritySafeCritical]
    public void GetLength(IntPtr pnLength)
    {
      this.ValidateStream();
      if (!(pnLength != IntPtr.Zero))
        return;
      Marshal.WriteInt64(pnLength, this.source.Length);
    }

    private delegate void ReadDelegate([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1), Out] byte[] buffer, int cb, IntPtr pcbRead);

    private delegate void WriteDelegate([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] byte[] buffer, int cb, IntPtr pcbWritten);

    private delegate void SeekDelegate(long dlibMove, int dwOrigin, IntPtr plibNewPosition);

    private delegate void StatDelegate(IntPtr pnLength);
  }
}
