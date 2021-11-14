// Decompiled with JetBrains decompiler
// Type: Microsoft.Phone.Wallet.WalletAgent
// Assembly: Microsoft.Phone, Version=8.0.0.0, Culture=neutral, PublicKeyToken=24eec0d8c86cda1e
// MVID: 6F92089B-2722-49C2-83AA-CF419958F32D
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MIF409~1.DLL

using Microsoft.Phone.SecureElement;
using Microsoft.Phone.TaskModel.Interop;
using System;

namespace Microsoft.Phone.Wallet
{
  public abstract class WalletAgent : BackgroundAgent
  {
    protected WalletAgent() => this.RequestComplete += new AgentRequestCompleteEventHandler(this.AgentRequestCompleted);

    private WalletAgentOperation CurrentWalletAgentOperation { get; set; }

    private SecureElementItemActionEventArgs SecureElementItemActionEventArgs { get; set; }

    private UserActionEventArgs UserActionEventArgs { get; set; }

    private void CheckParameterProperty(
      ParameterProperty property,
      ParameterPropertyValueType type,
      string name)
    {
      if (property == null || property.ValueType != type)
        throw new ArgumentException("Invalid property in parameter prop bag", name);
    }

    private void AgentRequestCompleted(object sender, AgentRequestCompleteEventArgs args) => NativeWallet.FreeWallet();

    internal override void Invoke(Uri uri, ParameterPropertyBag parameters) => this.NotifyComplete();

    protected virtual void OnUserAction(UserActionEventArgs args) => this.NotifyComplete();

    protected virtual void OnSecureElementItemAction(SecureElementItemActionEventArgs args) => this.NotifyComplete();

    protected virtual void OnRefreshData(RefreshDataEventArgs args) => this.NotifyComplete();

    internal static class WalletPropertyNames
    {
      public static readonly string WalletItemIds = nameof (WalletItemIds);
      public static readonly string Operation = nameof (Operation);
      public static readonly string SEEventData = "Data";
    }
  }
}
