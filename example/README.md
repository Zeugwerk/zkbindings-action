# Example

This folder shows the code, which is generated for the Quickstart Tutorial of the [Zeugwerk Development Kit](https://doc.zeugwerk.dev/).

The generated C# code can be used like this:

```cs
_ads = new TcAdsClient();
_ads.Connect(851);

// bind _quickstart to the PLC
_quickstart = new PLC.Mirror.QuickstartCom("ZGlobal.Com.Unit.Quickstart", _ads);

// synchronously write a struct to the PLC
_quickstart.Subscribe.Equipment.LimitSwitchLeft.Sync = new PLC.Types.ZApplication_DigitalComSubscribe { Enable = 0, Write = 1 };	
```

Note that all types of the PLC are available can be written to and read from in a type-safe way. Variable names as strings are only needed to bind to a root object.
