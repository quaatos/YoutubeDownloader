public class Check
{
    public bool IsValidPath(string path)
    {
        if (Directory.Exists(path)) return true;
        else return false;
    }

    public bool IsEmpty(string value)
    {
        if (value.Length == 0) return false;
        return true;
    }

    public static void CheckBoxCheck(CheckBox first, CheckBox second, CheckBox thirth, CheckBox fourth, TextBox textbox, bool disable)
    {
        CheckBox[] boxes = { second, thirth, fourth };
        if (first.Checked)
        {
            textbox.ReadOnly = false;
            textbox.Enabled = true;

            foreach (CheckBox box in boxes)
            {
                box.Checked = false;
                box.Enabled = false;
            }

            if (disable)
            {
                textbox.ReadOnly = true;
                textbox.Enabled = false;
            }
        }
        else foreach (CheckBox box in boxes) box.Enabled = true;
    }

    public static void formatCheck(CheckBox first, CheckBox second)
    {
        if (first.Checked)
        {
            second.Enabled = false;
        }
        else if (second.Checked)
        {
            second.Enabled = false;
        }
        else
        {
            second.Enabled = true;
            first.Enabled = true;
        }
    }

    public static string ReplaceSpaceTo_(string filename)
    {
        return filename.Replace(" ", "_");
    }
}