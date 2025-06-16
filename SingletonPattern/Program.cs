

var osInfo1 = OperatingSystemInfo.Instance;
var osInfo2 = OperatingSystemInfo.Instance;

Console.WriteLine($"Operating System: {osInfo1.OSName}");
Console.WriteLine($"Version: {osInfo1.OSVersion}");

Console.WriteLine(object.ReferenceEquals(osInfo1, osInfo2));
