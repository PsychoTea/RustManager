using System.Drawing;
using System.Windows.Forms;

namespace RustManager.Managers
{
    public class TabManager
    {
        private TabPage defaultPage;
        public TabControl SelectorControl = new TabControl();
        public TabPage ControlPage = new TabPage();
        public Label SayLabel = new Label();
        public Label CommandLabel = new Label();
        public TextBox OutputBox = new TextBox();
        public TextBox SayBox = new TextBox();
        public TextBox CommandBox = new TextBox();

        public static TabManager Instance
        {
            get
            {
                return new TabManager();
            }
        }

        public TabPage DefaultPage
        {
            get
            {
                return defaultPage ?? GenerateDefaultPage();
            }
        }

        TabPage GenerateDefaultPage()
        {
            defaultPage = new TabPage();
            defaultPage.Controls.Add(SelectorControl);
            defaultPage.Location = new Point(12, 45);
            defaultPage.Name = "NoConnectionPage";
            defaultPage.Size = new Size(510, 404);
            defaultPage.TabIndex = 0;
            defaultPage.Text = "No Connection";
            defaultPage.UseVisualStyleBackColor = true;

            SelectorControl.Controls.Add(ControlPage);
            SelectorControl.Location = new Point(2, 5);
            SelectorControl.Name = "SelectorControl";
            SelectorControl.Size = new Size(502, 396);
            SelectorControl.TabIndex = 0;
            SelectorControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            ControlPage.Controls.Add(SayLabel);
            ControlPage.Controls.Add(CommandLabel);
            ControlPage.Controls.Add(OutputBox);
            ControlPage.Controls.Add(SayBox);
            ControlPage.Controls.Add(CommandBox);
            ControlPage.Location = new Point(3, 6);
            ControlPage.Name = "ConsolePage";
            ControlPage.Size = new Size(496, 369);
            ControlPage.TabIndex = 0;
            ControlPage.Text = "Console";
            ControlPage.UseVisualStyleBackColor = true;
            
            OutputBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            OutputBox.Location = new Point(5, 6);
            OutputBox.Multiline = true;
            OutputBox.Name = "OutputBox";
            OutputBox.ReadOnly = true;
            OutputBox.ScrollBars = ScrollBars.Vertical;
            OutputBox.Size = new Size(484, 264);
            OutputBox.TabIndex = 1;

            SayLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SayLabel.AutoSize = true;
            SayLabel.Location = new Point(7, 278);
            SayLabel.Name = "SayLabel";
            SayLabel.Size = new Size(34, 13);
            SayLabel.TabIndex = 4;
            SayLabel.Text = "Say...";

            SayBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SayBox.Location = new Point(5, 296);
            SayBox.Name = "SayBox";
            SayBox.Size = new Size(484, 20);
            SayBox.TabIndex = 2;

            CommandLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CommandLabel.AutoSize = true;
            CommandLabel.Location = new Point(7, 323);
            CommandLabel.Name = "CommandLabel";
            CommandLabel.Size = new Size(63, 13);
            CommandLabel.TabIndex = 5;
            CommandLabel.Text = "Command...";

            CommandBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CommandBox.Location = new Point(5, 339);
            CommandBox.Name = "CommandBox";
            CommandBox.Size = new Size(484, 20);
            CommandBox.TabIndex = 3;

            return defaultPage;
        }
    }
}