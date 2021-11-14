// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.IFrameworkTemplateFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml
{
  [Guid(444113061, 37757, 18132, 131, 43, 148, 255, 20, 218, 176, 97)]
  [ExclusiveTo(typeof (FrameworkTemplate))]
  [WebHostHidden]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  internal interface IFrameworkTemplateFactory
  {
    FrameworkTemplate CreateInstance(object outer, out object inner);
  }
}
