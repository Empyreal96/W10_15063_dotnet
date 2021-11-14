// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Content.ContentManager
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Security;

namespace Microsoft.Xna.Framework.Content
{
  public class ContentManager : IDisposable
  {
    private const string contentExtension = ".xnb";
    private IServiceProvider serviceProvider;
    private string rootDirectory;
    private bool isRootDirectoryAbsolute;
    internal string fullRootDirectory;
    private byte[] byteBuffer;
    private WeakReference weakByteBuffer;
    private int readAssetRecurseCount;
    private Dictionary<string, object> loadedAssets = new Dictionary<string, object>((IEqualityComparer<string>) StringComparer.OrdinalIgnoreCase);
    private List<IDisposable> disposableAssets = new List<IDisposable>();

    public ContentManager(IServiceProvider serviceProvider)
      : this(serviceProvider, string.Empty)
    {
    }

    public ContentManager(IServiceProvider serviceProvider, string rootDirectory)
    {
      if (serviceProvider == null)
        throw new ArgumentNullException(nameof (serviceProvider));
      this.RootDirectory = rootDirectory != null ? rootDirectory : throw new ArgumentNullException(nameof (rootDirectory));
      this.serviceProvider = serviceProvider;
    }

    public IServiceProvider ServiceProvider => this.serviceProvider;

    public string RootDirectory
    {
      get => this.rootDirectory;
      set
      {
        if (value == null)
          throw new ArgumentNullException(nameof (value));
        if (this.loadedAssets.Count > 0)
          throw new InvalidOperationException(FrameworkResources.ContentManagerCannotChangeRootDirectory);
        this.rootDirectory = value;
        this.fullRootDirectory = value;
        this.isRootDirectoryAbsolute = TitleContainer.IsPathAbsolute(value);
      }
    }

    internal void RecordDisposableObject(IDisposable disposable) => this.disposableAssets.Add(disposable);

    public void Dispose()
    {
      this.Dispose(true);
      GC.SuppressFinalize((object) this);
    }

    protected virtual void Dispose(bool disposing)
    {
      try
      {
        if (!disposing || this.loadedAssets == null)
          return;
        this.Unload();
      }
      finally
      {
        this.loadedAssets = (Dictionary<string, object>) null;
        this.disposableAssets = (List<IDisposable>) null;
      }
    }

    public virtual void Unload()
    {
      if (this.loadedAssets == null)
        throw new ObjectDisposedException(this.ToString());
      try
      {
        foreach (IDisposable disposableAsset in this.disposableAssets)
          disposableAsset.Dispose();
      }
      finally
      {
        this.loadedAssets.Clear();
        this.disposableAssets.Clear();
      }
    }

    [SuppressMessage("Microsoft.Design", "CA1004")]
    public virtual T Load<T>(string assetName)
    {
      if (this.loadedAssets == null)
        throw new ObjectDisposedException(this.ToString());
      assetName = !string.IsNullOrEmpty(assetName) ? TitleContainer.GetCleanPath(assetName) : throw new ArgumentNullException(nameof (assetName));
      object obj1;
      if (this.loadedAssets.TryGetValue(assetName, out obj1))
        return obj1 is T obj3 ? obj3 : throw new ContentLoadException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, FrameworkResources.BadXnbWrongType, (object) assetName, (object) obj1.GetType(), (object) typeof (T)));
      Logger.BeginLogEvent(LoggingEvent.LoadContent, "XNA: Begin Loading Content: " + assetName);
      T obj4;
      try
      {
        obj4 = this.ReadAsset<T>(assetName, (Action<IDisposable>) null);
        this.loadedAssets.Add(assetName, (object) obj4);
      }
      finally
      {
        Logger.EndLogEvent(LoggingEvent.LoadContent, "XNA: Done Loading Content: " + assetName);
      }
      return obj4;
    }

    [SuppressMessage("Microsoft.Design", "CA1004")]
    protected T ReadAsset<T>(string assetName, Action<IDisposable> recordDisposableObject)
    {
      if (this.loadedAssets == null)
        throw new ObjectDisposedException(this.ToString());
      if (string.IsNullOrEmpty(assetName))
        throw new ArgumentNullException(nameof (assetName));
      using (Stream input = this.OpenStream(assetName))
      {
        using (ContentReader contentReader = ContentReader.Create(this, input, assetName, recordDisposableObject))
        {
          ++this.readAssetRecurseCount;
          try
          {
            return contentReader.ReadAsset<T>();
          }
          finally
          {
            if (--this.readAssetRecurseCount == 0)
              this.byteBuffer = (byte[]) null;
          }
        }
      }
    }

    [SecuritySafeCritical]
    protected virtual Stream OpenStream(string assetName)
    {
      try
      {
        return TitleContainer.OpenStream(TitleContainer.GetCleanPath(Path.Combine(this.fullRootDirectory, assetName + ".xnb")));
      }
      catch (Exception ex)
      {
        switch (ex)
        {
          case FileNotFoundException _:
          case DirectoryNotFoundException _:
            throw new ContentLoadException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, FrameworkResources.OpenStreamNotFound, (object) assetName), ex);
          default:
            throw new ContentLoadException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, FrameworkResources.OpenStreamError, (object) assetName), ex);
        }
      }
    }

    internal byte[] GetByteBuffer(int size)
    {
      byte[] numArray = this.byteBuffer;
      if (numArray == null && this.weakByteBuffer != null)
        numArray = (byte[]) this.weakByteBuffer.Target;
      if (numArray == null || numArray.Length < size)
      {
        numArray = new byte[size];
        this.byteBuffer = numArray;
        this.weakByteBuffer = new WeakReference((object) numArray);
      }
      return numArray;
    }
  }
}
