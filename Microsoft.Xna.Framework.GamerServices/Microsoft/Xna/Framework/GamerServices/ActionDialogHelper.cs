// Decompiled with JetBrains decompiler
// Type: Microsoft.Xna.Framework.GamerServices.ActionDialogHelper
// Assembly: Microsoft.Xna.Framework.GamerServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 4CE9CD1E-CFF0-4A29-B8E1-5772070CE886
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5CF0~1.DLL

using Microsoft.Phone;
using System;
using System.Text;
using System.Threading;

namespace Microsoft.Xna.Framework.GamerServices
{
  internal class ActionDialogHelper : IAsyncResult
  {
    protected EventWaitHandle asyncWaitHandle;
    private AsyncCallback _callback;
    internal static ActionDialogHelper ActiveActionDialog;

    public ActionDialogHelper(AsyncCallback callback, object state)
    {
      this.asyncWaitHandle = (EventWaitHandle) new ManualResetEvent(false);
      this.AsyncState = state;
      this._callback = callback;
      this.DialogHandle = uint.MaxValue;
    }

    public void ShowTextInput(
      string title,
      string description,
      string defaultText,
      bool usePasswordMode)
    {
      ActionDialogHelper.ActiveActionDialog = this;
      if (ActionDialogHelper.ShouldSuspendComplete)
        return;
      string resourceStringForCe1 = SafeNativeMethods.TryGetResourceStringForCE(10004);
      string resourceStringForCe2 = SafeNativeMethods.TryGetResourceStringForCE(10005);
      if (resourceStringForCe1 == null)
        FrameworkUIResources.GamerServicesOkButton.ToLower();
      if (resourceStringForCe2 == null)
        FrameworkUIResources.GamerServicesCancelButton.ToLower();
      this.DialogHandle = SafeNativeMethods.CreateTextInputDialog(title, description, defaultText, resourceStringForCe1, resourceStringForCe2, usePasswordMode);
      if (this.DialogHandle == uint.MaxValue)
        throw new Exception(FrameworkResources.InvalidNativeHandle);
      try
      {
        ThreadPool.QueueUserWorkItem(new WaitCallback(this.GetTextInputResult));
      }
      catch
      {
        this.Complete();
      }
    }

    private void GetTextInputResult(object state)
    {
      if (this.DialogHandle != uint.MaxValue)
      {
        try
        {
          GS_ActionDialogResult result;
          Helpers.ThrowExceptionFromResult(SafeNativeMethods.GetDialogResult(this.DialogHandle, out result));
          if (result.disReason == DismissedReason.ButtonPressed)
          {
            if (result.iButtonPressed == 0)
            {
              StringBuilder stringBuilder = new StringBuilder(result.cEditFieldLength + 1);
              Helpers.ThrowExceptionFromResult(SafeNativeMethods.GetDialogEditField(this.DialogHandle, stringBuilder, result.cEditFieldLength + 1));
              this.ResultText = stringBuilder.ToString();
            }
          }
        }
        catch
        {
        }
      }
      this.Complete();
    }

    public void ShowMessageBoxInput(
      string title,
      string text,
      string button1,
      string button2,
      MessageBoxIcon icon)
    {
      ActionDialogHelper.ActiveActionDialog = this;
      if (ActionDialogHelper.ShouldSuspendComplete)
        return;
      this.DialogHandle = SafeNativeMethods.CreateMessageBoxDialog(title, text, button1, button2, icon);
      if (this.DialogHandle == uint.MaxValue)
        throw new Exception(FrameworkResources.InvalidNativeHandle);
      try
      {
        ThreadPool.QueueUserWorkItem(new WaitCallback(this.GetMessageBoxResult));
      }
      catch
      {
        this.Complete();
      }
    }

    private void GetMessageBoxResult(object state)
    {
      if (this.DialogHandle != uint.MaxValue)
      {
        try
        {
          GS_ActionDialogResult result;
          Helpers.ThrowExceptionFromResult(SafeNativeMethods.GetDialogResult(this.DialogHandle, out result));
          if (result.disReason == DismissedReason.ButtonPressed)
            this.ResultButton = new int?(result.iButtonPressed);
        }
        catch
        {
        }
      }
      this.Complete();
    }

    public void Dismiss()
    {
      bool flag = false;
      if (this.DialogHandle != uint.MaxValue)
      {
        try
        {
          Helpers.ThrowExceptionFromResult(SafeNativeMethods.DismissDialog(this.DialogHandle));
          flag = true;
        }
        catch
        {
        }
      }
      if (flag)
        return;
      this.Complete();
    }

    public void Complete()
    {
      try
      {
        if (this.DialogHandle != uint.MaxValue)
        {
          int num = (int) SafeNativeMethods.ReleaseDialog(this.DialogHandle);
        }
      }
      finally
      {
        this.DialogHandle = uint.MaxValue;
        ActionDialogHelper.ActiveActionDialog = (ActionDialogHelper) null;
      }
      this.IsCompleted = true;
      this.asyncWaitHandle.Set();
      if (this._callback == null)
        return;
      this._callback((IAsyncResult) this);
    }

    private static bool ShouldSuspendComplete => QuirksMode.ShouldGuideDialogSuspendWhileAppIsInactive() && !SafeNativeMethods.CanOpenARD();

    public object AsyncState { get; private set; }

    public WaitHandle AsyncWaitHandle => (WaitHandle) this.asyncWaitHandle;

    public bool CompletedSynchronously => false;

    public bool IsCompleted { get; private set; }

    public string ResultText { get; private set; }

    public int? ResultButton { get; private set; }

    private uint DialogHandle { get; set; }
  }
}
