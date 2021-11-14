// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Storage.ExternalStorageFile
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.IO;
using System.Security;
using System.Threading.Tasks;

namespace Microsoft.Phone.Storage
{
  public class ExternalStorageFile : IDisposable
  {
    private int m_clientKey = -1;
    private string m_filePath;
    private string m_internalFilePath;
    private bool m_disposed;

    public string Name { get; private set; }

    public string Path
    {
      get => this.m_filePath;
      private set
      {
        string pathRoot = System.IO.Path.GetPathRoot(value);
        this.m_internalFilePath = value;
        this.m_filePath = value.Substring(pathRoot.Length);
      }
    }

    public DateTimeOffset DateModified { get; private set; }

    internal ExternalStorageFile(string filePath, DateTimeOffset lastModified)
    {
      this.Path = !string.IsNullOrEmpty(filePath) ? System.IO.Path.GetFullPath(filePath) : throw new ArgumentNullException(nameof (filePath));
      this.Name = System.IO.Path.GetFileName(this.m_internalFilePath);
      this.DateModified = lastModified;
    }

    [SecuritySafeCritical]
    protected virtual void Dispose(bool disposing)
    {
      if (this.m_disposed)
        return;
      int num = disposing ? 1 : 0;
      if (this.m_clientKey != -1)
        SafeNativeMethods.SDDeleteBrokerClientInstance(this.m_clientKey);
      this.m_disposed = true;
    }

    ~ExternalStorageFile() => this.Dispose(false);

    public void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }

    [SecuritySafeCritical]
    private Stream OpenForRead()
    {
      string tokenID = "";
      NativeFileStream nativeFileStream = (NativeFileStream) null;
      IntPtr handle = new IntPtr(-1);
      if (this.m_clientKey == -1)
        SafeNativeMethods.ThrowExceptionFromHResult(SafeNativeMethods.SDCreateBrokerClientInstance(out this.m_clientKey));
      SafeNativeMethods.ThrowExceptionFromHResult(SafeNativeMethods.SDCreateDssToken(this.m_clientKey, this.m_internalFilePath, out tokenID));
      if (!string.IsNullOrEmpty(tokenID) && SafeNativeMethods.DSOpenSharedFile(tokenID, 0, out handle) == 0)
        nativeFileStream = NativeFileStream.OpenFileFromToken(tokenID);
      return (Stream) nativeFileStream;
    }

    public Task<Stream> OpenForReadAsync() => Task<Stream>.Factory.StartNew(new Func<Stream>(this.OpenForRead));
  }
}
