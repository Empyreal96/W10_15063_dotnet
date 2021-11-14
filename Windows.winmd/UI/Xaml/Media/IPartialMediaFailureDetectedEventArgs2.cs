// Decompiled with JetBrains decompiler
// Type: Windows.UI.Xaml.Media.IPartialMediaFailureDetectedEventArgs2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.UI.Xaml.Media
{
  [ExclusiveTo(typeof (PartialMediaFailureDetectedEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [WebHostHidden]
  [Guid(1929857141, 35085, 16747, 185, 174, 232, 77, 253, 156, 75, 27)]
  internal interface IPartialMediaFailureDetectedEventArgs2
  {
    HResult ExtendedError { get; }
  }
}
