// Decompiled with JetBrains decompiler
// Type: Windows.Networking.NetworkOperators.INetworkOperatorTetheringOperationResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.Networking.NetworkOperators
{
  [ExclusiveTo(typeof (NetworkOperatorTetheringOperationResult))]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [Guid(3956409249, 442, 18285, 180, 179, 191, 61, 18, 200, 248, 12)]
  internal interface INetworkOperatorTetheringOperationResult
  {
    TetheringOperationStatus Status { get; }

    string AdditionalErrorMessage { get; }
  }
}
