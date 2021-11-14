// Decompiled with JetBrains decompiler
// Type: Windows.Media.Casting.ICastingConnectionErrorOccurredEventArgs
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Media.Casting
{
  [ExclusiveTo(typeof (CastingConnectionErrorOccurredEventArgs))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(2818260073, 34585, 20224, 129, 251, 150, 24, 99, 199, 154, 50)]
  internal interface ICastingConnectionErrorOccurredEventArgs
  {
    CastingConnectionErrorStatus ErrorStatus { get; }

    string Message { get; }
  }
}
