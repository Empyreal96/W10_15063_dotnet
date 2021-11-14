// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.Content.ResourceContentManager
// Assembly: Microsoft.Xna.Framework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 0BF92717-92F2-4BEE-9059-E2064336A44E
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIA915~1.DLL

using System;
using System.Globalization;
using System.IO;
using System.Resources;

namespace Microsoft.Xna.Framework.Content
{
  public class ResourceContentManager : ContentManager
  {
    private ResourceManager resourceManager;

    public ResourceContentManager(IServiceProvider serviceProvider, ResourceManager resourceManager)
      : base(serviceProvider)
    {
      this.resourceManager = resourceManager != null ? resourceManager : throw new ArgumentNullException(nameof (resourceManager));
    }

    protected override Stream OpenStream(string assetName)
    {
      object obj = this.resourceManager.GetObject(assetName);
      if (obj == null)
        throw new ContentLoadException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, FrameworkResources.OpenResourceNotFound, (object) assetName));
      return obj is byte[] buffer ? (Stream) new MemoryStream(buffer) : throw new ContentLoadException(string.Format((IFormatProvider) CultureInfo.CurrentCulture, FrameworkResources.OpenResourceNotBinary, (object) assetName));
    }
  }
}
