namespace Ex15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ToolStripMenuItem cutItem = new ToolStripMenuItem("Cut");
            ToolStripMenuItem copyItem = new ToolStripMenuItem("Copy");
            ToolStripMenuItem pasteItem = new ToolStripMenuItem("Paste");
            contextMenuStrip1.Items.Add(cutItem);
            contextMenuStrip1.Items.Add(copyItem);
            contextMenuStrip1.Items.Add(pasteItem);
            textBox1.ContextMenuStrip = contextMenuStrip1;
        }
    }
}
