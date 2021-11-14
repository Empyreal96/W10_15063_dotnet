// Decompiled with JetBrains decompiler
// Type: System.Data.StrongTypingException
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

namespace System.Data
{
  public class StrongTypingException : DataException
  {
    private const int StrongTyping = -2146232021;

    public StrongTypingException() => this.HResult = -2146232021;

    public StrongTypingException(string message)
      : base(message)
    {
      this.HResult = -2146232021;
    }

    public StrongTypingException(string s, Exception innerException)
      : base(s, innerException)
    {
      this.HResult = -2146232021;
    }
  }
}
