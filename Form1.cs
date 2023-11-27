namespace ChangeConfig
{
    public partial class Form1 : Form
    {

        private string host;
        private string user;
        private string pwd;
        private string port;
        private string db;
        public string path = "C:\\Visual Software\\MyCommerce\\config.ini";

        public string Host { get => host; set => host = value; }
        public string User { get => user; set => user = value; }
        public string Pwd { get => pwd; set => pwd = value; }
        public string Port { get => port; set => port = value; }
        public string Db { get => db; set => db = value; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = "C:\\Visual Software\\MyCommerce\\config.ini";

            string[] lines = File.ReadAllLines(path);

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].StartsWith("PortaServidor="))
                {
                    port = lines[i].Split('=')[1];
                }
                else if (lines[i].StartsWith("Database="))
                {
                    db = lines[i].Split('=')[1];
                }
                else if (lines[i].StartsWith("IPServidor="))
                {
                    host = lines[i].Split('=')[1];
                }
                else if (lines[i].StartsWith("UsuarioServidor="))
                {
                    user = lines[i].Split('=')[1];
                }
                else if (lines[i].StartsWith("PasswordServidor="))
                {
                    pwd = lines[i].Split('=')[2];
                }
                else if (lines[i].StartsWith("Relatorios="))
                {
                    break;
                }
            }

            txt_db.Text = db.ToString();
            txt_host.Text = host.ToString();
            txt_port.Text = port.ToString();
            txt_pwd.Text = pwd.ToString();
            txt_user.Text = user.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db = txt_db.Text;
            host = txt_host.Text;
            port = txt_port.Text;
            pwd = txt_pwd.Text;
            user = txt_user.Text;

            string[] lines = File.ReadAllLines(path);

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].StartsWith("PortaServidor="))
                {
                    lines[i] = $"PortaServidor={port}";
                }
                else if (lines[i].StartsWith("Database="))
                {
                    lines[i] = $"Database={db}";
                }
                else if (lines[i].StartsWith("IPServidor="))
                {
                    lines[i] = $"IPServidor={host}";
                }
                else if (lines[i].StartsWith("UsuarioServidor="))
                {
                    lines[i] = $"UsuarioServidor={user}";
                }
                else if (lines[i].StartsWith("PasswordServidor=="))
                {
                    lines[i] = $"PasswordServidor=={pwd}";
                }
                else if (lines[i].StartsWith("Relatorios="))
                {
                    break;
                }
            }

            File.WriteAllLines(path, lines);

            MessageBox.Show("Arquivo config.ini foi atualizado!", "Atualizado!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }
    }
}