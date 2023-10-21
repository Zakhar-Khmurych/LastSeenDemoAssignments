﻿namespace LastSeenDemo;

public class Assignment5
{
    
}

public class ReportPiece
{
    
}

public class Report
{
    //List<string> metrics = new List<string>() { "dailyAverage", "weeklyAverage", "total", "min", "max"};
    private Assignment4Features useful_stuff_returner = new Assignment4Features();

    public Dictionary<Guid, List<string>> ReturnDesiredInfo(List<string> metrics, List<Guid> user_id_s)
    {
        List<string> output_piece = new List<string>();
        Dictionary<Guid, List<string>> output = new Dictionary<Guid, List<string>>();

        foreach (var user in user_id_s)
        {
            output.Add(user, new List<string>());
        }
        
        if (metrics.Contains("dailyAverage"))
        {
            foreach (var user in user_id_s)
            {
                var daily_time = useful_stuff_returner.ReturnAverageTime(user, new List<UserTimeSpan>()).Daily_Time;
                output[user].Add(daily_time.ToString());
            }
        }
        if (metrics.Contains("weeklyAverage"))
        {
            foreach (var user in user_id_s)
            {
                var weekly_time = useful_stuff_returner.ReturnAverageTime(user, new List<UserTimeSpan>()).Weekly_Time;
                output[user].Add(weekly_time.ToString());
            }
        }
        if (metrics.Contains("total"))
        {
            foreach (var user in user_id_s)
            {
                var total_time = useful_stuff_returner.ReturnTotalTimeOnline(user, new List<UserTimeSpan>());
                output[user].Add(total_time.ToString());
            }
        }
        if (metrics.Contains("min"))
        {
            foreach (var user in user_id_s)
            {
                
            }
        }
        if (metrics.Contains("max"))
        {
            foreach (var user in user_id_s)
            {
                
            }
        }

        return output;
    }


}
