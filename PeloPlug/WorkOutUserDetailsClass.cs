namespace WorkOutUserDetailsNames;

public class WorkOutUserDetailsClass
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
    public int created { get; set; }
    public int device_time_created_at { get; set; }
    public object strava_id { get; set; }
    public object fitbit_id { get; set; }
    public object service_id { get; set; }
    public bool is_skip_intro_available { get; set; }
    public bool has_paused { get; set; }
    public bool is_pause_available { get; set; }
    public float pause_time_limit { get; set; }
    public object pause_time_elapsed { get; set; }
    public bool is_paused { get; set; }
    public Ride ride { get; set; }
    public Total_Heart_Rate_Zone_Durations total_heart_rate_zone_durations { get; set; }
    public float average_effort_score { get; set; }
    public Achievement_Templates[] achievement_templates { get; set; }
    public int leaderboard_rank { get; set; }
    public int total_leaderboard_users { get; set; }
    public Ftp_Info ftp_info { get; set; }
    public string device_type_display_name { get; set; }
}

public class Ride
{
    public Availability availability { get; set; }
    public string[] class_type_ids { get; set; }
    public string content_provider { get; set; }
    public string content_format { get; set; }
    public string description { get; set; }
    public float difficulty_estimate { get; set; }
    public float overall_estimate { get; set; }
    public float difficulty_rating_avg { get; set; }
    public int difficulty_rating_count { get; set; }
    public object difficulty_level { get; set; }
    public int duration { get; set; }
    public object[] equipment_ids { get; set; }
    public object[] equipment_tags { get; set; }
    public int explicit_rating { get; set; }
    public object[] extra_images { get; set; }
    public string fitness_discipline { get; set; }
    public string fitness_discipline_display_name { get; set; }
    public bool has_closed_captions { get; set; }
    public bool has_pedaling_metrics { get; set; }
    public string home_peloton_id { get; set; }
    public string id { get; set; }
    public string image_url { get; set; }
    public string instructor_id { get; set; }
    public object[] individual_instructor_ids { get; set; }
    public bool is_archived { get; set; }
    public bool is_closed_caption_shown { get; set; }
    public bool is_explicit { get; set; }
    public bool has_free_mode { get; set; }
    public bool is_live_in_studio_only { get; set; }
    public string language { get; set; }
    public string origin_locale { get; set; }
    public int length { get; set; }
    public string live_stream_id { get; set; }
    public object live_stream_url { get; set; }
    public string location { get; set; }
    public string[] metrics { get; set; }
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
    public object vod_stream_url { get; set; }
    public string vod_stream_id { get; set; }
    public string[] captions { get; set; }
    public Join_Tokens join_tokens { get; set; }
    public object[] flags { get; set; }
    public bool is_dynamic_video_eligible { get; set; }
    public bool is_fixed_distance { get; set; }
    public float dynamic_video_recorded_speed_in_mph { get; set; }
    public object thumbnail_title { get; set; }
    public object thumbnail_location { get; set; }
    public object distance { get; set; }
    public object distance_unit { get; set; }
    public object distance_display_value { get; set; }
    public object[] excluded_platforms { get; set; }
    public float class_avg_follow_along_score { get; set; }
    public Muscle_Group_Score[] muscle_group_score { get; set; }
}

public class Availability
{
    public bool is_available { get; set; }
    public object reason { get; set; }
}

public class Join_Tokens
{
    public string on_demand { get; set; }
}

public class Muscle_Group_Score
{
    public string muscle_group { get; set; }
    public float score { get; set; }
    public int percentage { get; set; }
    public int bucket { get; set; }
    public string display_name { get; set; }
}

public class Total_Heart_Rate_Zone_Durations
{
    public int heart_rate_z1_duration { get; set; }
    public int heart_rate_z2_duration { get; set; }
    public int heart_rate_z3_duration { get; set; }
    public int heart_rate_z4_duration { get; set; }
    public int heart_rate_z5_duration { get; set; }
}

public class Ftp_Info
{
    public int ftp { get; set; }
    public string ftp_source { get; set; }
    public object ftp_workout_id { get; set; }
}

public class Achievement_Templates
{
    public string id { get; set; }
    public string name { get; set; }
    public string slug { get; set; }
    public string image_url { get; set; }
    public string description { get; set; }
    public int achievement_count { get; set; }
}