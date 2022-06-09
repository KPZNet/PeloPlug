namespace WorkOutEventNames;

public class WorkOutEventClass
{
    public Ride ride { get; set; }
    public Class_Types[] class_types { get; set; }
    public Playlist playlist { get; set; }
    public Averages averages { get; set; }
    public Segments segments { get; set; }
    public Default_Album_Images default_album_images { get; set; }
    public object[] excluded_platforms { get; set; }
    public bool is_ftp_test { get; set; }
    public Disabled_Leaderboard_Filters disabled_leaderboard_filters { get; set; }
    public object sampled_top_tags { get; set; }
    public Instructor_Cues[] instructor_cues { get; set; }
    public Target_Class_Metrics target_class_metrics { get; set; }
    public Target_Metrics_Data target_metrics_data { get; set; }
    public Events events { get; set; }
    public Related_Rides related_rides { get; set; }
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
    public string vod_stream_url { get; set; }
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
    public Instructor instructor { get; set; }
    public Muscle_Group_Score[] muscle_group_score { get; set; }
    public bool is_favorite { get; set; }
    public int total_user_workouts { get; set; }
    public int total_following_workouts { get; set; }
    public object leaderboard_filter_type { get; set; }
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

public class Instructor
{
    public string id { get; set; }
    public string bio { get; set; }
    public string short_bio { get; set; }
    public string coach_type { get; set; }
    public bool is_filterable { get; set; }
    public bool is_instructor_group { get; set; }
    public bool is_visible { get; set; }
    public bool is_announced { get; set; }
    public int list_order { get; set; }
    public bool featured_profile { get; set; }
    public string film_link { get; set; }
    public string facebook_fan_page { get; set; }
    public string music_bio { get; set; }
    public string spotify_playlist_uri { get; set; }
    public string background { get; set; }
    public string[][] ordered_q_and_as { get; set; }
    public string instagram_profile { get; set; }
    public string strava_profile { get; set; }
    public string twitter_profile { get; set; }
    public string quote { get; set; }
    public string username { get; set; }
    public string name { get; set; }
    public string first_name { get; set; }
    public string last_name { get; set; }
    public string user_id { get; set; }
    public string life_style_image_url { get; set; }
    public object bike_instructor_list_display_image_url { get; set; }
    public string web_instructor_list_display_image_url { get; set; }
    public string ios_instructor_list_display_image_url { get; set; }
    public string about_image_url { get; set; }
    public string image_url { get; set; }
    public object jumbotron_url { get; set; }
    public string jumbotron_url_dark { get; set; }
    public string jumbotron_url_ios { get; set; }
    public object web_instructor_list_gif_image_url { get; set; }
    public string instructor_hero_image_url { get; set; }
    public Workout_Share_Images[] workout_share_images { get; set; }
    public string[] fitness_disciplines { get; set; }
}

public class Workout_Share_Images
{
    public string fitness_discipline { get; set; }
    public string image_url { get; set; }
}

public class Muscle_Group_Score
{
    public string muscle_group { get; set; }
    public float score { get; set; }
    public int percentage { get; set; }
    public int bucket { get; set; }
    public string display_name { get; set; }
}

public class Playlist
{
    public string id { get; set; }
    public string ride_id { get; set; }
    public Song[] songs { get; set; }
    public bool is_top_artists_shown { get; set; }
    public bool is_playlist_shown { get; set; }
    public bool is_in_class_music_shown { get; set; }
    public Top_Artists[] top_artists { get; set; }
    public Top_Albums[] top_albums { get; set; }
    public string stream_id { get; set; }
    public object stream_url { get; set; }
}

public class Song
{
    public string id { get; set; }
    public string title { get; set; }
    public Artist[] artists { get; set; }
    public Album album { get; set; }
    public int explicit_rating { get; set; }
    public int cue_time_offset { get; set; }
    public int start_time_offset { get; set; }
    public bool liked { get; set; }
}

public class Album
{
    public string id { get; set; }
    public string image_url { get; set; }
    public string name { get; set; }
}

public class Artist
{
    public string artist_id { get; set; }
    public string artist_name { get; set; }
}

public class Top_Artists
{
    public string artist_id { get; set; }
    public string artist_name { get; set; }
}

public class Top_Albums
{
    public string id { get; set; }
    public string image_url { get; set; }
    public string name { get; set; }
}

public class Averages
{
    public int average_total_work { get; set; }
    public float average_distance { get; set; }
    public int average_calories { get; set; }
    public int average_avg_power { get; set; }
    public float average_avg_speed { get; set; }
    public int average_avg_cadence { get; set; }
    public int average_avg_resistance { get; set; }
    public float average_effort_score { get; set; }
    public Total_Heart_Rate_Zone_Durations total_heart_rate_zone_durations { get; set; }
}

public class Total_Heart_Rate_Zone_Durations
{
    public int heart_rate_z1_duration { get; set; }
    public int heart_rate_z2_duration { get; set; }
    public int heart_rate_z3_duration { get; set; }
    public int heart_rate_z4_duration { get; set; }
    public int heart_rate_z5_duration { get; set; }
}

public class Segments
{
    public Segment_List[] segment_list { get; set; }
    public Segment_Category_Distribution segment_category_distribution { get; set; }
    public Segment_Body_Focus_Distribution segment_body_focus_distribution { get; set; }
}

public class Segment_Category_Distribution
{
    public string CyclingWarmup { get; set; }
    public string cycling { get; set; }
    public string CyclingCoolDown { get; set; }
}

public class Segment_Body_Focus_Distribution
{
    public string cardio { get; set; }
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
    public Subsegments_V2[] subsegments_v2 { get; set; }
    public bool is_transition { get; set; }
}

public class Subsegments_V2
{
    public string id { get; set; }
    public string type { get; set; }
    public string display_name { get; set; }
    public int scheduled_offset { get; set; }
    public int offset { get; set; }
    public int length { get; set; }
    public object rounds { get; set; }
    public bool trackable_movements_disabled { get; set; }
    public Movement[] movements { get; set; }
}

public class Movement
{
    public string id { get; set; }
    public string name { get; set; }
    public object note { get; set; }
    public object slug { get; set; }
    public string skill_level { get; set; }
    public Muscle_Groups[] muscle_groups { get; set; }
    public object short_video_url { get; set; }
    public object long_video_url { get; set; }
    public object[] movement_videos { get; set; }
    public object image_url { get; set; }
    public string talkback_description { get; set; }
}

public class Muscle_Groups
{
    public string muscle_group { get; set; }
    public string display_name { get; set; }
    public int ranking { get; set; }
}

public class Default_Album_Images
{
    public string default_in_class_image_url { get; set; }
    public string default_class_detail_image_url { get; set; }
}

public class Disabled_Leaderboard_Filters
{
    public bool just_me { get; set; }
    public bool age_and_gender { get; set; }
    public bool following { get; set; }
}

public class Target_Class_Metrics
{
    public Target_Graph_Metrics[] target_graph_metrics { get; set; }
    public Total_Expected_Output total_expected_output { get; set; }
}

public class Total_Expected_Output
{
    public int expected_upper_output { get; set; }
    public int expected_lower_output { get; set; }
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

public class Target_Metrics_Data
{
    public Target_Metrics[] target_metrics { get; set; }
    public Total_Expected_Output1 total_expected_output { get; set; }
}

public class Total_Expected_Output1
{
    public int expected_upper_output { get; set; }
    public int expected_lower_output { get; set; }
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

public class Events
{
    public object[] data { get; set; }
}

public class Related_Rides
{
    public string id { get; set; }
    public string name { get; set; }
    public string display_name { get; set; }
    public Ride1[] rides { get; set; }
}

public class Ride1
{
    public string fitness_discipline { get; set; }
    public string content_provider { get; set; }
    public string title { get; set; }
    public string instructor_id { get; set; }
    public string id { get; set; }
    public string image_url { get; set; }
    public string language { get; set; }
    public string origin_locale { get; set; }
    public int original_air_time { get; set; }
    public int scheduled_start_time { get; set; }
}

public class Class_Types
{
    public string id { get; set; }
    public string name { get; set; }
}

public class Instructor_Cues
{
    public Offsets1 offsets { get; set; }
    public Resistance_Range resistance_range { get; set; }
    public Cadence_Range cadence_range { get; set; }
}

public class Offsets1
{
    public int start { get; set; }
    public int end { get; set; }
}

public class Resistance_Range
{
    public int upper { get; set; }
    public int lower { get; set; }
}

public class Cadence_Range
{
    public int upper { get; set; }
    public int lower { get; set; }
}