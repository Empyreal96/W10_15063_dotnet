// Decompiled with JetBrains decompiler
// Type: Windows.Gaming.UI.IGameBarStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Gaming.UI
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (GameBar))]
  [Guid(498705042, 52344, 16755, 190, 69, 182, 30, 103, 40, 62, 167)]
  internal interface IGameBarStatics
  {
    event EventHandler<object> VisibilityChanged;

    event EventHandler<object> IsInputRedirectedChanged;

    bool Visible { get; }

    bool IsInputRedirected { get; }
  }
}
