namespace downloader;
using System.Diagnostics;
using System.Windows.Forms;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    Check validate = new Check();
    Random random = new Random();

    string dlPath = @"./dlp.exe";
    string command;
    string url;
    string download_path;
    string filename;

    /// <summary>
    /// Download video using the given URL.
    /// </summary>
    private void Download(object sender, EventArgs e)
    {
        filename = Check.ReplaceSpaceTo_(custom_filename.Text);
        url = youtube_url.Text;
        download_path = path.Text;

        if (url.Length > 0 && download_path.Length > 0)
        {
            if (validate.IsValidPath(download_path))
            {
                if (youtubeID.Checked && url.Contains("https://www.youtube.com/watch?v=")) filename = url.Replace("https://www.youtube.com/watch?v=", "").ToString();
                if (RandomID.Checked) filename = random.Next(1000000).ToString();

                if (YoutubeTitle.Checked && mp3_checkbox.Checked) Process.Start(dlPath, $"{url}" + command + $" -P \"{download_path}\" -x --audio-format mp3 -o \"%(title)s\".mp3");
                if (YoutubeTitle.Checked && mp4_checkbox.Checked) Process.Start(dlPath, $"{url}" + $" -P \"{download_path}\" --remux-video mp4 -o \"%(title)s\".mp4");

                if (mp3_checkbox.Checked && !YoutubeTitle.Checked) Process.Start(dlPath, $"{url}" + command + $" -P \"{download_path}\" -x --audio-format mp3 -o {filename}");
                if (mp4_checkbox.Checked && !YoutubeTitle.Checked) Process.Start(dlPath, $"{url}" + $" -P \"{download_path}\" --remux-video mp4 -o {filename}.mp4");

                if (!mp3_checkbox.Checked && !mp4_checkbox.Checked) Simplify.Echo("Please select a format (mp3 / mp4)");
            }
            else Simplify.Echo("Given path is invalid. Try again");
        }
    }

    private void AsMP3(object sender, EventArgs e)
    {
        Check.formatCheck(mp3_checkbox, mp4_checkbox);
    }

    private void AsMP4(object sender, EventArgs e)
    {
        Check.formatCheck(mp4_checkbox, mp3_checkbox);
    }

    private void OpenDialog(object sender, EventArgs e)
    {
        path.Text = Dialog.Open();
    }

    /* 
     * Check.CheckBoxCheck(checkBox1, checkBox2, checkBox3, custom_filename, false);
     *      Parameter 1: The checkbox which is first checked
     *      Parameter 2,3 & 4: The checkboxes which needs to be disabled and unchecked
     *      Parameter 5 & 6: Determines wether the custom filename input field should be disables or not
     */
    private void CustomNameChecked(object sender, EventArgs e) { Check.CheckBoxCheck(CustomName, RandomID, youtubeID, YoutubeTitle, custom_filename, false); }
    private void RandomIDChecked(object sender, EventArgs e) { Check.CheckBoxCheck(RandomID, CustomName, youtubeID, YoutubeTitle, custom_filename, true); }
    private void YoutubeIDChecked(object sender, EventArgs e) { Check.CheckBoxCheck(youtubeID, CustomName, RandomID, YoutubeTitle, custom_filename, true); }
    private void Titlechecked(object sender, EventArgs e) { Check.CheckBoxCheck(YoutubeTitle, CustomName, RandomID, youtubeID, custom_filename, true); }
}