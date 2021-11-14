// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.IInlineFactory
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Documents
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(1079553233, 12176, 19343, 153, 221, 66, 24, 239, 95, 3, 222)]
  [ExclusiveTo(typeof (Inline))]
  internal interface IInlineFactory
  {
    Inline CreateInstance(object outer, out object inner);
  }
}
