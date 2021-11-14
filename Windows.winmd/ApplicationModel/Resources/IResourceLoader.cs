// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Resources.IResourceLoader
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Resources
{
  [Guid(139610376, 5871, 17837, 166, 2, 41, 54, 55, 215, 230, 26)]
  [ExclusiveTo(typeof (ResourceLoader))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IResourceLoader
  {
    string GetString(string resource);
  }
}
