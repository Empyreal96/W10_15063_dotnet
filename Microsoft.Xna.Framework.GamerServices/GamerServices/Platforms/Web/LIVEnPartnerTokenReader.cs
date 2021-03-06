// Decompiled with JetBrains decompiler
// Type: GamerServices.Platforms.Web.LIVEnPartnerTokenReader
// Assembly: Microsoft.Xna.Framework.GamerServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=842cf8be1de50553
// MVID: 4CE9CD1E-CFF0-4A29-B8E1-5772070CE886
// Assembly location: C:\Users\Empyreal96\Desktop\WINDOW~1\100~1.150\MICROS~2.CBS\ARM_MI~1.297\windows\System32\MI5CF0~1.DLL

namespace GamerServices.Platforms.Web
{
  internal class LIVEnPartnerTokenReader : LIVEnTask
  {
    private string audienceUri;

    public string Token { get; private set; }

    public LIVEnPartnerTokenReader(string audienceUri) => this.audienceUri = audienceUri;

    public override void Do() => this.Token = this.webService.GetTokenString(this.audienceUri);
  }
}
