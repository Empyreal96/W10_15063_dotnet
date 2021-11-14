// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.BackgroundAudio.BackgroundAudioHelper
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Microsoft.Phone.BackgroundAudio
{
  internal class BackgroundAudioHelper
  {
    internal const int S_OK = 0;
    internal const int E_FAIL = -2147467259;
    internal const int E_INVALIDARG = -2147024890;
    internal const int E_OUTOFMEMORY = -2147024882;
    internal const int CO_E_APPNOTFOUND = -2147221003;
    internal const int ZERROR_E_NOCURRENTITEM = -2143682429;
    internal const int ZERROR_E_QUEUE_NOT_ALLOCATED = -2143682351;
    internal const int ZERROR_E_TOO_MANY_CLIENT_QUEUES = -2143682352;

    internal static Exception GetExceptionForHR(int hr, COMException originalException)
    {
      Exception exception;
      switch (hr)
      {
        case -2147467259:
          exception = (Exception) new InvalidOperationException("E_FAIL", (Exception) originalException);
          break;
        case -2147221003:
          exception = (Exception) new InvalidOperationException("Background agent could not be found; ensure it is correctly registered", (Exception) originalException);
          break;
        case -2147024890:
          exception = (Exception) new ArgumentException("E_INVALIDARG", (Exception) originalException);
          break;
        case -2147024882:
          exception = (Exception) new OutOfMemoryException("E_OUTOFMEMORY", (Exception) originalException);
          break;
        case -2143682352:
        case -2143682351:
          exception = (Exception) new InvalidOperationException("The background audio resources are no longer available.", (Exception) originalException);
          break;
        default:
          StringBuilder stringBuilder = new StringBuilder("HRESULT = ");
          stringBuilder.AppendFormat("0x{0}", (object) hr.ToString("X8"));
          exception = (Exception) new SystemException(stringBuilder.ToString(), (Exception) originalException);
          break;
      }
      return exception;
    }
  }
}
