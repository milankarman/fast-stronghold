using IniParser;
using IniParser.Model;

public static class Config
{
    public static bool WriteOutputToFile { private set; get; }
    public static bool ShowNetherTravelSuggestion { private set; get; }
    public static bool AlwaysOnTop { private set; get; }
    public static bool ApplyX4Z4Rule { private set; get; }

    public static void Initialize()
    {
        FileIniDataParser parser = new FileIniDataParser();
        IniData data = parser.ReadFile("config.ini");

        WriteOutputToFile = bool.Parse(data["Settings"]["write_output_to_file"]);
        ShowNetherTravelSuggestion = bool.Parse(data["Settings"]["show_nether_travel_suggestion"]);
        AlwaysOnTop = bool.Parse(data["Settings"]["always_on_top"]);
        ApplyX4Z4Rule = bool.Parse(data["Settings"]["apply_x4_z4_rule"]);
    }
}