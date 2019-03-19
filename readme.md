[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](LICENSE)

[![NuGet](https://img.shields.io/nuget/v/GeekyMonkey.TwoFactorAuthNetSkiaSharpQrProvider.svg?label=TwoFactorAuthNetSkiaSharpQrProvider%20nuget)](https://www.nuget.org/packages/SkiaSharp.QrCode)

# SkiaSharp QR Code Provider for TwoFactorAuth.Net

## :question: Purpose

A QR Code provider for [TwoFactorAuth.Net](https://github.com/RobThree/TwoFactorAuth.Net) that has no external API dependency. The image is generated on your own server. Also no dependency on System.Drawing to avoid installation issues with Linux.

---
## :point_down: Download

The project is published to [NuGet](https://www.nuget.org/packages/GeekyMonkey.TwoFactorAuthNetSkiaSharpQrProvider/)

---
## :small_blue_diamond: Compatability

* NET Standard
* NET Core

### Dependencies
* [TwoFactorAuth.Net](https://github.com/RobThree/TwoFactorAuth.Net) (>= 1.3.4)
* SkiaSharp (>= 1.68.0)
* SkiaSharp.QrCode (>= 0.3.1)

---
## :heavy_check_mark: Instructions

Instantiate your TwoFactorAuth

```cs
  var myTwoFactorAuth = new TwoFactorAuth(appTitle, qrcodeprovider: new SkiaSharpQrCodeProvider());
```

---
## :raising_hand: Contact

* Got a problem or suggestion? Use the [Issues](https://github.com/GeekyMonkey/TwoFactorAuthNetSkiaSharpQrProvider/issues) feature to let me know.
* Feel like your own code changes would be helpful? Issue a [Pull Request](https://github.com/GeekyMonkey/TwoFactorAuthNetSkiaSharpQrProvider/pulls).
* Did I save you some time? Feeling thankfull? Go on, [buy me a beer. :beer:](http://geekymonkey.azurewebsites.net/Home/Contact)
<form action="https://www.paypal.com/cgi-bin/webscr" method="post" target="_top" style="margin-left:30px">
<input type="hidden" name="cmd" value="_s-xclick">
<input type="hidden" name="hosted_button_id" value="LB9723JHYDXV4">
<input type="image" src="https://www.paypalobjects.com/en_US/i/btn/btn_donate_SM.gif" border="0" name="submit" alt="PayPal - The safer, easier way to pay online!">
<img alt="" border="0" src="https://www.paypalobjects.com/en_US/i/scr/pixel.gif" width="1" height="1">
</form>
