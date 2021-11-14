// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IResourceDictionaryFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [Guid(3929422261, 12727, 17009, 146, 201, 124, 149, 132, 169, 28, 34)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ResourceDictionary))]
  internal interface IResourceDictionaryFactory
  {
    ResourceDictionary CreateInstance(object outer, out object inner);
  }
}
