### cross framework compatible
```xml
<TargetFrameworks>netstandard2.0;net35</TargetFrameworks>
```

framework compatible code
```cs
#if NET35
    [System.Serializable]
#endif
```