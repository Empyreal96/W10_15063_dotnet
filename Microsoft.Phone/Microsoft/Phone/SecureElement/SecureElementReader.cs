// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.SecureElement.SecureElementReader
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Security;

namespace Microsoft.Phone.SecureElement
{
  public class SecureElementReader : IDisposable
  {
    private bool _disposed;

    public event EventHandler<RegisterSecureElementItemEventArgs> RegisterSecureElementItemCompleted;

    [SecuritySafeCritical]
    private SecureElementReader() => throw new NotImplementedException();

    ~SecureElementReader() => this.Dispose(false);

    public bool IsSecureElementPresent
    {
      [SecuritySafeCritical] get => throw new NotImplementedException();
    }

    public string TsmRoutingId
    {
      [SecuritySafeCritical] get => throw new NotImplementedException();
    }

    public static CardEmulationMode CardEmulationMode
    {
      [SecuritySafeCritical] get => throw new NotImplementedException();
    }

    public SecureElementSession OpenSession() => throw new NotImplementedException();

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

    public static SecureElementReader GetDefault() => throw new NotImplementedException();

    [SecuritySafeCritical]
    public void RegisterSecureElementItemAsync(ISecureElementItem item, byte[] serviceId) => throw new NotImplementedException();
  }
}
