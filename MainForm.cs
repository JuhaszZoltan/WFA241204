namespace WFA241204;

public partial class MainForm : Form
{
    private System.Windows.Forms.Timer timer;
    private List<Snowflake> snowflakes = [];

    public MainForm()
    {
        InitializeComponent();
        timer = new()
        {
            Interval = 100,
        };
        timer.Tick += TimerTick;

        this.Load += MainForm_Load;
    }

    private void MainForm_Load(object? sender, EventArgs e) =>
        timer.Start();

    private void TimerTick(object? sender, EventArgs e)
    {
        snowflakes.Add(new(this));
    }
}
