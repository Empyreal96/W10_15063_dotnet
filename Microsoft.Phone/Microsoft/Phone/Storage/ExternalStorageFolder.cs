// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Storage.ExternalStorageFolder
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Collections.Generic;
using System.IO;
using System.Security;
using System.Threading.Tasks;

namespace Microsoft.Phone.Storage
{
  [SecuritySafeCritical]
  public class ExternalStorageFolder
  {
    private string m_folderPath;
    private string m_internalFolderPath;

    public string Name { get; private set; }

    public string Path
    {
      get => this.m_folderPath;
      private set
      {
        string pathRoot = System.IO.Path.GetPathRoot(value);
        this.m_internalFolderPath = value;
        this.m_folderPath = value.Substring(pathRoot.Length);
      }
    }

    public DateTimeOffset DateModified { get; private set; }

    internal ExternalStorageFolder(string folderPath, DateTimeOffset lastModified)
    {
      this.Path = !string.IsNullOrEmpty(folderPath) ? System.IO.Path.GetFullPath(folderPath) : throw new ArgumentNullException(nameof (folderPath));
      this.Name = System.IO.Path.GetFileName(this.m_internalFolderPath);
      this.DateModified = lastModified;
    }

    [SecuritySafeCritical]
    private IEnumerable<ExternalStorageFile> GetFiles()
    {
      List<ExternalStorageFile> externalStorageFileList = new List<ExternalStorageFile>(50);
      bool flag = true;
      int key = -1;
      try
      {
        SafeNativeMethods.ThrowExceptionFromHResult(SafeNativeMethods.SDCreateBrokerClientInstance(out key));
        SafeNativeMethods.ManagedSDItem[] items;
        SafeNativeMethods.ThrowExceptionFromHResult(SafeNativeMethods.SDGetFirstBatchFiles(key, this.m_internalFolderPath, out items));
        if (items != null)
        {
          do
          {
            for (int index = 0; index < items.Length; ++index)
            {
              if (string.IsNullOrEmpty(items[index].name))
              {
                flag = false;
                break;
              }
              string filePath = System.IO.Path.Combine(this.m_internalFolderPath, items[index].name);
              DateTimeOffset lastModified = DateTimeOffset.FromFileTime(items[index].fileTime);
              externalStorageFileList.Add(new ExternalStorageFile(filePath, lastModified));
            }
            items = (SafeNativeMethods.ManagedSDItem[]) null;
            if (flag)
            {
              if (SafeNativeMethods.SDGetNextBatchFiles(key, this.m_folderPath, out items) != 0)
                break;
            }
            else
              break;
          }
          while (items != null);
        }
      }
      finally
      {
        if (key != -1)
          SafeNativeMethods.SDDeleteBrokerClientInstance(key);
      }
      return (IEnumerable<ExternalStorageFile>) externalStorageFileList;
    }

    [SecuritySafeCritical]
    private IEnumerable<ExternalStorageFolder> GetFolders()
    {
      List<ExternalStorageFolder> externalStorageFolderList = new List<ExternalStorageFolder>(50);
      bool flag = true;
      int key = -1;
      try
      {
        SafeNativeMethods.ThrowExceptionFromHResult(SafeNativeMethods.SDCreateBrokerClientInstance(out key));
        SafeNativeMethods.ManagedSDItem[] items;
        SafeNativeMethods.ThrowExceptionFromHResult(SafeNativeMethods.SDGetFirstBatchFolders(key, this.m_internalFolderPath, out items));
        if (items != null)
        {
          do
          {
            for (int index = 0; index < items.Length; ++index)
            {
              if (string.IsNullOrEmpty(items[index].name))
              {
                flag = false;
                break;
              }
              string folderPath = System.IO.Path.Combine(this.m_internalFolderPath, items[index].name);
              DateTimeOffset lastModified = DateTimeOffset.FromFileTime(items[index].fileTime);
              externalStorageFolderList.Add(new ExternalStorageFolder(folderPath, lastModified));
            }
            items = (SafeNativeMethods.ManagedSDItem[]) null;
            if (flag)
            {
              if (SafeNativeMethods.SDGetNextBatchFolders(key, this.m_internalFolderPath, out items) != 0)
                break;
            }
            else
              break;
          }
          while (items != null);
        }
      }
      finally
      {
        if (key != -1)
          SafeNativeMethods.SDDeleteBrokerClientInstance(key);
      }
      return (IEnumerable<ExternalStorageFolder>) externalStorageFolderList;
    }

    [SecuritySafeCritical]
    internal ExternalStorageFolder GetFolder(string name)
    {
      int key = -1;
      string folderPath = System.IO.Path.Combine(this.m_internalFolderPath, name);
      try
      {
        SafeNativeMethods.ThrowExceptionFromHResult(SafeNativeMethods.SDCreateBrokerClientInstance(out key));
        SafeNativeMethods.ManagedSDItem[] items;
        SafeNativeMethods.ThrowExceptionFromHResult(SafeNativeMethods.SDGetItem(key, SafeNativeMethods.managedSdItemType.SD_TYPE_FOLDER, folderPath, out items));
        DateTimeOffset lastModified = items != null ? DateTimeOffset.FromFileTime(items[0].fileTime) : throw new FileNotFoundException(string.Format("Folder {0} does not exist under the current directory, or access to this folder is denied", (object) name));
        return new ExternalStorageFolder(folderPath, lastModified);
      }
      finally
      {
        if (key != -1)
          SafeNativeMethods.SDDeleteBrokerClientInstance(key);
      }
    }

    [SecuritySafeCritical]
    internal ExternalStorageFile GetFile(string name)
    {
      int key = -1;
      string str = System.IO.Path.Combine(this.m_internalFolderPath, name);
      try
      {
        SafeNativeMethods.ThrowExceptionFromHResult(SafeNativeMethods.SDCreateBrokerClientInstance(out key));
        SafeNativeMethods.ManagedSDItem[] items;
        SafeNativeMethods.ThrowExceptionFromHResult(SafeNativeMethods.SDGetItem(key, SafeNativeMethods.managedSdItemType.SD_TYPE_FILE, str, out items));
        DateTimeOffset lastModified = items != null ? DateTimeOffset.FromFileTime(items[0].fileTime) : throw new FileNotFoundException(string.Format("File {0} does not exist under the current directory, or access to this file is denied", (object) name));
        return new ExternalStorageFile(str, lastModified);
      }
      finally
      {
        if (key != -1)
          SafeNativeMethods.SDDeleteBrokerClientInstance(key);
      }
    }

    public Task<IEnumerable<ExternalStorageFile>> GetFilesAsync() => Task<IEnumerable<ExternalStorageFile>>.Factory.StartNew(new Func<IEnumerable<ExternalStorageFile>>(this.GetFiles));

    public Task<IEnumerable<ExternalStorageFolder>> GetFoldersAsync() => Task<IEnumerable<ExternalStorageFolder>>.Factory.StartNew(new Func<IEnumerable<ExternalStorageFolder>>(this.GetFolders));

    public Task<ExternalStorageFolder> GetFolderAsync(string name) => !string.IsNullOrEmpty(name) ? Task<ExternalStorageFolder>.Factory.StartNew((Func<ExternalStorageFolder>) (() => this.GetFolder(name))) : throw new ArgumentException("Folder name cannot be null or empty");
  }
}
