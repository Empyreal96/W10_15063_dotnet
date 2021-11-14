// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Documents.ITextElement3
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Documents
{
  [WebHostHidden]
  [Guid(3520803855, 7108, 19624, 188, 247, 119, 11, 255, 155, 39, 171)]
  [ContractVersion(typeof (UniversalApiContract), 196608)]
  [ExclusiveTo(typeof (TextElement))]
  internal interface ITextElement3
  {
    bool AllowFocusOnInteraction { get; set; }

    string AccessKey { get; set; }

    bool ExitDisplayModeOnAccessKeyInvoked { get; set; }
  }
}
