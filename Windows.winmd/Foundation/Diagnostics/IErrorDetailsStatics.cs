// Decompiled with JetBrains decompiler
// Type: Windows.Foundation.Diagnostics.IErrorDetailsStatics
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using Windows.Foundation.Metadata;

namespace Windows.Foundation.Diagnostics
{
  [Guid(3077584720, 2845, 18120, 170, 14, 75, 129, 120, 228, 252, 233)]
  [ContractVersion(typeof (UniversalApiContract), 65536)]
  [ExclusiveTo(typeof (ErrorDetails))]
  internal interface IErrorDetailsStatics
  {
    [RemoteAsync]
    IAsyncOperation<ErrorDetails> CreateFromHResultAsync(int errorCode);
  }
}
