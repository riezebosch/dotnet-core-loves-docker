### cross framework compatible
```xml
<TargetFrameworks>netstandard2.0;net35</TargetFrameworks>
```

```cs
#if NET35
    [System.Serializable]
#endif
```