// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Storage.ExternalStorageDevice
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Microsoft.Phone.Storage
{
  public sealed class ExternalStorageDevice
  {
    private int deviceInstance;

    internal ExternalStorageDevice(string rootPath, int instanceID = 0)
    {
      this.RootFolder = new ExternalStorageFolder(rootPath, DateTimeOffset.MinValue);
      this.deviceInstance = instanceID;
    }

    public ExternalStorageFolder RootFolder { get; private set; }

    public string ExternalStorageID
    {
      get
      {
        string deviceID;
        Marshal.ThrowExceptionForHR(SafeNativeMethods.SDGetStorageID(this.deviceInstance, out deviceID));
        return deviceID;
      }
    }

    public Task<ExternalStorageFolder> GetFolderAsync(string folderPath) => !string.IsNullOrEmpty(folderPath) ? Task<ExternalStorageFolder>.Factory.StartNew((Func<ExternalStorageFolder>) (() => this.GetFolder(folderPath))) : throw new ArgumentException("Folder name cannot be null or empty");

    public Task<ExternalStorageFile> GetFileAsync(string filePath) => !string.IsNullOrEmpty(filePath) ? Task<ExternalStorageFile>.Factory.StartNew((Func<ExternalStorageFile>) (() => this.GetFile(filePath))) : throw new ArgumentException("File name cannot be null or empty");

    private ExternalStorageFolder GetFolder(string folderPath) => this.RootFolder.GetFolder(folderPath);

    private ExternalStorageFile GetFile(string filePath) => this.RootFolder.GetFile(filePath);
  }
}
