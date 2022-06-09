namespace WorkOutDetailsNames;

public class WorkOutDetailsClass
{
    public int duration { get; set; }
    public bool is_class_plan_shown { get; set; }
    public Segment_List[] segment_list { get; set; }
    public int[] seconds_since_pedaling_start { get; set; }
    public Average_Summaries[] average_summaries { get; set; }
    public Summary[] summaries { get; set; }
    public Metric1[] metrics { get; set; }
    public bool has_apple_watch_metrics { get; set; }
    public object[] location_data { get; set; }
    public object is_location_data_accurate { get; set; }
    public Splits_Data splits_data { get; set; }
    public Splits_Metrics splits_metrics { get; set; }
    public Target_Performance_Metrics target_performance_metrics { get; set; }
    public Target_Metrics_Performance_Data target_metrics_performance_data { get; set; }
    public Effort_Zones effort_zones { get; set; }
    public Muscle_Group_Score[] muscle_group_score { get; set; }
}

public class Splits_Data
{
    public string distance_marker_display_unit { get; set; }
    public string elevation_change_display_unit { get; set; }
    public Split[] splits { get; set; }
}

public class Split
{
    public float distance_marker { get; set; }
    public int order { get; set; }
    public float seconds { get; set; }
    public object elevation_change { get; set; }
    public bool is_best { get; set; }
}

public class Splits_Metrics
{
}

public class Target_Performance_Metrics
{
    public Target_Graph_Metrics[] target_graph_metrics { get; set; }
    public int cadence_time_in_range { get; set; }
    public int resistance_time_in_range { get; set; }
}

public class Target_Graph_Metrics
{
    public Graph_Data graph_data { get; set; }
    public int max { get; set; }
    public int min { get; set; }
    public int average { get; set; }
    public string type { get; set; }
}

public class Graph_Data
{
    public int[] upper { get; set; }
    public int[] lower { get; set; }
    public int[] average { get; set; }
}

public class Target_Metrics_Performance_Data
{
    public Target_Metrics[] target_metrics { get; set; }
    public Time_In_Metric[] time_in_metric { get; set; }
}

public class Target_Metrics
{
    public Offsets offsets { get; set; }
    public string segment_type { get; set; }
    public Metric[] metrics { get; set; }
}

public class Offsets
{
    public int start { get; set; }
    public int end { get; set; }
}

public class Metric
{
    public string name { get; set; }
    public float upper { get; set; }
    public float lower { get; set; }
}

public class Time_In_Metric
{
    public string name { get; set; }
    public int value { get; set; }
}

public class Effort_Zones
{
    public float total_effort_points { get; set; }
    public Heart_Rate_Zone_Durations heart_rate_zone_durations { get; set; }
}

public class Heart_Rate_Zone_Durations
{
    public int heart_rate_z1_duration { get; set; }
    public int heart_rate_z2_duration { get; set; }
    public int heart_rate_z3_duration { get; set; }
    public int heart_rate_z4_duration { get; set; }
    public int heart_rate_z5_duration { get; set; }
}

public class Segment_List
{
    public string id { get; set; }
    public int length { get; set; }
    public int start_time_offset { get; set; }
    public string icon_url { get; set; }
    public float intensity_in_mets { get; set; }
    public string metrics_type { get; set; }
    public string icon_name { get; set; }
    public string icon_slug { get; set; }
    public string name { get; set; }
    public bool is_drill { get; set; }
}

public class Average_Summaries
{
    public string display_name { get; set; }
    public string display_unit { get; set; }
    public float value { get; set; }
    public string slug { get; set; }
}

public class Summary
{
    public string display_name { get; set; }
    public string display_unit { get; set; }
    public float value { get; set; }
    public string slug { get; set; }
}

public class Metric1
{
    public string display_name { get; set; }
    public string display_unit { get; set; }
    public float max_value { get; set; }
    public float average_value { get; set; }
    public float[] values { get; set; }
    public string slug { get; set; }
    public Zone[] zones { get; set; }
    public int missing_data_duration { get; set; }
}

public class Zone
{
    public string display_name { get; set; }
    public string slug { get; set; }
    public string range { get; set; }
    public int duration { get; set; }
    public int max_value { get; set; }
    public int min_value { get; set; }
}

public class Muscle_Group_Score
{
    public string muscle_group { get; set; }
    public float score { get; set; }
    public int percentage { get; set; }
    public int bucket { get; set; }
    public string display_name { get; set; }
}