namespace LastSeenDemo.UnitTests;

public class OnlineDetector_UnitTests
{
    [Fact]
    public void CheckTheDetector_Detect()
    {
        OnlineDetector online_detector = new OnlineDetector(new DateTimeProvider());
        var uts = new List<UserTimeSpan>();
        uts.Add(new UserTimeSpan());
        var testment = online_detector.Detect(uts, new DateTimeOffset());
        Assert.True(testment);
    }
    
    [Fact]
    public void GetClosestOnlineTime_Returner()
    {
        OnlineDetector online_detector = new OnlineDetector(new DateTimeProvider());
        var uts = new List<UserTimeSpan>();
        uts.Add(new UserTimeSpan());
        var testment = online_detector.GetClosestOnlineTime(uts, new DateTimeOffset());
        Assert.NotNull(testment);
    }
    [Fact]
    public void CountOnline_Returner()
    {
        OnlineDetector online_detector = new OnlineDetector(new DateTimeProvider());
        var uts = new List<UserTimeSpan>();
        uts.Add(new UserTimeSpan());
        var dict = new Dictionary<Guid, List<UserTimeSpan>>();
        
        var testment = online_detector.CountOnline(dict, new DateTimeOffset());
        Assert.NotNull(testment);
    }
    [Fact]
    public void CountOnline_Returner_0()
    {
        OnlineDetector online_detector = new OnlineDetector(new DateTimeProvider());
        var uts = new List<UserTimeSpan>();
        uts.Add(new UserTimeSpan());
        var dict = new Dictionary<Guid, List<UserTimeSpan>>();
        
        var testment = online_detector.CountOnline(dict, new DateTimeOffset());
        Assert.Equal(0, testment);
    }
    [Fact]
    public void CalculateTotalTimeForUser_Returner_0()
    {
        OnlineDetector online_detector = new OnlineDetector(new DateTimeProvider());
        var uts = new List<UserTimeSpan>();
        uts.Add(new UserTimeSpan());
        var ttm = online_detector.CalculateTotalTimeForUser(uts);
        long tesment = Convert.ToInt64(ttm);
        long time = 63834616082/1000; //hardcoded
        Assert.Equal(time*uts.Count, tesment/1000);
    }
    
    [Fact]
    public void CalculateDailyAverageForUser_Returner_0()
    {
        OnlineDetector online_detector = new OnlineDetector(new DateTimeProvider());
        var uts = new List<UserTimeSpan>();
        uts.Add(new UserTimeSpan());
        uts[0].Login = DateTimeOffset.Now.AddHours(-2);
        uts[0].Login = DateTimeOffset.Now.AddHours(-1);
        var ttm = online_detector.CalculateDailyAverageForUser(uts);
        long tesment = Convert.ToInt64(ttm);
        Assert.Equal(3600, tesment);
    }
}
