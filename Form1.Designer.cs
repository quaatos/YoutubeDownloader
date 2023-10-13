namespace downloader;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        youtube_url = new TextBox();
        notifyIcon1 = new NotifyIcon(components);
        mp3_checkbox = new CheckBox();
        mp4_checkbox = new CheckBox();
        button1 = new Button();
        path = new TextBox();
        openFileDialog1 = new OpenFileDialog();
        FileDialog = new Button();
        custom_filename = new TextBox();
        groupBox1 = new GroupBox();
        YoutubeTitle = new CheckBox();
        youtubeID = new CheckBox();
        RandomID = new CheckBox();
        CustomName = new CheckBox();
        label5 = new Label();
        label4 = new Label();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // youtube_url
        // 
        youtube_url.AllowDrop = true;
        youtube_url.BackColor = SystemColors.Menu;
        youtube_url.BorderStyle = BorderStyle.FixedSingle;
        youtube_url.Cursor = Cursors.IBeam;
        youtube_url.Font = new Font("Segoe MDL2 Assets", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
        youtube_url.Location = new Point(468, 24);
        youtube_url.Margin = new Padding(3, 4, 3, 4);
        youtube_url.Name = "youtube_url";
        youtube_url.PlaceholderText = "URL";
        youtube_url.Size = new Size(870, 44);
        youtube_url.TabIndex = 0;
        // 
        // notifyIcon1
        // 
        notifyIcon1.Text = "notifyIcon1";
        notifyIcon1.Visible = true;
        // 
        // mp3_checkbox
        // 
        mp3_checkbox.AutoSize = true;
        mp3_checkbox.Location = new Point(44, 47);
        mp3_checkbox.Margin = new Padding(3, 4, 3, 4);
        mp3_checkbox.Name = "mp3_checkbox";
        mp3_checkbox.Size = new Size(71, 24);
        mp3_checkbox.TabIndex = 3;
        mp3_checkbox.Text = "Audio";
        mp3_checkbox.UseVisualStyleBackColor = false;
        mp3_checkbox.CheckedChanged += AsMP3;
        // 
        // mp4_checkbox
        // 
        mp4_checkbox.AutoSize = true;
        mp4_checkbox.Location = new Point(45, 79);
        mp4_checkbox.Margin = new Padding(3, 4, 3, 4);
        mp4_checkbox.Name = "mp4_checkbox";
        mp4_checkbox.Size = new Size(70, 24);
        mp4_checkbox.TabIndex = 4;
        mp4_checkbox.Text = "Video";
        mp4_checkbox.UseVisualStyleBackColor = false;
        mp4_checkbox.CheckedChanged += AsMP4;
        // 
        // button1
        // 
        button1.BackColor = Color.White;
        button1.Cursor = Cursors.Hand;
        button1.FlatAppearance.BorderColor = Color.LimeGreen;
        button1.FlatAppearance.BorderSize = 0;
        button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
        button1.Font = new Font("Segoe UI Symbol", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
        button1.ForeColor = Color.FromArgb(0, 0, 64);
        button1.Location = new Point(6, 432);
        button1.Margin = new Padding(3, 4, 3, 4);
        button1.Name = "button1";
        button1.Size = new Size(438, 73);
        button1.TabIndex = 5;
        button1.Text = "Download";
        button1.UseVisualStyleBackColor = false;
        button1.Click += Download;
        // 
        // path
        // 
        path.AllowDrop = true;
        path.BackColor = SystemColors.Menu;
        path.BorderStyle = BorderStyle.FixedSingle;
        path.Cursor = Cursors.IBeam;
        path.Font = new Font("Segoe MDL2 Assets", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
        path.ImeMode = ImeMode.On;
        path.Location = new Point(468, 73);
        path.Margin = new Padding(3, 4, 3, 4);
        path.Name = "path";
        path.PlaceholderText = "Output folder";
        path.Size = new Size(870, 44);
        path.TabIndex = 6;
        // 
        // openFileDialog1
        // 
        openFileDialog1.FileName = "openFileDialog1";
        // 
        // FileDialog
        // 
        FileDialog.BackColor = Color.WhiteSmoke;
        FileDialog.ForeColor = SystemColors.ActiveCaptionText;
        FileDialog.Location = new Point(1164, 73);
        FileDialog.Margin = new Padding(3, 4, 3, 4);
        FileDialog.Name = "FileDialog";
        FileDialog.Size = new Size(174, 44);
        FileDialog.TabIndex = 8;
        FileDialog.Text = "Select";
        FileDialog.UseVisualStyleBackColor = false;
        FileDialog.Click += OpenDialog;
        // 
        // custom_filename
        // 
        custom_filename.AllowDrop = true;
        custom_filename.BackColor = SystemColors.Menu;
        custom_filename.BorderStyle = BorderStyle.FixedSingle;
        custom_filename.Cursor = Cursors.IBeam;
        custom_filename.Font = new Font("Segoe MDL2 Assets", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
        custom_filename.ImeMode = ImeMode.On;
        custom_filename.Location = new Point(468, 125);
        custom_filename.Margin = new Padding(3, 4, 3, 4);
        custom_filename.Name = "custom_filename";
        custom_filename.PlaceholderText = "Filename";
        custom_filename.Size = new Size(870, 44);
        custom_filename.TabIndex = 9;
        // 
        // groupBox1
        // 
        groupBox1.BackColor = Color.Black;
        groupBox1.Controls.Add(YoutubeTitle);
        groupBox1.Controls.Add(youtubeID);
        groupBox1.Controls.Add(RandomID);
        groupBox1.Controls.Add(CustomName);
        groupBox1.Controls.Add(label5);
        groupBox1.Controls.Add(label4);
        groupBox1.Controls.Add(mp3_checkbox);
        groupBox1.Controls.Add(mp4_checkbox);
        groupBox1.Controls.Add(button1);
        groupBox1.ForeColor = Color.White;
        groupBox1.Location = new Point(12, 14);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(450, 512);
        groupBox1.TabIndex = 11;
        groupBox1.TabStop = false;
        groupBox1.Text = "Configuration";
        // 
        // YoutubeTitle
        // 
        YoutubeTitle.AutoSize = true;
        YoutubeTitle.Location = new Point(243, 143);
        YoutubeTitle.Margin = new Padding(3, 4, 3, 4);
        YoutubeTitle.Name = "YoutubeTitle";
        YoutubeTitle.Size = new Size(100, 24);
        YoutubeTitle.TabIndex = 11;
        YoutubeTitle.Text = "Video title";
        YoutubeTitle.UseVisualStyleBackColor = false;
        YoutubeTitle.CheckedChanged += Titlechecked;
        // 
        // youtubeID
        // 
        youtubeID.AutoSize = true;
        youtubeID.Location = new Point(243, 111);
        youtubeID.Margin = new Padding(3, 4, 3, 4);
        youtubeID.Name = "youtubeID";
        youtubeID.Size = new Size(104, 24);
        youtubeID.TabIndex = 10;
        youtubeID.Text = "Youtube ID";
        youtubeID.UseVisualStyleBackColor = false;
        youtubeID.CheckedChanged += YoutubeIDChecked;
        // 
        // RandomID
        // 
        RandomID.AutoSize = true;
        RandomID.Location = new Point(243, 79);
        RandomID.Margin = new Padding(3, 4, 3, 4);
        RandomID.Name = "RandomID";
        RandomID.Size = new Size(106, 24);
        RandomID.TabIndex = 9;
        RandomID.Text = "Random ID";
        RandomID.UseVisualStyleBackColor = false;
        RandomID.CheckedChanged += RandomIDChecked;
        // 
        // CustomName
        // 
        CustomName.AutoSize = true;
        CustomName.Location = new Point(243, 47);
        CustomName.Margin = new Padding(3, 4, 3, 4);
        CustomName.Name = "CustomName";
        CustomName.Size = new Size(145, 24);
        CustomName.TabIndex = 8;
        CustomName.Text = "Custom Filename";
        CustomName.UseVisualStyleBackColor = false;
        CustomName.CheckedChanged += CustomNameChecked;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(194, 23);
        label5.Name = "label5";
        label5.Size = new Size(69, 20);
        label5.TabIndex = 6;
        label5.Text = "Filename";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.BackColor = Color.Black;
        label4.ForeColor = Color.White;
        label4.Location = new Point(6, 23);
        label4.Name = "label4";
        label4.Size = new Size(56, 20);
        label4.TabIndex = 5;
        label4.Text = "Format";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Black;
        ClientSize = new Size(1350, 538);
        Controls.Add(groupBox1);
        Controls.Add(custom_filename);
        Controls.Add(FileDialog);
        Controls.Add(path);
        Controls.Add(youtube_url);
        ForeColor = SystemColors.ActiveBorder;
        FormBorderStyle = FormBorderStyle.FixedSingle;
        HelpButton = true;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(3, 4, 3, 4);
        Name = "Form1";
        Text = "Youtube Downloader";
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox youtube_url;
    private NotifyIcon notifyIcon1;
    private CheckBox mp3_checkbox;
    private CheckBox mp4_checkbox;
    private Button button1;
    private TextBox path;
    private OpenFileDialog openFileDialog1;
    private TextBox textBox1;
    private GroupBox groupBox1;
    private Label label4;
    private TextBox custom_filename;
    private CheckBox CustomName;
    private CheckBox CustomNameCheck;
    private CheckBox RandomID;
    private Label label5;
    private CheckBox youtubeID;
    private Button FileDialog;
    private CheckBox YoutubeTitle;
}
