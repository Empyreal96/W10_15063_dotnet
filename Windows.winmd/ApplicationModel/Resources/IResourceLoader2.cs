// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.Resources.IResourceLoader2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.Resources
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ResourceLoader))]
  [Guid(283864774, 33080, 18625, 188, 101, 225, 241, 66, 7, 54, 124)]
  internal interface IResourceLoader2
  {
    string GetStringForUri(Uri uri);
  }
}
