// Decompiled with JetBrains decompiler
// Type: Windows.ApplicationModel.DataTransfer.IOperationCompletedEventArgs2
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Metadata;

namespace Windows.ApplicationModel.DataTransfer
{
  [ContractVersion(typeof (UniversalApiContract), 131072)]
  [ExclusiveTo(typeof (OperationCompletedEventArgs))]
  [Guid(2240782451, 7705, 16645, 178, 247, 200, 71, 136, 8, 213, 98)]
  internal interface IOperationCompletedEventArgs2
  {
    string AcceptedFormatId { get; }
  }
}
