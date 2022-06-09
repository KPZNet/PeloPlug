namespace WorkOutListNames;

public class WorkOutListClass
{
    public Datum[] data { get; set; }
    public int limit { get; set; }
    public int page { get; set; }
    public int total { get; set; }
    public int count { get; set; }
    public int page_count { get; set; }
    public bool show_previous { get; set; }
    public bool show_next { get; set; }
    public string sort_by { get; set; }
    public Next next { get; set; }
    public object[] aggregate_stats { get; set; }
    public Total_Heart_Rate_Zone_Durations total_heart_rate_zone_durations { get; set; }
}

public class Next
{
    public string workout_id { get; set; }
    public int created_at { get; set; }
}

public class Total_Heart_Rate_Zone_Durations
{
    public int heart_rate_z1_duration { get; set; }
    public int heart_rate_z2_duration { get; set; }
    public int heart_rate_z3_duration { get; set; }
    public int heart_rate_z4_duration { get; set; }
    public int heart_rate_z5_duration { get; set; }
}

public class Datum
{
    public int created_at { get; set; }
    public string device_type { get; set; }
    public int end_time { get; set; }
    public string fitness_discipline { get; set; }
    public bool has_pedaling_metrics { get; set; }
    public bool has_leaderboard_metrics { get; set; }
    public string id { get; set; }
    public bool is_total_work_personal_record { get; set; }
    public bool is_outdoor { get; set; }
    public string metrics_type { get; set; }
    public string name { get; set; }
    public string peloton_id { get; set; }
    public string platform { get; set; }
    public int start_time { get; set; }
    public string status { get; set; }
    public string timezone { get; set; }
    public object title { get; set; }
    public float total_work { get; set; }
    public string user_id { get; set; }
    public string workout_type { get; set; }
    public int total_video_watch_time_seconds { get; set; }
    public int total_video_buffering_seconds { get; set; }
    public int v2_total_video_watch_time_seconds { get; set; }
    public int v2_total_video_buffering_seconds { get; set; }
    public object total_music_audio_play_seconds { get; set; }
    public object total_music_audio_buffer_seconds { get; set; }
    public Ride ride { get; set; }
    public int created { get; set; }
    public int device_time_created_at { get; set; }
    public object strava_id { get; set; }
    public object fitbit_id { get; set; }
    public Effort_Zones effort_zones { get; set; }
    public object service_id { get; set; }
}

public class Ride
{
    public bool has_closed_captions { get; set; }
    public string content_provider { get; set; }
    public string content_format { get; set; }
    public string description { get; set; }
    public float difficulty_rating_avg { get; set; }
    public int difficulty_rating_count { get; set; }
    public object difficulty_level { get; set; }
    public object distance { get; set; }
    public object distance_display_value { get; set; }
    public object distance_unit { get; set; }
    public int duration { get; set; }
    public float dynamic_video_recorded_speed_in_mph { get; set; }
    public object[] extra_images { get; set; }
    public string fitness_discipline { get; set; }
    public string fitness_discipline_display_name { get; set; }
    public bool has_pedaling_metrics { get; set; }
    public string home_peloton_id { get; set; }
    public string id { get; set; }
    public string image_url { get; set; }
    public string instructor_id { get; set; }
    public bool is_archived { get; set; }
    public bool is_closed_caption_shown { get; set; }
    public bool is_dynamic_video_eligible { get; set; }
    public bool is_explicit { get; set; }
    public bool is_fixed_distance { get; set; }
    public bool is_live_in_studio_only { get; set; }
    public string language { get; set; }
    public int length { get; set; }
    public string live_stream_id { get; set; }
    public object live_stream_url { get; set; }
    public string location { get; set; }
    public string[] metrics { get; set; }
    public string origin_locale { get; set; }
    public int original_air_time { get; set; }
    public float overall_rating_avg { get; set; }
    public int overall_rating_count { get; set; }
    public int pedaling_start_offset { get; set; }
    public int pedaling_end_offset { get; set; }
    public int pedaling_duration { get; set; }
    public int rating { get; set; }
    public string ride_type_id { get; set; }
    public string[] ride_type_ids { get; set; }
    public object sample_vod_stream_url { get; set; }
    public object sample_preview_stream_url { get; set; }
    public int scheduled_start_time { get; set; }
    public string series_id { get; set; }
    public bool sold_out { get; set; }
    public string studio_peloton_id { get; set; }
    public string title { get; set; }
    public int total_ratings { get; set; }
    public int total_in_progress_workouts { get; set; }
    public int total_workouts { get; set; }
    public string vod_stream_url { get; set; }
    public string vod_stream_id { get; set; }
    public string[] class_type_ids { get; set; }
    public float difficulty_estimate { get; set; }
    public float overall_estimate { get; set; }
    public Availability availability { get; set; }
    public int explicit_rating { get; set; }
    public object[] flags { get; set; }
}

public class Availability
{
    public bool is_available { get; set; }
    public object reason { get; set; }
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