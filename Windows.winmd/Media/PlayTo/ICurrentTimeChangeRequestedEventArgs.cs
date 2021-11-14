// Decompiled with JetBrains decompiler
// Type: Windows.Media.PlayTo.ICurrentTimeChangeRequestedEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.PlayTo
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2574324516, 60871, 19445, 145, 246, 60, 134, 39, 219, 89, 229)]
  [ExclusiveTo(typeof (CurrentTimeChangeRequestedEventArgs))]
  internal interface ICurrentTimeChangeRequestedEventArgs
  {
    TimeSpan Time { get; }
  }
}
