// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Maps.Services.QueryCompletedEventArgs`1
// Assembly: Microsoft.Phone.Maps, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: AD44C31E-8F11-44BE-ADAC-6B7D25A9892C
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIC25C~1.DLL

using System;
using System.ComponentModel;

namespace Microsoft.Phone.Maps.Services
{
  public sealed class QueryCompletedEventArgs<T> : AsyncCompletedEventArgs
  {
    private T result;

    internal QueryCompletedEventArgs(Exception error, bool cancelled, object userState, T result)
      : base(error, cancelled, userState)
    {
      this.Result = result;
    }

    public T Result
    {
      get
      {
        this.RaiseExceptionIfNecessary();
        return this.result;
      }
      private set => this.result = value;
    }
  }
}
