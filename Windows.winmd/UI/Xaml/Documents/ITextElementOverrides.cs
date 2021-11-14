// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.ITextElementOverrides
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Documents
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [ExclusiveTo(typeof (TextElement))]
  [Guid(216145639, 20342, 19929, 191, 145, 22, 59, 236, 207, 132, 188)]
  internal interface ITextElementOverrides
  {
    void OnDisconnectVisualChildren();
  }
}
