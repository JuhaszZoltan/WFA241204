namespace WFA241204;

internal class Snowflake
{
    private Form form;

    private const string IMAGE = 
        "E:\\juhaszz\\PROJECTS\\WFA241204\\imgs\\snowflake.png";

    private PictureBox pictureBox;
    public int Speed { get; set; }

    public bool Fall()
    {
        pictureBox.Location = new(
            x: pictureBox.Location.X,
            y: pictureBox.Location.Y - 5);

        return pictureBox.Location.Y < form.Height;
    }

    public Snowflake(Form form)
    {
        this.form = form;

        int rndSize = Random.Shared.Next(30, 90);

        pictureBox = new()
        {
            BackColor = Color.Transparent,
            Bounds = new(
                x: Random.Shared.Next(form.Size.Width),
                y: 0,
                width: rndSize,
                height: rndSize),
            Image = Image.FromFile(IMAGE, true),
            SizeMode = PictureBoxSizeMode.Zoom,
        };

        this.form.Controls.Add(pictureBox);

        Speed = Random.Shared.Next(10) + 1;
    }
}
