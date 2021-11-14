// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.SecureElement.SecureElementSession
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Security;

namespace Microsoft.Phone.SecureElement
{
  public class SecureElementSession : IDisposable
  {
    private bool _disposed;

    public SecureElementReader Reader { get; internal set; }

    public byte[] AnswerToReset
    {
      [SecuritySafeCritical] get => throw new NotImplementedException();
    }

    [SecuritySafeCritical]
    internal SecureElementSession(SecureElementReader seReader) => throw new NotImplementedException();

    ~SecureElementSession() => this.Dispose(false);

    public SecureElementChannel OpenChannel(byte[] appletId) => throw new NotImplementedException();

    public void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }

    [SecuritySafeCritical]
    private void Dispose(bool disposing)
    {
      if (this._disposed)
        return;
      this._disposed = true;
    }
  }
}
