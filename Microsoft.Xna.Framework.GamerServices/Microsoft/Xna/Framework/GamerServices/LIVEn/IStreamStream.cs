// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GamerServices.LIVEn.IStreamStream
// Assembly: Microsoft.Xna.Framework.GamerServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 4CE9CD1E-CFF0-4A29-B8E1-5772070CE886
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5CF0~1.DLL

using System;
using System.IO;

namespace Microsoft.Xna.Framework.GamerServices.LIVEn
{
  internal class IStreamStream : Stream
  {
    private uint _istreamHandle;

    internal IStreamStream(uint handle) => this._istreamHandle = handle;

    public override void Flush()
    {
    }

    public override int Read(byte[] buffer, int offset, int count)
    {
      if (!this.IsValidHandle)
        return 0;
      uint pcbRead;
      int num = (int) SafeMobileNativeMethods.IStream_Read(this._istreamHandle, buffer, (uint) count, out pcbRead);
      return (int) pcbRead;
    }

    public override int ReadByte() => throw new NotImplementedException();

    public override long Seek(long offset, SeekOrigin origin) => throw new NotImplementedException();

    public override void SetLength(long length) => throw new NotImplementedException();

    public override void Write(byte[] buffer, int offset, int count) => throw new NotImplementedException();

    public override void WriteByte(byte value) => throw new NotImplementedException();

    public override void Close()
    {
      if (!this.IsValidHandle)
        return;
      int num = (int) SafeMobileNativeMethods.IStream_Close(this._istreamHandle);
    }

    public override bool CanRead => true;

    public override bool CanSeek => false;

    public override bool CanWrite => false;

    public override long Length => throw new NotImplementedException();

    public override long Position
    {
      get => throw new NotImplementedException();
      set => throw new NotImplementedException();
    }

    internal bool IsValidHandle => this._istreamHandle != uint.MaxValue;
  }
}
