// Decompiled with JetBrains decompiler
// Type: Windows.Services.Store.StoreSendRequestResult
// Assembly: Windows, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null, ContentType=WindowsRuntime
// MVID: 806AFA92-BECA-4A21-B50F-752CC54B3430
// Assembly location: C:\Users\Empyreal96\Desktop\Windows 10 Mobile\winmd\Windows.WinMD

using System.Runtime.CompilerServices;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.Web.Http;

namespace Windows.Services.Store
{
  [ContractVersion(typeof (StoreContract), 65536)]
  [Threading(ThreadingModel.Both)]
  [MarshalingBehavior(MarshalingType.Agile)]
  public sealed class StoreSendRequestResult : IStoreSendRequestResult, IStoreSendRequestResult2
  {
    public extern string Response { [MethodImpl] get; }

    public extern HResult ExtendedError { [MethodImpl] get; }

    public extern HttpStatusCode HttpStatusCode { [MethodImpl] get; }
  }
}
