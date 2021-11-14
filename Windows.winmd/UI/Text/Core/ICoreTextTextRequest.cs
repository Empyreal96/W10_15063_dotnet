// Decompiled with JetBrains decompiler
// Type: Windows.UI.Text.Core.ICoreTextTextRequest
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Text.Core
{
  [ExclusiveTo(typeof (CoreTextTextRequest))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(1356419241, 62750, 19649, 140, 161, 230, 52, 109, 26, 97, 190)]
  internal interface ICoreTextTextRequest
  {
    CoreTextRange Range { get; }

    string Text { get; set; }

    bool IsCanceled { get; }

    Deferral GetDeferral();
  }
}
