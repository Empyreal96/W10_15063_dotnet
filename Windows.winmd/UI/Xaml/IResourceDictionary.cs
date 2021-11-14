// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IResourceDictionary
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (ResourceDictionary))]
  [Guid(3253358372, 55006, 16785, 142, 58, 244, 134, 1, 247, 72, 156)]
  internal interface IResourceDictionary
  {
    Uri Source { get; set; }

    IVector<ResourceDictionary> MergedDictionaries { get; }

    IMap<object, object> ThemeDictionaries { get; }
  }
}
