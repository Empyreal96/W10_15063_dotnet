// Decompiled with JetBrains decompiler
// Type: Windows.System.IProtocolForResultsOperation
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;

namespace Windows.System
{
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ProtocolForResultsOperation))]
  [Guid(3582011706, 28137, 19752, 147, 120, 248, 103, 130, 225, 130, 187)]
  internal interface IProtocolForResultsOperation
  {
    void ReportCompleted(ValueSet data);
  }
}
