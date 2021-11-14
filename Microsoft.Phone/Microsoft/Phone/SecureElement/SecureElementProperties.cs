// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.SecureElement.SecureElementProperties
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.Wallet;
using System;

namespace Microsoft.Phone.SecureElement
{
  public class SecureElementProperties
  {
    internal SecureElementProperties(WalletItem owneritem)
    {
    }

    public SecureElementProperties.AppletState LastKnownAppletState => throw new NotImplementedException();

    public byte[] AppletId => throw new NotImplementedException();

    public byte[] ServiceId => throw new NotImplementedException();

    public bool ActivationRequiresAuthentication
    {
      get => throw new NotImplementedException();
      set => throw new NotImplementedException();
    }

    public enum AppletState
    {
      None,
      Init,
      Deactivated,
      Activated,
      Locked,
    }
  }
}
