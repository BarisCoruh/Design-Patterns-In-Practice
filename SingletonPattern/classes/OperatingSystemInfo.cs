public class OperatingSystemInfo
{
    private static OperatingSystemInfo _instance;

    private OperatingSystemInfo()
    {
        OSName = Environment.OSVersion.Platform.ToString();
        OSVersion = Environment.OSVersion.Version.ToString();
    }

    public static OperatingSystemInfo Instance
    {
        get
        {
            if (_instance == null)
                _instance = new OperatingSystemInfo();

            return _instance;
        }
    }

    public string OSName { get; private set; }
    public string OSVersion { get; private set; }
}