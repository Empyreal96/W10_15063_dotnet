// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IPartialMediaFailureDetectedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Media.Playback;

namespace Windows.UI.Xaml.Media
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [WebHostHidden]
  [Guid(45505169, 58785, 17451, 136, 211, 45, 193, 39, 191, 197, 155)]
  [ExclusiveTo(typeof (PartialMediaFailureDetectedEventArgs))]
  internal interface IPartialMediaFailureDetectedEventArgs
  {
    FailedMediaStreamKind StreamKind { get; }
  }
}
